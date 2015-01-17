using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ProftaakOefening
{
    class Person
    {

         //fields heten deze dingen toch
        private int personID;
        private string name;
        private int age;
        private string gender;

        //maak dingetje aan
        public Person(int personID, string name, int age, string gender)
        {
            this.personID = personID;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public static List<Person> Laden()
        {
            // Voer een select-query uit om alle studenten uit te lezen
            Database.Query = "SELECT * FROM Person";
            Database.OpenConnection();

            // De reader is een while loop die alle queries een voor een doorloopt
            SQLiteDataReader reader = Database.Command.ExecuteReader();

            // nieuwe lijst maken die alle personen gaat laten zien
            List<Person> personen = new List<Person>();
            while (reader.Read())
            {
                //alle personen pakken
                personen.Add(new Person(Convert.ToInt32(reader["personID"]),
                                         Convert.ToString(reader["name"]),
                                         Convert.ToInt32(reader["age"]),
                                         Convert.ToString(reader["gender"])
                                         ));
            }

            Database.CloseConnection();

            //return lijst personen
            return personen;
        }

        public static bool VoegToe(int personID, string name, int age, string gender)
        {
            // Bouw de insert-query op met de gegeven informatie
            Database.Query = "INSERT INTO Person (personID, name, age, gender) values (" + personID + ", '" + name + "'" +", " + age + ", '" + gender + "')";
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
                // deze insert niet meer zou zijn. Het is dus niet toegevoegd.
                if (e.ErrorCode == 19)
                {
                }
            }

            Database.CloseConnection();
            return success;
        }

        public static void Verwijder(Person person)
        {
            // Bouw de query op om de gegeven student te verwijderen
            Database.Query = "DELETE FROM Person WHERE personID=" + person.personID;
            Database.OpenConnection();

            Database.Command.ExecuteScalar();

            Database.CloseConnection();
        }

        public override string ToString()
        {
            return personID + " - " + name + ", " + age + " years old, " + gender + ".";
        }
        public int PersonID   // the Name property
        {
            get
            {
                return personID;
            }
            set 
            {
                personID  = value; 
            }
        }
    }
}

