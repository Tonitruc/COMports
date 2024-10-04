namespace COMports
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            inputTextBox = new TextBox();
            panel2 = new Panel();
            outputTextBox = new TextBox();
            panel3 = new Panel();
            label15 = new Label();
            label14 = new Label();
            outputComboBox = new ComboBox();
            label2 = new Label();
            inputComboBox = new ComboBox();
            amountServingLabel = new Label();
            label1 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label18 = new Label();
            panel5 = new Panel();
            byteStaffingOutput = new RichTextBox();
            label17 = new Label();
            label16 = new Label();
            label4 = new Label();
            label13 = new Label();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(inputTextBox);
            panel1.Location = new Point(31, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 150);
            panel1.TabIndex = 0;
            // 
            // inputTextBox
            // 
            inputTextBox.BorderStyle = BorderStyle.FixedSingle;
            inputTextBox.Location = new Point(4, 4);
            inputTextBox.Margin = new Padding(0);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(250, 140);
            inputTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(outputTextBox);
            panel2.Location = new Point(341, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 150);
            panel2.TabIndex = 1;
            // 
            // outputTextBox
            // 
            outputTextBox.BorderStyle = BorderStyle.FixedSingle;
            outputTextBox.Location = new Point(4, 4);
            outputTextBox.Margin = new Padding(0);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(250, 140);
            outputTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(outputComboBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(inputComboBox);
            panel3.Location = new Point(31, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(570, 113);
            panel3.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sylfaen", 10.8F);
            label15.Location = new Point(344, 35);
            label15.Name = "label15";
            label15.Size = new Size(114, 23);
            label15.TabIndex = 6;
            label15.Text = "Порт приема:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sylfaen", 10.8F);
            label14.Location = new Point(34, 35);
            label14.Name = "label14";
            label14.Size = new Size(131, 23);
            label14.TabIndex = 5;
            label14.Text = "Порт передачи:";
            // 
            // outputComboBox
            // 
            outputComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            outputComboBox.FormattingEnabled = true;
            outputComboBox.Items.AddRange(new object[] { "Не выбран" });
            outputComboBox.Location = new Point(344, 66);
            outputComboBox.Name = "outputComboBox";
            outputComboBox.Size = new Size(190, 28);
            outputComboBox.TabIndex = 1;
            outputComboBox.SelectedIndexChanged += outputComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(192, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 26);
            label2.TabIndex = 4;
            label2.Text = "Окно управления";
            // 
            // inputComboBox
            // 
            inputComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inputComboBox.FormattingEnabled = true;
            inputComboBox.Items.AddRange(new object[] { "Не выбран" });
            inputComboBox.Location = new Point(34, 66);
            inputComboBox.Name = "inputComboBox";
            inputComboBox.Size = new Size(190, 28);
            inputComboBox.TabIndex = 0;
            inputComboBox.SelectedIndexChanged += inputComboBox_SelectedIndexChanged;
            // 
            // amountServingLabel
            // 
            amountServingLabel.AutoSize = true;
            amountServingLabel.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic);
            amountServingLabel.Location = new Point(351, 176);
            amountServingLabel.Name = "amountServingLabel";
            amountServingLabel.Size = new Size(19, 23);
            amountServingLabel.TabIndex = 3;
            amountServingLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(95, 141);
            label1.Name = "label1";
            label1.Size = new Size(125, 26);
            label1.TabIndex = 0;
            label1.Text = "Окно ввода";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(400, 141);
            label3.Name = "label3";
            label3.Size = new Size(140, 26);
            label3.TabIndex = 3;
            label3.Text = "Окно вывода";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(label18);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(amountServingLabel);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(31, 342);
            panel4.Name = "panel4";
            panel4.Size = new Size(570, 307);
            panel4.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Sylfaen", 10.8F);
            label18.Location = new Point(21, 25);
            label18.Name = "label18";
            label18.Size = new Size(154, 23);
            label18.TabIndex = 13;
            label18.Text = "Структура кадров:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(byteStaffingOutput);
            panel5.Location = new Point(17, 57);
            panel5.Name = "panel5";
            panel5.Size = new Size(537, 116);
            panel5.TabIndex = 12;
            // 
            // byteStaffingOutput
            // 
            byteStaffingOutput.BorderStyle = BorderStyle.FixedSingle;
            byteStaffingOutput.Location = new Point(3, 3);
            byteStaffingOutput.Name = "byteStaffingOutput";
            byteStaffingOutput.Size = new Size(527, 107);
            byteStaffingOutput.TabIndex = 1;
            byteStaffingOutput.Text = "";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic);
            label17.Location = new Point(405, 243);
            label17.Name = "label17";
            label17.Size = new Size(40, 23);
            label17.TabIndex = 11;
            label17.Text = "Нет";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Sylfaen", 10.8F);
            label16.Location = new Point(258, 243);
            label16.Name = "label16";
            label16.Size = new Size(150, 23);
            label16.TabIndex = 10;
            label16.Text = "Контроль потока: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(201, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 26);
            label4.TabIndex = 9;
            label4.Text = "Окно состояния";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label13.Location = new Point(101, 211);
            label13.Name = "label13";
            label13.Size = new Size(46, 23);
            label13.TabIndex = 8;
            label13.Text = "9600";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label10.Location = new Point(86, 274);
            label10.Name = "label10";
            label10.Size = new Size(138, 23);
            label10.TabIndex = 5;
            label10.Text = "Не используется";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label12.Location = new Point(471, 211);
            label12.Name = "label12";
            label12.Size = new Size(19, 23);
            label12.TabIndex = 7;
            label12.Text = "8";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.Location = new Point(101, 243);
            label11.Name = "label11";
            label11.Size = new Size(19, 23);
            label11.TabIndex = 6;
            label11.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 10.8F);
            label9.Location = new Point(17, 178);
            label9.Name = "label9";
            label9.Size = new Size(337, 23);
            label9.TabIndex = 4;
            label9.Text = "Количество полученных порций символов:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sylfaen", 10.8F);
            label8.Location = new Point(17, 274);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 3;
            label8.Text = "Паритет:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 10.8F);
            label7.Location = new Point(17, 243);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 2;
            label7.Text = "Стоп бит:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 10.8F);
            label6.Location = new Point(258, 211);
            label6.Name = "label6";
            label6.Size = new Size(218, 23);
            label6.TabIndex = 1;
            label6.Text = "Количество битов в байте: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(17, 211);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 0;
            label5.Text = "Скорость:";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(31, 544);
            panel6.Name = "panel6";
            panel6.Size = new Size(570, 2);
            panel6.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(632, 661);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа 2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private ComboBox inputComboBox;
        private ComboBox outputComboBox;
        private Label label2;
        private Label label3;
        private Label amountServingLabel;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label4;
        private Label label15;
        private Label label14;
        private Label label16;
        private Label label17;
        private Panel panel5;
        private RichTextBox byteStaffingOutput;
        private TextBox outputTextBox;
        private TextBox inputTextBox;
        private Label label18;
        private Panel panel6;
    }
}
