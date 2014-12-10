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
        WebCam webcam;
        Saver saver = new Saver();

        public Form1()
        {
            InitializeComponent();
            mainWinForm_Load(null, null);              
        }
        
        private void mainWinForm_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox);
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            webcam.Start();  
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        //private void bntVideoFormat_Click(object sender, EventArgs e)
        //{
        //    webcam.ResolutionSetting();
        //}

        //private void bntVideoSource_Click(object sender, EventArgs e)
        //{
        //    webcam.AdvanceSetting();
        //}


        private void Save_click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {
            saver.SaveImageCapture(pictureBox.Image);
            //label1.Text = saver.counter.ToString();
           }
        }

        
    }
    }

