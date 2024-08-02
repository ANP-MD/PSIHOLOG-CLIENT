using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Psiholog
{
    class WStatutFisaPersonala : Clasificator
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;
        protected int id;
        protected string denumire;

        public WStatutFisaPersonala(MySqlConnection _connection)
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
            MySqlCommand cmd = new MySqlCommand("SelectStatut", connection);
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

            MySqlCommand cmd = new MySqlCommand("SelectStatutByName", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter denumire = new MySqlParameter("_Denumire", _paramsearch);
            cmd.Parameters.Add(denumire);

            dr = cmd.ExecuteReader();

            return dr;

        }

        public string SelectDenumireById(int _id)
        {
            /*  string denumire = "";
              if (connection.State == ConnectionState.Open)
              {
                  connection.Close();
                  connection.Open();
              }
              else
                  connection.Open();

              MySqlCommand cmd = new MySqlCommand("SelectUnitateById", connection);
              cmd.CommandType = CommandType.StoredProcedure;

              MySqlParameter id = new MySqlParameter("_idUnitate", _id);
              cmd.Parameters.Add(id);

              dr = cmd.ExecuteReader();

              if (dr.Read() && (!dr.IsDBNull(0)))
              {
                  denumire = dr["denumire"].ToString();

              }
              return denumire;
              */
            return "";
        }


    }
}
