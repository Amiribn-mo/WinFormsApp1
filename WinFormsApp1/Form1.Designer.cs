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
            label5 = new Label();
            pictureBox6 = new PictureBox();
            btnPictures = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            listBox1 = new ListBox();
            imageList2 = new ImageList(components);
            panel10 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.BorderStyle = BorderStyle.None;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(135, 103);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(691, 352);
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
            button1.Location = new Point(135, 470);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(92, 22);
            button1.TabIndex = 1;
            button1.Text = "view";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 10, 48);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(btnPictures);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 546);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tempus Sans ITC", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 16);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 14;
            label5.Text = "File Explorer";
            label5.MouseLeave += label5_MouseLeave;
            label5.MouseHover += label5_MouseHover;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(4, 242);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // btnPictures
            // 
            btnPictures.BackColor = Color.FromArgb(5, 10, 48);
            btnPictures.FlatStyle = FlatStyle.Popup;
            btnPictures.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPictures.ForeColor = Color.White;
            btnPictures.Location = new Point(6, 242);
            btnPictures.Margin = new Padding(2);
            btnPictures.Name = "btnPictures";
            btnPictures.Size = new Size(125, 20);
            btnPictures.TabIndex = 9;
            btnPictures.Text = "Documents";
            btnPictures.UseVisualStyleBackColor = false;
            btnPictures.Click += btnPictures_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(35, 464);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseHover += pictureBox4_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 206);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 173);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(5, 10, 48);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(6, 206);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(125, 20);
            button3.TabIndex = 3;
            button3.Text = "Downloads";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseHover += button3_MouseHover;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(5, 10, 48);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(16, 173);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(113, 21);
            button2.TabIndex = 0;
            button2.Text = "Quick Access";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseHover += button2_MouseHover;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuText;
            textBox1.Location = new Point(225, 5);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(132, 20);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.MouseLeave += textBox1_MouseLeave;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 5);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 178, 23);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(127, 529);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 17);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(596, 103);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 61);
            panel3.TabIndex = 6;
            panel3.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(219, 178, 23);
            button6.Dock = DockStyle.Top;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(0, 40);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(178, 20);
            button6.TabIndex = 2;
            button6.Text = "Rename";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(219, 178, 23);
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(0, 20);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(178, 20);
            button5.TabIndex = 1;
            button5.Text = "Remove";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(219, 178, 23);
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(178, 20);
            button4.TabIndex = 0;
            button4.Text = "Create";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(5, 10, 48);
            panel4.Location = new Point(133, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(303, 10);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(5, 10, 48);
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(199, 33);
            panel5.Name = "panel5";
            panel5.Size = new Size(394, 12);
            panel5.TabIndex = 8;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(5, 10, 48);
            panel6.Location = new Point(442, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(278, 12);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(5, 10, 48);
            panel7.Location = new Point(132, 33);
            panel7.Name = "panel7";
            panel7.Size = new Size(65, 12);
            panel7.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(5, 10, 48);
            panel8.Location = new Point(596, 33);
            panel8.Name = "panel8";
            panel8.Size = new Size(124, 12);
            panel8.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(5, 10, 48);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(label3);
            panel9.Controls.Add(label2);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(pictureBox5);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(858, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(84, 529);
            panel9.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 108);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 14;
            label6.Text = "Volt";
            label6.MouseLeave += label6_MouseLeave;
            label6.MouseHover += label6_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 81);
            label4.Name = "label4";
            label4.Size = new Size(11, 15);
            label4.TabIndex = 13;
            label4.Text = ".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(219, 178, 23);
            label3.Location = new Point(3, 433);
            label3.Name = "label3";
            label3.Size = new Size(76, 13);
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
            label2.Location = new Point(20, 84);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Active ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(219, 178, 23);
            label1.Location = new Point(18, 63);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Mr. Pass";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(22, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Cursor = Cursors.Hand;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(156, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 105);
            listBox1.TabIndex = 13;
            listBox1.Visible = false;
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
            panel10.Location = new Point(849, 2);
            panel10.Margin = new Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 705);
            panel10.TabIndex = 14;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.Window;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(942, 546);
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
            Text = "Dashboard";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            MouseDoubleClick += Form1_MouseDoubleClick;
            MouseLeave += Form1_MouseLeave;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private ImageList imageList1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button button4;
        private Button button6;
        private Button button5;
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
        private PictureBox pictureBox6;
        private Button btnPictures;
        private Panel panel10;
        private Label label5;
        private Label label6;
    }
}