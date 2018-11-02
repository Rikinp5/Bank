namespace Bank
{
    partial class BranchForm
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
            this.tabControlBranch = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvReadBranches = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.lblStatusAdd = new System.Windows.Forms.Label();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.lblStatusEdit = new System.Windows.Forms.Label();
            this.btnEditBranch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditedZipCode = new System.Windows.Forms.TextBox();
            this.txtEditedProvince = new System.Windows.Forms.TextBox();
            this.txtEditedCity = new System.Windows.Forms.TextBox();
            this.txtEditedStreetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlBranch.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadBranches)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBranch
            // 
            this.tabControlBranch.Controls.Add(this.tabPageMain);
            this.tabControlBranch.Controls.Add(this.tabPageAdd);
            this.tabControlBranch.Controls.Add(this.tabPageEdit);
            this.tabControlBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBranch.Location = new System.Drawing.Point(0, 0);
            this.tabControlBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlBranch.Name = "tabControlBranch";
            this.tabControlBranch.SelectedIndex = 0;
            this.tabControlBranch.Size = new System.Drawing.Size(732, 482);
            this.tabControlBranch.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.label8);
            this.tabPageMain.Controls.Add(this.label7);
            this.tabPageMain.Controls.Add(this.panel1);
            this.tabPageMain.Controls.Add(this.dgvReadBranches);
            this.tabPageMain.Location = new System.Drawing.Point(4, 34);
            this.tabPageMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMain.Size = new System.Drawing.Size(724, 444);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Read Branch";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(717, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "To see the Customers in the  branch, select the branch and click \"Access Branch\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Please select a row for deleting and Accessing";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 100);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Access Branch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(356, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Branch";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(194, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 44);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Branch";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Branch";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvReadBranches
            // 
            this.dgvReadBranches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReadBranches.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReadBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadBranches.Location = new System.Drawing.Point(188, 23);
            this.dgvReadBranches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReadBranches.MultiSelect = false;
            this.dgvReadBranches.Name = "dgvReadBranches";
            this.dgvReadBranches.Size = new System.Drawing.Size(379, 202);
            this.dgvReadBranches.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.lblStatusAdd);
            this.tabPageAdd.Controls.Add(this.btnAddBranch);
            this.tabPageAdd.Controls.Add(this.txtZipCode);
            this.tabPageAdd.Controls.Add(this.txtProvince);
            this.tabPageAdd.Controls.Add(this.txtCity);
            this.tabPageAdd.Controls.Add(this.txtStreetName);
            this.tabPageAdd.Controls.Add(this.lblZipCode);
            this.tabPageAdd.Controls.Add(this.lblProvince);
            this.tabPageAdd.Controls.Add(this.lblCity);
            this.tabPageAdd.Controls.Add(this.lblStreetName);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 34);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAdd.Size = new System.Drawing.Size(724, 444);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add Branch";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // lblStatusAdd
            // 
            this.lblStatusAdd.AutoSize = true;
            this.lblStatusAdd.Location = new System.Drawing.Point(227, 259);
            this.lblStatusAdd.Name = "lblStatusAdd";
            this.lblStatusAdd.Size = new System.Drawing.Size(93, 25);
            this.lblStatusAdd.TabIndex = 10;
            this.lblStatusAdd.Text = "Message";
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBranch.Location = new System.Drawing.Point(4, 391);
            this.btnAddBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(716, 48);
            this.btnAddBranch.TabIndex = 9;
            this.btnAddBranch.Text = "Add Branch";
            this.btnAddBranch.UseVisualStyleBackColor = true;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(284, 219);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(230, 30);
            this.txtZipCode.TabIndex = 8;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(284, 174);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(230, 30);
            this.txtProvince.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(284, 120);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(230, 30);
            this.txtCity.TabIndex = 6;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(284, 62);
            this.txtStreetName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(230, 30);
            this.txtStreetName.TabIndex = 5;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(73, 219);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(98, 25);
            this.lblZipCode.TabIndex = 4;
            this.lblZipCode.Text = "ZipCode :";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(73, 174);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(99, 25);
            this.lblProvince.TabIndex = 3;
            this.lblProvince.Text = "Province :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(107, 120);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 25);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City :";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(43, 68);
            this.lblStreetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(132, 25);
            this.lblStreetName.TabIndex = 1;
            this.lblStreetName.Text = "Street Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Branch Address";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.lblStatusEdit);
            this.tabPageEdit.Controls.Add(this.btnEditBranch);
            this.tabPageEdit.Controls.Add(this.label6);
            this.tabPageEdit.Controls.Add(this.txtEditedZipCode);
            this.tabPageEdit.Controls.Add(this.txtEditedProvince);
            this.tabPageEdit.Controls.Add(this.txtEditedCity);
            this.tabPageEdit.Controls.Add(this.txtEditedStreetName);
            this.tabPageEdit.Controls.Add(this.label2);
            this.tabPageEdit.Controls.Add(this.label3);
            this.tabPageEdit.Controls.Add(this.label4);
            this.tabPageEdit.Controls.Add(this.label5);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 34);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(724, 444);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Edit Branch ";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // lblStatusEdit
            // 
            this.lblStatusEdit.AutoSize = true;
            this.lblStatusEdit.Location = new System.Drawing.Point(278, 308);
            this.lblStatusEdit.Name = "lblStatusEdit";
            this.lblStatusEdit.Size = new System.Drawing.Size(93, 25);
            this.lblStatusEdit.TabIndex = 19;
            this.lblStatusEdit.Text = "Message";
            // 
            // btnEditBranch
            // 
            this.btnEditBranch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBranch.Location = new System.Drawing.Point(0, 396);
            this.btnEditBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditBranch.Name = "btnEditBranch";
            this.btnEditBranch.Size = new System.Drawing.Size(724, 48);
            this.btnEditBranch.TabIndex = 18;
            this.btnEditBranch.Text = "Edit Branch";
            this.btnEditBranch.UseVisualStyleBackColor = true;
            this.btnEditBranch.Click += new System.EventHandler(this.btnEditBranch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Enter New Branch Address";
            // 
            // txtEditedZipCode
            // 
            this.txtEditedZipCode.Location = new System.Drawing.Point(283, 232);
            this.txtEditedZipCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditedZipCode.Name = "txtEditedZipCode";
            this.txtEditedZipCode.Size = new System.Drawing.Size(230, 30);
            this.txtEditedZipCode.TabIndex = 16;
            // 
            // txtEditedProvince
            // 
            this.txtEditedProvince.Location = new System.Drawing.Point(283, 187);
            this.txtEditedProvince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditedProvince.Name = "txtEditedProvince";
            this.txtEditedProvince.Size = new System.Drawing.Size(230, 30);
            this.txtEditedProvince.TabIndex = 15;
            // 
            // txtEditedCity
            // 
            this.txtEditedCity.Location = new System.Drawing.Point(283, 133);
            this.txtEditedCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditedCity.Name = "txtEditedCity";
            this.txtEditedCity.Size = new System.Drawing.Size(230, 30);
            this.txtEditedCity.TabIndex = 14;
            // 
            // txtEditedStreetName
            // 
            this.txtEditedStreetName.Location = new System.Drawing.Point(283, 75);
            this.txtEditedStreetName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditedStreetName.Name = "txtEditedStreetName";
            this.txtEditedStreetName.Size = new System.Drawing.Size(230, 30);
            this.txtEditedStreetName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "ZipCode :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Province :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "City :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Street Name :";
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 482);
            this.Controls.Add(this.tabControlBranch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BranchForm";
            this.Text = "BranchForm";
            this.tabControlBranch.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadBranches)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBranch;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.DataGridView dgvReadBranches;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Button btnEditBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditedZipCode;
        private System.Windows.Forms.TextBox txtEditedProvince;
        private System.Windows.Forms.TextBox txtEditedCity;
        private System.Windows.Forms.TextBox txtEditedStreetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatusAdd;
        private System.Windows.Forms.Label lblStatusEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}