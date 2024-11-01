using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace COMports
{
    public partial class Form1 : Form
    {
        private readonly SerialPort _inputComPort;
        private readonly SerialPort _outputComPort;

        private int _amountServing = 0;

        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
           
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            _inputComPort = BaseComportConfiguration();
            _outputComPort = BaseComportConfiguration();
            inputComboBox.DropDown += inputComboBox_DropDown;
            outputComboBox.DropDown += outputComboBox_DropDown;
            inputComboBox.SelectedIndex = 0;
            outputComboBox.SelectedIndex = 0;
        }

        private async Task<bool> TryOpenPortAsync(SerialPort serialPort)
        {
            return await Task.Run(() =>
            {
                try
                {
                    serialPort.Open();
                    return true;
                }
                catch (UnauthorizedAccessException) { return false; }
            });
        }

        private async Task ClosePortAsync(SerialPort serialPort)
        {
            await Task.Run(() =>
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            });
        }

        private async void inputComboBox_DropDown(object? sender, EventArgs e)
        {
            string currentSelection = inputComboBox.SelectedItem?.ToString() ?? "";
            inputComboBox.Items.Clear();
            List<string> avaliablePorts = await GetAvaliableComports(currentSelection);
            string selectedPort = outputComboBox.SelectedItem?.ToString() ?? string.Empty;
            inputComboBox.Items.AddRange(avaliablePorts.ToArray());
            inputComboBox.Items.Remove("COM" + (GetComportNumber(selectedPort) - 1));
            inputComboBox.Items.Insert(0, "Не выбран");
            if (!inputComboBox.Items.Contains(currentSelection))
            {
                inputComboBox.Items.Add(currentSelection);
            }
            inputComboBox.SelectedItem = currentSelection;
        }

        private async void outputComboBox_DropDown(object? sender, EventArgs e)
        {
            string currentSelection = outputComboBox.SelectedItem?.ToString() ?? "";
            outputComboBox.Items.Clear();
            List<string> avaliablePorts = await GetAvaliableComports(currentSelection);
            string selectedPort = inputComboBox.SelectedItem?.ToString() ?? string.Empty;
            outputComboBox.Items.AddRange(avaliablePorts.ToArray());
            outputComboBox.Items.Remove("COM" + (GetComportNumber(selectedPort) + 1));
            outputComboBox.Items.Insert(0, "Не выбран");
            if (!outputComboBox.Items.Contains(currentSelection))
            {
                outputComboBox.Items.Add(currentSelection);
            }
            outputComboBox.SelectedItem = currentSelection;
        }

        private int GetComportNumber(string comportName)
        {
            var match = System.Text.RegularExpressions.Regex.Match(comportName, @"\d+$");

            if (match.Success)
            {
                return Convert.ToInt32(match.Value);
            }

            return -1;
        }

        private async Task<List<string>> GetAvaliableComports(string current)
        {
            List<string> comPorts = [];
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                SerialPort serialPort = BaseComportConfiguration();
                serialPort.PortName = port;
                {
                    if (port == current)
                    {
                        comPorts.Add(current);
                    }
                    else
                    {
                        bool isPortOpen = await TryOpenPortAsync(serialPort);
                        if (isPortOpen)
                        {
                            await ClosePortAsync(serialPort);
                            comPorts.Add(port);
                        }
                    }
                }
            }

            return comPorts;
        }

        private SerialPort BaseComportConfiguration()
        {
            var port = new SerialPort()
            {
                BaudRate = 100,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Encoding = Encoding.UTF8,
            };

            port.DataReceived += DataReceivedHandler;
            return port;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string dataToSend = inputTextBox.Text;
                if (!_inputComPort.IsOpen)
                {
                    MessageBox.Show("Выберите порт для передачи данных.", "Ошибка");
                    if (!string.IsNullOrWhiteSpace(dataToSend))
                    {
                        inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1);
                        inputTextBox.SelectionStart = inputTextBox.Text.Length;
                        inputTextBox.SelectionLength = 0;
                    }
                    else
                    {
                        inputTextBox.Clear();
                    }
                    return;
                }

                if (string.IsNullOrEmpty(dataToSend))
                {
                    return;
                }

                var frames = ByteStaffingConverter.CreateFrames(dataToSend, GetComportNumber(_inputComPort.PortName));
                RecolorReplacesBytes(frames);
                string data = string.Empty;
                foreach (var frame in frames)
                {
                    //Coding.CreateMistake(frame);
                    data += frame;
                }

                _inputComPort.Write(data);

                inputTextBox.Clear();
            }
        }

        private void RecolorReplacesBytes(List<string> frames, string sp = " ")
        {
            byteStaffingOutput.Clear();
            foreach (var frame in frames)
            {
                for (int i = 0; i < frame.Length; i += 2)
                {
                    byteStaffingOutput.AppendText(frame.Substring(i, 2) + sp);
                    if (i != frame.Length - 2 && frame.Substring(i, 2) == ByteStaffingConverter.ReplaceCode.ToString("X"))
                    {
                        i += 2;
                        byteStaffingOutput.AppendText(frame.Substring(i, 2) + sp);
                        int textLength = byteStaffingOutput.TextLength;
                        byteStaffingOutput.Select(textLength - 4 - 2 * sp.Length, 4 + 2 * sp.Length);
                        byteStaffingOutput.SelectionColor = Color.Red;
                        byteStaffingOutput.Select(textLength, 0);
                        byteStaffingOutput.SelectionColor = byteStaffingOutput.ForeColor;
                    }
                }
                byteStaffingOutput.AppendText(Environment.NewLine);
            }
        }

        private void DataReceivedHandler(object sender,
            SerialDataReceivedEventArgs e)
        {
            if (!_outputComPort.IsOpen)
            {
                return;
            }

            if (_outputComPort.BytesToRead > 0)
            {
                string dataReceived = _outputComPort.ReadExisting();
                this.Invoke(new Action(() =>
                {
                    _amountServing++;
                    amountServingLabel.Text = _amountServing.ToString();
                    outputTextBox.Text = ByteStaffingConverter.GetData(dataReceived);
                    outputTextBox.SelectionStart = outputTextBox.Text.Length;
                    outputTextBox.ScrollToCaret();
                }));
            }
        }

        private async void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            await ClosePortAsync(_inputComPort);
            await ClosePortAsync(_outputComPort);
        }

        private void inputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedComPort = inputComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedComPort))
            {
                _inputComPort.Close();
                _inputComPort.PortName = selectedComPort;
                if (inputComboBox.SelectedIndex != 0)
                {
                    _inputComPort.Open();
                }

            }
        }

        private void outputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedComPort = outputComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedComPort))
            {
                _outputComPort.Close();
                _outputComPort.PortName = selectedComPort;
                if (outputComboBox.SelectedIndex != 0)
                {
                    _outputComPort.Open();
                }
            }
        }
    }
}
