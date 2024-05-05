namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            button1 = new Button();
            panel1 = new Panel();
            downloadIconOrange = new PictureBox();
            documentIconOrange = new PictureBox();
            quickIconOrange = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            label5 = new Label();
            documentIconWhite = new PictureBox();
            btndocuments = new Button();
            pictureBox4 = new PictureBox();
            downloadIconWhite = new PictureBox();
            quickIconWhite = new PictureBox();
            btnDownloads = new Button();
            btnQuick = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnRename = new Button();
            btnRemove = new Button();
            btnCreate = new Button();
            panel4 = new Panel();
            pictureBox10 = new PictureBox();
            panel5 = new Panel();
            listBox1 = new ListBox();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            imageList2 = new ImageList(components);
            panel10 = new Panel();
            toolTip1 = new ToolTip(components);
            pictureBox11 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel11 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)downloadIconOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentIconOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quickIconOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentIconWhite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downloadIconWhite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quickIconWhite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.SnapToGrid;
            listView1.AllowColumnReorder = true;
            listView1.BackColor = Color.White;
            listView1.BorderStyle = BorderStyle.None;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HoverSelection = true;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(223, 172);
            listView1.Name = "listView1";
            listView1.ShowItemToolTips = true;
            listView1.Size = new Size(957, 603);
            listView1.SmallImageList = imageList1;
            listView1.Sorting = SortOrder.Descending;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.UseWaitCursor = true;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-folder-50.png");
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(219, 178, 23);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1030, 791);
            button1.Name = "button1";
            button1.Size = new Size(131, 37);
            button1.TabIndex = 1;
            button1.Text = "view";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 10, 48);
            panel1.Controls.Add(downloadIconOrange);
            panel1.Controls.Add(documentIconOrange);
            panel1.Controls.Add(quickIconOrange);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(documentIconWhite);
            panel1.Controls.Add(btndocuments);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(downloadIconWhite);
            panel1.Controls.Add(quickIconWhite);
            panel1.Controls.Add(btnDownloads);
            panel1.Controls.Add(btnQuick);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 888);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // downloadIconOrange
            // 
            downloadIconOrange.Image = (Image)resources.GetObject("downloadIconOrange.Image");
            downloadIconOrange.Location = new Point(11, 343);
            downloadIconOrange.Name = "downloadIconOrange";
            downloadIconOrange.Size = new Size(31, 33);
            downloadIconOrange.SizeMode = PictureBoxSizeMode.Zoom;
            downloadIconOrange.TabIndex = 18;
            downloadIconOrange.TabStop = false;
            downloadIconOrange.Visible = false;
            downloadIconOrange.Click += downloadIconOrange_Click;
            // 
            // documentIconOrange
            // 
            documentIconOrange.Image = (Image)resources.GetObject("documentIconOrange.Image");
            documentIconOrange.Location = new Point(12, 403);
            documentIconOrange.Name = "documentIconOrange";
            documentIconOrange.Size = new Size(31, 33);
            documentIconOrange.SizeMode = PictureBoxSizeMode.Zoom;
            documentIconOrange.TabIndex = 17;
            documentIconOrange.TabStop = false;
            documentIconOrange.Visible = false;
            // 
            // quickIconOrange
            // 
            quickIconOrange.Image = (Image)resources.GetObject("quickIconOrange.Image");
            quickIconOrange.Location = new Point(8, 288);
            quickIconOrange.Name = "quickIconOrange";
            quickIconOrange.Size = new Size(33, 35);
            quickIconOrange.SizeMode = PictureBoxSizeMode.Zoom;
            quickIconOrange.TabIndex = 16;
            quickIconOrange.TabStop = false;
            quickIconOrange.Visible = false;
            quickIconOrange.Click += quickIconOrange_Click;
            quickIconOrange.MouseHover += pictureBox9_MouseHover;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(9, 0);
            pictureBox8.Margin = new Padding(4, 5, 4, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            pictureBox8.Visible = false;
            pictureBox8.MouseClick += pictureBox8_MouseClick;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(9, 7);
            pictureBox7.Margin = new Padding(4, 5, 4, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(29, 28);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            pictureBox7.MouseClick += pictureBox7_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tempus Sans ITC", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 50);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 14;
            label5.Text = "File Explorer";
            label5.MouseLeave += label5_MouseLeave;
            label5.MouseHover += label5_MouseHover;
            // 
            // documentIconWhite
            // 
            documentIconWhite.Image = (Image)resources.GetObject("documentIconWhite.Image");
            documentIconWhite.Location = new Point(11, 403);
            documentIconWhite.Name = "documentIconWhite";
            documentIconWhite.Size = new Size(31, 33);
            documentIconWhite.SizeMode = PictureBoxSizeMode.Zoom;
            documentIconWhite.TabIndex = 10;
            documentIconWhite.TabStop = false;
            documentIconWhite.Click += pictureBox6_Click;
            documentIconWhite.MouseHover += pictureBox6_MouseHover;
            // 
            // btndocuments
            // 
            btndocuments.BackColor = Color.FromArgb(5, 10, 48);
            btndocuments.FlatStyle = FlatStyle.Popup;
            btndocuments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndocuments.ForeColor = Color.White;
            btndocuments.Location = new Point(47, 403);
            btndocuments.Name = "btndocuments";
            btndocuments.Size = new Size(153, 33);
            btndocuments.TabIndex = 9;
            btndocuments.Text = "Documents";
            btndocuments.UseVisualStyleBackColor = false;
            btndocuments.Click += btnPictures_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(47, 777);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(77, 72);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            pictureBox4.MouseHover += pictureBox4_MouseHover;
            // 
            // downloadIconWhite
            // 
            downloadIconWhite.Image = (Image)resources.GetObject("downloadIconWhite.Image");
            downloadIconWhite.Location = new Point(11, 343);
            downloadIconWhite.Name = "downloadIconWhite";
            downloadIconWhite.Size = new Size(31, 33);
            downloadIconWhite.SizeMode = PictureBoxSizeMode.Zoom;
            downloadIconWhite.TabIndex = 7;
            downloadIconWhite.TabStop = false;
            downloadIconWhite.Click += pictureBox3_Click;
            downloadIconWhite.MouseClick += pictureBox3_MouseClick;
            downloadIconWhite.MouseHover += pictureBox3_MouseHover;
            // 
            // quickIconWhite
            // 
            quickIconWhite.Image = (Image)resources.GetObject("quickIconWhite.Image");
            quickIconWhite.Location = new Point(8, 288);
            quickIconWhite.Name = "quickIconWhite";
            quickIconWhite.Size = new Size(33, 35);
            quickIconWhite.SizeMode = PictureBoxSizeMode.Zoom;
            quickIconWhite.TabIndex = 6;
            quickIconWhite.TabStop = false;
            quickIconWhite.Click += pictureBox2_Click;
            quickIconWhite.MouseHover += pictureBox2_MouseHover;
            // 
            // btnDownloads
            // 
            btnDownloads.BackColor = Color.FromArgb(5, 10, 48);
            btnDownloads.FlatStyle = FlatStyle.Popup;
            btnDownloads.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDownloads.ForeColor = Color.White;
            btnDownloads.Location = new Point(23, 343);
            btnDownloads.Name = "btnDownloads";
            btnDownloads.Size = new Size(194, 33);
            btnDownloads.TabIndex = 3;
            btnDownloads.Text = "Downloads";
            btnDownloads.UseVisualStyleBackColor = false;
            btnDownloads.Click += button3_Click;
            btnDownloads.MouseHover += button3_MouseHover;
            // 
            // btnQuick
            // 
            btnQuick.BackColor = Color.FromArgb(5, 10, 48);
            btnQuick.FlatStyle = FlatStyle.Popup;
            btnQuick.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuick.ForeColor = Color.White;
            btnQuick.Location = new Point(37, 288);
            btnQuick.Name = "btnQuick";
            btnQuick.Size = new Size(180, 35);
            btnQuick.TabIndex = 0;
            btnQuick.Text = "Quick Access";
            btnQuick.UseVisualStyleBackColor = false;
            btnQuick.Click += button2_Click;
            btnQuick.MouseHover += button2_MouseHover;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Highlight;
            textBox1.Location = new Point(321, 7);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(187, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.MouseLeave += textBox1_MouseLeave;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 178, 23);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(190, 860);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 28);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(btnRename);
            panel3.Controls.Add(btnRemove);
            panel3.Controls.Add(btnCreate);
            panel3.Location = new Point(851, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 102);
            panel3.TabIndex = 6;
            panel3.Visible = false;
            // 
            // btnRename
            // 
            btnRename.BackColor = Color.FromArgb(219, 178, 23);
            btnRename.Dock = DockStyle.Top;
            btnRename.FlatStyle = FlatStyle.Popup;
            btnRename.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRename.Location = new Point(0, 66);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(254, 33);
            btnRename.TabIndex = 2;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(219, 178, 23);
            btnRemove.Dock = DockStyle.Top;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(0, 33);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(254, 33);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += button5_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(219, 178, 23);
            btnCreate.Dock = DockStyle.Top;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.ActiveCaptionText;
            btnCreate.Location = new Point(0, 0);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(254, 33);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(5, 10, 48);
            panel4.Controls.Add(pictureBox10);
            panel4.Location = new Point(197, 83);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 17);
            panel4.TabIndex = 7;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(87, -25);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(37, 32);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 15;
            pictureBox10.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(5, 10, 48);
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(284, 55);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(563, 20);
            panel5.TabIndex = 8;
            panel5.Paint += panel5_Paint;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Cursor = Cursors.Hand;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(284, 38);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(545, 200);
            listBox1.Sorted = true;
            listBox1.TabIndex = 13;
            listBox1.Visible = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(5, 10, 48);
            panel6.Location = new Point(631, 80);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(549, 20);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(5, 10, 48);
            panel7.Location = new Point(197, 55);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(86, 20);
            panel7.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(5, 10, 48);
            panel8.Location = new Point(851, 55);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(329, 20);
            panel8.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(5, 10, 48);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(label3);
            panel9.Controls.Add(label2);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(pictureBox5);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(1214, 0);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(120, 860);
            panel9.TabIndex = 12;
            panel9.Paint += panel9_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 180);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(18, 25);
            label7.TabIndex = 15;
            label7.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(31, 183);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 14;
            label6.Text = "Volt";
            label6.Click += label6_Click;
            label6.MouseLeave += label6_MouseLeave;
            label6.MouseHover += label6_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(18, 25);
            label4.TabIndex = 13;
            label4.Text = ".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(219, 178, 23);
            label3.Location = new Point(9, 753);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 3;
            label3.Text = "change User?";
            label3.Click += label3_Click;
            label3.MouseHover += label3_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "Active ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(219, 178, 23);
            label1.Location = new Point(26, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Mr. Pass";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(31, 23);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "icons8-file-30.png");
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel10.BackColor = Color.FromArgb(219, 178, 23);
            panel10.Location = new Point(1200, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(17, 1473);
            panel10.TabIndex = 14;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 200;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(284, 8);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(37, 32);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 15;
            pictureBox11.TabStop = false;
            pictureBox11.Visible = false;
            pictureBox11.MouseHover += pictureBox11_MouseHover;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 4);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 4);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Linen;
            panel11.Controls.Add(pictureBox3);
            panel11.Controls.Add(pictureBox2);
            panel11.Location = new Point(1108, 8);
            panel11.Name = "panel11";
            panel11.Size = new Size(81, 38);
            panel11.TabIndex = 18;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.Window;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1334, 888);
            Controls.Add(panel11);
            Controls.Add(pictureBox11);
            Controls.Add(panel10);
            Controls.Add(listBox1);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(button1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "Form1";
            Opacity = 0.97D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            MouseDoubleClick += Form1_MouseDoubleClick;
            MouseLeave += Form1_MouseLeave;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)downloadIconOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentIconOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)quickIconOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentIconWhite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)downloadIconWhite).EndInit();
            ((System.ComponentModel.ISupportInitialize)quickIconWhite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel11.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private ImageList imageList1;
        private Panel panel1;
        private Button btnDownloads;
        private Button btnQuick;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox downloadIconWhite;
        private PictureBox quickIconWhite;
        private Panel panel3;
        private Button btnCreate;
        private Button btnRename;
        private Button btnRemove;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private PictureBox pictureBox4;
        private Panel panel9;
        private Label label1;
        private PictureBox pictureBox5;
        private Label label3;
        private Label label2;
        private Label label4;
        private ListBox listBox1;
        private ImageList imageList2;
        private PictureBox documentIconWhite;
        private Button btndocuments;
        private Panel panel10;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private ToolTip toolTip1;
        private PictureBox quickIconOrange;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox documentIconOrange;
        private PictureBox downloadIconOrange;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel11;
    }
}