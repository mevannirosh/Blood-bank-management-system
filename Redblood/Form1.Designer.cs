namespace Redblood
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlSliding = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnSandwich = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStatus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSliding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSandwich)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelTransition2
            // 
            this.PanelTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.PanelTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.PanelTransition2.DefaultAnimation = animation2;
            // 
            // pnlMain
            // 
            this.LogoTransition.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(50, 29);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(741, 460);
            this.pnlMain.TabIndex = 5;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.LogoTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.LogoTransition.DefaultAnimation = animation1;
            // 
            // pnlSliding
            // 
            this.pnlSliding.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSliding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSliding.BackgroundImage")));
            this.pnlSliding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSliding.Controls.Add(this.Logo);
            this.pnlSliding.Controls.Add(this.btnSandwich);
            this.pnlSliding.Controls.Add(this.btnStatus);
            this.pnlSliding.Controls.Add(this.btnSearch);
            this.pnlSliding.Controls.Add(this.btnRegister);
            this.pnlSliding.Controls.Add(this.btnHome);
            this.LogoTransition.SetDecoration(this.pnlSliding, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.pnlSliding, BunifuAnimatorNS.DecorationType.None);
            this.pnlSliding.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSliding.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlSliding.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlSliding.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.pnlSliding.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnlSliding.Location = new System.Drawing.Point(0, 29);
            this.pnlSliding.Name = "pnlSliding";
            this.pnlSliding.Quality = 10;
            this.pnlSliding.Size = new System.Drawing.Size(50, 460);
            this.pnlSliding.TabIndex = 0;
            // 
            // Logo
            // 
            this.PanelTransition2.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::Redblood.Properties.Resources.ghf;
            this.Logo.Location = new System.Drawing.Point(68, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(58, 48);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // btnSandwich
            // 
            this.btnSandwich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.LogoTransition.SetDecoration(this.btnSandwich, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.btnSandwich, BunifuAnimatorNS.DecorationType.None);
            this.btnSandwich.Image = global::Redblood.Properties.Resources.menu_alt_512;
            this.btnSandwich.ImageActive = null;
            this.btnSandwich.Location = new System.Drawing.Point(9, 3);
            this.btnSandwich.Name = "btnSandwich";
            this.btnSandwich.Size = new System.Drawing.Size(31, 27);
            this.btnSandwich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSandwich.TabIndex = 2;
            this.btnSandwich.TabStop = false;
            this.btnSandwich.Zoom = 10;
            this.btnSandwich.Click += new System.EventHandler(this.btnSandwich_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatus.BorderRadius = 0;
            this.btnStatus.ButtonText = "          Blood Bank Status";
            this.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnStatus, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.btnStatus, BunifuAnimatorNS.DecorationType.None);
            this.btnStatus.DisabledColor = System.Drawing.Color.Gray;
            this.btnStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.btnStatus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStatus.Iconimage = global::Redblood.Properties.Resources.icons8_Unknown_Status_64;
            this.btnStatus.Iconimage_right = null;
            this.btnStatus.Iconimage_right_Selected = null;
            this.btnStatus.Iconimage_Selected = null;
            this.btnStatus.IconMarginLeft = 0;
            this.btnStatus.IconMarginRight = 0;
            this.btnStatus.IconRightVisible = true;
            this.btnStatus.IconRightZoom = 0D;
            this.btnStatus.IconVisible = true;
            this.btnStatus.IconZoom = 60D;
            this.btnStatus.IsTab = true;
            this.btnStatus.Location = new System.Drawing.Point(0, 363);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStatus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnStatus.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnStatus.selected = false;
            this.btnStatus.Size = new System.Drawing.Size(208, 38);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "          Blood Bank Status";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Textcolor = System.Drawing.Color.White;
            this.btnStatus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "           Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = global::Redblood.Properties.Resources.icons8_Detective_64;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 60D;
            this.btnSearch.IsTab = true;
            this.btnSearch.Location = new System.Drawing.Point(0, 272);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(208, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "           Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.BorderRadius = 0;
            this.btnRegister.ButtonText = "           Register";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnRegister, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.btnRegister, BunifuAnimatorNS.DecorationType.None);
            this.btnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.btnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegister.Iconimage = global::Redblood.Properties.Resources.icons8_Add_User_Male_64;
            this.btnRegister.Iconimage_right = null;
            this.btnRegister.Iconimage_right_Selected = null;
            this.btnRegister.Iconimage_Selected = null;
            this.btnRegister.IconMarginLeft = 0;
            this.btnRegister.IconMarginRight = 0;
            this.btnRegister.IconRightVisible = true;
            this.btnRegister.IconRightZoom = 0D;
            this.btnRegister.IconVisible = true;
            this.btnRegister.IconZoom = 60D;
            this.btnRegister.IsTab = true;
            this.btnRegister.Location = new System.Drawing.Point(0, 178);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.selected = false;
            this.btnRegister.Size = new System.Drawing.Size(208, 38);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "           Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Textcolor = System.Drawing.Color.White;
            this.btnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "             Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = global::Redblood.Properties.Resources.icons8_Roofing_64;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 60D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 92);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(208, 38);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "             Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Header
            // 
            this.Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header.BackgroundImage")));
            this.Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header.Controls.Add(this.bunifuCustomLabel1);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.bunifuImageButton2);
            this.Header.Controls.Add(this.bunifuImageButton3);
            this.LogoTransition.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.Header.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(8)))));
            this.Header.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Header.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Quality = 10;
            this.Header.Size = new System.Drawing.Size(791, 29);
            this.Header.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition2.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(230, -1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(230, 28);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Blood Bank Management";
            // 
            // pictureBox1
            // 
            this.PanelTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Redblood.Properties.Resources._38378519_donate_blood_design_on_red_background_clean_vector;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.LogoTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::Redblood.Properties.Resources.icons8_Cancel_64;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(759, 1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(31, 27);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.LogoTransition.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition2.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = global::Redblood.Properties.Resources.icons8_Minimize_Window_64;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(728, 1);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(31, 27);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 489);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSliding);
            this.Controls.Add(this.Header);
            this.PanelTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSliding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSandwich)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuImageButton btnSandwich;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSliding;
        private Bunifu.Framework.UI.BunifuGradientPanel Header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegister;
        private BunifuAnimatorNS.BunifuTransition PanelTransition2;
        private System.Windows.Forms.PictureBox Logo;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private System.Windows.Forms.Panel pnlMain;
    }
}

