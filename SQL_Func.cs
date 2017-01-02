using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace WindowsApp1
{
    public class Database
    {
        private string server;
        private string database;
        private string login;
        private string password;        

        private MySqlConnection connection;

        public MySqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }


        public Database()
        {            
            server = "localhost";
            database = "filmy_base";
            login = "root";
            password = "password";
            connection = new MySqlConnection("SERVER=" + server + ";DATABASE=" + database + ";UID=" + login + ";PASSWORD=" + password + ";");      
        }
        
        public bool Open()
        {
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return connection.Ping();
        }      
       
        public bool Ping()
        {

            this.Open();
            bool ping = connection.Ping();
            this.Close();
            return ping;      
        }

        public bool Close()
        {
            if(connection.Ping())
            {
                connection.Close();
                return true;               
            }
            return false;
        }

        public string Get(int id)
        {
            string ret = null;
            try
            {
                this.Open();                                             
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;            
            }            
            MySqlCommand command = new MySqlCommand("SELECT * FROM filmy WHERE id=" + id, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ret = "Id: " + reader[0].ToString() + " Tytuł: " + reader[1].ToString() + " Rok: " + reader[2].ToString() + " Gatunek: " + reader[3].ToString() + "\n";
            }
            reader.Close();
            this.Close();
            return ret;            
        }
        
    }
}
