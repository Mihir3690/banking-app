using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Form1 : Form
    {
        private ListBox listBoxAccounts;
        private TextBox textBoxDepositAmount;
        private TextBox textBoxWithdrawAmount;
        private Button buttonDeposit;
        private Button buttonWithdraw;
        private Button buttonCalculateInterest;

        private Customer customer;

        public Form1()
        {
            this.Text = "Banking App";
            this.Width = 400;
            this.Height = 300;

            listBoxAccounts = new ListBox();
            listBoxAccounts.Location = new Point(10, 10);
            listBoxAccounts.Size = new Size(200, 200);
            this.Controls.Add(listBoxAccounts);

            textBoxDepositAmount = new TextBox();
            textBoxDepositAmount.Location = new Point(220, 10);
            textBoxDepositAmount.Size = new Size(100, 20);
            this.Controls.Add(textBoxDepositAmount);

            textBoxWithdrawAmount = new TextBox();
            textBoxWithdrawAmount.Location = new Point(220, 40);
            textBoxWithdrawAmount.Size = new Size(100, 20);
            this.Controls.Add(textBoxWithdrawAmount);

            buttonDeposit = new Button();
            buttonDeposit.Location = new Point(220, 70);
            buttonDeposit.Size = new Size(100, 20);
            buttonDeposit.Text = "Deposit";
            buttonDeposit.Click += buttonDeposit_Click;
            this.Controls.Add(buttonDeposit);

            buttonWithdraw = new Button();
            buttonWithdraw.Location = new Point(220, 100);
            buttonWithdraw.Size = new Size(100, 20);
            buttonWithdraw.Text = "Withdraw";
            buttonWithdraw.Click += buttonWithdraw_Click;
            this.Controls.Add(buttonWithdraw);

            buttonCalculateInterest = new Button();
            buttonCalculateInterest.Location = new Point(220, 130);
            buttonCalculateInterest.Size = new Size(100, 20);
            buttonCalculateInterest.Text = "Calculate Interest";
            buttonCalculateInterest.Click += buttonCalculateInterest_Click;
            this.Controls.Add(buttonCalculateInterest);

            customer = new Customer(1, "John Doe", "123 Main St", new Account[] {
                new EverydayAccount(1, 1000),
                new InvestmentAccount(2, 2000, 0.05),
                new OmniAccount(3, 3000, 0.03, 1000)
            });

            UpdateAccountList();
        }

        private void UpdateAccountList()
        {
            listBoxAccounts.Items.Clear();
            foreach (Account account in customer.Accounts)
            {
                listBoxAccounts.Items.Add(account.ToString());
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (listBoxAccounts.SelectedItem != null)
            {
                Account selectedAccount = customer.Accounts[listBoxAccounts.SelectedIndex];
                double amount = double.Parse(textBoxDepositAmount.Text);
                selectedAccount.Deposit(amount);
                UpdateAccountList();
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            if (listBoxAccounts.SelectedItem != null)
            {
                Account selectedAccount = customer.Accounts[listBoxAccounts.SelectedIndex];
                double amount = double.Parse(textBoxWithdrawAmount.Text);
                try
                {
                    selectedAccount.Withdraw(amount);
                }
                catch (System.InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                UpdateAccountList();
            }
        }

        private void buttonCalculateInterest_Click(object sender, EventArgs e)
        {
            if (listBoxAccounts.SelectedItem != null)
            {
                Account selectedAccount = customer.Accounts[listBoxAccounts.SelectedIndex];
                selectedAccount.CalculateInterest();
                UpdateAccountList();
            }
        }
    }
}

