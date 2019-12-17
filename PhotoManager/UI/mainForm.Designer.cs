using PhotoManager.Models;

namespace PhotoManager.UI
{
    partial class mainForm
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
            this.FileOpenPicker = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewPhotos = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtOriginalRoot = new System.Windows.Forms.TextBox();
            this.btnOpenOriginalRoot = new System.Windows.Forms.Button();
            this.btnOpenNewRoot = new System.Windows.Forms.Button();
            this.txtNewRoot = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.directoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDirectoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeOriginalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orientationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhotos
            // 
            this.dataGridViewPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPhotos.AutoGenerateColumns = false;
            this.dataGridViewPhotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhotos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directoryNameDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.newDirectoryNameDataGridViewTextBoxColumn,
            this.newFileNameDataGridViewTextBoxColumn,
            this.dateTimeOriginalDataGridViewTextBoxColumn,
            this.orientationDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.lagitudeDataGridViewTextBoxColumn,
            this.uniqueIDDataGridViewTextBoxColumn});
            this.dataGridViewPhotos.DataSource = this.photosBindingSource;
            this.dataGridViewPhotos.Location = new System.Drawing.Point(9, 125);
            this.dataGridViewPhotos.Name = "dataGridViewPhotos";
            this.dataGridViewPhotos.Size = new System.Drawing.Size(1170, 584);
            this.dataGridViewPhotos.TabIndex = 1;
            // 
            // txtOriginalRoot
            // 
            this.txtOriginalRoot.Location = new System.Drawing.Point(12, 12);
            this.txtOriginalRoot.Name = "txtOriginalRoot";
            this.txtOriginalRoot.Size = new System.Drawing.Size(657, 20);
            this.txtOriginalRoot.TabIndex = 13;
            // 
            // btnOpenOriginalRoot
            // 
            this.btnOpenOriginalRoot.Location = new System.Drawing.Point(675, 12);
            this.btnOpenOriginalRoot.Name = "btnOpenOriginalRoot";
            this.btnOpenOriginalRoot.Size = new System.Drawing.Size(30, 23);
            this.btnOpenOriginalRoot.TabIndex = 12;
            this.btnOpenOriginalRoot.Text = "...";
            this.btnOpenOriginalRoot.UseVisualStyleBackColor = true;
            this.btnOpenOriginalRoot.Click += new System.EventHandler(this.btnOpenOriginalRoot_Click);
            // 
            // btnOpenNewRoot
            // 
            this.btnOpenNewRoot.Location = new System.Drawing.Point(675, 38);
            this.btnOpenNewRoot.Name = "btnOpenNewRoot";
            this.btnOpenNewRoot.Size = new System.Drawing.Size(30, 23);
            this.btnOpenNewRoot.TabIndex = 15;
            this.btnOpenNewRoot.Text = "...";
            this.btnOpenNewRoot.UseVisualStyleBackColor = true;
            this.btnOpenNewRoot.Click += new System.EventHandler(this.btnOpenNewRoot_Click);
            // 
            // txtNewRoot
            // 
            this.txtNewRoot.Location = new System.Drawing.Point(12, 41);
            this.txtNewRoot.Name = "txtNewRoot";
            this.txtNewRoot.Size = new System.Drawing.Size(657, 20);
            this.txtNewRoot.TabIndex = 14;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(406, 67);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(263, 23);
            this.btnApply.TabIndex = 17;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 67);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(271, 23);
            this.btnProcess.TabIndex = 16;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // directoryNameDataGridViewTextBoxColumn
            // 
            this.directoryNameDataGridViewTextBoxColumn.DataPropertyName = "DirectoryName";
            this.directoryNameDataGridViewTextBoxColumn.HeaderText = "DirectoryName";
            this.directoryNameDataGridViewTextBoxColumn.Name = "directoryNameDataGridViewTextBoxColumn";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // newDirectoryNameDataGridViewTextBoxColumn
            // 
            this.newDirectoryNameDataGridViewTextBoxColumn.DataPropertyName = "NewDirectoryName";
            this.newDirectoryNameDataGridViewTextBoxColumn.HeaderText = "NewDirectoryName";
            this.newDirectoryNameDataGridViewTextBoxColumn.Name = "newDirectoryNameDataGridViewTextBoxColumn";
            // 
            // newFileNameDataGridViewTextBoxColumn
            // 
            this.newFileNameDataGridViewTextBoxColumn.DataPropertyName = "NewFileName";
            this.newFileNameDataGridViewTextBoxColumn.HeaderText = "NewFileName";
            this.newFileNameDataGridViewTextBoxColumn.Name = "newFileNameDataGridViewTextBoxColumn";
            // 
            // dateTimeOriginalDataGridViewTextBoxColumn
            // 
            this.dateTimeOriginalDataGridViewTextBoxColumn.DataPropertyName = "DateTimeOriginal";
            this.dateTimeOriginalDataGridViewTextBoxColumn.HeaderText = "DateTimeOriginal";
            this.dateTimeOriginalDataGridViewTextBoxColumn.Name = "dateTimeOriginalDataGridViewTextBoxColumn";
            // 
            // orientationDataGridViewTextBoxColumn
            // 
            this.orientationDataGridViewTextBoxColumn.DataPropertyName = "Orientation";
            this.orientationDataGridViewTextBoxColumn.HeaderText = "Orientation";
            this.orientationDataGridViewTextBoxColumn.Name = "orientationDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            // 
            // lagitudeDataGridViewTextBoxColumn
            // 
            this.lagitudeDataGridViewTextBoxColumn.DataPropertyName = "Lagitude";
            this.lagitudeDataGridViewTextBoxColumn.HeaderText = "Lagitude";
            this.lagitudeDataGridViewTextBoxColumn.Name = "lagitudeDataGridViewTextBoxColumn";
            // 
            // uniqueIDDataGridViewTextBoxColumn
            // 
            this.uniqueIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueID";
            this.uniqueIDDataGridViewTextBoxColumn.HeaderText = "UniqueID";
            this.uniqueIDDataGridViewTextBoxColumn.Name = "uniqueIDDataGridViewTextBoxColumn";
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataSource = typeof(PhotoManager.Models.Photos);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 721);
            this.Controls.Add(this.txtOriginalRoot);
            this.Controls.Add(this.btnOpenOriginalRoot);
            this.Controls.Add(this.btnOpenNewRoot);
            this.Controls.Add(this.txtNewRoot);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.dataGridViewPhotos);
            this.Name = "mainForm";
            this.Text = "PhotoManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog FileOpenPicker;
        private System.Windows.Forms.DataGridView dataGridViewPhotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private System.Windows.Forms.TextBox txtOriginalRoot;
        private System.Windows.Forms.Button btnOpenOriginalRoot;
        private System.Windows.Forms.Button btnOpenNewRoot;
        private System.Windows.Forms.TextBox txtNewRoot;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newDirectoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeOriginalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orientationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueIDDataGridViewTextBoxColumn;
    }
}

