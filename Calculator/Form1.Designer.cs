namespace Calculator
{
    partial class form_calculator
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
            textBox_number = new TextBox();
            button_clear = new Button();
            button_backspace = new Button();
            button_equal = new Button();
            SuspendLayout();
            // 
            // textBox_number
            // 
            textBox_number.Location = new Point(61, 107);
            textBox_number.Name = "textBox_number";
            textBox_number.Size = new Size(297, 27);
            textBox_number.TabIndex = 0;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(264, 252);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 8;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_backspace
            // 
            button_backspace.Location = new Point(61, 252);
            button_backspace.Name = "button_backspace";
            button_backspace.Size = new Size(94, 29);
            button_backspace.TabIndex = 9;
            button_backspace.Text = "Backspace";
            button_backspace.UseVisualStyleBackColor = true;
            button_backspace.Click += button_backspace_Click;
            // 
            // button_equal
            // 
            button_equal.Location = new Point(165, 195);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(94, 29);
            button_equal.TabIndex = 10;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = true;
            button_equal.Click += button_equal_Click;
            // 
            // form_calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(button_equal);
            Controls.Add(button_backspace);
            Controls.Add(button_clear);
            Controls.Add(textBox_number);
            Name = "form_calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_number;
        private Button button_clear;
        private Button button_backspace;
        private Button button_equal;
    }
}
