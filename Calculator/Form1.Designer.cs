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
            textBox_firstNumber = new TextBox();
            textBox_secondNumber = new TextBox();
            textBox_finalResult = new TextBox();
            button_add = new Button();
            SuspendLayout();
            // 
            // textBox_firstNumber
            // 
            textBox_firstNumber.Location = new Point(61, 42);
            textBox_firstNumber.Name = "textBox_firstNumber";
            textBox_firstNumber.PlaceholderText = "Enter first number";
            textBox_firstNumber.Size = new Size(297, 27);
            textBox_firstNumber.TabIndex = 0;
            // 
            // textBox_secondNumber
            // 
            textBox_secondNumber.Location = new Point(61, 96);
            textBox_secondNumber.Name = "textBox_secondNumber";
            textBox_secondNumber.PlaceholderText = "Enter second number";
            textBox_secondNumber.Size = new Size(297, 27);
            textBox_secondNumber.TabIndex = 1;
            // 
            // textBox_finalResult
            // 
            textBox_finalResult.Enabled = false;
            textBox_finalResult.Location = new Point(61, 336);
            textBox_finalResult.Name = "textBox_finalResult";
            textBox_finalResult.PlaceholderText = "Final Result will appear here...";
            textBox_finalResult.ReadOnly = true;
            textBox_finalResult.Size = new Size(238, 27);
            textBox_finalResult.TabIndex = 2;
            // 
            // button_add
            // 
            button_add.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.Location = new Point(61, 153);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 56);
            button_add.TabIndex = 3;
            button_add.Text = "+";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // form_calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(button_add);
            Controls.Add(textBox_finalResult);
            Controls.Add(textBox_secondNumber);
            Controls.Add(textBox_firstNumber);
            Name = "form_calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_firstNumber;
        private TextBox textBox_secondNumber;
        private TextBox textBox_finalResult;
        private Button button_add;
    }
}
