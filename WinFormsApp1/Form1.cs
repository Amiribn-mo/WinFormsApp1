using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string colorForButtons = "#050A30";
        private Random random;

        private string initialDirectory = @"C:\\Users\\Lenovo\\Desktop";
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    PopulateListView(selectedPath);
                }
            }
        }

        private void PopulateListView(string folderPath)
        {
            listView1.Items.Clear();

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

                foreach (var directory in directoryInfo.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(directory.Name);
                    item.SubItems.Add("Folder");
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color buttonColor = ColorTranslator.FromHtml(colorForButtons);

            downloadIconOrange.Visible = false;
            documentIconOrange.Visible = false;
            quickIconOrange.Visible = false;

            quickIconWhite.Visible = true;
            downloadIconWhite.Visible = true;
            documentIconWhite.Visible = true;


            btnQuick.ForeColor = buttonColor;
            btnQuick.BackColor = Color.White;

            btnDownloads.BackColor = buttonColor;
            btnDownloads.ForeColor = Color.White;

            btndocuments.ForeColor = Color.White;
            btndocuments.BackColor = buttonColor;

            label2.ForeColor = Color.ForestGreen;
            string folderPath = @"C:\\Users\\Lenovo\\Desktop";

            DirectoryInfo directory = new DirectoryInfo(folderPath);

            // Clear the ListView
            listView1.Items.Clear();

            // Add folders to the ListView
            foreach (DirectoryInfo subdirectory in directory.GetDirectories())
            {
                ListViewItem item = new ListViewItem(subdirectory.Name, 0); // Use folder icon
                item.SubItems.Add("Folder");
                item.SubItems.Add(""); // Leave the Size column empty for folders
                item.SubItems.Add(subdirectory.LastWriteTime.ToString()); // Use the LastWriteTime as the Date Modified
                listView1.Items.Add(item);
            }

            // Add files to the ListView
            foreach (FileInfo file in directory.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name, 1); // Use file icon
                item.SubItems.Add("File");
                item.ImageIndex = 1;
                item.SubItems.Add(file.Length.ToString()); // Use the Length property as the Size
                item.SubItems.Add(file.LastWriteTime.ToString()); // Use the LastWriteTime as the Date Modified
                listView1.Items.Add(item);
            }



        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*panel3.Visible = false;*/
            listBox1.Hide();
            panel3.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            user usr = new user();
            usr.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            listBox1.Visible = true;
            string searchQuery = textBox1.Text;
            string searchDirectory = @"C:\\Users\\Lenovo\\Desktop"; // Specify the directory to search in

            // Clear the previous search results
            listBox1.Items.Clear();


            // Perform the file search
            string[] files = Directory.GetFiles(searchDirectory, "*" + searchQuery + "*");


            // Add the matching files to the list
            listBox1.Items.AddRange(files);

        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            listBox1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(initialDirectory);

            // Clear the ListView
            listView1.Items.Clear();

            // Add the folders to the ListView
            foreach (DirectoryInfo subdirectory in directory.GetDirectories())
            {
                ListViewItem item = new ListViewItem(subdirectory.Name, 0); // Use folder icon
                listView1.Items.Add(item);
            }

            // Add the files to the ListView
            foreach (FileInfo file in directory.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name, 1); // Use file icon
                listView1.Items.Add(item);
            }
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {


        }

        private void button3_MouseHover(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color buttonColor = ColorTranslator.FromHtml(colorForButtons);



            downloadIconOrange.Visible = false;
            documentIconOrange.Visible = false;
            quickIconOrange.Visible = false;

            quickIconWhite.Visible = true;
            downloadIconWhite.Visible = true;
            documentIconWhite.Visible = true;

            btnDownloads.BackColor = Color.White;
            btnDownloads.ForeColor = Color.Black;

            btnQuick.ForeColor = Color.White;
            btnQuick.BackColor = buttonColor;
            /*  button2.BackColor = Color.DarkBlue;*/

            btndocuments.BackColor = buttonColor;
            btndocuments.ForeColor = Color.White;



            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\[FreeCourseSite.com] Udemy - Python and Django Full Stack Web Developer Bootcamp";
            label2.ForeColor = Color.ForestGreen;
            DirectoryInfo directory = new DirectoryInfo(downloadsPath);

            // Clear the ListView
            listView1.Items.Clear();

            // Add the folders to the ListView
            foreach (DirectoryInfo subdirectory in directory.GetDirectories())
            {
                ListViewItem item = new ListViewItem(subdirectory.Name, 0); // Use folder icon
                listView1.Items.Add(item);
            }

            // Add the files to the ListView
            foreach (FileInfo file in directory.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name, 1); // Use file icon
                listView1.Items.Add(item);
            }
        }

        private void btnPictures_Click(object sender, EventArgs e)
        {

            Color buttonColor = ColorTranslator.FromHtml(colorForButtons);

            downloadIconOrange.Visible = false;
            documentIconOrange.Visible = false;
            quickIconOrange.Visible = false;

            quickIconWhite.Visible = true;
            downloadIconWhite.Visible = true;
            documentIconWhite.Visible = true;

            btndocuments.BackColor = Color.White;
            btndocuments.ForeColor = buttonColor;

            btnQuick.ForeColor = Color.White;
            btnQuick.BackColor = buttonColor;

            btnDownloads.ForeColor = Color.White;
            btnDownloads.BackColor = buttonColor;

            listView1.Items.Clear();
            label2.ForeColor = Color.ForestGreen;
            string[] documentPaths = Directory.GetFiles(@"C:\\Users\\Lenovo\\Documents");

            foreach (string path in documentPaths)
            {
                FileInfo fileInfo = new FileInfo(path);
                ListViewItem item = new ListViewItem();
                item.Text = fileInfo.Name;
                item.SubItems.Add(fileInfo.Length.ToString());
                // Add more sub-items to display additional information if desired
                listView1.Items.Add(item);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedDocumentPath = Path.Combine(@"C:\Path\To\Documents", listView1.SelectedItems[0].Text);
                OpenDocument(selectedDocumentPath);
            }
        }
        private void OpenDocument(string documentPath)
        {
            try
            {
                Process.Start("notepad.exe", documentPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to open the document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {




        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox4, "File Explorer ");
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Orange;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Size = new Size(600, 31);
            pictureBox11.Visible = true;
            pictureBox1.Visible = false;



        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Size = new Size(131, 31);
            pictureBox11.Visible = false;
            pictureBox1.Visible = true;


        }



        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string filePath = item.Tag.ToString(); // Assuming the file path is stored in the Tag property of each ListViewItem

                    // Set the Read-only attribute for the file
                    FileAttributes attributes = File.GetAttributes(filePath);
                    File.SetAttributes(filePath, attributes | FileAttributes.ReadOnly);
                }

                MessageBox.Show("Files locked successfully.", "Volt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while locking the files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Size = new Size(50, 533);
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            //  listView1.Size = new Size(781, 328);
            label5.Visible = false;
            pictureBox4.Visible = false;

        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Size = new Size(200, 533);
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
            //listView1.Size = new Size(670, 328);
            label5.Visible = true;
            pictureBox4.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            quickIconWhite.Visible = false;
            quickIconOrange.Visible = true;

            documentIconOrange.Visible = false;
            documentIconWhite.Visible = true;

            downloadIconWhite.Visible = true;
            downloadIconOrange.Visible = false;

            string folderPath = @"C:\\Users\\Lenovo\\Desktop";

            DirectoryInfo directory = new DirectoryInfo(folderPath);

            // Clear the ListView
            listView1.Items.Clear();

            // Add folders to the ListView
            foreach (DirectoryInfo subdirectory in directory.GetDirectories())
            {
                ListViewItem item = new ListViewItem(subdirectory.Name, 0); // Use folder icon
                item.SubItems.Add("Folder");
                item.SubItems.Add(""); // Leave the Size column empty for folders
                item.SubItems.Add(subdirectory.LastWriteTime.ToString()); // Use the LastWriteTime as the Date Modified
                listView1.Items.Add(item);
            }

            // Add files to the ListView
            foreach (FileInfo file in directory.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name, 1); // Use file icon
                item.SubItems.Add("File");
                item.ImageIndex = 1;
                item.SubItems.Add(file.Length.ToString()); // Use the Length property as the Size
                item.SubItems.Add(file.LastWriteTime.ToString()); // Use the LastWriteTime as the Date Modified
                listView1.Items.Add(item);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /*pictureBox9.Visible = false;
            pictureBox2.Visible = true;*/

            quickIconWhite.Visible = true;
            quickIconOrange.Visible = false;

            documentIconOrange.Visible = false;
            documentIconWhite.Visible = true;

            downloadIconWhite.Visible = false;
            downloadIconOrange.Visible = true;


            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            label2.ForeColor = Color.ForestGreen;
            DirectoryInfo directory = new DirectoryInfo(downloadsPath);

            // Clear the ListView
            listView1.Items.Clear();

            // Add the folders to the ListView
            foreach (DirectoryInfo subdirectory in directory.GetDirectories())
            {
                ListViewItem item = new ListViewItem(subdirectory.Name, 0); // Use folder icon
                listView1.Items.Add(item);
            }

            // Add the files to the ListView
            foreach (FileInfo file in directory.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name, 1); // Use file icon
                listView1.Items.Add(item);
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(quickIconWhite, "Desktop Folders");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(downloadIconWhite, "Downloads");
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(documentIconWhite, "Documents.");
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(quickIconOrange, "Desktop Folders");
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            quickIconWhite.Visible = true;
            quickIconOrange.Visible = false;

            documentIconOrange.Visible = true;
            documentIconWhite.Visible = false;

            downloadIconWhite.Visible = true;
            downloadIconOrange.Visible = false;

            string[] documentPaths = Directory.GetFiles(@"C:\\Users\\Lenovo\\Documents");

            foreach (string path in documentPaths)
            {
                FileInfo fileInfo = new FileInfo(path);
                ListViewItem item = new ListViewItem();
                item.Text = fileInfo.Name;
                item.SubItems.Add(fileInfo.Length.ToString());
                // Add more sub-items to display additional information if desired
                listView1.Items.Add(item);
            }
        }

        private void quickIconOrange_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color randomColor = GetRandomColor();
            label2.ForeColor = randomColor;
        }
        private Color GetRandomColor()
        {
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);
            return Color.FromArgb(red, green, blue);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            listView1.BackColor = Color.Black; listView1.ForeColor = Color.White;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            listView1.BackColor = Color.White; listView1.ForeColor = Color.Black;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void downloadIconOrange_Click(object sender, EventArgs e)
        {

        }
    }
}

