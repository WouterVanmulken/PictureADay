namespace ProftaakOefening
{
    partial class VideoControls
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.textBoxSound = new System.Windows.Forms.TextBox();
            this.browseSavePathBtn = new System.Windows.Forms.Button();
            this.browseSoundFileBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Ok = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "People :0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 160);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sound file";
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(16, 224);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(174, 20);
            this.textBoxSavePath.TabIndex = 4;
            // 
            // textBoxSound
            // 
            this.textBoxSound.Location = new System.Drawing.Point(16, 266);
            this.textBoxSound.Name = "textBoxSound";
            this.textBoxSound.Size = new System.Drawing.Size(174, 20);
            this.textBoxSound.TabIndex = 5;
            // 
            // browseSavePathBtn
            // 
            this.browseSavePathBtn.Location = new System.Drawing.Point(197, 224);
            this.browseSavePathBtn.Name = "browseSavePathBtn";
            this.browseSavePathBtn.Size = new System.Drawing.Size(75, 23);
            this.browseSavePathBtn.TabIndex = 6;
            this.browseSavePathBtn.Text = "Browse..";
            this.browseSavePathBtn.UseVisualStyleBackColor = true;
            this.browseSavePathBtn.Click += new System.EventHandler(this.browseSavePathBtn_Click);
            // 
            // browseSoundFileBtn
            // 
            this.browseSoundFileBtn.Location = new System.Drawing.Point(197, 266);
            this.browseSoundFileBtn.Name = "browseSoundFileBtn";
            this.browseSoundFileBtn.Size = new System.Drawing.Size(75, 23);
            this.browseSoundFileBtn.TabIndex = 7;
            this.browseSoundFileBtn.Text = "Browse..";
            this.browseSoundFileBtn.UseVisualStyleBackColor = true;
            this.browseSoundFileBtn.Click += new System.EventHandler(this.browseSoundFileBtn_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(16, 301);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(259, 23);
            this.Ok.TabIndex = 8;
            this.Ok.Text = "Convert";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // VideoControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 334);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.browseSoundFileBtn);
            this.Controls.Add(this.browseSavePathBtn);
            this.Controls.Add(this.textBoxSound);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "VideoControls";
            this.Text = "VideoControls";
            this.Load += new System.EventHandler(this.VideoControls_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.TextBox textBoxSound;
        private System.Windows.Forms.Button browseSavePathBtn;
        private System.Windows.Forms.Button browseSoundFileBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;

    }
}