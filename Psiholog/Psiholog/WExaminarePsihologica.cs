using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Psiholog
{
    class WExaminarePsihologica
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;

        public WExaminarePsihologica(MySqlConnection _connection)
        {
            connection = _connection;
        }

        public void Closeconnection()
        {
            connection.Close();
        }

        public int Insert(ExaminarePsihologica _examinarepsihologica)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("InsertExaminarePsihologica", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter id = new MySqlParameter("_Id", _examinarepsihologica.Id) { Direction = ParameterDirection.Output };
            MySqlParameter idcandidat = new MySqlParameter("_IdCandidat", _examinarepsihologica.IdCandidat);
            MySqlParameter dataexaminare = new MySqlParameter("_DATA", _examinarepsihologica.DataExaminare);
            MySqlParameter examinare = new MySqlParameter("_EXAMINARE", _examinarepsihologica.Examinare);
          
            cmd.Parameters.Add(id);
            cmd.Parameters.Add(idcandidat);
            cmd.Parameters.Add(dataexaminare);
            cmd.Parameters.Add(examinare);
      
            cmd.ExecuteNonQuery();

            connection.Close();
            return Convert.ToInt32(id.Value);
        }

        public MySqlDataReader SelectExaminareByIdCandidat(int _idcandidat)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectExaminarePsihologicaByIdCandidat", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_IdCandidat", _idcandidat));
            
            dr = cmd.ExecuteReader();

            return dr;

        }


        public string SelectExaminareByIdExaminare(int _idexaminiarepsih)
        {
            string examinare = "";
            if(_idexaminiarepsih > 0)
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Open();
                }
                else
                    connection.Open();

                MySqlCommand cmd = new MySqlCommand("SelectExaminarePsihologicaById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("_Id", _idexaminiarepsih));

                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        examinare = dr["examinare"].ToString();                        
                    }
                    dr.Close();
                }
                return examinare;
            }
            else
                return examinare;
        }




    }
}
