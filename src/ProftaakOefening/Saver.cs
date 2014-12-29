using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProftaakOefening
{
    class Saver
    {
        public int counter = 1;//might be a little outdated since we're going to be using a database to determine which is the highest number that has been made
        string counterString;

        
        
        public  void SaveImageCapture(System.Drawing.Image image, int counter, int personID)
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
            //p stands for person and i stands for image 
            s.FileName = ("D:\\P" + personID + "I" +counterString + ".Jpeg");// Default file name
            
            string filename = s.FileName;
            System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create);
            image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
            counter++;
            
        }
        //these two classes are used to encode a image to a string and a string to a image
        public string ImageToBase64(Image image,
            System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                
                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        //code from http://www.dailycoding.com/posts/convert_image_to_base64_string_and_base64_string_to_image.aspx
    }
}
