using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Collections.ObjectModel;

namespace UserTasks
{
    public class DatabaseService
    {
        static SQLiteConnection _dbConnection;
        private string tableName = "";

        public void ConnectToDatabase(string databaseName)
        {

            _dbConnection = new SQLiteConnection("Data Source=" + databaseName);
        }

        public void CreateDatabase(string databaseName)
        {
            SQLiteConnection.CreateFile(databaseName);
            _dbConnection = new SQLiteConnection("Data Source=" + databaseName);
        }

        public void CreateTable(string tableName)
        {
            this.tableName = tableName;
            _dbConnection.Open();

            string query = "create table " + tableName + "(userid integer primary key autoincrement ,isikukood long, eesnimi varchar(20), perekonnanimi varchar(20), kasutajanimi varchar(20), parool varchar(20))";
            SQLiteCommand command1 = new SQLiteCommand(query, _dbConnection);
            command1.ExecuteNonQuery();
            _dbConnection.Close();
        }

        public void AddData(long isikukood, string eesnimi, string perekonnanimi, string kasutajanimi, string parool, string tableName)
        {
            _dbConnection.Open();
            string query = "SELECT COUNT(*) FROM userinfo WHERE kasutajanimi ='" + kasutajanimi + "'";
            SQLiteCommand command1 = new SQLiteCommand(query, _dbConnection);
            int count = Convert.ToInt32(command1.ExecuteScalar());
            if (count != 1) 
            {
                string query1 = "insert into " + tableName + "(isikukood, eesnimi, perekonnanimi, kasutajanimi, parool) values ('" + isikukood + "','" + eesnimi + "','" + perekonnanimi + "','" + kasutajanimi +
                "','" + parool + "')";
                SQLiteCommand command = new SQLiteCommand(query1, _dbConnection);
                command.ExecuteNonQuery();
            }

            _dbConnection.Close();
        }

        public void DeleteData(long isikukood, string tableName)
        {
            _dbConnection.Open();

            string query = "delete from " + tableName + " where isikukood ='" + isikukood + "'";
            SQLiteCommand command = new SQLiteCommand(query, _dbConnection);
            command.ExecuteNonQuery();
            _dbConnection.Close();
        }

        public ObservableCollection<string> GetData()
        {
            ObservableCollection<string> info = new ObservableCollection<string>();
            _dbConnection.Open();
            string query1 = "select * from " + tableName + " order by isikukood";
            SQLiteCommand command1 = new SQLiteCommand(query1, _dbConnection);
            SQLiteDataReader reader = command1.ExecuteReader();

            while (reader.Read())
            {
                info.Add("Isikudkood: " + reader["isikukood"] + " " + "eesnimi: " + reader["eesnimi"] + " " + "perekonnanimi: " + reader["perekonnanimi"] + " " + "kasutajanimi: " + reader["kasutajanimi"]);
            }

            _dbConnection.Close();
            return info;
        }
    }
}
