namespace Bank
{
    partial class AccountForm
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
            this.tabControlAccount = new System.Windows.Forms.TabControl();
            this.tabPageReadAccount = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditAccountInMain = new System.Windows.Forms.Button();
            this.btnDeleteAccountInMain = new System.Windows.Forms.Button();
            this.dgvReadSavingsAccounts = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChqAdd = new System.Windows.Forms.Button();
            this.btnAddChq = new System.Windows.Forms.Button();
            this.btnDelChq = new System.Windows.Forms.Button();
            this.dgvReadChequingAccounts = new System.Windows.Forms.DataGridView();
            this.tabPageAddAccount = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatusAdd = new System.Windows.Forms.Label();
            this.btnAddChqAccount = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageEditAccount = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.lblStatusEdit = new System.Windows.Forms.Label();
            this.txtEditedAccountNumber = new System.Windows.Forms.TextBox();
            this.lblEditedAccountNumber = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbChequing = new System.Windows.Forms.RadioButton();
            this.rbSavings = new System.Windows.Forms.RadioButton();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tabControlAccount.SuspendLayout();
            this.tabPageReadAccount.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadSavingsAccounts)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadChequingAccounts)).BeginInit();
            this.tabPageAddAccount.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageEditAccount.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAccount
            // 
            this.tabControlAccount.Controls.Add(this.tabPageReadAccount);
            this.tabControlAccount.Controls.Add(this.tabPageAddAccount);
            this.tabControlAccount.Controls.Add(this.tabPageEditAccount);
            this.tabControlAccount.Controls.Add(this.tabPage5);
            this.tabControlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAccount.Location = new System.Drawing.Point(0, 0);
            this.tabControlAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlAccount.Name = "tabControlAccount";
            this.tabControlAccount.SelectedIndex = 0;
            this.tabControlAccount.Size = new System.Drawing.Size(751, 448);
            this.tabControlAccount.TabIndex = 0;
            // 
            // tabPageReadAccount
            // 
            this.tabPageReadAccount.Controls.Add(this.tabControl2);
            this.tabPageReadAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageReadAccount.Location = new System.Drawing.Point(4, 34);
            this.tabPageReadAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageReadAccount.Name = "tabPageReadAccount";
            this.tabPageReadAccount.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageReadAccount.Size = new System.Drawing.Size(743, 410);
            this.tabPageReadAccount.TabIndex = 0;
            this.tabPageReadAccount.Text = "Read Account";
            this.tabPageReadAccount.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(735, 402);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.dgvReadSavingsAccounts);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(727, 364);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Savings Accounts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditAccountInMain);
            this.panel1.Controls.Add(this.btnDeleteAccountInMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 100);
            this.panel1.TabIndex = 11;
            // 
            // btnEditAccountInMain
            // 
            this.btnEditAccountInMain.Location = new System.Drawing.Point(49, 21);
            this.btnEditAccountInMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAccountInMain.Name = "btnEditAccountInMain";
            this.btnEditAccountInMain.Size = new System.Drawing.Size(200, 46);
            this.btnEditAccountInMain.TabIndex = 7;
            this.btnEditAccountInMain.Text = "Edit Account";
            this.btnEditAccountInMain.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccountInMain
            // 
            this.btnDeleteAccountInMain.Location = new System.Drawing.Point(300, 21);
            this.btnDeleteAccountInMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAccountInMain.Name = "btnDeleteAccountInMain";
            this.btnDeleteAccountInMain.Size = new System.Drawing.Size(196, 46);
            this.btnDeleteAccountInMain.TabIndex = 8;
            this.btnDeleteAccountInMain.Text = "Delete Account";
            this.btnDeleteAccountInMain.UseVisualStyleBackColor = true;
            // 
            // dgvReadSavingsAccounts
            // 
            this.dgvReadSavingsAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadSavingsAccounts.Location = new System.Drawing.Point(174, 58);
            this.dgvReadSavingsAccounts.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvReadSavingsAccounts.Name = "dgvReadSavingsAccounts";
            this.dgvReadSavingsAccounts.Size = new System.Drawing.Size(360, 108);
            this.dgvReadSavingsAccounts.TabIndex = 10;
            this.dgvReadSavingsAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReadSavingsAccounts_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.dgvReadChequingAccounts);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(727, 364);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Chequing Account";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChqAdd);
            this.panel2.Controls.Add(this.btnAddChq);
            this.panel2.Controls.Add(this.btnDelChq);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 100);
            this.panel2.TabIndex = 13;
            // 
            // btnChqAdd
            // 
            this.btnChqAdd.Location = new System.Drawing.Point(242, 21);
            this.btnChqAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnChqAdd.Name = "btnChqAdd";
            this.btnChqAdd.Size = new System.Drawing.Size(200, 46);
            this.btnChqAdd.TabIndex = 7;
            this.btnChqAdd.Text = "Edit Account";
            this.btnChqAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddChq
            // 
            this.btnAddChq.Location = new System.Drawing.Point(18, 21);
            this.btnAddChq.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddChq.Name = "btnAddChq";
            this.btnAddChq.Size = new System.Drawing.Size(200, 46);
            this.btnAddChq.TabIndex = 9;
            this.btnAddChq.Text = "Add Account";
            this.btnAddChq.UseVisualStyleBackColor = true;
            // 
            // btnDelChq
            // 
            this.btnDelChq.Location = new System.Drawing.Point(477, 21);
            this.btnDelChq.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelChq.Name = "btnDelChq";
            this.btnDelChq.Size = new System.Drawing.Size(196, 46);
            this.btnDelChq.TabIndex = 8;
            this.btnDelChq.Text = "Delete Account";
            this.btnDelChq.UseVisualStyleBackColor = true;
            // 
            // dgvReadChequingAccounts
            // 
            this.dgvReadChequingAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadChequingAccounts.Location = new System.Drawing.Point(42, 6);
            this.dgvReadChequingAccounts.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvReadChequingAccounts.Name = "dgvReadChequingAccounts";
            this.dgvReadChequingAccounts.Size = new System.Drawing.Size(442, 217);
            this.dgvReadChequingAccounts.TabIndex = 12;
            // 
            // tabPageAddAccount
            // 
            this.tabPageAddAccount.Controls.Add(this.tabControl1);
            this.tabPageAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddAccount.Location = new System.Drawing.Point(4, 34);
            this.tabPageAddAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAddAccount.Name = "tabPageAddAccount";
            this.tabPageAddAccount.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAddAccount.Size = new System.Drawing.Size(743, 410);
            this.tabPageAddAccount.TabIndex = 1;
            this.tabPageAddAccount.Text = "Add Account";
            this.tabPageAddAccount.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblStatusAdd);
            this.tabPage1.Controls.Add(this.btnAddChqAccount);
            this.tabPage1.Controls.Add(this.txtAccountNumber);
            this.tabPage1.Controls.Add(this.lblAccountNumber);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Savings Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 162);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 30);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Enter Account Number";
            // 
            // lblStatusAdd
            // 
            this.lblStatusAdd.AutoSize = true;
            this.lblStatusAdd.Location = new System.Drawing.Point(291, 252);
            this.lblStatusAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusAdd.Name = "lblStatusAdd";
            this.lblStatusAdd.Size = new System.Drawing.Size(93, 25);
            this.lblStatusAdd.TabIndex = 31;
            this.lblStatusAdd.Text = "Message";
            // 
            // btnAddChqAccount
            // 
            this.btnAddChqAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddChqAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChqAccount.Location = new System.Drawing.Point(3, 313);
            this.btnAddChqAccount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddChqAccount.Name = "btnAddChqAccount";
            this.btnAddChqAccount.Size = new System.Drawing.Size(721, 48);
            this.btnAddChqAccount.TabIndex = 32;
            this.btnAddChqAccount.Text = "Add Account";
            this.btnAddChqAccount.UseVisualStyleBackColor = true;
            this.btnAddChqAccount.Click += new System.EventHandler(this.btnAddAccount_Click_1);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(277, 107);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(305, 30);
            this.txtAccountNumber.TabIndex = 30;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(82, 107);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(169, 25);
            this.lblAccountNumber.TabIndex = 29;
            this.lblAccountNumber.Text = "Account Number :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chequing Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 162);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 30);
            this.textBox2.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Interest Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Enter Account Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Message";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(721, 48);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 107);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(305, 30);
            this.textBox3.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Account Number :";
            // 
            // tabPageEditAccount
            // 
            this.tabPageEditAccount.Controls.Add(this.label4);
            this.tabPageEditAccount.Controls.Add(this.btnEditAccount);
            this.tabPageEditAccount.Controls.Add(this.lblStatusEdit);
            this.tabPageEditAccount.Controls.Add(this.txtEditedAccountNumber);
            this.tabPageEditAccount.Controls.Add(this.lblEditedAccountNumber);
            this.tabPageEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEditAccount.Location = new System.Drawing.Point(4, 34);
            this.tabPageEditAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEditAccount.Name = "tabPageEditAccount";
            this.tabPageEditAccount.Size = new System.Drawing.Size(743, 410);
            this.tabPageEditAccount.TabIndex = 2;
            this.tabPageEditAccount.Text = "Edit Account";
            this.tabPageEditAccount.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter Account Number";
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.Location = new System.Drawing.Point(0, 362);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(743, 48);
            this.btnEditAccount.TabIndex = 25;
            this.btnEditAccount.Text = "Edit Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // lblStatusEdit
            // 
            this.lblStatusEdit.AutoSize = true;
            this.lblStatusEdit.Location = new System.Drawing.Point(285, 241);
            this.lblStatusEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusEdit.Name = "lblStatusEdit";
            this.lblStatusEdit.Size = new System.Drawing.Size(93, 25);
            this.lblStatusEdit.TabIndex = 24;
            this.lblStatusEdit.Text = "Message";
            // 
            // txtEditedAccountNumber
            // 
            this.txtEditedAccountNumber.Location = new System.Drawing.Point(367, 121);
            this.txtEditedAccountNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEditedAccountNumber.Name = "txtEditedAccountNumber";
            this.txtEditedAccountNumber.Size = new System.Drawing.Size(305, 30);
            this.txtEditedAccountNumber.TabIndex = 22;
            // 
            // lblEditedAccountNumber
            // 
            this.lblEditedAccountNumber.AutoSize = true;
            this.lblEditedAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditedAccountNumber.Location = new System.Drawing.Point(113, 128);
            this.lblEditedAccountNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEditedAccountNumber.Name = "lblEditedAccountNumber";
            this.lblEditedAccountNumber.Size = new System.Drawing.Size(169, 25);
            this.lblEditedAccountNumber.TabIndex = 21;
            this.lblEditedAccountNumber.Text = "Account Number :";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.btnDeposit);
            this.tabPage5.Controls.Add(this.btnDebit);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.txtAmount);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(743, 410);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Transactions";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChequing);
            this.groupBox1.Controls.Add(this.rbSavings);
            this.groupBox1.Location = new System.Drawing.Point(500, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbChequing
            // 
            this.rbChequing.AutoSize = true;
            this.rbChequing.Location = new System.Drawing.Point(27, 92);
            this.rbChequing.Name = "rbChequing";
            this.rbChequing.Size = new System.Drawing.Size(195, 29);
            this.rbChequing.TabIndex = 1;
            this.rbChequing.TabStop = true;
            this.rbChequing.Text = "Chequing Account";
            this.rbChequing.UseVisualStyleBackColor = true;
            // 
            // rbSavings
            // 
            this.rbSavings.AutoSize = true;
            this.rbSavings.Location = new System.Drawing.Point(27, 57);
            this.rbSavings.Name = "rbSavings";
            this.rbSavings.Size = new System.Drawing.Size(181, 29);
            this.rbSavings.TabIndex = 0;
            this.rbSavings.TabStop = true;
            this.rbSavings.Text = "Savings Account";
            this.rbSavings.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(323, 223);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(130, 41);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(145, 223);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(130, 41);
            this.btnDebit.TabIndex = 2;
            this.btnDebit.Text = "Debit";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Enter Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(233, 95);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 30);
            this.txtAmount.TabIndex = 0;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 448);
            this.Controls.Add(this.tabControlAccount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountForm";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.tabControlAccount.ResumeLayout(false);
            this.tabPageReadAccount.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadSavingsAccounts)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadChequingAccounts)).EndInit();
            this.tabPageAddAccount.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageEditAccount.ResumeLayout(false);
            this.tabPageEditAccount.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAccount;
        private System.Windows.Forms.TabPage tabPageReadAccount;
        private System.Windows.Forms.TabPage tabPageAddAccount;
        private System.Windows.Forms.TabPage tabPageEditAccount;
        private System.Windows.Forms.TextBox txtEditedAccountNumber;
        private System.Windows.Forms.Label lblEditedAccountNumber;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Label lblStatusEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatusAdd;
        private System.Windows.Forms.Button btnAddChqAccount;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditAccountInMain;
        private System.Windows.Forms.Button btnDeleteAccountInMain;
        private System.Windows.Forms.DataGridView dgvReadSavingsAccounts;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChqAdd;
        private System.Windows.Forms.Button btnAddChq;
        private System.Windows.Forms.Button btnDelChq;
        private System.Windows.Forms.DataGridView dgvReadChequingAccounts;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChequing;
        private System.Windows.Forms.RadioButton rbSavings;
    }
}