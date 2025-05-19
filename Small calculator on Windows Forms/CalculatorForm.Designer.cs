namespace Small_calculator_on_Windows_Forms
{
    partial class CalculatorForm
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(65, 65, 65);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 374);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 1;
            button1.Text = "+/-";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(65, 65, 65);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(93, 374);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 2;
            button2.Text = "+/-";
            button2.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(384, 461);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CalculatorForm";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
    }
}
