using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Psiholog
{
   public class ConnectorBD
    {
        private string username;//nume de utilizator de acces
        private string password;//parola
        private string server;//specifica ip-ul serverului
        private string database;//specifica denumirea bazei de date
        private MySqlConnection connectionbd;
        private string connectionstring;
        
       //---------------------
        public ConnectorBD(string _username, string _password, string _server, string _database)
        {
            //constructor
            username = _username;
            password = _password;
            server = _server;
            database = _database;            
            CreateConnectionBD();
        }
        public ConnectorBD(string _server, string _database)
        {
            //constructor 2
            server = _server;
            database = _database;
        }

        private void CreateConnectionString()
        {
            connectionstring = "Server = " + server + "; port=3306; Database = " + database + "; User ID = "+username + "; Password = "+password+ "; charset=utf8;";
        }

        public void SetUser(string _username)
        {
            username = _username;
        }

        public void SetPassword(string _password)
        {
            password = _password;
        }

        public string GetConnectionString()
        {
           return connectionstring;
        }

        public string CreateConnectionBD()
        {
            CreateConnectionString();
            try
            {
                connectionbd = new MySqlConnection(connectionstring);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "";
        }

        public MySqlConnection GetConnectionBD()
        {
            return connectionbd;
        }

        public string GetUser()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }
    }//class ConnectorBD
}
