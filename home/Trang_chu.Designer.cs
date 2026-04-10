namespace home
{
    partial class Trang_Chu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.LinkLabel linkLogin;

        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.Panel pnlGameToggle;
        private System.Windows.Forms.Panel pnlHero;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblFeaturedHeader;
        private System.Windows.Forms.Label lblLienQuanHeader;
        private System.Windows.Forms.FlowLayoutPanel flpLienQuan;
        private home.UserControls.UcTournamentCard ucLQ1;
        private home.UserControls.UcTournamentCard ucLQ2;
        private home.UserControls.UcTournamentCard ucLQ3;
        private home.UserControls.UcTournamentCard ucLQ4;
        private home.UserControls.UcTournamentCard ucFF1;
        private home.UserControls.UcTournamentCard ucFF2;
        private home.UserControls.UcTournamentCard ucFF3;
        private home.UserControls.UcTournamentCard ucFF4;
        private System.Windows.Forms.Label lblFreeFireHeader;
        private System.Windows.Forms.FlowLayoutPanel flpFreeFire;
        private System.Windows.Forms.Label lblPopularHeader;
        private System.Windows.Forms.FlowLayoutPanel flpPopular;

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
            this.pnlGameToggle = new System.Windows.Forms.Panel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.flpFreeFire = new System.Windows.Forms.FlowLayoutPanel();
            this.ucFF1 = new home.UserControls.UcTournamentCard();
            this.ucFF2 = new home.UserControls.UcTournamentCard();
            this.ucFF3 = new home.UserControls.UcTournamentCard();
            this.ucFF4 = new home.UserControls.UcTournamentCard();
            this.lblFreeFireHeader = new System.Windows.Forms.Label();
            this.flpLienQuan = new System.Windows.Forms.FlowLayoutPanel();
            this.ucLQ1 = new home.UserControls.UcTournamentCard();
            this.ucLQ2 = new home.UserControls.UcTournamentCard();
            this.ucLQ3 = new home.UserControls.UcTournamentCard();
            this.ucLQ4 = new home.UserControls.UcTournamentCard();
            this.lblLienQuanHeader = new System.Windows.Forms.Label();
            this.lblPopularHeader = new System.Windows.Forms.Label();
            this.flpPopular = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHero = new System.Windows.Forms.Panel();
            this.Quan_ly_doi = new System.Windows.Forms.LinkLabel();
            this.Tao_doi = new System.Windows.Forms.LinkLabel();
            this.Tao_giai_dau = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            this.flpFreeFire.SuspendLayout();
            this.flpLienQuan.SuspendLayout();
            this.pnlHero.SuspendLayout();
            this.pnlNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameToggle
            // 
            this.pnlGameToggle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGameToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGameToggle.Location = new System.Drawing.Point(0, 0);
            this.pnlGameToggle.Name = "pnlGameToggle";
            this.pnlGameToggle.Size = new System.Drawing.Size(1200, 60);
            this.pnlGameToggle.TabIndex = 4;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.flpFreeFire);
            this.pnlMainContent.Controls.Add(this.lblFreeFireHeader);
            this.pnlMainContent.Controls.Add(this.flpLienQuan);
            this.pnlMainContent.Controls.Add(this.lblLienQuanHeader);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 459);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1699, 772);
            this.pnlMainContent.TabIndex = 0;
            // 
            // flpFreeFire
            // 
            this.flpFreeFire.AutoScroll = true;
            this.flpFreeFire.Controls.Add(this.ucFF1);
            this.flpFreeFire.Controls.Add(this.ucFF2);
            this.flpFreeFire.Controls.Add(this.ucFF3);
            this.flpFreeFire.Controls.Add(this.ucFF4);
            this.flpFreeFire.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpFreeFire.Location = new System.Drawing.Point(0, 424);
            this.flpFreeFire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpFreeFire.Name = "flpFreeFire";
            this.flpFreeFire.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.flpFreeFire.Size = new System.Drawing.Size(1699, 308);
            this.flpFreeFire.TabIndex = 4;
            this.flpFreeFire.WrapContents = false;
            // 
            // ucFF1
            // 
            this.ucFF1.BackColor = System.Drawing.Color.White;
            this.ucFF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucFF1.Location = new System.Drawing.Point(45, 30);
            this.ucFF1.Margin = new System.Windows.Forms.Padding(15);
            this.ucFF1.Name = "ucFF1";
            this.ucFF1.Size = new System.Drawing.Size(374, 307);
            this.ucFF1.TabIndex = 4;
            // 
            // ucFF2
            // 
            this.ucFF2.BackColor = System.Drawing.Color.White;
            this.ucFF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucFF2.Location = new System.Drawing.Point(449, 30);
            this.ucFF2.Margin = new System.Windows.Forms.Padding(15);
            this.ucFF2.Name = "ucFF2";
            this.ucFF2.Size = new System.Drawing.Size(374, 307);
            this.ucFF2.TabIndex = 5;
            // 
            // ucFF3
            // 
            this.ucFF3.BackColor = System.Drawing.Color.White;
            this.ucFF3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucFF3.Location = new System.Drawing.Point(853, 30);
            this.ucFF3.Margin = new System.Windows.Forms.Padding(15);
            this.ucFF3.Name = "ucFF3";
            this.ucFF3.Size = new System.Drawing.Size(374, 307);
            this.ucFF3.TabIndex = 6;
            // 
            // ucFF4
            // 
            this.ucFF4.BackColor = System.Drawing.Color.White;
            this.ucFF4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucFF4.Location = new System.Drawing.Point(1257, 30);
            this.ucFF4.Margin = new System.Windows.Forms.Padding(15);
            this.ucFF4.Name = "ucFF4";
            this.ucFF4.Size = new System.Drawing.Size(374, 307);
            this.ucFF4.TabIndex = 7;
            // 
            // lblFreeFireHeader
            // 
            this.lblFreeFireHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFreeFireHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFreeFireHeader.Location = new System.Drawing.Point(0, 381);
            this.lblFreeFireHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFreeFireHeader.Name = "lblFreeFireHeader";
            this.lblFreeFireHeader.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblFreeFireHeader.Size = new System.Drawing.Size(1699, 43);
            this.lblFreeFireHeader.TabIndex = 3;
            this.lblFreeFireHeader.Text = "FREE FIRE";
            this.lblFreeFireHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpLienQuan
            // 
            this.flpLienQuan.AutoScroll = true;
            this.flpLienQuan.Controls.Add(this.ucLQ1);
            this.flpLienQuan.Controls.Add(this.ucLQ2);
            this.flpLienQuan.Controls.Add(this.ucLQ3);
            this.flpLienQuan.Controls.Add(this.ucLQ4);
            this.flpLienQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpLienQuan.Location = new System.Drawing.Point(0, 43);
            this.flpLienQuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpLienQuan.Name = "flpLienQuan";
            this.flpLienQuan.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.flpLienQuan.Size = new System.Drawing.Size(1699, 338);
            this.flpLienQuan.TabIndex = 2;
            this.flpLienQuan.WrapContents = false;
            // 
            // ucLQ1
            // 
            this.ucLQ1.BackColor = System.Drawing.Color.White;
            this.ucLQ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucLQ1.Location = new System.Drawing.Point(45, 30);
            this.ucLQ1.Margin = new System.Windows.Forms.Padding(15);
            this.ucLQ1.Name = "ucLQ1";
            this.ucLQ1.Size = new System.Drawing.Size(374, 657);
            this.ucLQ1.TabIndex = 0;
            this.ucLQ1.Load += new System.EventHandler(this.ucLQ1_Load);
            // 
            // ucLQ2
            // 
            this.ucLQ2.BackColor = System.Drawing.Color.White;
            this.ucLQ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucLQ2.Location = new System.Drawing.Point(449, 30);
            this.ucLQ2.Margin = new System.Windows.Forms.Padding(15);
            this.ucLQ2.Name = "ucLQ2";
            this.ucLQ2.Size = new System.Drawing.Size(374, 657);
            this.ucLQ2.TabIndex = 1;
            // 
            // ucLQ3
            // 
            this.ucLQ3.BackColor = System.Drawing.Color.White;
            this.ucLQ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucLQ3.Location = new System.Drawing.Point(853, 30);
            this.ucLQ3.Margin = new System.Windows.Forms.Padding(15);
            this.ucLQ3.Name = "ucLQ3";
            this.ucLQ3.Size = new System.Drawing.Size(374, 657);
            this.ucLQ3.TabIndex = 2;
            // 
            // ucLQ4
            // 
            this.ucLQ4.BackColor = System.Drawing.Color.White;
            this.ucLQ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucLQ4.Location = new System.Drawing.Point(1257, 30);
            this.ucLQ4.Margin = new System.Windows.Forms.Padding(15);
            this.ucLQ4.Name = "ucLQ4";
            this.ucLQ4.Size = new System.Drawing.Size(374, 657);
            this.ucLQ4.TabIndex = 3;
            // 
            // lblLienQuanHeader
            // 
            this.lblLienQuanHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLienQuanHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLienQuanHeader.Location = new System.Drawing.Point(0, 0);
            this.lblLienQuanHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLienQuanHeader.Name = "lblLienQuanHeader";
            this.lblLienQuanHeader.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblLienQuanHeader.Size = new System.Drawing.Size(1699, 43);
            this.lblLienQuanHeader.TabIndex = 1;
            this.lblLienQuanHeader.Text = "LIÊN QUÂN";
            this.lblLienQuanHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPopularHeader
            // 
            this.lblPopularHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPopularHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPopularHeader.Location = new System.Drawing.Point(0, 526);
            this.lblPopularHeader.Name = "lblPopularHeader";
            this.lblPopularHeader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblPopularHeader.Size = new System.Drawing.Size(1200, 28);
            this.lblPopularHeader.TabIndex = 5;
            this.lblPopularHeader.Text = "GIẢI NHIỀU NGƯỜI XEM";
            this.lblPopularHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpPopular
            // 
            this.flpPopular.AutoScroll = true;
            this.flpPopular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPopular.Location = new System.Drawing.Point(0, 554);
            this.flpPopular.Name = "flpPopular";
            this.flpPopular.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.flpPopular.Size = new System.Drawing.Size(1200, 0);
            this.flpPopular.TabIndex = 6;
            // 
            // pnlHero
            // 
            this.pnlHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlHero.BackgroundImage = global::home.Properties.Resources.Screenshot_2026_04_02_113334;
            this.pnlHero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHero.Controls.Add(this.Quan_ly_doi);
            this.pnlHero.Controls.Add(this.Tao_doi);
            this.pnlHero.Controls.Add(this.Tao_giai_dau);
            this.pnlHero.Controls.Add(this.lblTitle);
            this.pnlHero.Controls.Add(this.txtSearch);
            this.pnlHero.Controls.Add(this.btnSearch);
            this.pnlHero.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHero.Location = new System.Drawing.Point(0, 88);
            this.pnlHero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHero.Name = "pnlHero";
            this.pnlHero.Size = new System.Drawing.Size(1699, 371);
            this.pnlHero.TabIndex = 1;
            this.pnlHero.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHero_Paint);
            // 
            // Quan_ly_doi
            // 
            this.Quan_ly_doi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quan_ly_doi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quan_ly_doi.Location = new System.Drawing.Point(995, 242);
            this.Quan_ly_doi.Name = "Quan_ly_doi";
            this.Quan_ly_doi.Size = new System.Drawing.Size(131, 52);
            this.Quan_ly_doi.TabIndex = 5;
            this.Quan_ly_doi.TabStop = true;
            this.Quan_ly_doi.Text = "Quản lý đội";
            this.Quan_ly_doi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Quan_ly_doi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quan_ly_doi_LinkClicked);
            // 
            // Tao_doi
            // 
            this.Tao_doi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tao_doi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tao_doi.Location = new System.Drawing.Point(777, 242);
            this.Tao_doi.Name = "Tao_doi";
            this.Tao_doi.Size = new System.Drawing.Size(136, 52);
            this.Tao_doi.TabIndex = 4;
            this.Tao_doi.TabStop = true;
            this.Tao_doi.Text = "Tạo đội";
            this.Tao_doi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tao_doi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Tao_doi_LinkClicked);
            // 
            // Tao_giai_dau
            // 
            this.Tao_giai_dau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tao_giai_dau.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tao_giai_dau.Location = new System.Drawing.Point(552, 242);
            this.Tao_giai_dau.Name = "Tao_giai_dau";
            this.Tao_giai_dau.Size = new System.Drawing.Size(143, 52);
            this.Tao_giai_dau.TabIndex = 3;
            this.Tao_giai_dau.TabStop = true;
            this.Tao_giai_dau.Text = "Tạo giải đấu";
            this.Tao_giai_dau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Ivory;
            this.lblTitle.Location = new System.Drawing.Point(386, 85);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(897, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ GIẢI ĐẤU CHUYÊN NGHIỆP";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(326, 162);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(898, 36);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1242, 156);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlNavBar.BackgroundImage = global::home.Properties.Resources.background_xanh_1;
            this.pnlNavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNavBar.Controls.Add(this.linkRegister);
            this.pnlNavBar.Controls.Add(this.button6);
            this.pnlNavBar.Controls.Add(this.button5);
            this.pnlNavBar.Controls.Add(this.button4);
            this.pnlNavBar.Controls.Add(this.button3);
            this.pnlNavBar.Controls.Add(this.button2);
            this.pnlNavBar.Controls.Add(this.button1);
            this.pnlNavBar.Controls.Add(this.linkLogin);
            this.pnlNavBar.Controls.Add(this.btnHome);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(1699, 88);
            this.pnlNavBar.TabIndex = 2;
            this.pnlNavBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNavBar_Paint);
            // 
            // linkRegister
            // 
            this.linkRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRegister.BackColor = System.Drawing.Color.Transparent;
            this.linkRegister.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.ForeColor = System.Drawing.Color.White;
            this.linkRegister.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkRegister.Location = new System.Drawing.Point(1563, 26);
            this.linkRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(118, 43);
            this.linkRegister.TabIndex = 11;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "ĐĂNG KÝ";
            this.linkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1179, 2);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 88);
            this.button6.TabIndex = 10;
            this.button6.Text = "BẢNG TIN";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(982, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 88);
            this.button5.TabIndex = 9;
            this.button5.Text = "HƯỚNG DẪN";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(808, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 88);
            this.button4.TabIndex = 8;
            this.button4.Text = "THEO DÕI";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(648, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 88);
            this.button3.TabIndex = 7;
            this.button3.Text = "ĐẤU TẬP";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(450, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 88);
            this.button2.TabIndex = 6;
            this.button2.Text = "ĐỘI THI ĐẤU";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(282, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 88);
            this.button1.TabIndex = 5;
            this.button1.Text = "GIẢI ĐẤU";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // linkLogin
            // 
            this.linkLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.ForeColor = System.Drawing.Color.White;
            this.linkLogin.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLogin.Location = new System.Drawing.Point(1397, 25);
            this.linkLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(162, 43);
            this.linkLogin.TabIndex = 1;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "ĐĂNG NHẬP";
            this.linkLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(86, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(204, 88);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "TRANG CHỦ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Trang_Chu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1699, 1231);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlHero);
            this.Controls.Add(this.pnlNavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Trang_Chu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMainContent.ResumeLayout(false);
            this.flpFreeFire.ResumeLayout(false);
            this.flpLienQuan.ResumeLayout(false);
            this.pnlHero.ResumeLayout(false);
            this.pnlHero.PerformLayout();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.LinkLabel Tao_giai_dau;
        private System.Windows.Forms.LinkLabel Quan_ly_doi;
        private System.Windows.Forms.LinkLabel Tao_doi;
    }
}

