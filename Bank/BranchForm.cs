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
using System.Xml.Serialization;
using Desktop;

namespace Bank
{
    public partial class BranchForm : Form
    {
        public static List<Branch> BranchesList = new List<Branch>();
        //MainMenu mm = new MainMenu();
        public BranchForm()
        {
            InitializeComponent();
            BranchesList = LoadBranches();
            dgvReadBranches.DataSource = BranchesList;
            dgvReadBranches.ClearSelection();
            

        }

        public static List<Branch> LoadBranches()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Branch>));
            StreamReader file = new StreamReader(@"Branches.xml");

            List<Branch> BranchesList = (List<Branch>)reader.Deserialize(file);
            file.Close();
            return BranchesList;
            
        }

        public static void SaveBranches()
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Branch>));
            string path = "Branches.xml";
            FileStream file = File.Create(path);
            writer.Serialize(file, BranchesList);

            file.Close();
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            try
            {
                Branch b = new Branch(new Address(txtStreetName.Text,txtCity.Text,txtProvince.Text,txtZipCode.Text));
                BranchesList.Add(b);
                SaveBranches();
                //if in branch class construtor it gets created properly 
                //it will get added to list of branches in bank ie Bank.Branches.Add(this) in branch constuctor
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvReadBranches.DataSource =  null;
            dgvReadBranches.DataSource = BranchesList;
            lblStatusAdd.Text = "Branch Successfully Added.";
        }

        private void btnAddBranchInMain_Click(object sender, EventArgs e)
        {
            tabControlBranch.SelectTab("tabPageAdd");
        }

        private void btnEditBranchInMain_Click(object sender, EventArgs e)
        {
            if (this.dgvReadBranches.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rows were selected,Please Select a row to edit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tabControlBranch.SelectTab("tabPageEdit");

        }

        private void btnDeleteBranchInMain_Click(object sender, EventArgs e)
        {
            if (this.dgvReadBranches.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rows were selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure, you want to delete it", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            foreach (DataGridViewRow item in this.dgvReadBranches.SelectedRows)
            {
                BranchesList.RemoveAt(item.Index);
            }
            dgvReadBranches.DataSource = null;
            dgvReadBranches.DataSource = BranchesList;
        }

        private void btnEditBranch_Click(object sender, EventArgs e)
        {
            int i = dgvReadBranches.CurrentRow.Index;
            try
            {            
                BranchesList[i].Address.Street = txtEditedStreetName.Text;
                BranchesList[i].Address.City = txtEditedCity.Text;
                BranchesList[i].Address.Province = txtEditedProvince.Text;
                BranchesList[i].Address.PostalCode = txtEditedZipCode.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvReadBranches.DataSource = null;
            dgvReadBranches.DataSource = BranchesList;
            lblStatusEdit.Text = "Branch Edited Successfully.";

        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tabControlBranch.SelectTab(tabPageEdit);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = dgvReadBranches.CurrentRow.Index;
            BranchesList.RemoveAt(i);
            dgvReadBranches.DataSource = null;
            dgvReadBranches.DataSource = BranchesList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControlBranch.SelectTab(tabPageAdd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexOfBranch = dgvReadBranches.CurrentRow.Index;
            Customers c = new Customers(indexOfBranch);
            c.ShowDialog();
        }

    }
}
