namespace ProftaakOefening
{
    partial class PictureADayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureADayForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.serialPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.rescanBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aanpassenBtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.getImagesFromDatabase = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbWebcams = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(166, 19);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save button";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.Save_click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(655, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // serialPortSelectionBox
            // 
            this.serialPortSelectionBox.FormattingEnabled = true;
            this.serialPortSelectionBox.Location = new System.Drawing.Point(6, 19);
            this.serialPortSelectionBox.Name = "serialPortSelectionBox";
            this.serialPortSelectionBox.Size = new System.Drawing.Size(106, 21);
            this.serialPortSelectionBox.TabIndex = 8;
            // 
            // rescanBtn
            // 
            this.rescanBtn.Location = new System.Drawing.Point(6, 46);
            this.rescanBtn.Name = "rescanBtn";
            this.rescanBtn.Size = new System.Drawing.Size(224, 23);
            this.rescanBtn.TabIndex = 10;
            this.rescanBtn.Text = "Rescan Ports";
            this.rescanBtn.UseVisualStyleBackColor = true;
            this.rescanBtn.Click += new System.EventHandler(this.rescanBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(118, 19);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(112, 23);
            this.connectBtn.TabIndex = 11;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectBtn);
            this.groupBox1.Controls.Add(this.rescanBtn);
            this.groupBox1.Controls.Add(this.serialPortSelectionBox);
            this.groupBox1.Location = new System.Drawing.Point(657, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Poorten";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbWebcams);
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Location = new System.Drawing.Point(655, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 51);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aanpassenBtn);
            this.groupBox3.Location = new System.Drawing.Point(658, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 50);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "People Data";
            // 
            // aanpassenBtn
            // 
            this.aanpassenBtn.Location = new System.Drawing.Point(6, 19);
            this.aanpassenBtn.Name = "aanpassenBtn";
            this.aanpassenBtn.Size = new System.Drawing.Size(106, 23);
            this.aanpassenBtn.TabIndex = 3;
            this.aanpassenBtn.Text = "Change Data";
            this.aanpassenBtn.UseVisualStyleBackColor = true;
            this.aanpassenBtn.Click += new System.EventHandler(this.changeDataBtn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.getImagesFromDatabase);
            this.groupBox4.Location = new System.Drawing.Point(785, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 79);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Images";
            // 
            // getImagesFromDatabase
            // 
            this.getImagesFromDatabase.Location = new System.Drawing.Point(15, 30);
            this.getImagesFromDatabase.Name = "getImagesFromDatabase";
            this.getImagesFromDatabase.Size = new System.Drawing.Size(88, 39);
            this.getImagesFromDatabase.TabIndex = 0;
            this.getImagesFromDatabase.Text = "Get images from database";
            this.getImagesFromDatabase.UseVisualStyleBackColor = true;
            this.getImagesFromDatabase.Click += new System.EventHandler(this.getImagesFromDatabase_Click);
            // 
            // cbWebcams
            // 
            this.cbWebcams.FormattingEnabled = true;
            this.cbWebcams.Location = new System.Drawing.Point(6, 21);
            this.cbWebcams.Name = "cbWebcams";
            this.cbWebcams.Size = new System.Drawing.Size(154, 21);
            this.cbWebcams.TabIndex = 7;
            this.cbWebcams.SelectedIndexChanged += new System.EventHandler(this.cbWebcams_SelectedIndexChanged);
            // 
            // PictureADayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 478);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureADayForm";
            this.Text = "Picture A Day";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.PictureADayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox serialPortSelectionBox;
        private System.Windows.Forms.Button rescanBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button aanpassenBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button getImagesFromDatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbWebcams;
    }
}

