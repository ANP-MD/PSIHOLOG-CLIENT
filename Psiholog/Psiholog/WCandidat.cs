using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Psiholog
{
    
    class WCandidat
    {

        protected MySqlConnection connection;
        protected MySqlDataReader dr;

        public WCandidat(MySqlConnection _connection)
        {
            connection = _connection;
        }

        public void Closeconnection()
        {
            connection.Close();
        }


        public int Update(Candidat _candidat)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("UpdateCandidat", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter id = new MySqlParameter("_Id", _candidat.Id);
            MySqlParameter idnp = new MySqlParameter("_Idnp", _candidat.Idnp);
            MySqlParameter nume = new MySqlParameter("_Nume", _candidat.Nume);
            MySqlParameter prenume = new MySqlParameter("_Prenume", _candidat.Prenume);
            MySqlParameter patronimic = new MySqlParameter("_Patronimic", _candidat.Patronimic);
            MySqlParameter datanastere = new MySqlParameter("_DataNastere", _candidat.DataNastere);
            MySqlParameter locnastere = new MySqlParameter("_LocNastere", _candidat.LoculNastere);


            cmd.Parameters.Add(id);
            cmd.Parameters.Add(idnp);
            cmd.Parameters.Add(nume);
            cmd.Parameters.Add(prenume);
            cmd.Parameters.Add(patronimic);
            cmd.Parameters.Add(datanastere);
            cmd.Parameters.Add(locnastere);

            int i = cmd.ExecuteNonQuery();

            connection.Close();
            return i;
        }


        public int Insert(Candidat _candidat)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("InsertCandidat", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter id = new MySqlParameter("_Id", _candidat.Id) { Direction = ParameterDirection.Output };
            MySqlParameter idnp = new MySqlParameter("_Idnp", _candidat.Idnp);
            MySqlParameter nume = new MySqlParameter("_Nume", _candidat.Nume);
            MySqlParameter prenume = new MySqlParameter("_Prenume", _candidat.Prenume);
            MySqlParameter patronimic = new MySqlParameter("_Patronimic", _candidat.Patronimic);
            MySqlParameter datanastere = new MySqlParameter("_DataNastere", _candidat.DataNastere);
            MySqlParameter locnastere = new MySqlParameter("_LocNastere", _candidat.LoculNastere);
            

            cmd.Parameters.Add(id);
            cmd.Parameters.Add(idnp);
            cmd.Parameters.Add(nume);
            cmd.Parameters.Add(prenume);
            cmd.Parameters.Add(patronimic);
            cmd.Parameters.Add(datanastere);
            cmd.Parameters.Add(locnastere);

            cmd.ExecuteNonQuery();

            connection.Close();
            return Convert.ToInt32(id.Value);
        }

        public Candidat SelectCandidatById(int _idcandidat)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectCandidatById", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter id = new MySqlParameter("_Id", _idcandidat);

            cmd.Parameters.Add(id);

            dr = cmd.ExecuteReader();

            Candidat candidat = new Candidat();

            if (dr.Read() && (!dr.IsDBNull(0)))
            {
                candidat.Id = _idcandidat;
                candidat.Idnp = dr["idnp"].ToString();
                candidat.Nume = dr["nume"].ToString();
                candidat.Prenume = dr["prenume"].ToString();
                candidat.Patronimic = dr["patronimic"].ToString();
                candidat.DataNastere = Convert.ToDateTime(dr["datanastere"]);
                candidat.LoculNastere = dr["locnastere"].ToString();                
            }
            connection.Close();
            return candidat;

        }

        public MySqlDataReader SelectCandidatByNPP(string _nume,string _prenume, string _patronimic, int _idinstitutia)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            string cmdText = "";

            if (_idinstitutia > 0) cmdText = "SelectCandidatByNPPIdPenitenciar";
            else cmdText = "SelectCandidatByNPP";

            MySqlCommand cmd = new MySqlCommand(cmdText, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_Nume", _nume));
            cmd.Parameters.Add(new MySqlParameter("_Prenume", _prenume));
            cmd.Parameters.Add(new MySqlParameter("_Patronimic", _patronimic));
            if (_idinstitutia > 0) cmd.Parameters.Add(new MySqlParameter("_IdPenitenciar", _idinstitutia));

            dr = cmd.ExecuteReader();

            return dr;

          }




    }
}
