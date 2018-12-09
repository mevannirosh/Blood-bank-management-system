namespace Redblood
{
    partial class search
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.donordetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodBankDataSet = new Redblood.BloodBankDataSet();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.donordetailsTableAdapter = new Redblood.BloodBankDataSetTableAdapters.DonordetailsTableAdapter();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtDno2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearchdata = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvDonor = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBloodgrp2 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.donordetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankDataSet)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // donordetailsBindingSource
            // 
            this.donordetailsBindingSource.DataMember = "Donordetails";
            this.donordetailsBindingSource.DataSource = this.bloodBankDataSet;
            // 
            // bloodBankDataSet
            // 
            this.bloodBankDataSet.DataSetName = "BloodBankDataSet";
            this.bloodBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Select!";
            // 
            // donordetailsTableAdapter
            // 
            this.donordetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtDno2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.btnDelete);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.btnSearchdata);
            this.bunifuGradientPanel1.Controls.Add(this.dgvDonor);
            this.bunifuGradientPanel1.Controls.Add(this.cmbBloodgrp2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(3)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(11)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(741, 460);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // txtDno2
            // 
            this.txtDno2.BackColor = System.Drawing.Color.Silver;
            this.txtDno2.BorderColor = System.Drawing.Color.Transparent;
            this.txtDno2.Location = new System.Drawing.Point(341, 102);
            this.txtDno2.Name = "txtDno2";
            this.txtDno2.Size = new System.Drawing.Size(131, 20);
            this.txtDno2.TabIndex = 37;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(235, 102);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(39, 17);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "DNO";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = global::Redblood.Properties.Resources.icons8_Delete_File_64;
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(504, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 34);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 35;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(601, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 126);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // btnSearchdata
            // 
            this.btnSearchdata.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchdata.Image = global::Redblood.Properties.Resources.icons8_Search_Property_64;
            this.btnSearchdata.ImageActive = null;
            this.btnSearchdata.Location = new System.Drawing.Point(504, 20);
            this.btnSearchdata.Name = "btnSearchdata";
            this.btnSearchdata.Size = new System.Drawing.Size(40, 34);
            this.btnSearchdata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchdata.TabIndex = 33;
            this.btnSearchdata.TabStop = false;
            this.btnSearchdata.Zoom = 10;
            this.btnSearchdata.Click += new System.EventHandler(this.btnSearchdata_Click);
            // 
            // dgvDonor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDonor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonor.AutoGenerateColumns = false;
            this.dgvDonor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDonor.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dgvDonor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(11)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNODataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bloodgroupDataGridViewTextBoxColumn,
            this.birthyearDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvDonor.DataSource = this.donordetailsBindingSource;
            this.dgvDonor.DoubleBuffered = true;
            this.dgvDonor.EnableHeadersVisualStyles = false;
            this.dgvDonor.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(11)))), ((int)(((byte)(30)))));
            this.dgvDonor.HeaderForeColor = System.Drawing.Color.LightGray;
            this.dgvDonor.Location = new System.Drawing.Point(2, 164);
            this.dgvDonor.Name = "dgvDonor";
            this.dgvDonor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonor.Size = new System.Drawing.Size(593, 284);
            this.dgvDonor.TabIndex = 32;
            // 
            // dNODataGridViewTextBoxColumn
            // 
            this.dNODataGridViewTextBoxColumn.DataPropertyName = "DNO";
            this.dNODataGridViewTextBoxColumn.HeaderText = "DNO";
            this.dNODataGridViewTextBoxColumn.Name = "dNODataGridViewTextBoxColumn";
            this.dNODataGridViewTextBoxColumn.Width = 60;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 72;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 72;
            // 
            // bloodgroupDataGridViewTextBoxColumn
            // 
            this.bloodgroupDataGridViewTextBoxColumn.DataPropertyName = "Bloodgroup";
            this.bloodgroupDataGridViewTextBoxColumn.HeaderText = "Bloodgroup";
            this.bloodgroupDataGridViewTextBoxColumn.Name = "bloodgroupDataGridViewTextBoxColumn";
            this.bloodgroupDataGridViewTextBoxColumn.Width = 101;
            // 
            // birthyearDataGridViewTextBoxColumn
            // 
            this.birthyearDataGridViewTextBoxColumn.DataPropertyName = "Birthyear";
            this.birthyearDataGridViewTextBoxColumn.HeaderText = "Birthyear";
            this.birthyearDataGridViewTextBoxColumn.Name = "birthyearDataGridViewTextBoxColumn";
            this.birthyearDataGridViewTextBoxColumn.Width = 84;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 79;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 51;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 62;
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "telno";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "telno";
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            this.telnoDataGridViewTextBoxColumn.Width = 63;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 77;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.Width = 86;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 54;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 65;
            // 
            // cmbBloodgrp2
            // 
            this.cmbBloodgrp2.BackColor = System.Drawing.Color.Silver;
            this.cmbBloodgrp2.FormattingEnabled = true;
            this.cmbBloodgrp2.Items.AddRange(new object[] {
            "A RhD positive (A+)",
            "A RhD negative (A-)",
            "B RhD positive (B+)",
            "B RhD negative (B-)",
            "O RhD positive (O+)",
            "O RhD negative (O-)",
            "AB RhD positive (AB+)",
            "AB RhD negative (AB-)"});
            this.cmbBloodgrp2.Location = new System.Drawing.Point(341, 33);
            this.cmbBloodgrp2.Name = "cmbBloodgrp2";
            this.cmbBloodgrp2.Size = new System.Drawing.Size(131, 21);
            this.cmbBloodgrp2.TabIndex = 29;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(235, 36);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 17);
            this.bunifuCustomLabel3.TabIndex = 28;
            this.bunifuCustomLabel3.Text = "Blood Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Redblood.Properties.Resources._7a57578ac5e50962303a92120a57f41a;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 460);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donordetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankDataSet)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBloodgrp2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchdata;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDonor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip2;
        private BloodBankDataSet bloodBankDataSet;
        private System.Windows.Forms.BindingSource donordetailsBindingSource;
        private BloodBankDataSetTableAdapters.DonordetailsTableAdapter donordetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDno2;
    }
}