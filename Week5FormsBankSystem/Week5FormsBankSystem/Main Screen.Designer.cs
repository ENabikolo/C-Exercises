namespace Week5FormsBankSystem
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewAccountToolStripMenuItem,
            this.viewAccountsToolStripMenuItem,
            this.editAccountsToolStripMenuItem,
            this.deactivateAccountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // createNewAccountToolStripMenuItem
            // 
            this.createNewAccountToolStripMenuItem.Name = "createNewAccountToolStripMenuItem";
            this.createNewAccountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.createNewAccountToolStripMenuItem.Text = "Create New Account";
            // 
            // viewAccountsToolStripMenuItem
            // 
            this.viewAccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specificToolStripMenuItem,
            this.allToolStripMenuItem});
            this.viewAccountsToolStripMenuItem.Name = "viewAccountsToolStripMenuItem";
            this.viewAccountsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewAccountsToolStripMenuItem.Text = "View Accounts";
            // 
            // editAccountsToolStripMenuItem
            // 
            this.editAccountsToolStripMenuItem.Name = "editAccountsToolStripMenuItem";
            this.editAccountsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editAccountsToolStripMenuItem.Text = "Edit Account";
            // 
            // specificToolStripMenuItem
            // 
            this.specificToolStripMenuItem.Name = "specificToolStripMenuItem";
            this.specificToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.specificToolStripMenuItem.Text = "Specific";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // deactivateAccountToolStripMenuItem
            // 
            this.deactivateAccountToolStripMenuItem.Name = "deactivateAccountToolStripMenuItem";
            this.deactivateAccountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deactivateAccountToolStripMenuItem.Text = "Deactivate Account";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositsToolStripMenuItem,
            this.withdrawalsToolStripMenuItem,
            this.balanceToolStripMenuItem,
            this.statementToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // depositsToolStripMenuItem
            // 
            this.depositsToolStripMenuItem.Name = "depositsToolStripMenuItem";
            this.depositsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.depositsToolStripMenuItem.Text = "Deposits";
            this.depositsToolStripMenuItem.Click += new System.EventHandler(this.depositsToolStripMenuItem_Click);
            // 
            // withdrawalsToolStripMenuItem
            // 
            this.withdrawalsToolStripMenuItem.Name = "withdrawalsToolStripMenuItem";
            this.withdrawalsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.withdrawalsToolStripMenuItem.Text = "Withdrawals";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.balanceToolStripMenuItem.Text = "Balance";
            // 
            // statementToolStripMenuItem
            // 
            this.statementToolStripMenuItem.Name = "statementToolStripMenuItem";
            this.statementToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statementToolStripMenuItem.Text = "Statement";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementToolStripMenuItem;
    }
}