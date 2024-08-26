namespace BankingApp
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
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.textBoxWithdrawAmount = new System.Windows.Forms.TextBox();
            this.buttonCalculateInterest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.Location = new System.Drawing.Point(12, 12);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(260, 160);
            this.listBoxAccounts.TabIndex = 0;
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(12, 190);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepositAmount.TabIndex = 1;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(118, 190);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposit.TabIndex = 2;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(118, 220);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(75, 23);
            this.buttonWithdraw.TabIndex = 4;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            // 
            // textBoxWithdrawAmount
            // 
            this.textBoxWithdrawAmount.Location = new System.Drawing.Point(12, 220);
            this.textBoxWithdrawAmount.Name = "textBoxWithdrawAmount";
            this.textBoxWithdrawAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxWithdrawAmount.TabIndex = 3;
            // 
            // buttonCalculateInterest
            // 
            this.buttonCalculateInterest.Location = new System.Drawing.Point(12, 250);
            this.buttonCalculateInterest.Name = "buttonCalculateInterest";
            this.buttonCalculateInterest.Size = new System.Drawing.Size(181, 23);
            this.buttonCalculateInterest.TabIndex = 5;
            this.buttonCalculateInterest.Text = "Calculate Interest";
            this.buttonCalculateInterest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this.buttonCalculateInterest);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.textBoxWithdrawAmount);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.textBoxDepositAmount);
            this.Controls.Add(this.listBoxAccounts);
            this.Name = "Form1";
            this.Text = "Banking App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}