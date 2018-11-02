namespace Bank
{
    partial class Customers
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
            this.tabControlCustomer = new System.Windows.Forms.TabControl();
            this.tabPageReadCustomers = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddCustomersInMain = new System.Windows.Forms.Button();
            this.btnDeleteCustomersInMain = new System.Windows.Forms.Button();
            this.btnEditCustomersInMain = new System.Windows.Forms.Button();
            this.dgvReadCustomers = new System.Windows.Forms.DataGridView();
            this.tabPageAddCustomers = new System.Windows.Forms.TabPage();
            this.lblStatusAdd = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.tabPageEditCustomers = new System.Windows.Forms.TabPage();
            this.lblStatusEdit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.txtEditedLastName = new System.Windows.Forms.TextBox();
            this.txtEditedFirstName = new System.Windows.Forms.TextBox();
            this.lblLastNameEdited = new System.Windows.Forms.Label();
            this.lblFirstNameEdited = new System.Windows.Forms.Label();
            this.txtEditedZipCode = new System.Windows.Forms.TextBox();
            this.txtEditedProvince = new System.Windows.Forms.TextBox();
            this.txtEditedCity = new System.Windows.Forms.TextBox();
            this.txtEditedStreetName = new System.Windows.Forms.TextBox();
            this.lblZipCodeEdited = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCityEdited = new System.Windows.Forms.Label();
            this.lblStreetNameEdited = new System.Windows.Forms.Label();
            this.tabControlCustomer.SuspendLayout();
            this.tabPageReadCustomers.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadCustomers)).BeginInit();
            this.tabPageAddCustomers.SuspendLayout();
            this.tabPageEditCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCustomer
            // 
            this.tabControlCustomer.Controls.Add(this.tabPageReadCustomers);
            this.tabControlCustomer.Controls.Add(this.tabPageAddCustomers);
            this.tabControlCustomer.Controls.Add(this.tabPageEditCustomers);
            this.tabControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCustomer.Location = new System.Drawing.Point(0, 0);
            this.tabControlCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlCustomer.Name = "tabControlCustomer";
            this.tabControlCustomer.SelectedIndex = 0;
            this.tabControlCustomer.Size = new System.Drawing.Size(751, 466);
            this.tabControlCustomer.TabIndex = 0;
            // 
            // tabPageReadCustomers
            // 
            this.tabPageReadCustomers.Controls.Add(this.panel2);
            this.tabPageReadCustomers.Controls.Add(this.dgvReadCustomers);
            this.tabPageReadCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageReadCustomers.Location = new System.Drawing.Point(4, 34);
            this.tabPageReadCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageReadCustomers.Name = "tabPageReadCustomers";
            this.tabPageReadCustomers.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageReadCustomers.Size = new System.Drawing.Size(743, 428);
            this.tabPageReadCustomers.TabIndex = 0;
            this.tabPageReadCustomers.Text = "Read Customers";
            this.tabPageReadCustomers.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnAddCustomersInMain);
            this.panel2.Controls.Add(this.btnDeleteCustomersInMain);
            this.panel2.Controls.Add(this.btnEditCustomersInMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 301);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 123);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Access Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddCustomersInMain
            // 
            this.btnAddCustomersInMain.Location = new System.Drawing.Point(62, 4);
            this.btnAddCustomersInMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomersInMain.Name = "btnAddCustomersInMain";
            this.btnAddCustomersInMain.Size = new System.Drawing.Size(200, 46);
            this.btnAddCustomersInMain.TabIndex = 2;
            this.btnAddCustomersInMain.Text = "Add Customers";
            this.btnAddCustomersInMain.UseVisualStyleBackColor = true;
            this.btnAddCustomersInMain.Click += new System.EventHandler(this.btnAddCustomersInMain_Click);
            // 
            // btnDeleteCustomersInMain
            // 
            this.btnDeleteCustomersInMain.Location = new System.Drawing.Point(62, 73);
            this.btnDeleteCustomersInMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCustomersInMain.Name = "btnDeleteCustomersInMain";
            this.btnDeleteCustomersInMain.Size = new System.Drawing.Size(200, 46);
            this.btnDeleteCustomersInMain.TabIndex = 1;
            this.btnDeleteCustomersInMain.Text = "Delete Customers";
            this.btnDeleteCustomersInMain.UseVisualStyleBackColor = true;
            this.btnDeleteCustomersInMain.Click += new System.EventHandler(this.btnDeleteCustomersInMain_Click);
            // 
            // btnEditCustomersInMain
            // 
            this.btnEditCustomersInMain.Location = new System.Drawing.Point(400, 4);
            this.btnEditCustomersInMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCustomersInMain.Name = "btnEditCustomersInMain";
            this.btnEditCustomersInMain.Size = new System.Drawing.Size(209, 46);
            this.btnEditCustomersInMain.TabIndex = 0;
            this.btnEditCustomersInMain.Text = "Edit Customers";
            this.btnEditCustomersInMain.UseVisualStyleBackColor = true;
            this.btnEditCustomersInMain.Click += new System.EventHandler(this.btnEditCustomersInMain_Click);
            // 
            // dgvReadCustomers
            // 
            this.dgvReadCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReadCustomers.Location = new System.Drawing.Point(4, 4);
            this.dgvReadCustomers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvReadCustomers.Name = "dgvReadCustomers";
            this.dgvReadCustomers.Size = new System.Drawing.Size(735, 420);
            this.dgvReadCustomers.TabIndex = 1;
            // 
            // tabPageAddCustomers
            // 
            this.tabPageAddCustomers.Controls.Add(this.lblStatusAdd);
            this.tabPageAddCustomers.Controls.Add(this.btnAddCustomer);
            this.tabPageAddCustomers.Controls.Add(this.label1);
            this.tabPageAddCustomers.Controls.Add(this.txtLastName);
            this.tabPageAddCustomers.Controls.Add(this.txtFirstName);
            this.tabPageAddCustomers.Controls.Add(this.lblLastName);
            this.tabPageAddCustomers.Controls.Add(this.lblFirstName);
            this.tabPageAddCustomers.Controls.Add(this.txtZipCode);
            this.tabPageAddCustomers.Controls.Add(this.txtProvince);
            this.tabPageAddCustomers.Controls.Add(this.txtCity);
            this.tabPageAddCustomers.Controls.Add(this.txtStreetName);
            this.tabPageAddCustomers.Controls.Add(this.lblZipCode);
            this.tabPageAddCustomers.Controls.Add(this.lblProvince);
            this.tabPageAddCustomers.Controls.Add(this.lblCity);
            this.tabPageAddCustomers.Controls.Add(this.lblStreetName);
            this.tabPageAddCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddCustomers.Location = new System.Drawing.Point(4, 34);
            this.tabPageAddCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAddCustomers.Name = "tabPageAddCustomers";
            this.tabPageAddCustomers.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAddCustomers.Size = new System.Drawing.Size(743, 428);
            this.tabPageAddCustomers.TabIndex = 1;
            this.tabPageAddCustomers.Text = "Add Customers";
            this.tabPageAddCustomers.UseVisualStyleBackColor = true;
            // 
            // lblStatusAdd
            // 
            this.lblStatusAdd.AutoSize = true;
            this.lblStatusAdd.Location = new System.Drawing.Point(319, 343);
            this.lblStatusAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusAdd.Name = "lblStatusAdd";
            this.lblStatusAdd.Size = new System.Drawing.Size(93, 25);
            this.lblStatusAdd.TabIndex = 11;
            this.lblStatusAdd.Text = "Message";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(4, 376);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(735, 48);
            this.btnAddCustomer.TabIndex = 22;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter Customer Details";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(260, 121);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(305, 30);
            this.txtLastName.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(260, 76);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(305, 30);
            this.txtFirstName.TabIndex = 19;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(81, 126);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 25);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(81, 79);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(117, 25);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(260, 299);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(305, 30);
            this.txtZipCode.TabIndex = 16;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(260, 257);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(305, 30);
            this.txtProvince.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(260, 213);
            this.txtCity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(305, 30);
            this.txtCity.TabIndex = 14;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(260, 169);
            this.txtStreetName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(305, 30);
            this.txtStreetName.TabIndex = 13;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(100, 302);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(98, 25);
            this.lblZipCode.TabIndex = 12;
            this.lblZipCode.Text = "ZipCode :";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(100, 260);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(99, 25);
            this.lblProvince.TabIndex = 11;
            this.lblProvince.Text = "Province :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(141, 216);
            this.lblCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 25);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City :";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(66, 172);
            this.lblStreetName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(132, 25);
            this.lblStreetName.TabIndex = 9;
            this.lblStreetName.Text = "Street Name :";
            // 
            // tabPageEditCustomers
            // 
            this.tabPageEditCustomers.Controls.Add(this.lblStatusEdit);
            this.tabPageEditCustomers.Controls.Add(this.label2);
            this.tabPageEditCustomers.Controls.Add(this.btnEditCustomer);
            this.tabPageEditCustomers.Controls.Add(this.txtEditedLastName);
            this.tabPageEditCustomers.Controls.Add(this.txtEditedFirstName);
            this.tabPageEditCustomers.Controls.Add(this.lblLastNameEdited);
            this.tabPageEditCustomers.Controls.Add(this.lblFirstNameEdited);
            this.tabPageEditCustomers.Controls.Add(this.txtEditedZipCode);
            this.tabPageEditCustomers.Controls.Add(this.txtEditedProvince);
            this.tabPageEditCustomers.Controls.Add(this.txtEditedCity);
            this.tabPageEditCustomers.Controls.Add(this.txtEditedStreetName);
            this.tabPageEditCustomers.Controls.Add(this.lblZipCodeEdited);
            this.tabPageEditCustomers.Controls.Add(this.label5);
            this.tabPageEditCustomers.Controls.Add(this.lblCityEdited);
            this.tabPageEditCustomers.Controls.Add(this.lblStreetNameEdited);
            this.tabPageEditCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEditCustomers.Location = new System.Drawing.Point(4, 34);
            this.tabPageEditCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEditCustomers.Name = "tabPageEditCustomers";
            this.tabPageEditCustomers.Size = new System.Drawing.Size(743, 428);
            this.tabPageEditCustomers.TabIndex = 2;
            this.tabPageEditCustomers.Text = "Edit Customers";
            this.tabPageEditCustomers.UseVisualStyleBackColor = true;
            // 
            // lblStatusEdit
            // 
            this.lblStatusEdit.AutoSize = true;
            this.lblStatusEdit.Location = new System.Drawing.Point(313, 347);
            this.lblStatusEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusEdit.Name = "lblStatusEdit";
            this.lblStatusEdit.Size = new System.Drawing.Size(93, 25);
            this.lblStatusEdit.TabIndex = 35;
            this.lblStatusEdit.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Edit Customer Details";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Location = new System.Drawing.Point(0, 380);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(743, 48);
            this.btnEditCustomer.TabIndex = 33;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // txtEditedLastName
            // 
            this.txtEditedLastName.Location = new System.Drawing.Point(319, 130);
            this.txtEditedLastName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEditedLastName.Name = "txtEditedLastName";
            this.txtEditedLastName.Size = new System.Drawing.Size(305, 30);
            this.txtEditedLastName.TabIndex = 32;
            // 
            // txtEditedFirstName
            // 
            this.txtEditedFirstName.Location = new System.Drawing.Point(319, 86);
            this.txtEditedFirstName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEditedFirstName.Name = "txtEditedFirstName";
            this.txtEditedFirstName.Size = new System.Drawing.Size(305, 30);
            this.txtEditedFirstName.TabIndex = 31;
            // 
            // lblLastNameEdited
            // 
            this.lblLastNameEdited.AutoSize = true;
            this.lblLastNameEdited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameEdited.Location = new System.Drawing.Point(132, 138);
            this.lblLastNameEdited.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastNameEdited.Name = "lblLastNameEdited";
            this.lblLastNameEdited.Size = new System.Drawing.Size(117, 25);
            this.lblLastNameEdited.TabIndex = 30;
            this.lblLastNameEdited.Text = "Last Name :";
            // 
            // lblFirstNameEdited
            // 
            this.lblFirstNameEdited.AutoSize = true;
            this.lblFirstNameEdited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameEdited.Location = new System.Drawing.Point(132, 94);
            this.lblFirstNameEdited.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstNameEdited.Name = "lblFirstNameEdited";
            this.lblFirstNameEdited.Size = new System.Drawing.Size(117, 25);
            this.lblFirstNameEdited.TabIndex = 29;
            this.lblFirstNameEdited.Text = "First Name :";
            // 
            // txtEditedZipCode
            // 
            this.txtEditedZipCode.Location = new System.Drawing.Point(319, 309);
            this.txtEditedZipCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEditedZipCode.Name = "txtEditedZipCode";
            this.txtEditedZipCode.Size = new System.Drawing.Size(305, 30);
            this.txtEditedZipCode.TabIndex = 28;
            // 
            // txtEditedProvince
            // 
            this.txtEditedProvince.Location = new System.Drawing.Point(319, 267);
            this.txtEditedProvince.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEditedProvince.Name = "txtEditedProvince";
            this.txtEditedProvince.Size = new System.Drawing.Size(305, 30);
            this.txtEditedProvince.TabIndex = 27;
            // 
            // txtEditedCity
            // 
            this.txtEditedCity.Location = new System.Drawing.Point(319, 223);
            this.txtEditedCity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEditedCity.Name = "txtEditedCity";
            this.txtEditedCity.Size = new System.Drawing.Size(305, 30);
            this.txtEditedCity.TabIndex = 26;
            // 
            // txtEditedStreetName
            // 
            this.txtEditedStreetName.Location = new System.Drawing.Point(319, 178);
            this.txtEditedStreetName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEditedStreetName.Name = "txtEditedStreetName";
            this.txtEditedStreetName.Size = new System.Drawing.Size(305, 30);
            this.txtEditedStreetName.TabIndex = 25;
            // 
            // lblZipCodeEdited
            // 
            this.lblZipCodeEdited.AutoSize = true;
            this.lblZipCodeEdited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCodeEdited.Location = new System.Drawing.Point(155, 316);
            this.lblZipCodeEdited.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblZipCodeEdited.Name = "lblZipCodeEdited";
            this.lblZipCodeEdited.Size = new System.Drawing.Size(98, 25);
            this.lblZipCodeEdited.TabIndex = 24;
            this.lblZipCodeEdited.Text = "ZipCode :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Province :";
            // 
            // lblCityEdited
            // 
            this.lblCityEdited.AutoSize = true;
            this.lblCityEdited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityEdited.Location = new System.Drawing.Point(200, 230);
            this.lblCityEdited.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCityEdited.Name = "lblCityEdited";
            this.lblCityEdited.Size = new System.Drawing.Size(57, 25);
            this.lblCityEdited.TabIndex = 22;
            this.lblCityEdited.Text = "City :";
            // 
            // lblStreetNameEdited
            // 
            this.lblStreetNameEdited.AutoSize = true;
            this.lblStreetNameEdited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNameEdited.Location = new System.Drawing.Point(115, 186);
            this.lblStreetNameEdited.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStreetNameEdited.Name = "lblStreetNameEdited";
            this.lblStreetNameEdited.Size = new System.Drawing.Size(132, 25);
            this.lblStreetNameEdited.TabIndex = 21;
            this.lblStreetNameEdited.Text = "Street Name :";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 466);
            this.Controls.Add(this.tabControlCustomer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customers";
            this.Text = "CustomersForm";
            this.tabControlCustomer.ResumeLayout(false);
            this.tabPageReadCustomers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadCustomers)).EndInit();
            this.tabPageAddCustomers.ResumeLayout(false);
            this.tabPageAddCustomers.PerformLayout();
            this.tabPageEditCustomers.ResumeLayout(false);
            this.tabPageEditCustomers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCustomer;
        private System.Windows.Forms.TabPage tabPageReadCustomers;
        private System.Windows.Forms.TabPage tabPageAddCustomers;
        private System.Windows.Forms.TabPage tabPageEditCustomers;
        private System.Windows.Forms.DataGridView dgvReadCustomers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCustomersInMain;
        private System.Windows.Forms.Button btnDeleteCustomersInMain;
        private System.Windows.Forms.Button btnEditCustomersInMain;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblStatusAdd;
        private System.Windows.Forms.Label lblStatusEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.TextBox txtEditedLastName;
        private System.Windows.Forms.TextBox txtEditedFirstName;
        private System.Windows.Forms.Label lblLastNameEdited;
        private System.Windows.Forms.Label lblFirstNameEdited;
        private System.Windows.Forms.TextBox txtEditedZipCode;
        private System.Windows.Forms.TextBox txtEditedProvince;
        private System.Windows.Forms.TextBox txtEditedCity;
        private System.Windows.Forms.TextBox txtEditedStreetName;
        private System.Windows.Forms.Label lblZipCodeEdited;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCityEdited;
        private System.Windows.Forms.Label lblStreetNameEdited;
        private System.Windows.Forms.Button button1;
    }
}