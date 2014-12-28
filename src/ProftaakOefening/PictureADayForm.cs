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
using System.IO;
using System.IO.Ports;

namespace ProftaakOefening
{

    public partial class PictureADayForm : Form
    {
        WebCam webcam;
        Saver saver = new Saver();
        List<Person> people = new List<Person>();

        public PictureADayForm()
        {
            InitializeComponent();

            //webcam
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
            //webcam.Start();

            //add comports and connects it
            rescanBtn_Click(null, null);
            if (serialPortSelectionBox.Items.Count != 0) { serialPortSelectionBox.SelectedIndex = 0; }//connectBtn_Click(null, null); MessageBox.Show("Connection to arduino has been established"); }
            else { MessageBox.Show("No connected devices found."); }

            serialPort1.BaudRate = 9600;
            serialPort1.NewLine = "#";

        }
        private void bntStart_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            pictureBox1.Image = null;
        }

        private void bntVideoFormat_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void bntVideoSource_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void Save_click(object sender, EventArgs e)
        {
            saver.SaveImageCapture(pictureBox1.Image, saver.counter);//saver.counter is niet goed genoeg dit moet met sql worden opgeslagen of deze button moet worden opgeheven.
            pictureBox2.Image = pictureBox1.Image;
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
                    MessageBox.Show("Could not connect to the given serial port: " + exception.Message);
                }
            }

        }


        private void toevoegenBtn_Click(object sender, EventArgs e)
        {
            PopUpForm popup = new PopUpForm();

            // Show testDialog as a modal dialog and determine if DialogResult = OK. 
            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox. 
                //this.txtResult.Text = testDialog.TextBox1.Text;
            }
            else
            {
                //this.txtResult.Text = "Cancelled";
            }
            popup.Dispose();

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //dit word gebruikt om te reageren op de arduino
            
            switch (serialPort1.ReadLine())
            {
                case "0":
                    MessageBox.Show("0");
                    break;
                case "1":
                    MessageBox.Show("1");
                    break;
                case "2":
                    MessageBox.Show("2");
                    break;
                case "3":
                    MessageBox.Show("3");
                    break;
                case "4":
                    MessageBox.Show("4");
                    break;
                case "5":
                    MessageBox.Show("5");
                    break;
                case "6":
                    MessageBox.Show("6");
                    break;
                case "7":
                    MessageBox.Show("7");
                    break;
                case "8":
                    MessageBox.Show("8");
                    break;
                case "9":
                    MessageBox.Show("9");
                    break;

                default:
                    MessageBox.Show(serialPort1.ReadChar().ToString());
                   // MessageBox.Show("something went wrong");
                    break;
            }
            //needs some work
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

    }
}

