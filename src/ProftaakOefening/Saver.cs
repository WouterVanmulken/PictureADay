using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO.FileStream;

namespace ProftaakOefening
{
    class Saver
    {
        public int counter = 1;//might be a little outdated since we're going to be using a database to determine which is the highest number that has been made
        string counterString;

        
        
        public  void SaveImageCapture(System.Drawing.Image image, int counter)
        {

            if (counter < 10) 
            {
                counterString = "0000" + counter;   
            }
            else if(counter<100)
            {
                counterString = "000" + counter;
            }
            else if (counter < 1000)
            {
                counterString = "00" + counter;
            }
            else if (counter < 10000)
            {
                counterString = "0" + counter;
            }
            else if (counter < 100000)
            {
                counterString = Convert.ToString(counter);
            }
            else { MessageBox.Show("Please use no more then 10000 pictures. This is a limitation because of the filename."); }


            SaveFileDialog s = new SaveFileDialog();

            s.FileName = ("D:\\Image" + counterString + ".Jpeg");// Default file name
            
            string filename = s.FileName;
            System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create);
            image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
            counter++;
            

            

        }
    }
}
