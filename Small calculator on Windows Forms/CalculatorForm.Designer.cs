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
            staples = new Button();
            zero = new Button();
            separator = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            multiply = new Button();
            minus = new Button();
            plus = new Button();
            equally = new Button();
            share = new Button();
            eraseFullLastNum = new Button();
            eraseEverything = new Button();
            eraseLast = new Button();
            output = new TextBox();
            info = new Label();
            SuspendLayout();
            // 
            // staples
            // 
            staples.BackColor = Color.FromArgb(65, 65, 65);
            staples.FlatAppearance.BorderSize = 0;
            staples.FlatStyle = FlatStyle.Flat;
            staples.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            staples.ForeColor = Color.WhiteSmoke;
            staples.Location = new Point(11, 389);
            staples.Name = "staples";
            staples.Size = new Size(75, 55);
            staples.TabIndex = 1;
            staples.Text = "( )";
            staples.UseVisualStyleBackColor = false;
            staples.Click += staples_Click;
            // 
            // zero
            // 
            zero.BackColor = Color.FromArgb(65, 65, 65);
            zero.FlatAppearance.BorderSize = 0;
            zero.FlatStyle = FlatStyle.Flat;
            zero.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            zero.ForeColor = Color.WhiteSmoke;
            zero.Location = new Point(93, 389);
            zero.Name = "zero";
            zero.Size = new Size(75, 55);
            zero.TabIndex = 2;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // separator
            // 
            separator.BackColor = Color.FromArgb(65, 65, 65);
            separator.FlatAppearance.BorderSize = 0;
            separator.FlatStyle = FlatStyle.Flat;
            separator.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            separator.ForeColor = Color.WhiteSmoke;
            separator.Location = new Point(174, 389);
            separator.Name = "separator";
            separator.Size = new Size(75, 55);
            separator.TabIndex = 3;
            separator.Text = ".";
            separator.UseVisualStyleBackColor = false;
            separator.Click += separator_Click;
            // 
            // one
            // 
            one.BackColor = Color.FromArgb(65, 65, 65);
            one.FlatAppearance.BorderSize = 0;
            one.FlatStyle = FlatStyle.Flat;
            one.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            one.ForeColor = Color.WhiteSmoke;
            one.Location = new Point(12, 323);
            one.Name = "one";
            one.Size = new Size(75, 55);
            one.TabIndex = 4;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_Click;
            // 
            // two
            // 
            two.BackColor = Color.FromArgb(65, 65, 65);
            two.FlatAppearance.BorderSize = 0;
            two.FlatStyle = FlatStyle.Flat;
            two.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            two.ForeColor = Color.WhiteSmoke;
            two.Location = new Point(93, 323);
            two.Name = "two";
            two.Size = new Size(75, 55);
            two.TabIndex = 5;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // three
            // 
            three.BackColor = Color.FromArgb(65, 65, 65);
            three.FlatAppearance.BorderSize = 0;
            three.FlatStyle = FlatStyle.Flat;
            three.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            three.ForeColor = Color.WhiteSmoke;
            three.Location = new Point(174, 323);
            three.Name = "three";
            three.Size = new Size(75, 55);
            three.TabIndex = 6;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // four
            // 
            four.BackColor = Color.FromArgb(65, 65, 65);
            four.FlatAppearance.BorderSize = 0;
            four.FlatStyle = FlatStyle.Flat;
            four.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            four.ForeColor = Color.WhiteSmoke;
            four.Location = new Point(12, 257);
            four.Name = "four";
            four.Size = new Size(75, 55);
            four.TabIndex = 7;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // five
            // 
            five.BackColor = Color.FromArgb(65, 65, 65);
            five.FlatAppearance.BorderSize = 0;
            five.FlatStyle = FlatStyle.Flat;
            five.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            five.ForeColor = Color.WhiteSmoke;
            five.Location = new Point(93, 257);
            five.Name = "five";
            five.Size = new Size(75, 55);
            five.TabIndex = 8;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // six
            // 
            six.BackColor = Color.FromArgb(65, 65, 65);
            six.FlatAppearance.BorderSize = 0;
            six.FlatStyle = FlatStyle.Flat;
            six.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            six.ForeColor = Color.WhiteSmoke;
            six.Location = new Point(174, 257);
            six.Name = "six";
            six.Size = new Size(75, 55);
            six.TabIndex = 9;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // seven
            // 
            seven.BackColor = Color.FromArgb(65, 65, 65);
            seven.FlatAppearance.BorderSize = 0;
            seven.FlatStyle = FlatStyle.Flat;
            seven.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            seven.ForeColor = Color.WhiteSmoke;
            seven.Location = new Point(12, 191);
            seven.Name = "seven";
            seven.Size = new Size(75, 55);
            seven.TabIndex = 10;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_Click;
            // 
            // eight
            // 
            eight.BackColor = Color.FromArgb(65, 65, 65);
            eight.FlatAppearance.BorderSize = 0;
            eight.FlatStyle = FlatStyle.Flat;
            eight.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            eight.ForeColor = Color.WhiteSmoke;
            eight.Location = new Point(93, 191);
            eight.Name = "eight";
            eight.Size = new Size(75, 55);
            eight.TabIndex = 11;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_Click;
            // 
            // nine
            // 
            nine.BackColor = Color.FromArgb(65, 65, 65);
            nine.FlatAppearance.BorderSize = 0;
            nine.FlatStyle = FlatStyle.Flat;
            nine.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            nine.ForeColor = Color.WhiteSmoke;
            nine.Location = new Point(174, 191);
            nine.Name = "nine";
            nine.Size = new Size(75, 55);
            nine.TabIndex = 12;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_Click;
            // 
            // multiply
            // 
            multiply.BackColor = Color.FromArgb(55, 55, 55);
            multiply.FlatAppearance.BorderSize = 0;
            multiply.FlatStyle = FlatStyle.Flat;
            multiply.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            multiply.ForeColor = Color.WhiteSmoke;
            multiply.Location = new Point(255, 191);
            multiply.Name = "multiply";
            multiply.Size = new Size(75, 55);
            multiply.TabIndex = 16;
            multiply.Text = "×";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.FromArgb(55, 55, 55);
            minus.FlatAppearance.BorderSize = 0;
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            minus.ForeColor = Color.WhiteSmoke;
            minus.Location = new Point(255, 257);
            minus.Name = "minus";
            minus.Size = new Size(75, 55);
            minus.TabIndex = 15;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.FromArgb(55, 55, 55);
            plus.FlatAppearance.BorderSize = 0;
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            plus.ForeColor = Color.WhiteSmoke;
            plus.Location = new Point(255, 323);
            plus.Name = "plus";
            plus.Size = new Size(75, 55);
            plus.TabIndex = 14;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // equally
            // 
            equally.BackColor = Color.FromArgb(0, 100, 255);
            equally.FlatAppearance.BorderSize = 0;
            equally.FlatStyle = FlatStyle.Flat;
            equally.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            equally.ForeColor = Color.WhiteSmoke;
            equally.Location = new Point(255, 389);
            equally.Name = "equally";
            equally.Size = new Size(75, 55);
            equally.TabIndex = 13;
            equally.Text = "=";
            equally.UseVisualStyleBackColor = false;
            equally.Click += equally_Click;
            // 
            // share
            // 
            share.BackColor = Color.FromArgb(55, 55, 55);
            share.FlatAppearance.BorderSize = 0;
            share.FlatStyle = FlatStyle.Flat;
            share.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            share.ForeColor = Color.WhiteSmoke;
            share.Location = new Point(255, 125);
            share.Name = "share";
            share.Size = new Size(75, 55);
            share.TabIndex = 20;
            share.Text = "÷";
            share.UseVisualStyleBackColor = false;
            share.Click += share_Click;
            // 
            // eraseFullLastNum
            // 
            eraseFullLastNum.BackColor = Color.FromArgb(55, 55, 55);
            eraseFullLastNum.FlatAppearance.BorderSize = 0;
            eraseFullLastNum.FlatStyle = FlatStyle.Flat;
            eraseFullLastNum.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            eraseFullLastNum.ForeColor = Color.WhiteSmoke;
            eraseFullLastNum.Location = new Point(174, 125);
            eraseFullLastNum.Name = "eraseFullLastNum";
            eraseFullLastNum.Size = new Size(75, 55);
            eraseFullLastNum.TabIndex = 19;
            eraseFullLastNum.Text = "CE";
            eraseFullLastNum.UseVisualStyleBackColor = false;
            eraseFullLastNum.Click += eraseFullLastNum_Click;
            // 
            // eraseEverything
            // 
            eraseEverything.BackColor = Color.FromArgb(55, 55, 55);
            eraseEverything.FlatAppearance.BorderSize = 0;
            eraseEverything.FlatStyle = FlatStyle.Flat;
            eraseEverything.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            eraseEverything.ForeColor = Color.WhiteSmoke;
            eraseEverything.Location = new Point(93, 125);
            eraseEverything.Name = "eraseEverything";
            eraseEverything.Size = new Size(75, 55);
            eraseEverything.TabIndex = 18;
            eraseEverything.Text = "C";
            eraseEverything.UseVisualStyleBackColor = false;
            eraseEverything.Click += eraseEverything_Click;
            // 
            // eraseLast
            // 
            eraseLast.BackColor = Color.FromArgb(55, 55, 55);
            eraseLast.FlatAppearance.BorderSize = 0;
            eraseLast.FlatStyle = FlatStyle.Flat;
            eraseLast.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            eraseLast.ForeColor = Color.WhiteSmoke;
            eraseLast.Location = new Point(12, 125);
            eraseLast.Name = "eraseLast";
            eraseLast.Size = new Size(75, 55);
            eraseLast.TabIndex = 17;
            eraseLast.Text = "❮";
            eraseLast.UseVisualStyleBackColor = false;
            eraseLast.Click += eraseLast_Click;
            // 
            // output
            // 
            output.BackColor = Color.FromArgb(35, 35, 35);
            output.BorderStyle = BorderStyle.FixedSingle;
            output.Font = new Font("Segoe UI Semibold", 30.75F, FontStyle.Bold);
            output.ForeColor = Color.WhiteSmoke;
            output.Location = new Point(12, 12);
            output.Name = "output";
            output.Size = new Size(318, 62);
            output.TabIndex = 21;
            // 
            // info
            // 
            info.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            info.ForeColor = Color.DimGray;
            info.Location = new Point(12, 77);
            info.Name = "info";
            info.Size = new Size(317, 45);
            info.TabIndex = 22;
            info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(341, 461);
            Controls.Add(info);
            Controls.Add(output);
            Controls.Add(share);
            Controls.Add(eraseFullLastNum);
            Controls.Add(eraseEverything);
            Controls.Add(eraseLast);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(equally);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(separator);
            Controls.Add(zero);
            Controls.Add(staples);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CalculatorForm";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button staples;
        private Button zero;
        private Button separator;
        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button multiply;
        private Button minus;
        private Button plus;
        private Button equally;
        private Button share;
        private Button eraseFullLastNum;
        private Button eraseEverything;
        private Button eraseLast;
        private TextBox output;
        private Label info;
    }
}
