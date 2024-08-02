using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Psiholog
{
    class WGradul : Clasificator
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;
        protected int id;
        protected string denumire;

        public WGradul(MySqlConnection _connection)
        {
            connection = _connection;
            id = 0;
            denumire = "";
        }

        public override void Closeconnection()
        {
            //dr.Close();
            connection.Close();
            id = 0;
            denumire = "";
        }
        //---------------------------------------------
        public override MySqlDataReader GetValues()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("SelectGradul", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            return dr;
        }

        public override void Add()
        {

        }

        public override void Delete(int _id)
        {
        }

        public override void Edit(int _id)
        {
        }

        public override MySqlDataReader Search(string _paramsearch)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectGradulByName", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter denumire = new MySqlParameter("_Denumire", _paramsearch);
            cmd.Parameters.Add(denumire);

            dr = cmd.ExecuteReader();

            return dr;

        }

        public string SelectDenumireById(int _id)
        {
            return "";
        }


    }
}
