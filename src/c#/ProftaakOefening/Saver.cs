using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace ProftaakOefening
{
    class Saver
    {
        public int counter = 1;
        string counterString;
        string imageString;


        //might need to check in folder to prevent overwritting
        public void SaveImageCapture(System.Drawing.Image image, int personID)
        {

            //getting the highest pictureCount
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + Database.DatabaseFilename + ";Version=3");

            string sql = "select max(pictureIDCount) from Picture where personID=\"" + personID + "\"";
            SQLiteCommand command = new SQLiteCommand(sql, connection);

            connection.Open();
            if (command.ExecuteScalar() != DBNull.Value)
            {
                counter = Convert.ToInt32(command.ExecuteScalar());
            }
            else { counter = 0; }
            
            counter++;      //since you don't want to overwride the previous image
            connection.Close();


            //turning the counter into a counterstring
            if (counter < 10)
            {
                counterString = "0000" + counter;
            }
            else if (counter < 100)
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
            else { MessageBox.Show("Please use no more then 100000 pictures. This is a limitation because of the filename."); }



            //converting the image to a string
            imageString = ImageToBase64(image, System.Drawing.Imaging.ImageFormat.Jpeg);


            //saving to file
            SaveFileDialog s = new SaveFileDialog();

            //p stands for person and i stands for image 
            string fileStorage = "D:\\P" + personID + "I" + counterString + ".Jpeg";
            s.FileName = fileStorage;// Default file name

            //remove directory from the filename
            string filename = s.FileName;
            string[] temperaryFilenameArray = filename.Split('\\');
            filename = temperaryFilenameArray[temperaryFilenameArray.Length - 1];

            System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create);
            image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();


            //saving to database
            Database.Query = "INSERT INTO Picture (pictureID, personID, pictureIDCount, Date, onlineStorage, localStorage) values ('" + filename + "', '" + personID + "', " + counter + ", '" + DateTime.Today + "', '" + imageString + "', '" + fileStorage + "')";
            Database.OpenConnection();


            try
            {
                // ExecuteNonQuery wordt gebruikt als we geen gegevens verwachten van de query
                Database.Command.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                // Code 19 geeft aan dat een veld wat uniek moet zijn in de database, dit door
                // deze insert niet meer zou zijn. Het is dus niet toegevoegd. 
                MessageBox.Show("something went wrong. The error code is : " + e.ErrorCode.ToString() + ", For more information about what happened you can go to  https://www.sqlite.org/c3ref/c_abort.html");
            }

            Database.CloseConnection();

        }


        public bool allDatabaseImageSaver(string path)
        {
            try
            {
                Database.Query = "SELECT pictureID,onlineStorage FROM Picture";
                Database.OpenConnection();

                SQLiteDataReader reader = Database.Command.ExecuteReader();


                while (reader.Read())
                {
                    string tempPicID = Convert.ToString(reader["pictureID"]);
                    string tempOnlineStorage = Convert.ToString(reader["onlineStorage"]);

                    System.Drawing.Image tempImage = Base64ToImage(tempOnlineStorage);

                    SaveFileDialog s = new SaveFileDialog();
                    if (!File.Exists(path + tempPicID))
                    {

                        System.IO.FileStream fstream = new System.IO.FileStream(path + tempPicID, System.IO.FileMode.Create);
                        tempImage.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        fstream.Close();

                    }
                }

                Database.CloseConnection();
                return true;
            }
            catch (Exception e) { return false; }
        }



        //these two classes are used to encode a image to a string and a string to a image
        public string ImageToBase64(Image image,
            System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);                                                         //zegt dat het object op dit moment voor iets anderts word gebruikt
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
