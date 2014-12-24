namespace ProftaakOefening
{
    partial class PopUpForm
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
            this.popUpFormNaamLbl = new System.Windows.Forms.Label();
            this.popUpFormLeeftijdLbl = new System.Windows.Forms.Label();
            this.popUpFormNaamTxtBox = new System.Windows.Forms.TextBox();
            this.popUpFormLeeftijdNud = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popUpFormLeeftijdNud)).BeginInit();
            this.SuspendLayout();
            // 
            // popUpFormNaamLbl
            // 
            this.popUpFormNaamLbl.AutoSize = true;
            this.popUpFormNaamLbl.Location = new System.Drawing.Point(12, 31);
            this.popUpFormNaamLbl.Name = "popUpFormNaamLbl";
            this.popUpFormNaamLbl.Size = new System.Drawing.Size(35, 13);
            this.popUpFormNaamLbl.TabIndex = 0;
            this.popUpFormNaamLbl.Text = "Naam";
            // 
            // popUpFormLeeftijdLbl
            // 
            this.popUpFormLeeftijdLbl.AutoSize = true;
            this.popUpFormLeeftijdLbl.Location = new System.Drawing.Point(12, 61);
            this.popUpFormLeeftijdLbl.Name = "popUpFormLeeftijdLbl";
            this.popUpFormLeeftijdLbl.Size = new System.Drawing.Size(41, 13);
            this.popUpFormLeeftijdLbl.TabIndex = 1;
            this.popUpFormLeeftijdLbl.Text = "Leeftijd";
            // 
            // popUpFormNaamTxtBox
            // 
            this.popUpFormNaamTxtBox.Location = new System.Drawing.Point(80, 28);
            this.popUpFormNaamTxtBox.Name = "popUpFormNaamTxtBox";
            this.popUpFormNaamTxtBox.Size = new System.Drawing.Size(100, 20);
            this.popUpFormNaamTxtBox.TabIndex = 2;
            // 
            // popUpFormLeeftijdNud
            // 
            this.popUpFormLeeftijdNud.Location = new System.Drawing.Point(80, 59);
            this.popUpFormLeeftijdNud.Name = "popUpFormLeeftijdNud";
            this.popUpFormLeeftijdNud.Size = new System.Drawing.Size(100, 20);
            this.popUpFormLeeftijdNud.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Klaar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.popUpFormLeeftijdNud);
            this.Controls.Add(this.popUpFormNaamTxtBox);
            this.Controls.Add(this.popUpFormLeeftijdLbl);
            this.Controls.Add(this.popUpFormNaamLbl);
            this.Name = "PopUpForm";
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.popUpFormLeeftijdNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popUpFormNaamLbl;
        private System.Windows.Forms.Label popUpFormLeeftijdLbl;
        private System.Windows.Forms.TextBox popUpFormNaamTxtBox;
        private System.Windows.Forms.NumericUpDown popUpFormLeeftijdNud;
        private System.Windows.Forms.Button button1;
    }
}