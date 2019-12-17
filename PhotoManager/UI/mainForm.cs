using ExifLib;
using PhotoManager.Models;
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
using PhotoManager.Services;

namespace PhotoManager.UI
{
    public partial class mainForm : Form
    {
        /// <summary>
        /// Photo files
        /// </summary>
        string[] photoFiles;
        Photos photosExif;

        public mainForm()
        {
            InitializeComponent();

            this.btnApply.Enabled = false;
        }

        private void btnOpenOriginalRoot_Click(object sender, EventArgs e)
        {
            photoFiles = null;
            folderBrowserDialog.SelectedPath = @"C:\_Personnel\Medias\Photos\Photos\";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtOriginalRoot.Text = folderBrowserDialog.SelectedPath;
                photoFiles = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.jp*g", SearchOption.AllDirectories);
            }
            this.btnApply.Enabled = false;
        }


        private void btnOpenNewRoot_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = @"C:\_DL\TEST";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtNewRoot.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            this.Enabled = false;

            // Retrieve exif metadata
            photosExif = ExifService.GetExifMetadata(photoFiles);
            photosBindingSource.DataSource = photosExif;

            if (Directory.Exists(txtNewRoot.Text))
            {
                // Build new folders and filenames
                List<string> newFiles = new List<string>();
                // Rename folders and files
                ExifService.RebuildFolderAndFiles(photosExif, txtNewRoot.Text);
            }

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
            this.Enabled = true;

            this.btnApply.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            this.Enabled = false;

            DateTime ds = DateTime.Now;
            int nbFfiles = 0;

            string newFileName = null;

            foreach (Photo p in photosExif)
            {
                DirectoryInfo di = new DirectoryInfo(p.NewDirectoryName);
                if (!di.Exists)
                {
                    di.Create();
                }
                newFileName = p.NewDirectoryName + @"\" + p.NewFileName;
                if (!File.Exists(newFileName))
                {
                    File.Copy(p.DirectoryName + @"\" + p.FileName, p.NewDirectoryName + @"\" + p.NewFileName);
                    nbFfiles++;
                }
            }

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
            this.Enabled = true;

            TimeSpan t = DateTime.Now - ds;
            MessageBox.Show(string.Format("{0} Fichiers traités en {1}", nbFfiles, t.ToString(@"hh\:mm\:ss")));
        }
    }
}