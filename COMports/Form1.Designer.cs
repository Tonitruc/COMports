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
            outputComboBox = new ComboBox();
            inputComboBox = new ComboBox();
            amountServingLabel = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(inputTextBox);
            panel1.Location = new Point(26, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 150);
            panel1.TabIndex = 0;
            // 
            // inputTextBox
            // 
            inputTextBox.BorderStyle = BorderStyle.FixedSingle;
            inputTextBox.Location = new Point(4, 4);
            inputTextBox.Margin = new Padding(0);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(160, 140);
            inputTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(outputTextBox);
            panel2.Location = new Point(246, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 150);
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
            outputTextBox.Size = new Size(160, 140);
            outputTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(outputComboBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(inputComboBox);
            panel3.Location = new Point(31, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 83);
            panel3.TabIndex = 2;
            // 
            // outputComboBox
            // 
            outputComboBox.FormattingEnabled = true;
            outputComboBox.Items.AddRange(new object[] { "COM1", "COM2", "COM3", "COM4" });
            outputComboBox.Location = new Point(230, 36);
            outputComboBox.Name = "outputComboBox";
            outputComboBox.Size = new Size(125, 28);
            outputComboBox.TabIndex = 1;
            outputComboBox.SelectedIndexChanged += outputComboBox_SelectedIndexChanged;
            // 
            // inputComboBox
            // 
            inputComboBox.FormattingEnabled = true;
            inputComboBox.Items.AddRange(new object[] { "COM1", "COM2", "COM3", "COM4" });
            inputComboBox.Location = new Point(17, 36);
            inputComboBox.Name = "inputComboBox";
            inputComboBox.Size = new Size(125, 28);
            inputComboBox.TabIndex = 0;
            inputComboBox.SelectedIndexChanged += inputComboBox_SelectedIndexChanged;
            // 
            // amountServingLabel
            // 
            amountServingLabel.AutoSize = true;
            amountServingLabel.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic);
            amountServingLabel.Location = new Point(260, 150);
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
            label1.Location = new Point(48, 111);
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
            label3.Location = new Point(261, 111);
            label3.Name = "label3";
            label3.Size = new Size(140, 26);
            label3.TabIndex = 3;
            label3.Text = "Окно вывода";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(102, 2);
            label2.Name = "label2";
            label2.Size = new Size(186, 26);
            label2.TabIndex = 4;
            label2.Text = "Окно управления";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(amountServingLabel);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(31, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(385, 185);
            panel4.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label10.Location = new Point(99, 120);
            label10.Name = "label10";
            label10.Size = new Size(19, 23);
            label10.TabIndex = 5;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 10.8F);
            label9.Location = new Point(17, 150);
            label9.Name = "label9";
            label9.Size = new Size(240, 23);
            label9.TabIndex = 4;
            label9.Text = "Количество порций символов:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 10.8F);
            label8.Location = new Point(17, 120);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 3;
            label8.Text = "Паритет:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 10.8F);
            label7.Location = new Point(17, 90);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 2;
            label7.Text = "Стоп бит:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 10.8F);
            label6.Location = new Point(17, 60);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 1;
            label6.Text = "Количество битов: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(17, 30);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 0;
            label5.Text = "Скорость:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.Location = new Point(104, 90);
            label11.Name = "label11";
            label11.Size = new Size(19, 23);
            label11.TabIndex = 6;
            label11.Text = "1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label12.Location = new Point(178, 60);
            label12.Name = "label12";
            label12.Size = new Size(19, 23);
            label12.TabIndex = 7;
            label12.Text = "1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sylfaen", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label13.Location = new Point(107, 30);
            label13.Name = "label13";
            label13.Size = new Size(46, 23);
            label13.TabIndex = 8;
            label13.Text = "9600";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(110, 4);
            label4.Name = "label4";
            label4.Size = new Size(169, 26);
            label4.TabIndex = 9;
            label4.Text = "Окно состояния";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(442, 503);
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
            Text = "Lab1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox inputTextBox;
        private Panel panel2;
        private TextBox outputTextBox;
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
    }
}
