namespace Week5FormsCalcApplication3
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.D1 = new System.Windows.Forms.TextBox();
            this.Zero = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Equals1 = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(37, 55);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(209, 20);
            this.D1.TabIndex = 0;
            this.D1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.D1.TextChanged += new System.EventHandler(this.Screen_TextChanged);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(37, 81);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(49, 40);
            this.Zero.TabIndex = 1;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.clicked);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(89, 81);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(49, 40);
            this.One.TabIndex = 2;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.clicked);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(140, 81);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(49, 40);
            this.Two.TabIndex = 3;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.clicked);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(197, 81);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(49, 40);
            this.Three.TabIndex = 4;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.clicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(197, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.clicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(140, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.clicked);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(89, 126);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(49, 40);
            this.Five.TabIndex = 6;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.clicked);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(37, 126);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(49, 40);
            this.Four.TabIndex = 5;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.clicked);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(197, 181);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(49, 40);
            this.Minus.TabIndex = 12;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.execute);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(140, 181);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(49, 40);
            this.Add.TabIndex = 11;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.execute);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(89, 181);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 40);
            this.button11.TabIndex = 10;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(37, 181);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 40);
            this.button12.TabIndex = 9;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(37, 229);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(49, 40);
            this.Multiply.TabIndex = 13;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.execute);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(89, 229);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(49, 40);
            this.Divide.TabIndex = 14;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.execute);
            // 
            // Equals1
            // 
            this.Equals1.Location = new System.Drawing.Point(144, 229);
            this.Equals1.Name = "Equals1";
            this.Equals1.Size = new System.Drawing.Size(102, 38);
            this.Equals1.TabIndex = 15;
            this.Equals1.Text = "=";
            this.Equals1.UseVisualStyleBackColor = true;
            this.Equals1.Click += new System.EventHandler(this.Equals_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(37, 273);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(209, 26);
            this.C.TabIndex = 16;
            this.C.Text = "Clear";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(197, 12);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(49, 23);
            this.Power.TabIndex = 17;
            this.Power.Text = "On/Off";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(298, 306);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Equals1);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.D1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox D1;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Equals1;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Power;
    }
}

