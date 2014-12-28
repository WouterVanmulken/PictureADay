using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace ProftaakOefening
{
    class Database
    {

        // De bestandsnaam voor de database
        private static readonly string databaseFilename = "Database.sqlite";
        // Variabele voor het opzetten van de verbinding
        private static SQLiteConnection connection;
        // Variable waar de SQL-commandos tijdelijk in opgeslagen worden
        private static SQLiteCommand command;

        /// <summary>
        /// Stel de SQL query in die uitgevoerd moet gaan worden.
        /// </summary>
        public static string Query
        {
            set
            {
                // Zorg ervoor dat er een verbinding gemaakt kan worden
                PrepareConnection();
                // Stel het SQL commando in met de gegeven query
                command = new SQLiteCommand(value, connection);
            }
        }

        /// <summary>
        /// Haalt het command-object op waarmee queries uitgevoerd kunnen worden.
        /// </summary>
        public static SQLiteCommand Command
        {
            get { return command; }
        }

        /// <summary>
        /// Haal de bestandsnaam op van de database.
        /// </summary>
        public static string DatabaseFilename
        {
            get { return databaseFilename; }
        }

        /// <summary>
        /// Open de verbinding met de database
        /// </summary>
        public static void OpenConnection()
        {
            // Controleer of de verbinding niet al open is
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Sluit de verbinding met de database
        /// </summary>
        public static void CloseConnection()
        {
            // Controleer of de verbinding niet al gesloten is
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Controleert of de database al bestaat. Zo niet, wordt deze aangemaakt
        /// en gevuld met wat dummy data. Daarnaast wordt altijd de connectie opgezet
        /// met de database indien deze nog niet opgezet was.
        /// </summary>
        private static void PrepareConnection()
        {
            // Controleer of we een nieuwe database met dummy data moeten aanmaken
            bool createNew = !File.Exists("Database.sqlite");

            // Bestand bestaat niet: maak een lege database aan
            if (createNew)
            {
                SQLiteConnection.CreateFile(databaseFilename);
            }

            // Zet een verbinding op met de database
            if (connection == null)
            {
                connection = new SQLiteConnection("Data Source=" + databaseFilename + ";Version=3");
            }

            // Als we een nieuwe database gemaakt hebben, voegen we alvast wat records toe.
            // We doen dit nu pas omdat we een connection nodig hebben om te communiceren met
            // de database: vandaar dat deze code niet boven bij de CreateFile functie staat.
            if (createNew)
            {
                CreateDummyData();
            }
        }

        /// <summary>
        /// Functie die een nieuwe tabel aanmaakt op een lege database, en deze vult met een
        /// aantal records.
        /// </summary>
        private static void CreateDummyData()
        {
            OpenConnection();

            try
            {
                // Nieuwe tabel met drie kolommen: number (INT), name (VARCHAR), email (VARCHAR)
                Query = "CREATE TABLE Person (personID INT PRIMARY KEY, name VARCHAR(50), age INT, gender VARCHAR(6))";
                Command.ExecuteNonQuery();

                Query = "CREATE TABLE Picture (pictureID INT PRIMARY KEY, personID INT, Date VARCHAR(12), onlineStorage VARCHAR(500), localStorage VARCHAR(500))";
                Command.ExecuteNonQuery();

                // Voeg nieuwe rijen toe aan de database
                Query = "INSERT INTO Person (personID, name, age, gender) values (01, 'Leon', 129, 'meel')";
                Command.ExecuteNonQuery();

                Query = "INSERT INTO Picture (pictureID, personID, date, onlineStorage, localStorage) values (0001, 01, '27-12-2014', 'www.google.com', 'c:Users/Leon/Pictures/engefoto.png')";
                Command.ExecuteNonQuery();
            }
            catch (SQLiteException)
            {
                // Er is iets mis gegaan: waarschijnlijk bestond de tabel al. Voor nu is er
                // verder geen foutafhandeling nodig.
            }

            CloseConnection();
        }
    }
}
