using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCam_Capture;

namespace ProftaakOefening
{
        
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            mainWinForm_Load(null, null);
           
            
        }
        WebCam webcam;
        private void mainWinForm_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox);
            webcam.Start();
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            
            webcam.Start();
                
            
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void bntContinue_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        //private void bntCapture_Click(object sender, EventArgs e)
        //{
        //    imgCapture.Image = imgVideo.Image;
        //}

        //private void bntSave_Click(object sender, EventArgs e)
        //{
        //    Helper.SaveImageCapture(imgCapture.Image);
        //}

        private void bntVideoFormat_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void bntVideoSource_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void imgVideo_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Save_click(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            saver.SaveImageCapture(pictureBox.Image);

        }

        
    }
    }

