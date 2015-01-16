using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProftaakOefening
{
    class Picture
    {//////////////////////////////////////////////////////////////fuck deze nederlandse shit
        //Fields
        private string pictureID;
        private int personID;
        private string date;
        private string online;
        private string local;

        public Picture(string pictureID, int personID, string date, string online, string local)
        {
            this.pictureID = pictureID;
            this.personID = personID;
            this.date = date;
            this.online = online;
            this.local = local;
        }

        public static List<Picture> Laden(Person persoon)
        {
            // Voer een select-query uit om alle studenten uit te lezen
            int _personID = persoon.PersonID - 1;
            Database.Query = "SELECT * FROM Picture WHERE personID =" + _personID;
            Database.OpenConnection();

            // De reader is een while loop die alle queries een voor een doorloopt
            SQLiteDataReader reader = Database.Command.ExecuteReader();

            // nieuwe lijst maken die alle personen gaat laten zien
            List<Picture> pictures = new List<Picture>();
            while (reader.Read())
            {
                                         
                //alle personen pakken
                pictures.Add(new Picture(Convert.ToString(reader["pictureID"]),
                                         Convert.ToInt32(reader["personID"]),
                                         Convert.ToString(reader["Date"]),
                                         Convert.ToString(reader["onlineStorage"]),
                                         Convert.ToString(reader["localStorage"])
                                         ));
            }

            Database.CloseConnection();

            //return lijst personen
            return pictures;
        }

        public static bool VoegToe(int fotoID, Person persoon, string datum, string online, string lokaal)
        {
            // Bouw de insert-query op met de gegeven informatie
            Database.Query = "INSERT INTO Picture (pictureID, personID, Date, onlineStorage, localStorage) values (" + fotoID + ", " + persoon.PersonID + ", '" + datum + "', '" + online + "', '" + lokaal + "')";
            Database.OpenConnection();

            bool success = false;
            try
            {
                // ExecuteNonQuery wordt gebruikt als we geen gegevens verwachten van de query
                Database.Command.ExecuteNonQuery();
                success = true;
            }
            catch (SQLiteException e)
            {
                // Code 19 geeft aan dat een veld wat uniek moet zijn in de database, dit door
                // deze insert niet meer zou zijn. Het is dus niet toegevoegd. Aangezien in deze
                // applicatie deze constraint alleen op het studentnummer staat, kunnen we de
                // foutmelding heel specifiek weergeven.
                if (e.ErrorCode == 19)
                {
                }
            }

            Database.CloseConnection();
            return success;
        }

        public static void Verwijder(Picture picture)
        {
            // Bouw de query op om de gegeven student te verwijderen
            Database.Query = "DELETE FROM Picture WHERE pictureID=\"" + picture.pictureID + "\"";
            Database.OpenConnection();

            // Foutafhandling is hier achterwege gelaten: gaat er iets mis, probeer dan de
            // onderliggende reden te vinden en deze op te lossen. ExecuteScalar wordt
            // gebruikt als we willen weten hoeveel records in de database zijn aangepast
            // door de query die we uitgevoerd hebben.
            Database.Command.ExecuteScalar();

            Database.CloseConnection();
        }

        public override string ToString()
        {
            return pictureID + " - " + date + "local storage : " + local;
        }
    }
}

