using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NameGenerator
{
    public partial class mapNameGen : Form
    {
        public mapNameGen()
        {
            InitializeComponent();
        }

        private void createTestFileButton_Click(object sender, EventArgs e)
        {
            string sourcePath = selectFile();
            string targetPath = selectFolder();

            MessageBox.Show(sourcePath);

            System.IO.File.Copy(sourcePath, targetPath);
        }


        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        private string selectFile()
        {
            System.Windows.Forms.OpenFileDialog fileDlg =
                new System.Windows.Forms.OpenFileDialog();

            fileDlg.Title = "Select file to rename";            

            if (fileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = fileDlg.FileName;
                return file;
            }
            else { return null; }
        }


        private string selectFolder()
        {
            // This line calls the folder diag
            System.Windows.Forms.FolderBrowserDialog folderDlg =
                new System.Windows.Forms.FolderBrowserDialog();

            folderDlg.Description = "Select file upload directory";

            // This is what will execute if the user selects 
            // a folder and hits OK (File if you change to FileBrowserDialog)
            if (folderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = folderDlg.SelectedPath;
                return folder;
            }
            else
            {
                return null;
                // This prevents a crash when you close out of the window with nothing
            }
        }
    }
}
