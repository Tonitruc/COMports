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
            amountServingLabel = new Label();
            label4 = new Label();
            outputComboBox = new ComboBox();
            inputComboBox = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel2.Location = new Point(286, 140);
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
            panel3.Controls.Add(amountServingLabel);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(outputComboBox);
            panel3.Controls.Add(inputComboBox);
            panel3.Location = new Point(31, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 75);
            panel3.TabIndex = 2;
            // 
            // amountServingLabel
            // 
            amountServingLabel.AutoSize = true;
            amountServingLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            amountServingLabel.Location = new Point(260, 45);
            amountServingLabel.Name = "amountServingLabel";
            amountServingLabel.Size = new Size(18, 20);
            amountServingLabel.TabIndex = 3;
            amountServingLabel.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(17, 45);
            label4.Name = "label4";
            label4.Size = new Size(238, 20);
            label4.TabIndex = 2;
            label4.Text = "Количество порций символов:";
            // 
            // outputComboBox
            // 
            outputComboBox.FormattingEnabled = true;
            outputComboBox.Items.AddRange(new object[] { "COM1", "COM2", "COM3", "COM4" });
            outputComboBox.Location = new Point(277, 11);
            outputComboBox.Name = "outputComboBox";
            outputComboBox.Size = new Size(125, 28);
            outputComboBox.TabIndex = 1;
            outputComboBox.SelectedIndexChanged += outputComboBox_SelectedIndexChanged;
            // 
            // inputComboBox
            // 
            inputComboBox.FormattingEnabled = true;
            inputComboBox.Items.AddRange(new object[] { "COM1", "COM2", "COM3", "COM4" });
            inputComboBox.Location = new Point(17, 11);
            inputComboBox.Name = "inputComboBox";
            inputComboBox.Size = new Size(125, 28);
            inputComboBox.TabIndex = 0;
            inputComboBox.SelectedIndexChanged += inputComboBox_SelectedIndexChanged;
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
            label3.Location = new Point(301, 111);
            label3.Name = "label3";
            label3.Size = new Size(140, 26);
            label3.TabIndex = 3;
            label3.Text = "Окно вывода";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(148, 4);
            label2.Name = "label2";
            label2.Size = new Size(186, 26);
            label2.TabIndex = 4;
            label2.Text = "Окно управления";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 303);
            Controls.Add(label2);
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
        private Label label4;
        private Label amountServingLabel;
    }
}
