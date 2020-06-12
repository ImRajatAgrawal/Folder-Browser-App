namespace BrowseFolder
{
    partial class BrowseFolder
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
            this.browse = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.Label();
            this.folders_label = new System.Windows.Forms.Label();
            this.Files_label = new System.Windows.Forms.Label();
            this.content_label = new System.Windows.Forms.Label();
            this.folde_name_label = new System.Windows.Forms.Label();
            this.Folders = new System.Windows.Forms.ListBox();
            this.Files = new System.Windows.Forms.ListBox();
            this.display = new System.Windows.Forms.Button();
            this.upbutton = new System.Windows.Forms.Button();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.foldercontentbox = new System.Windows.Forms.RichTextBox();
            this.foldername = new System.Windows.Forms.RichTextBox();
            this.lastaccess_label = new System.Windows.Forms.Label();
            this.modifytime_label = new System.Windows.Forms.Label();
            this.CreationTime_label = new System.Windows.Forms.Label();
            this.filesize = new System.Windows.Forms.RichTextBox();
            this.lastmodify = new System.Windows.Forms.RichTextBox();
            this.lastaccesstime = new System.Windows.Forms.RichTextBox();
            this.FileSize_label = new System.Windows.Forms.Label();
            this.Filename_label = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.RichTextBox();
            this.creationtime = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(576, 64);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 36;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.Location = new System.Drawing.Point(119, 400);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(158, 13);
            this.Details.TabIndex = 35;
            this.Details.Text = "Details of the Selected file";
            // 
            // folders_label
            // 
            this.folders_label.AutoSize = true;
            this.folders_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folders_label.Location = new System.Drawing.Point(434, 198);
            this.folders_label.Name = "folders_label";
            this.folders_label.Size = new System.Drawing.Size(48, 13);
            this.folders_label.TabIndex = 34;
            this.folders_label.Text = "Folders";
            // 
            // Files_label
            // 
            this.Files_label.AutoSize = true;
            this.Files_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Files_label.Location = new System.Drawing.Point(153, 198);
            this.Files_label.Name = "Files_label";
            this.Files_label.Size = new System.Drawing.Size(33, 13);
            this.Files_label.TabIndex = 33;
            this.Files_label.Text = "Files";
            // 
            // content_label
            // 
            this.content_label.AutoSize = true;
            this.content_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_label.Location = new System.Drawing.Point(129, 112);
            this.content_label.Name = "content_label";
            this.content_label.Size = new System.Drawing.Size(130, 13);
            this.content_label.TabIndex = 32;
            this.content_label.Text = "Contents of the folder";
            // 
            // folde_name_label
            // 
            this.folde_name_label.AutoSize = true;
            this.folde_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folde_name_label.Location = new System.Drawing.Point(129, 37);
            this.folde_name_label.Name = "folde_name_label";
            this.folde_name_label.Size = new System.Drawing.Size(256, 13);
            this.folde_name_label.TabIndex = 31;
            this.folde_name_label.Text = "Enter the name of the folder to be examined";
            // 
            // Folders
            // 
            this.Folders.FormattingEnabled = true;
            this.Folders.Location = new System.Drawing.Point(423, 224);
            this.Folders.Name = "Folders";
            this.Folders.Size = new System.Drawing.Size(259, 173);
            this.Folders.TabIndex = 30;
            this.Folders.SelectedIndexChanged += new System.EventHandler(this.Folders_SelectedIndexChanged);
            // 
            // Files
            // 
            this.Files.FormattingEnabled = true;
            this.Files.Location = new System.Drawing.Point(143, 224);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(258, 173);
            this.Files.TabIndex = 29;
            this.Files.SelectedIndexChanged += new System.EventHandler(this.Files_SelectedIndexChanged);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(576, 107);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 23);
            this.display.TabIndex = 28;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // upbutton
            // 
            this.upbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upbutton.Location = new System.Drawing.Point(576, 145);
            this.upbutton.Name = "upbutton";
            this.upbutton.Size = new System.Drawing.Size(75, 23);
            this.upbutton.TabIndex = 27;
            this.upbutton.Text = "Up";
            this.upbutton.UseVisualStyleBackColor = true;
            this.upbutton.Click += new System.EventHandler(this.upbutton_Click);
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(518, 265);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(8, 8);
            this.richTextBox5.TabIndex = 26;
            this.richTextBox5.Text = "";
            // 
            // foldercontentbox
            // 
            this.foldercontentbox.Location = new System.Drawing.Point(122, 138);
            this.foldercontentbox.Name = "foldercontentbox";
            this.foldercontentbox.Size = new System.Drawing.Size(338, 30);
            this.foldercontentbox.TabIndex = 25;
            this.foldercontentbox.Text = "";
            // 
            // foldername
            // 
            this.foldername.Location = new System.Drawing.Point(122, 64);
            this.foldername.Name = "foldername";
            this.foldername.Size = new System.Drawing.Size(338, 32);
            this.foldername.TabIndex = 24;
            this.foldername.Text = "";
            // 
            // lastaccess_label
            // 
            this.lastaccess_label.AutoSize = true;
            this.lastaccess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastaccess_label.Location = new System.Drawing.Point(389, 569);
            this.lastaccess_label.Name = "lastaccess_label";
            this.lastaccess_label.Size = new System.Drawing.Size(102, 13);
            this.lastaccess_label.TabIndex = 46;
            this.lastaccess_label.Text = "Last access time";
            // 
            // modifytime_label
            // 
            this.modifytime_label.AutoSize = true;
            this.modifytime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifytime_label.Location = new System.Drawing.Point(131, 569);
            this.modifytime_label.Name = "modifytime_label";
            this.modifytime_label.Size = new System.Drawing.Size(130, 13);
            this.modifytime_label.TabIndex = 45;
            this.modifytime_label.Text = "Last modification time";
            // 
            // CreationTime_label
            // 
            this.CreationTime_label.AutoSize = true;
            this.CreationTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationTime_label.Location = new System.Drawing.Point(395, 489);
            this.CreationTime_label.Name = "CreationTime_label";
            this.CreationTime_label.Size = new System.Drawing.Size(81, 13);
            this.CreationTime_label.TabIndex = 44;
            this.CreationTime_label.Text = "Creation time";
            // 
            // filesize
            // 
            this.filesize.Location = new System.Drawing.Point(122, 513);
            this.filesize.Name = "filesize";
            this.filesize.Size = new System.Drawing.Size(179, 34);
            this.filesize.TabIndex = 43;
            this.filesize.Text = "";
            // 
            // lastmodify
            // 
            this.lastmodify.Location = new System.Drawing.Point(122, 594);
            this.lastmodify.Name = "lastmodify";
            this.lastmodify.Size = new System.Drawing.Size(179, 33);
            this.lastmodify.TabIndex = 42;
            this.lastmodify.Text = "";
            // 
            // lastaccesstime
            // 
            this.lastaccesstime.Location = new System.Drawing.Point(378, 594);
            this.lastaccesstime.Name = "lastaccesstime";
            this.lastaccesstime.Size = new System.Drawing.Size(206, 33);
            this.lastaccesstime.TabIndex = 41;
            this.lastaccesstime.Text = "";
            // 
            // FileSize_label
            // 
            this.FileSize_label.AutoSize = true;
            this.FileSize_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSize_label.Location = new System.Drawing.Point(131, 489);
            this.FileSize_label.Name = "FileSize_label";
            this.FileSize_label.Size = new System.Drawing.Size(55, 13);
            this.FileSize_label.TabIndex = 40;
            this.FileSize_label.Text = "File Size";
            // 
            // Filename_label
            // 
            this.Filename_label.AutoSize = true;
            this.Filename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filename_label.Location = new System.Drawing.Point(146, 441);
            this.Filename_label.Name = "Filename_label";
            this.Filename_label.Size = new System.Drawing.Size(61, 13);
            this.Filename_label.TabIndex = 39;
            this.Filename_label.Text = "File name";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(213, 438);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(371, 32);
            this.filename.TabIndex = 38;
            this.filename.Text = "";
            // 
            // creationtime
            // 
            this.creationtime.Location = new System.Drawing.Point(387, 515);
            this.creationtime.Name = "creationtime";
            this.creationtime.Size = new System.Drawing.Size(197, 32);
            this.creationtime.TabIndex = 37;
            this.creationtime.Text = "";
            // 
            // BrowseFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.lastaccess_label);
            this.Controls.Add(this.modifytime_label);
            this.Controls.Add(this.CreationTime_label);
            this.Controls.Add(this.filesize);
            this.Controls.Add(this.lastmodify);
            this.Controls.Add(this.lastaccesstime);
            this.Controls.Add(this.FileSize_label);
            this.Controls.Add(this.Filename_label);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.creationtime);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.folders_label);
            this.Controls.Add(this.Files_label);
            this.Controls.Add(this.content_label);
            this.Controls.Add(this.folde_name_label);
            this.Controls.Add(this.Folders);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.display);
            this.Controls.Add(this.upbutton);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.foldercontentbox);
            this.Controls.Add(this.foldername);
            this.Name = "BrowseFolder";
            this.Text = "FolderBrowser";
            this.Load += new System.EventHandler(this.BrowseFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.Label folders_label;
        private System.Windows.Forms.Label Files_label;
        private System.Windows.Forms.Label content_label;
        private System.Windows.Forms.Label folde_name_label;
        private System.Windows.Forms.ListBox Folders;
        private System.Windows.Forms.ListBox Files;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button upbutton;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox foldercontentbox;
        private System.Windows.Forms.RichTextBox foldername;
        private System.Windows.Forms.Label lastaccess_label;
        private System.Windows.Forms.Label modifytime_label;
        private System.Windows.Forms.Label CreationTime_label;
        private System.Windows.Forms.RichTextBox filesize;
        private System.Windows.Forms.RichTextBox lastmodify;
        private System.Windows.Forms.RichTextBox lastaccesstime;
        private System.Windows.Forms.Label FileSize_label;
        private System.Windows.Forms.Label Filename_label;
        private System.Windows.Forms.RichTextBox filename;
        private System.Windows.Forms.RichTextBox creationtime;
    }
}

