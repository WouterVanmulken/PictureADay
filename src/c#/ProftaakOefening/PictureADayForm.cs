using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

using System.Data.SQLite;

using TouchlessLib;
using NUnit.Framework;
using DirectShowLib;
using Splicer.Timeline;
using Splicer.Renderer;
using Splicer.Utilities;
using Splicer.WindowsMedia;

namespace ProftaakOefening
{

    public partial class PictureADayForm : Form
    {
        TouchlessMgr manager;
        Saver saver = new Saver();
        List<Person> people = new List<Person>();


        public PictureADayForm()
        {
            InitializeComponent();

        }
        private void PictureADayForm_Load(object sender, EventArgs e)
        {
            //initialize the touchless manager object
            manager = new TouchlessMgr();

            //Listing the available cameras in the combobox
            foreach (Camera item in manager.Cameras)
            {
                cbWebcams.Items.Add(item);
            }
            if (cbWebcams.Items.Count != 0) { cbWebcams.SelectedIndex = 0; }

            //add comports and connects it
            rescanBtn_Click(null, null);
            if (serialPortSelectionBox.Items.Count != 0) { serialPortSelectionBox.SelectedIndex = 0; }
            else { }//listBox1.Items.Add(DateTime.Now + ": No Connected devices found");}

            serialPort1.BaudRate = 9600;
            serialPort1.NewLine = "#";

            cbResolution.SelectedIndex = 0;
        }
        private void Save_click(object sender, EventArgs e)
        {
            int temperaryPersonIDHolder;
            Image tempImage = manager.CurrentCamera.GetCurrentImage();
            using (SavePersonPicker pp = new SavePersonPicker())
            {
                if (pp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    temperaryPersonIDHolder = pp.personSelected;

                    if (pictureBox1.Image != null)
                    {
                        pictureBox2.Image = tempImage;
                        Saver savefile = new Saver();
                        savefile.SaveImageCapture(tempImage, temperaryPersonIDHolder);
                    }
                    else { }//listBox1.Items.Add(DateTime.Now + ": No image to save.");}
                }
            }
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timer1.Enabled = false;
                serialPort1.Close();
                connectBtn.Text = "Connect";

            }
            else
            {
                String port = serialPortSelectionBox.Text;
                try
                {
                    serialPort1.PortName = port;
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        //ClearAllMessageData();
                        serialPort1.DiscardInBuffer();
                        serialPort1.DiscardOutBuffer();
                    }
                    timer1.Enabled = true;
                    connectBtn.Text = "Disconnect";
                }
                catch (Exception exception)
                {
                    richTextBox1.AppendText("\n" + DateTime.Now + ": Could not connect to the given serial port: " + exception.Message);

                }
            }

        }

        private void rescanBtn_Click(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            serialPortSelectionBox.Items.Clear();
            foreach (String port in ports)
            {
                serialPortSelectionBox.Items.Add(port);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            notifyIcon1.Visible = false;
        }

        //dit word gebruikt om te reageren op de arduino
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Image tempImage = manager.CurrentCamera.GetCurrentImage();
                pictureBox2.Image = tempImage;

                string serialData = serialPort1.ReadLine().ToString();
                int tempNumber;
                Int32.TryParse(serialData, out tempNumber);

                Saver serialSaver = new Saver();
                serialSaver.SaveImageCapture(tempImage, tempNumber);
            }
            catch (Exception exception) { }
        }

        private void changeDataBtn_Click(object sender, EventArgs e)
        {
            using (PopUpForm popupForm = new PopUpForm())
            {
                if (popupForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //hier kun je data van de form ophalen
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == true)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
        }

        private void getImagesFromDatabase_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("This procces will not overwrite existing files with the same file name, so if you cleared your database before we recommend to change the path of those pictures. ", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog1.SelectedPath;
                    if (!saver.allDatabaseImageSaver(selectedPath)) { richTextBox1.AppendText("\n" + DateTime.Now + "Something went wrong"); }

                }
            }
        }

        private void cbWebcams_SelectedIndexChanged(object sender, EventArgs e)
        {
            //initializing the camera to be used based on the selection
            manager.CurrentCamera = (Camera)cbWebcams.SelectedItem;

            //Setting the Event handler for the camera
            manager.CurrentCamera.OnImageCaptured += new EventHandler<CameraEventArgs>(CurrentCamera_OnImageCaptured);

            manager.CurrentCamera.CaptureHeight = 600;
            manager.CurrentCamera.CaptureWidth = 800;

        }
        void CurrentCamera_OnImageCaptured(object sender, CameraEventArgs e)
        {
            //Giving the feed of the camera to the picturepox
            pictureBox1.Image = manager.CurrentCamera.GetCurrentImage();
        }

        private void rescanCamBtn_Click(object sender, EventArgs e)
        {
            cbWebcams.Items.Clear();
            foreach (Camera item in manager.Cameras)
            {
                cbWebcams.Items.Add(item);
            }
        }


        private void cbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWebcams.Items.Count != 0)
            {
                cbResolution.SelectedItem.ToString().Split();
                string[] _resolution = cbResolution.SelectedItem.ToString().Split('x');
                manager.CurrentCamera.CaptureWidth = Convert.ToInt32(_resolution[0]);
                manager.CurrentCamera.CaptureHeight = Convert.ToInt32(_resolution[1]);
            }
        }

        private void imageToVideoBtn_Click(object sender, EventArgs e)
        {


            using (VideoControls pp = new VideoControls())
            {
                if (pp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }






        }
    }
}

