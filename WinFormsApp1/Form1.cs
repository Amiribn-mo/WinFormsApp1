using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private string initialDirectory = @"C:\\Users\\Lenovo\\Desktop";
        public Form1()
        {
            InitializeComponent();
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

            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;

            button3.BackColor = Color.DarkBlue;
            button3.ForeColor = Color.White;

            btnPictures.ForeColor = Color.White;
            btnPictures.BackColor = Color.DarkBlue;

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
            string searchDirectory = @"C:\"; // Specify the directory to search in

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
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;

            button2.ForeColor = Color.White;
            button2.BackColor = Color.DarkBlue;

            btnPictures.BackColor = Color.DarkBlue;
            btnPictures.ForeColor = Color.White;



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

        private void btnPictures_Click(object sender, EventArgs e)
        {
            btnPictures.BackColor = Color.White;
            btnPictures.ForeColor = Color.Black;

            button2.ForeColor = Color.White;
            button2.BackColor = Color.DarkBlue;

            button3.ForeColor = Color.White;
            button3.BackColor = Color.DarkBlue;

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
            string abt = "About our comapny";
            MessageBox.Show(abt);
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
            textBox1.Size = new Size(512, 31);


        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Size = new Size(131, 31);
            

        }
    }

}


