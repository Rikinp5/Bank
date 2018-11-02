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
    public partial class Customers : Form
    {
        public static List<Customer> CustomersList = new List<Customer>();
        int index;
        //BranchForm bf = new BranchForm();

        public Customers(int indexOfBranch)
        {
            InitializeComponent();
            index = indexOfBranch;
            CustomersList = LoadCustomers();
            dgvReadCustomers.DataSource = CustomersList;
        }

        public List<Customer> LoadCustomers()
        {
            //List<Branch> branches = BranchForm.LoadBranches();
            return BranchForm.LoadBranches()[index].Customers;
        }

        public void SaveCustomers()
        {
            BranchForm.BranchesList[index].Customers = CustomersList;
            BranchForm.SaveBranches();
        }
        

        private void btnAddCustomersInMain_Click(object sender, EventArgs e)
        {
            tabControlCustomer.SelectTab("tabPageAddCustomers");

        }

        private void btnEditCustomersInMain_Click(object sender, EventArgs e)
        {
            if (this.dgvReadCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rows were selected,Please Select a row to edit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tabControlCustomer.SelectTab("tabPageEditCustomers");
        }

        private void btnDeleteCustomersInMain_Click(object sender, EventArgs e)
        {
            if (this.dgvReadCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rows were selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure, you want to delete it", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            foreach (DataGridViewRow item in this.dgvReadCustomers.SelectedRows)
            {
              //  BranchForm.Customers.RemoveAt(item.Index);
            }
            dgvReadCustomers.DataSource = null;
          //  dgvReadCustomers.DataSource = BranchForm.Customers;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer(txtFirstName.Text,txtLastName.Text,new Address(txtStreetName.Text, txtCity.Text, txtProvince.Text, txtZipCode.Text));
                CustomersList.Add(c);

                SaveCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvReadCustomers.DataSource = null;
            dgvReadCustomers.DataSource = CustomersList;
            lblStatusAdd.Text = "Customer Successfully Added.";
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int i = dgvReadCustomers.CurrentRow.Index;
            try
            {
                //BranchForm.Customers[i].FirstName = txtEditedFirstName.Text;
                //BranchForm.Customers[i].LastName = txtEditedLastName.Text;
                //BranchForm.Customers[i].Address.Street = txtEditedStreetName.Text;
                //BranchForm.Customers[i].Address.City = txtEditedCity.Text;
                //BranchForm.Customers[i].Address.Province = txtEditedProvince.Text;
                //BranchForm.Customers[i].Address.PostalCode = txtEditedZipCode.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvReadCustomers.DataSource = null;
         //   dgvReadCustomers.DataSource = BranchForm.Customers;
            lblStatusEdit.Text = "Customer Edited Successfully.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int indexOfCustomer = dgvReadCustomers.CurrentRow.Index;
                AccountForm a = new AccountForm(index, indexOfCustomer);
                a.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("INVALID");
            }
        }

       
    }
}
