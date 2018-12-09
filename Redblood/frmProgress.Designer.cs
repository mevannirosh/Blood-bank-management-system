namespace Redblood
{
    partial class frmProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgress));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bloodBankDataSet = new Redblood.BloodBankDataSet();
            this.bloodBankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donordetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donordetailsTableAdapter = new Redblood.BloodBankDataSetTableAdapters.DonordetailsTableAdapter();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar5 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar6 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donordetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCircleProgressbar6);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCircleProgressbar5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCircleProgressbar4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCircleProgressbar3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCircleProgressbar2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCircleProgressbar1);
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
            // bloodBankDataSet
            // 
            this.bloodBankDataSet.DataSetName = "BloodBankDataSet";
            this.bloodBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodBankDataSetBindingSource
            // 
            this.bloodBankDataSetBindingSource.DataSource = this.bloodBankDataSet;
            this.bloodBankDataSetBindingSource.Position = 0;
            // 
            // donordetailsBindingSource
            // 
            this.donordetailsBindingSource.DataMember = "Donordetails";
            this.donordetailsBindingSource.DataSource = this.bloodBankDataSetBindingSource;
            // 
            // donordetailsTableAdapter
            // 
            this.donordetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Turquoise;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 5;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(18, 75);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Silver;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(156, 156);
            this.bunifuCircleProgressbar1.TabIndex = 0;
            this.bunifuCircleProgressbar1.Value = 40;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(46, 239);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(119, 13);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "A RhD positive (A+)";
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = false;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 300;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.Turquoise;
            this.bunifuCircleProgressbar2.LabelVisible = true;
            this.bunifuCircleProgressbar2.LineProgressThickness = 5;
            this.bunifuCircleProgressbar2.LineThickness = 5;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(280, 70);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Silver;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(156, 156);
            this.bunifuCircleProgressbar2.TabIndex = 0;
            this.bunifuCircleProgressbar2.Value = 10;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(314, 240);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 13);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "A RhD negative (A-)";
            // 
            // bunifuCircleProgressbar3
            // 
            this.bunifuCircleProgressbar3.animated = false;
            this.bunifuCircleProgressbar3.animationIterval = 5;
            this.bunifuCircleProgressbar3.animationSpeed = 300;
            this.bunifuCircleProgressbar3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar3.BackgroundImage")));
            this.bunifuCircleProgressbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar3.ForeColor = System.Drawing.Color.Turquoise;
            this.bunifuCircleProgressbar3.LabelVisible = true;
            this.bunifuCircleProgressbar3.LineProgressThickness = 5;
            this.bunifuCircleProgressbar3.LineThickness = 5;
            this.bunifuCircleProgressbar3.Location = new System.Drawing.Point(543, 70);
            this.bunifuCircleProgressbar3.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.bunifuCircleProgressbar3.MaxValue = 100;
            this.bunifuCircleProgressbar3.Name = "bunifuCircleProgressbar3";
            this.bunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.Silver;
            this.bunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar3.Size = new System.Drawing.Size(156, 156);
            this.bunifuCircleProgressbar3.TabIndex = 0;
            this.bunifuCircleProgressbar3.Value = 56;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(580, 240);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(119, 13);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "B RhD positive (B+)";
            // 
            // bunifuCircleProgressbar4
            // 
            this.bunifuCircleProgressbar4.animated = false;
            this.bunifuCircleProgressbar4.animationIterval = 5;
            this.bunifuCircleProgressbar4.animationSpeed = 300;
            this.bunifuCircleProgressbar4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar4.BackgroundImage")));
            this.bunifuCircleProgressbar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar4.ForeColor = System.Drawing.Color.Turquoise;
            this.bunifuCircleProgressbar4.LabelVisible = true;
            this.bunifuCircleProgressbar4.LineProgressThickness = 5;
            this.bunifuCircleProgressbar4.LineThickness = 5;
            this.bunifuCircleProgressbar4.Location = new System.Drawing.Point(543, 276);
            this.bunifuCircleProgressbar4.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.bunifuCircleProgressbar4.MaxValue = 100;
            this.bunifuCircleProgressbar4.Name = "bunifuCircleProgressbar4";
            this.bunifuCircleProgressbar4.ProgressBackColor = System.Drawing.Color.Silver;
            this.bunifuCircleProgressbar4.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar4.Size = new System.Drawing.Size(156, 156);
            this.bunifuCircleProgressbar4.TabIndex = 0;
            this.bunifuCircleProgressbar4.Value = 28;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(580, 441);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(135, 13);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "AB RhD positive (AB+)";
            // 
            // bunifuCircleProgressbar5
            // 
            this.bunifuCircleProgressbar5.animated = false;
            this.bunifuCircleProgressbar5.animationIterval = 5;
            this.bunifuCircleProgressbar5.animationSpeed = 300;
            this.bunifuCircleProgressbar5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar5.BackgroundImage")));
            this.bunifuCircleProgressbar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar5.ForeColor = System.Drawing.Color.Turquoise;
            this.bunifuCircleProgressbar5.LabelVisible = true;
            this.bunifuCircleProgressbar5.LineProgressThickness = 5;
            this.bunifuCircleProgressbar5.LineThickness = 5;
            this.bunifuCircleProgressbar5.Location = new System.Drawing.Point(18, 276);
            this.bunifuCircleProgressbar5.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.bunifuCircleProgressbar5.MaxValue = 100;
            this.bunifuCircleProgressbar5.Name = "bunifuCircleProgressbar5";
            this.bunifuCircleProgressbar5.ProgressBackColor = System.Drawing.Color.Silver;
            this.bunifuCircleProgressbar5.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar5.Size = new System.Drawing.Size(156, 156);
            this.bunifuCircleProgressbar5.TabIndex = 0;
            this.bunifuCircleProgressbar5.Value = 80;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(46, 440);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(121, 13);
            this.bunifuCustomLabel5.TabIndex = 2;
            this.bunifuCustomLabel5.Text = "O RhD positive (O+)";
            // 
            // bunifuCircleProgressbar6
            // 
            this.bunifuCircleProgressbar6.animated = false;
            this.bunifuCircleProgressbar6.animationIterval = 5;
            this.bunifuCircleProgressbar6.animationSpeed = 300;
            this.bunifuCircleProgressbar6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar6.BackgroundImage")));
            this.bunifuCircleProgressbar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar6.ForeColor = System.Drawing.Color.Turquoise;
            this.bunifuCircleProgressbar6.LabelVisible = true;
            this.bunifuCircleProgressbar6.LineProgressThickness = 5;
            this.bunifuCircleProgressbar6.LineThickness = 5;
            this.bunifuCircleProgressbar6.Location = new System.Drawing.Point(280, 277);
            this.bunifuCircleProgressbar6.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.bunifuCircleProgressbar6.MaxValue = 100;
            this.bunifuCircleProgressbar6.Name = "bunifuCircleProgressbar6";
            this.bunifuCircleProgressbar6.ProgressBackColor = System.Drawing.Color.Silver;
            this.bunifuCircleProgressbar6.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar6.Size = new System.Drawing.Size(156, 156);
            this.bunifuCircleProgressbar6.TabIndex = 0;
            this.bunifuCircleProgressbar6.Value = 69;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(314, 441);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(123, 13);
            this.bunifuCustomLabel6.TabIndex = 2;
            this.bunifuCustomLabel6.Text = "O RhD negative (O-)";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(12, 22);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(226, 33);
            this.bunifuCustomLabel7.TabIndex = 3;
            this.bunifuCustomLabel7.Text = "Status of Blood Types";
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 460);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgress";
            this.Text = "frmProgress";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donordetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.BindingSource bloodBankDataSetBindingSource;
        private BloodBankDataSet bloodBankDataSet;
        private System.Windows.Forms.BindingSource donordetailsBindingSource;
        private BloodBankDataSetTableAdapters.DonordetailsTableAdapter donordetailsTableAdapter;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar6;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}