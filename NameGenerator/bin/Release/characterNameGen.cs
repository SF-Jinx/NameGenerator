using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NameGenerator
{
    public partial class characterNameGen : Form
    {
        string sourceFile;
        string targetPath = Properties.Resources.mainDirectoryPath.ToString();
        string characterType;

        public characterNameGen()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(characterNameGen_DragEnter);
            this.DragDrop  += new DragEventHandler(characterNameGen_DragDrop);
        }

        private void generateFilenameButton_Click(object sender, EventArgs e)
        {
            if (sourceFile == "")
            {
                sourceFile = selectFile();
            }

            if (targetPath == "")
            {
                targetPath = selectFolder() + "\\";
                
            }
            
            string name = textBoxCharacterName.Text.ToString();
            name = name.ToUpper();

            string frameSizeX = "_x" + textBoxFrameX.Text.ToString();
            string frameSizeY = "_y" + textBoxFrameY.Text.ToString();

            if      (radioButtonPlayer.Checked) { characterType = "player_"; }
            else if (radioButtonEnemy.Checked)  { characterType = "enemy_";}
            else characterType = "NPC_";

            string characterName = characterType + name + frameSizeX + frameSizeY + ".png";

//            Clipboard.SetText(characterName);

            string fullPathName = targetPath + characterName;

            MessageBox.Show(fullPathName + "\n\nSaved to clipboard");
//            System.IO.File.Copy(sourceFile, fullPathName);
            this.Close();
        }

        ///////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////

        /// <summary>
        /// Ask the user to select the file to alter name and upload
        /// </summary>
        /// <returns>string fileNameAndPath</returns>

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

        /// <summary>
        /// Allow the user to select a folder to save the file 
        /// with newly-generated nameinto
        /// </summary>
        /// <returns>string folderLocation</returns>

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

        private void becomeMainDirectory()
        {
            MessageBox.Show("Would you like this selected folder to become your main directory?");
            
                
        }

        void characterNameGen_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) MessageBox.Show(file);
            sourceFile = files[0];
        }

        void characterNameGen_DragEnter(object sender, DragEventArgs e) 
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
    }
}
