namespace WindowsFormsApp1.Views
{
    partial class QuanLyFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyFile));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuThưViệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSáchVàoPhânLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThểLoạiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thưViệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinThànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnViews = new System.Windows.Forms.Button();
            this.btnsachvaotheloai = new System.Windows.Forms.Button();
            this.btnAddtheloai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.txtaddtheloai = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstRead = new System.Windows.Forms.ListBox();
            this.lstUnread = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstLoadingFile = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_browser = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1301, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.lưuThưViệnToolStripMenuItem,
            this.thểLoạiToolStripMenuItem,
            this.fileToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.addToolStripMenuItem.Text = "&Add library ";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // lưuThưViệnToolStripMenuItem
            // 
            this.lưuThưViệnToolStripMenuItem.Name = "lưuThưViệnToolStripMenuItem";
            this.lưuThưViệnToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.lưuThưViệnToolStripMenuItem.Text = "&Lưu thư viện";
            this.lưuThưViệnToolStripMenuItem.Click += new System.EventHandler(this.lưuThưViệnToolStripMenuItem_Click);
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmThểLoạiToolStripMenuItem,
            this.thêmSáchVàoPhânLoạiToolStripMenuItem,
            this.xóaThểLoạiToolStripMenuItem1});
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.thểLoạiToolStripMenuItem.Text = "&Thể loại";
            // 
            // thêmThểLoạiToolStripMenuItem
            // 
            this.thêmThểLoạiToolStripMenuItem.Name = "thêmThểLoạiToolStripMenuItem";
            this.thêmThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.thêmThểLoạiToolStripMenuItem.Text = "&Thêm thể loại";
            this.thêmThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thêmThểLoạiToolStripMenuItem_Click);
            // 
            // thêmSáchVàoPhânLoạiToolStripMenuItem
            // 
            this.thêmSáchVàoPhânLoạiToolStripMenuItem.Name = "thêmSáchVàoPhânLoạiToolStripMenuItem";
            this.thêmSáchVàoPhânLoạiToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.thêmSáchVàoPhânLoạiToolStripMenuItem.Text = "&Thêm/ Xóa sách trong thể loại";
            this.thêmSáchVàoPhânLoạiToolStripMenuItem.Click += new System.EventHandler(this.thêmSáchVàoPhânLoạiToolStripMenuItem_Click);
            // 
            // xóaThểLoạiToolStripMenuItem1
            // 
            this.xóaThểLoạiToolStripMenuItem1.Name = "xóaThểLoạiToolStripMenuItem1";
            this.xóaThểLoạiToolStripMenuItem1.Size = new System.Drawing.Size(292, 26);
            this.xóaThểLoạiToolStripMenuItem1.Text = "&Xóa thể loại";
            this.xóaThểLoạiToolStripMenuItem1.Click += new System.EventHandler(this.xóaThểLoạiToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.loadingFileToolStripMenuItem1,
            this.xóaFileToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.addFileToolStripMenuItem.Text = "&Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click_1);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.openFileToolStripMenuItem.Text = "&Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // loadingFileToolStripMenuItem1
            // 
            this.loadingFileToolStripMenuItem1.Name = "loadingFileToolStripMenuItem1";
            this.loadingFileToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.loadingFileToolStripMenuItem1.Text = "&Loading File";
            this.loadingFileToolStripMenuItem1.Click += new System.EventHandler(this.loadingFileToolStripMenuItem1_Click);
            // 
            // xóaFileToolStripMenuItem1
            // 
            this.xóaFileToolStripMenuItem1.Name = "xóaFileToolStripMenuItem1";
            this.xóaFileToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.xóaFileToolStripMenuItem1.Text = "&Xóa File";
            this.xóaFileToolStripMenuItem1.Click += new System.EventHandler(this.xóaFileToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thưViệnToolStripMenuItem,
            this.sáchToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.viewToolStripMenuItem.Text = "&Go";
            // 
            // thưViệnToolStripMenuItem
            // 
            this.thưViệnToolStripMenuItem.Name = "thưViệnToolStripMenuItem";
            this.thưViệnToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.thưViệnToolStripMenuItem.Text = "&Thư viện";
            this.thưViệnToolStripMenuItem.Click += new System.EventHandler(this.thưViệnToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.sáchToolStripMenuItem.Text = "&Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinThànhViênToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.helpToolStripMenuItem.Text = "&Information";
            // 
            // thôngTinThànhViênToolStripMenuItem
            // 
            this.thôngTinThànhViênToolStripMenuItem.Name = "thôngTinThànhViênToolStripMenuItem";
            this.thôngTinThànhViênToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.thôngTinThànhViênToolStripMenuItem.Text = "&Thông tin thành viên";
            this.thôngTinThànhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinThànhViênToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.btnViews);
            this.splitContainer1.Panel1.Controls.Add(this.btnsachvaotheloai);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddtheloai);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveNote);
            this.splitContainer1.Panel1.Controls.Add(this.txtaddtheloai);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtghichu);
            this.splitContainer1.Panel1.Controls.Add(this.lblProgress);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.lstLoadingFile);
            this.splitContainer1.Panel2.Controls.Add(this.axAcroPDF1);
            this.splitContainer1.Size = new System.Drawing.Size(1301, 588);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnViews
            // 
            this.btnViews.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViews.Image = global::WindowsFormsApp1.Properties.Resources._999999999999999;
            this.btnViews.Location = new System.Drawing.Point(3, 113);
            this.btnViews.Name = "btnViews";
            this.btnViews.Size = new System.Drawing.Size(73, 50);
            this.btnViews.TabIndex = 22;
            this.btnViews.UseVisualStyleBackColor = true;
            this.btnViews.Click += new System.EventHandler(this.btnViews_Click);
            // 
            // btnsachvaotheloai
            // 
            this.btnsachvaotheloai.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsachvaotheloai.Location = new System.Drawing.Point(115, 233);
            this.btnsachvaotheloai.Name = "btnsachvaotheloai";
            this.btnsachvaotheloai.Size = new System.Drawing.Size(88, 38);
            this.btnsachvaotheloai.TabIndex = 21;
            this.btnsachvaotheloai.Text = "Add";
            this.btnsachvaotheloai.UseVisualStyleBackColor = true;
            this.btnsachvaotheloai.Click += new System.EventHandler(this.btnsachvaotheloai_Click);
            // 
            // btnAddtheloai
            // 
            this.btnAddtheloai.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtheloai.Location = new System.Drawing.Point(0, 164);
            this.btnAddtheloai.Name = "btnAddtheloai";
            this.btnAddtheloai.Size = new System.Drawing.Size(192, 38);
            this.btnAddtheloai.TabIndex = 20;
            this.btnAddtheloai.Text = "Thêm thể loại:";
            this.btnAddtheloai.UseVisualStyleBackColor = true;
            this.btnAddtheloai.Click += new System.EventHandler(this.btnAddtheloai_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 18F);
            this.label5.Location = new System.Drawing.Point(3, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Thể loại:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._102737165_576374023023527_5484574261998722795_n;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNote.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNote.Location = new System.Drawing.Point(0, 305);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(146, 41);
            this.btnSaveNote.TabIndex = 17;
            this.btnSaveNote.Text = "SaveNote";
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // txtaddtheloai
            // 
            this.txtaddtheloai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaddtheloai.Location = new System.Drawing.Point(0, 203);
            this.txtaddtheloai.Name = "txtaddtheloai";
            this.txtaddtheloai.Size = new System.Drawing.Size(203, 22);
            this.txtaddtheloai.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "khoahoc",
            "vanhoc",
            "toanhoc",
            "tuyentranh"});
            this.comboBox1.Location = new System.Drawing.Point(0, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtghichu
            // 
            this.txtghichu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtghichu.Location = new System.Drawing.Point(3, 347);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(189, 162);
            this.txtghichu.TabIndex = 13;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.Location = new System.Drawing.Point(0, 528);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(203, 22);
            this.lblProgress.TabIndex = 11;
            this.lblProgress.Text = "Trạng thái";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 553);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstRead);
            this.panel1.Controls.Add(this.lstUnread);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(782, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 588);
            this.panel1.TabIndex = 21;
            // 
            // lstRead
            // 
            this.lstRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRead.FormattingEnabled = true;
            this.lstRead.ItemHeight = 16;
            this.lstRead.Location = new System.Drawing.Point(0, 40);
            this.lstRead.Name = "lstRead";
            this.lstRead.Size = new System.Drawing.Size(311, 244);
            this.lstRead.TabIndex = 3;
            // 
            // lstUnread
            // 
            this.lstUnread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUnread.FormattingEnabled = true;
            this.lstUnread.ItemHeight = 16;
            this.lstUnread.Location = new System.Drawing.Point(0, 355);
            this.lstUnread.Name = "lstUnread";
            this.lstUnread.Size = new System.Drawing.Size(311, 260);
            this.lstUnread.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 18F);
            this.label3.Location = new System.Drawing.Point(3, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sách chưa đọc:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 18F);
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sách đã đọc:";
            // 
            // lstLoadingFile
            // 
            this.lstLoadingFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLoadingFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.directory,
            this.size});
            this.lstLoadingFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLoadingFile.HideSelection = false;
            this.lstLoadingFile.LargeImageList = this.imageList1;
            this.lstLoadingFile.Location = new System.Drawing.Point(-8, -7);
            this.lstLoadingFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstLoadingFile.Name = "lstLoadingFile";
            this.lstLoadingFile.Size = new System.Drawing.Size(780, 599);
            this.lstLoadingFile.SmallImageList = this.imageList1;
            this.lstLoadingFile.TabIndex = 2;
            this.lstLoadingFile.UseCompatibleStateImageBehavior = false;
            this.lstLoadingFile.View = System.Windows.Forms.View.Details;
            this.lstLoadingFile.Visible = false;
            this.lstLoadingFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstLoadingFile_MouseClick);
            this.lstLoadingFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstLoadingFile_MouseDoubleClick);
            // 
            // name
            // 
            this.name.Text = "Tên file";
            this.name.Width = 170;
            // 
            // directory
            // 
            this.directory.Text = "Thư mục";
            this.directory.Width = 547;
            // 
            // size
            // 
            this.size.Text = "Kích thước";
            this.size.Width = 100;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "unnamed.png");
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1093, 588);
            this.axAcroPDF1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1185, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Visible = false;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.Enabled = false;
            this.txtFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFolderPath.Location = new System.Drawing.Point(288, 26);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(491, 26);
            this.txtFolderPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(234, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // btn_browser
            // 
            this.btn_browser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browser.Font = new System.Drawing.Font("Mistral", 12F);
            this.btn_browser.Location = new System.Drawing.Point(796, 23);
            this.btn_browser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(103, 28);
            this.btn_browser.TabIndex = 6;
            this.btn_browser.Text = "Browser";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btn_browser_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton7,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1301, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsFormsApp1.Properties.Resources.tạo_file;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Mở File";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsFormsApp1.Properties.Resources.past;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Lưu thư viện";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WindowsFormsApp1.Properties.Resources.tải_xuống;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Loading File";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::WindowsFormsApp1.Properties.Resources.tải_xuống__1_;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "Thư viện";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::WindowsFormsApp1.Properties.Resources.logo_sach_61__6e256;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "Đọc sách";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::WindowsFormsApp1.Properties.Resources.fffffffffffff;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Delete File";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchName.Location = new System.Drawing.Point(1043, 27);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(246, 22);
            this.txtSearchName.TabIndex = 7;
            this.txtSearchName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(938, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search:";
            // 
            // QuanLyFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btn_browser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyFile";
            this.Text = "Chương trình quản lý file";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView lstLoadingFile;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader directory;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ListBox lstUnread;
        private System.Windows.Forms.ListBox lstRead;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtaddtheloai;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddtheloai;
        private System.Windows.Forms.Button btnsachvaotheloai;
        private System.Windows.Forms.Button btnViews;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem lưuThưViệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSáchVàoPhânLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadingFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xóaFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xóaThểLoạiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thưViệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinThànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
    }
}

