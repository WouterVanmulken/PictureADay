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
    public partial class VideoControls : Form
    {
        private int personSelected;
        private string path;
        private string songPath;
        Video video = new Video();

        public int PersonSelected   // the Name property
        {
            get { return personSelected; }
            set { personSelected = value; }
        }
        public string Path   // the Name property
        {
            get { return path; }
            set { path = value; }
        }
        public string SongPath   // the Name property
        {
            get { return songPath; }
            set { songPath = value; }
        }

        public VideoControls()
        {
            InitializeComponent();
            listBox1.Items.Clear();
        }

        private void VideoControls_Load(object sender, EventArgs e)
        {
            foreach (Person persoon in Person.Laden())
            {
                listBox1.Items.Add(persoon);
            }
            groupBox1.Text = "People :" + listBox1.Items.Count;
            if (listBox1.Items.Count != -1) { listBox1.SetSelected(0, true); }
        }



        private void browseSavePathBtn_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void browseSoundFileBtn_Click(object sender, EventArgs e)
        {

            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Video File (*.wav)|*.wav";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSound.Text = openFileDialog1.FileName;

            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
                            
            if(personSelected==-1){MessageBox.Show("Please select a person/");}
            if (!Directory.Exists(textBoxSavePath.Text)) 
            { 
                MessageBox.Show("Please use a valid directory to save"); 
            }
            else if (!File.Exists(textBoxSound.Text))
            {
                MessageBox.Show("please use a valid song");
            }
            else {
                personSelected = listBox1.SelectedIndex;
                string[] splitter = listBox1.GetItemText(personSelected).Split(' ');
                Int32.TryParse(splitter[0], out personSelected);
                video.SaveVideo(textBoxSavePath.Text, textBoxSound.Text, personSelected.ToString()); this.DialogResult = DialogResult.OK; }
        }

    }
}

