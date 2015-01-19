using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;


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
    class Video
    {
        int iProgress;
        public void SaveVideo(string outputFilePath, string soundFragment, string personSelected)
        {
            // generates a little slide-show, with audio track and fades between images.            

            using (ITimeline timeline = new DefaultTimeline())
            {
                IGroup group = timeline.AddVideoGroup(32, 160, 100);
                ITrack videoTrack = group.AddTrack();

                Database.Query = "SELECT * FROM Picture";
                Database.OpenConnection();

                SQLiteDataReader reader = Database.Command.ExecuteReader();

                Saver saver = new Saver();
                Image image;

                int _imagecounter = 0;
                while (reader.Read())
                {
                    string base64 = Convert.ToString(reader["onlineStorage"]);
                    image = saver.Base64ToImage(base64);
                    videoTrack.AddImage(image);
                    _imagecounter++;
                }
                if (_imagecounter != 0)
                {
                    // add some audio
                    ITrack audioTrack = timeline.AddAudioGroup().AddTrack();
                    IClip audio = audioTrack.AddAudio(soundFragment, 0, videoTrack.Duration);


                    var participant = new PercentageProgressParticipant(timeline);
                    participant.ProgressChanged += new EventHandler<Splicer.Renderer.ProgressChangedEventArgs>(participant_ProgressChanged);

                    new ThreadedWorker2();


                    // render our slideshow out to a windows media file
                    IRenderer renderer = new WindowsMediaRenderer(timeline, outputFilePath + "\\test.wmv", WindowsMediaProfiles.HighQualityVideo, new ICallbackParticipant[] { participant }, null);
                    try { renderer.Render(); progresvariables.progres = 100; }
                    catch (Exception e) { MessageBox.Show(e.ToString());  }

                }
                else { MessageBox.Show("No pictures where found of this person"); }
                }

        }
        private void participant_ProgressChanged(object sender, Splicer.Renderer.ProgressChangedEventArgs e)
        {
            
            iProgress = (int)(e.Progress * 100);
            progresvariables.progres = iProgress;            
        }
    }
    public class ThreadedWorker2
    {
        Thread t2;

        public ThreadedWorker2()
        {
            t2 = new Thread(new ThreadStart(doWork2));
            t2.Start();
        }
        void doWork2()
        {
            using (ProgressBar pb = new ProgressBar())
            {
                if (pb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }



    }
    public static class progresvariables 
    {
        public static int progres;
    
    }
}

