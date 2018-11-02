using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop;

namespace Bank
{
    public partial class AccountForm : Form
    {

        // public static List<Account> AccountsList = new List<Account>();
        public static List<SavingsAccount> SavingsAccountsList = new List<SavingsAccount>();
        public static List<ChequingAccount> ChequingAccountsList = new List<ChequingAccount>();

        int indexOfCustomer;
        int indexOfBranch;
        public AccountForm(int indexOfBranch, int indexOfCustomer)
        {
            InitializeComponent();
            this.indexOfCustomer = indexOfCustomer;
            this.indexOfBranch = indexOfBranch;
            LoadAccounts();

            dgvReadSavingsAccounts.DataSource = SavingsAccountsList;
            dgvReadChequingAccounts.DataSource = ChequingAccountsList;


            AddingAccounts();
        }



        public void SaveSavingsAccounts()
        {
            BranchForm.BranchesList[indexOfBranch].Customers[indexOfCustomer].SavingsAccounts = SavingsAccountsList;
            BranchForm.SaveBranches();
        }

        public void SaveChequingAccounts()
        {
            BranchForm.BranchesList[indexOfBranch].Customers[indexOfCustomer].ChequingAccounts = ChequingAccountsList;
            BranchForm.SaveBranches();
        }

        public void LoadAccounts()
        {
            SavingsAccountsList = BranchForm.LoadBranches()[indexOfBranch].Customers[indexOfCustomer].SavingsAccounts;
            ChequingAccountsList = BranchForm.LoadBranches()[indexOfBranch].Customers[indexOfCustomer].ChequingAccounts;
        }

        private void btnAddAccountInMain_Click(object sender, EventArgs e)
        {
            tabControlAccount.SelectTab("tabPageAddAccount");
        }

        private void btnEditAccountInMain_Click(object sender, EventArgs e)
        {
            if (this.dgvReadSavingsAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rows were selected,Please Select a row to edit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tabControlAccount.SelectTab("tabPageEditAccount");
        }

        private void btnDeleteAccountInMain_Click(object sender, EventArgs e)
        {
            if (this.dgvReadSavingsAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rows were selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure, you want to delete it", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            foreach (DataGridViewRow item in this.dgvReadSavingsAccounts.SelectedRows)
            {
                //Transactions.RemoveAt(item.Index);
            }
            dgvReadSavingsAccounts.DataSource = null;
            //dgvReadAccounts.DataSource = Customers.Accounts;
        }


        private void btnAddAccount_Click_1(object sender, EventArgs e)
        {
            SavingsAccount a = new SavingsAccount(txtAccountNumber.Text, Convert.ToDouble(textBox1.Text));

            SavingsAccountsList.Add(a);

            SaveSavingsAccounts();
            dgvReadSavingsAccounts.DataSource = null;
            dgvReadSavingsAccounts.DataSource = SavingsAccountsList;
            MessageBox.Show("Added");

        }



        private void button1_Click(object sender, EventArgs e)
        {
            ChequingAccount a = new ChequingAccount(textBox3.Text, Convert.ToDouble(textBox2.Text));

            ChequingAccountsList.Add(a);

            SaveChequingAccounts();

            dgvReadChequingAccounts.DataSource = null;
            dgvReadChequingAccounts.DataSource = ChequingAccountsList;
            MessageBox.Show("Added");
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (rbSavings.Checked)
            {
                i = dgvReadSavingsAccounts.CurrentRow.Index;
                SavingsAccountsList[i].Debit(Convert.ToDouble(txtAmount));
            }
            else if (rbChequing.Checked)
            {
                i = dgvReadChequingAccounts.CurrentRow.Index;
                ChequingAccountsList[i].Debit(Convert.ToDouble(txtAmount));
            }
            else
            {
                MessageBox.Show("Please select the account type");
            }


            dgvReadSavingsAccounts.DataSource = null;
            dgvReadChequingAccounts.DataSource = null;
            dgvReadSavingsAccounts.DataSource = SavingsAccountsList;
            dgvReadChequingAccounts.DataSource = ChequingAccountsList;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (rbSavings.Checked)
            {
                i = dgvReadSavingsAccounts.CurrentRow.Index;
                SavingsAccountsList[i].Deposit(Convert.ToDouble(txtAmount));
            }
            else if (rbChequing.Checked)
            {
                i = dgvReadChequingAccounts.CurrentRow.Index;
                ChequingAccountsList[i].Deposit(Convert.ToDouble(txtAmount));
            }
            else
            {
                MessageBox.Show("Please select the account type");
            }


            dgvReadSavingsAccounts.DataSource = null;
            dgvReadChequingAccounts.DataSource = null;
            dgvReadSavingsAccounts.DataSource = SavingsAccountsList;
            dgvReadChequingAccounts.DataSource = ChequingAccountsList;

        }

        public void AddingAccounts()
        {
            SavingsAccount s1 = new SavingsAccount("S1",3.23);
            SavingsAccount s2 = new SavingsAccount("S2", 2.21);
            SavingsAccount s3 = new SavingsAccount("S3", 3.13);
            SavingsAccount s4 = new SavingsAccount("S4", 2.45);
            SavingsAccount s5 = new SavingsAccount("S5", 4.06);

            SavingsAccountsList.Add(s1);
            SavingsAccountsList.Add(s2);
            SavingsAccountsList.Add(s3);
            SavingsAccountsList.Add(s4);
            SavingsAccountsList.Add(s5);
            
        }

        private void dgvReadSavingsAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
