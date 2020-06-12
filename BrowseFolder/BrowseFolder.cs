using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowseFolder
{

    public partial class BrowseFolder : Form
    {
        private String[] files;
        private String[] dirs;
        public BrowseFolder()
        {
            InitializeComponent();
        }

        private void BrowseFolder_Load(object sender, EventArgs e)
        {

        }
        //select a directory 
        private void browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            foldername.Text = folder.SelectedPath;
        }

        // switch to parent directory on up button click
        private void upbutton_Click(object sender, EventArgs e)
        {
            try {
                string directory = Directory.GetParent(foldercontentbox.Text).ToString();
                foldercontentbox.Text = directory;
                foldername.Text = directory;
                display_Click(sender, e);
            }
            catch (Exception)
            {
                foldername.Text = "Path cannot be empty!!";
            }
            
           }
        private void showfiles_dirs(String[] dirs)
        {
            for (int i = 0; i < dirs.Length; i++)
            {
                String[] folder_name = dirs[i].Split('\\');

                Folders.Items.Add(folder_name[folder_name.Length - 1]);
            }
            files = Directory.GetFiles(foldercontentbox.Text);
            for (int i = 0; i < files.Length; i++)
            {
                String[] file_name = files[i].Split('\\');

                Files.Items.Add(file_name[file_name.Length - 1]);
            }
        }
        // Load the directory on display button click
        private void display_Click(object sender, EventArgs e)
        {
            try
            {
                Folders.Items.Clear();
                Files.Items.Clear();
                foldercontentbox.Text = foldername.Text;
                dirs = Directory.GetDirectories(foldercontentbox.Text);
                showfiles_dirs(dirs);
            }
            catch(Exception)
            {
                foldercontentbox.Text = "Folder Not Found!!";

            }
        }
               //selected a file from the listbox
        private void Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            int getnameindx = Files.SelectedIndex;
            string getname = files[getnameindx];
            FileInfo fi = new FileInfo(getname);
            filename.Text = fi.Name;
            creationtime.Text = fi.CreationTime.ToLongTimeString();
            lastaccesstime.Text = fi.LastAccessTime.ToLongDateString();
            filesize.Text = fi.Length.ToString() + " Bytes";
            lastmodify.Text = fi.LastWriteTime.ToString();
        }

        //selected a folder from the folders listbox
        private void Folders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int getnameindx = Folders.SelectedIndex;
            string getname = dirs[getnameindx];
            DirectoryInfo di = new DirectoryInfo(getname);
            filename.Text = di.Name;
            creationtime.Text = di.CreationTime.ToLongTimeString();
            lastaccesstime.Text = di.LastAccessTime.ToLongDateString();
            filesize.Text = di.EnumerateFiles().Sum(file => file.Length) + " Bytes";
            lastmodify.Text = di.LastWriteTime.ToString();
            Folders.Items.Clear();
            Files.Items.Clear();
            foldercontentbox.Text += "\\"+filename.Text;
            dirs = Directory.GetDirectories(foldercontentbox.Text);
            showfiles_dirs(dirs);
        }
    }
}
