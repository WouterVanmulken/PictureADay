using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
//using System.IO.FileStream;

namespace ProftaakOefening
{
    class Saver
    {
        int counter = 1;
        
        public  void SaveImageCapture(System.Drawing.Image image)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = ("Image"+ counter);// Default file name
            s.DefaultExt = ".Jpg";// Default file extension
            s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

             //Show save file dialog box
             //Process save file dialog box results
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string filename = s.FileName;
                System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
                counter++;
            }

        }
    }
}
