namespace Week5FormsBankSystem
{
    partial class Accounts
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
            this.T2 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.T3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentRadioButton = new System.Windows.Forms.RadioButton();
            this.S = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.F = new System.Windows.Forms.RadioButton();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccNo = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(105, 63);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(100, 20);
            this.T2.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 66);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(105, 103);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(100, 20);
            this.T3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // currentRadioButton
            // 
            this.currentRadioButton.AutoCheck = false;
            this.currentRadioButton.AutoSize = true;
            this.currentRadioButton.Checked = true;
            this.currentRadioButton.Location = new System.Drawing.Point(12, 168);
            this.currentRadioButton.Name = "currentRadioButton";
            this.currentRadioButton.Size = new System.Drawing.Size(59, 17);
            this.currentRadioButton.TabIndex = 6;
            this.currentRadioButton.TabStop = true;
            this.currentRadioButton.Text = "Current";
            this.currentRadioButton.UseVisualStyleBackColor = true;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(12, 201);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(63, 17);
            this.S.TabIndex = 7;
            this.S.Text = "Savings";
            this.S.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoCheck = false;
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(151, 168);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 8;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(151, 201);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(59, 17);
            this.F.TabIndex = 9;
            this.F.Text = "Female";
            this.F.UseVisualStyleBackColor = true;
            // 
            // CreateAccount
            // 
            this.CreateAccount.Location = new System.Drawing.Point(69, 226);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(100, 23);
            this.CreateAccount.TabIndex = 13;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Account Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gender";
            // 
            // AccNo
            // 
            this.AccNo.AutoSize = true;
            this.AccNo.Location = new System.Drawing.Point(12, 25);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(87, 13);
            this.AccNo.TabIndex = 0;
            this.AccNo.Text = "Account Number";
            // 
            // T1
            // 
            this.T1.Enabled = false;
            this.T1.Location = new System.Drawing.Point(105, 22);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(100, 20);
            this.T1.TabIndex = 1;
            this.T1.TextChanged += new System.EventHandler(this.T1_TextChanged);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.F);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.S);
            this.Controls.Add(this.currentRadioButton);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.AccNo);
            this.Name = "Accounts";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton currentRadioButton;
        private System.Windows.Forms.RadioButton S;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AccNo;
        private System.Windows.Forms.TextBox T1;
    }
}

