using System;

namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.Add = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.TextBox();
            this.T1 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.T3 = new System.Windows.Forms.TextBox();
            this.T4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(15, 106);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(50, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(103, 38);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(100, 20);
            this.T.TabIndex = 1;
            this.T.Text = "7";
            this.T.TextChanged += new System.EventHandler(this.T_TextChanged);
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(103, 64);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(100, 20);
            this.T1.TabIndex = 2;
            this.T1.Text = "8";
            this.T1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(103, 159);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(100, 20);
            this.T2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "+ Width";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(22, 239);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(100, 20);
            this.T3.TabIndex = 8;
            // 
            // T4
            // 
            this.T4.Location = new System.Drawing.Point(22, 358);
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(100, 20);
            this.T4.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "+-Width";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(71, 106);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 23);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "Minus";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(127, 106);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(50, 23);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(183, 106);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 23);
            this.Divide.TabIndex = 13;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 449);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.T4);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.T);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.TextBox T4;
        private System.Windows.Forms.Button button3;
        protected internal System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
    }
}

