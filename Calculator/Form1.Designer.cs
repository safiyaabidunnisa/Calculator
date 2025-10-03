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
            button_add = new Button();
            button_sub = new Button();
            button_multiply = new Button();
            button_div = new Button();
            label_result = new Label();
            button_clear = new Button();
            button_backspace = new Button();
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
            // button_sub
            // 
            button_sub.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_sub.Location = new Point(187, 153);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(94, 56);
            button_sub.TabIndex = 4;
            button_sub.Text = "-";
            button_sub.UseVisualStyleBackColor = true;
            button_sub.Click += button_sub_Click;
            // 
            // button_multiply
            // 
            button_multiply.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_multiply.Location = new Point(61, 230);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(94, 56);
            button_multiply.TabIndex = 5;
            button_multiply.Text = "*";
            button_multiply.UseVisualStyleBackColor = true;
            button_multiply.Click += button_multiply_Click;
            // 
            // button_div
            // 
            button_div.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_div.Location = new Point(187, 230);
            button_div.Name = "button_div";
            button_div.Size = new Size(94, 56);
            button_div.TabIndex = 6;
            button_div.Text = "/";
            button_div.UseVisualStyleBackColor = true;
            button_div.Click += button_div_Click;
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new Point(61, 326);
            label_result.Name = "label_result";
            label_result.Size = new Size(204, 20);
            label_result.TabIndex = 7;
            label_result.Text = "Final Result will appear here...";
            // 
            // button_clear
            // 
            button_clear.Location = new Point(244, 369);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 8;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_backspace
            // 
            button_backspace.Location = new Point(96, 369);
            button_backspace.Name = "button_backspace";
            button_backspace.Size = new Size(94, 29);
            button_backspace.TabIndex = 9;
            button_backspace.Text = "Backspace";
            button_backspace.UseVisualStyleBackColor = true;
            button_backspace.Click += button_backspace_Click;
            // 
            // form_calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(button_backspace);
            Controls.Add(button_clear);
            Controls.Add(label_result);
            Controls.Add(button_div);
            Controls.Add(button_multiply);
            Controls.Add(button_sub);
            Controls.Add(button_add);
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
        private Button button_add;
        private Button button_sub;
        private Button button_multiply;
        private Button button_div;
        private Label label_result;
        private Button button_clear;
        private Button button_backspace;
    }
}
