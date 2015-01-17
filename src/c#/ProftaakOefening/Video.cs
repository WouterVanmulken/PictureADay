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

                      
                      while(reader.Read()){
                          string base64 = Convert.ToString(reader["onlineStorage"]);
                          image = saver.Base64ToImage(base64);
                          videoTrack.AddImage(image);
                      }

                      // add some audio
                      ITrack audioTrack = timeline.AddAudioGroup().AddTrack();
                      IClip audio = audioTrack.AddAudio(soundFragment, 0, videoTrack.Duration);



                    // render our slideshow out to a windows media file
                    IRenderer renderer = new WindowsMediaRenderer(timeline, outputFilePath + "\\test.wmv", WindowsMediaProfiles.HighQualityVideo);
                    try { renderer.Render(); }
                    catch (Exception e) { MessageBox.Show(e.ToString()); }
                    }
                    
                }
            


        }
    }

