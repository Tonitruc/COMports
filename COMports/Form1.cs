using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;

namespace COMports
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        private SerialPort _inputComPort;
        private SerialPort _outputComPort;

        private int _amountServing = 0;

        public int AmountServing
        {
            get { return _amountServing; }
            set
            {
                _amountServing = value;
                OnPropertyChanged(nameof(AmountServing));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            amountServingLabel.DataBindings.Add("Text", this, nameof(AmountServing));
            _inputComPort = BaseComportConfiguration();
            _outputComPort = BaseComportConfiguration();
        }

        private SerialPort BaseComportConfiguration()
        {
            var port = new SerialPort()
            {
                BaudRate = 9600,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,

            };

            port.DataReceived += DataReceivedHandler;
            return port;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!_inputComPort.IsOpen)
                {
                    MessageBox.Show("Выберите comport для отправки данных.", "Ошибка");
                    return;
                }

                string dataToSend = inputTextBox.Text;
                if (string.IsNullOrEmpty(dataToSend))
                {
                    return;
                }


                _inputComPort.Write(dataToSend);
                AmountServing++;

                inputTextBox.Clear();

            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (!_outputComPort.IsOpen)
            {
                //MessageBox.Show("Выберите comport для вывода данных.", "Ошибка");
                return;
            }

            if (_outputComPort.BytesToRead > 0)
            {
                string dataReceived = _outputComPort.ReadExisting();
                this.Invoke(new Action(() =>
                {
                    outputTextBox.Text = dataReceived;
                }));
            }
        }

        private void inputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedComPort = inputComboBox.SelectedItem?.ToString();

            if (selectedComPort != null)
            {
                OpenSelectedComport(_inputComPort, _outputComPort, selectedComPort, inputComboBox);
            }
        }

        private void outputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedComPort = outputComboBox.SelectedItem?.ToString();

            if (selectedComPort != null)
            {
                OpenSelectedComport(_outputComPort, _inputComPort, selectedComPort, outputComboBox);
            }
        }

        private void OpenSelectedComport(SerialPort openComPort, SerialPort openedComPort, string name, ComboBox comboBox)
        {
            if (openComPort.IsOpen)
            {
                openComPort.Close();
            }

            openComPort.PortName = name;

            try
            {
                //TODO Think about same comport for write and read
                if (!openedComPort.IsOpen || openComPort.PortName != openedComPort.PortName)
                {
                    openComPort.Open();
                }
                else
                {
                    MessageBox.Show($"Имя {openedComPort.PortName} уже используется", "Ошибка");
                    comboBox.SelectedIndex = -1;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Не удалось найти {ex.FileName}", "Ошибка");
                comboBox.SelectedIndex = -1;
            }
        }
    }
}
