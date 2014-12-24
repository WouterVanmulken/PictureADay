namespace ProftaakOefening
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.config1Btn = new System.Windows.Forms.Button();
            this.config2Btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.serialPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.rescanBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aanpassenBtn = new System.Windows.Forms.Button();
            this.verwijderenBtn = new System.Windows.Forms.Button();
            this.toevoegenBtn = new System.Windows.Forms.Button();
            this.LijstBtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(4, 19);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start button";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(4, 48);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop button";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.bntStop_Click);
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
            // config1Btn
            // 
            this.config1Btn.Location = new System.Drawing.Point(85, 19);
            this.config1Btn.Name = "config1Btn";
            this.config1Btn.Size = new System.Drawing.Size(75, 23);
            this.config1Btn.TabIndex = 5;
            this.config1Btn.Text = "Config1";
            this.config1Btn.UseVisualStyleBackColor = true;
            this.config1Btn.Click += new System.EventHandler(this.bntVideoFormat_Click);
            // 
            // config2Btn
            // 
            this.config2Btn.Location = new System.Drawing.Point(85, 48);
            this.config2Btn.Name = "config2Btn";
            this.config2Btn.Size = new System.Drawing.Size(75, 23);
            this.config2Btn.TabIndex = 6;
            this.config2Btn.Text = "Config 2";
            this.config2Btn.UseVisualStyleBackColor = true;
            this.config2Btn.Click += new System.EventHandler(this.bntVideoSource_Click);
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
            this.groupBox2.Controls.Add(this.config2Btn);
            this.groupBox2.Controls.Add(this.config1Btn);
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Controls.Add(this.stopBtn);
            this.groupBox2.Controls.Add(this.startBtn);
            this.groupBox2.Location = new System.Drawing.Point(657, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 74);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aanpassenBtn);
            this.groupBox3.Controls.Add(this.verwijderenBtn);
            this.groupBox3.Controls.Add(this.toevoegenBtn);
            this.groupBox3.Controls.Add(this.LijstBtn);
            this.groupBox3.Location = new System.Drawing.Point(657, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 80);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personen Controls";
            // 
            // aanpassenBtn
            // 
            this.aanpassenBtn.Enabled = false;
            this.aanpassenBtn.Location = new System.Drawing.Point(6, 49);
            this.aanpassenBtn.Name = "aanpassenBtn";
            this.aanpassenBtn.Size = new System.Drawing.Size(75, 23);
            this.aanpassenBtn.TabIndex = 3;
            this.aanpassenBtn.Text = "Aanpassen";
            this.aanpassenBtn.UseVisualStyleBackColor = true;
            // 
            // verwijderenBtn
            // 
            this.verwijderenBtn.Enabled = false;
            this.verwijderenBtn.Location = new System.Drawing.Point(155, 50);
            this.verwijderenBtn.Name = "verwijderenBtn";
            this.verwijderenBtn.Size = new System.Drawing.Size(75, 23);
            this.verwijderenBtn.TabIndex = 2;
            this.verwijderenBtn.Text = "Verwijderen";
            this.verwijderenBtn.UseVisualStyleBackColor = true;
            // 
            // toevoegenBtn
            // 
            this.toevoegenBtn.Enabled = false;
            this.toevoegenBtn.Location = new System.Drawing.Point(6, 19);
            this.toevoegenBtn.Name = "toevoegenBtn";
            this.toevoegenBtn.Size = new System.Drawing.Size(75, 23);
            this.toevoegenBtn.TabIndex = 0;
            this.toevoegenBtn.Text = "Toevoegen";
            this.toevoegenBtn.UseVisualStyleBackColor = true;
            this.toevoegenBtn.Click += new System.EventHandler(this.toevoegenBtn_Click);
            // 
            // LijstBtn
            // 
            this.LijstBtn.Enabled = false;
            this.LijstBtn.Location = new System.Drawing.Point(155, 19);
            this.LijstBtn.Name = "LijstBtn";
            this.LijstBtn.Size = new System.Drawing.Size(75, 23);
            this.LijstBtn.TabIndex = 1;
            this.LijstBtn.Text = "Lijst";
            this.LijstBtn.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Picture A Day";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button config1Btn;
        private System.Windows.Forms.Button config2Btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox serialPortSelectionBox;
        private System.Windows.Forms.Button rescanBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button aanpassenBtn;
        private System.Windows.Forms.Button verwijderenBtn;
        private System.Windows.Forms.Button LijstBtn;
        private System.Windows.Forms.Button toevoegenBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

