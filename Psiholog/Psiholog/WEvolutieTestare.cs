using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Psiholog
{
    class WEvolutieTestare
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;

        public WEvolutieTestare(MySqlConnection _connection)
        {
            connection = _connection;
        }

        public void Closeconnection()
        {
            connection.Close();
        }

        public int Update(EvolutieTestare _testare)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("UpdateEvolutieTestare", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_Id", _testare.Id));
            //cmd.Parameters.Add(new MySqlParameter("_IdFisa", _testare.IdFisa)); 
            cmd.Parameters.Add(new MySqlParameter("_DataEvaluare", _testare.DataEvaluare));
            cmd.Parameters.Add(new MySqlParameter("_Domiciliu", _testare.Domiciliu));  
            cmd.Parameters.Add(new MySqlParameter("_IdStareCivila", _testare.IdStareCivil)); 
            cmd.Parameters.Add(new MySqlParameter("_Functia", _testare.Functia));
            cmd.Parameters.Add(new MySqlParameter("_IdGradul", _testare.IdGradul));
            cmd.Parameters.Add(new MySqlParameter("_IdInstitutia", _testare.IdInstitutia));
            cmd.Parameters.Add(new MySqlParameter("_IdMotivExaminare", _testare.IdMotivExaminare));  
            cmd.Parameters.Add(new MySqlParameter("_IdStatut", _testare.IdStatut));
 
            int i = cmd.ExecuteNonQuery();

            connection.Close();
            return i;
        }



        public int Insert(EvolutieTestare _testare)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("InsertEvolutieTestare", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add( new MySqlParameter("_Id", _testare.Id) { Direction = ParameterDirection.Output });
            cmd.Parameters.Add( new MySqlParameter("_IdFisa", _testare.IdFisa));
            cmd.Parameters.Add(new MySqlParameter("_DataEvaluare", _testare.DataEvaluare));
            cmd.Parameters.Add(new MySqlParameter("_Domiciliu", _testare.Domiciliu));  
            cmd.Parameters.Add(new MySqlParameter("_IdStareCivil", _testare.IdStareCivil));
            cmd.Parameters.Add(new MySqlParameter("_Functia", _testare.Functia));
            cmd.Parameters.Add(new MySqlParameter("_IdGradul", _testare.IdGradul));
            cmd.Parameters.Add(new MySqlParameter("_IdInstitutia", _testare.IdInstitutia));
            cmd.Parameters.Add(new MySqlParameter("_IdMotivExaminare", _testare.IdMotivExaminare));
            cmd.Parameters.Add(new MySqlParameter("_IdStatut", _testare.IdStatut));

            _testare.Id = cmd.ExecuteNonQuery();
            
            connection.Close();
            _testare.Id = Convert.ToInt32(cmd.Parameters["_Id"].Value);

            return _testare.Id;
        }


        public MySqlDataReader SelectAllFisaByIdFisa(int _idfisa)
        {
            /*return onli DataTestare and Statut/IdStatut*/
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectAllEvolutieTestare", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_IdFisa", _idfisa));

            dr = cmd.ExecuteReader();

          //  FisaIndividuala fisa = new FisaIndividuala();

            return dr; 
        }

        public EvolutieTestare SelectMaxTestareByIdFisa(int _idfisa)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectMaxTestareByIdFisa", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_IdFisa", _idfisa));
           
            dr = cmd.ExecuteReader();

            EvolutieTestare testare = new EvolutieTestare();

            if (dr.Read() && (!dr.IsDBNull(0)))
            {
                testare.Id = Convert.ToInt32(dr["id"]);
                testare.IdFisa = Convert.ToInt32(dr["idfisa"]);
                testare.DataEvaluare = Convert.ToDateTime(dr["dataevaluare"]);
                testare.Domiciliu = dr["domiciliu"].ToString();
                testare.IdStareCivil = Convert.ToInt32(dr["idstarecivil"]);
                testare.StareCivil = dr["starecivila"].ToString();
                testare.Functia = dr["functia"].ToString();
                testare.IdGradul = Convert.ToInt32(dr["idgradul"]);
                testare.Gradul = dr["gradul"].ToString();
                testare.IdInstitutia = Convert.ToInt32(dr["idinstitutia"]);
                testare.Institutia = dr["institutia"].ToString();
                testare.IdMotivExaminare = Convert.ToInt32(dr["idmotivexaminare"]);
                testare.MotivExaminare = dr["motivexaminare"].ToString();
                testare.IdStatut = Convert.ToInt32(dr["idstatut"]);
                testare.Statut = dr["statut"].ToString();

            }
            connection.Close();
            return testare;

        }

        public EvolutieTestare SelectEvolutieTestareById(int _id)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectEvolutieTestareById", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_Id", _id));

            dr = cmd.ExecuteReader();

            EvolutieTestare testare = new EvolutieTestare();

            if (dr.Read() && (!dr.IsDBNull(0)))
            {
                testare.Id = Convert.ToInt32(dr["id"]);
                testare.IdFisa = Convert.ToInt32(dr["idfisa"]);
                testare.DataEvaluare = Convert.ToDateTime(dr["dataevaluare"]);
                testare.Domiciliu = dr["domiciliu"].ToString();
                testare.IdStareCivil = Convert.ToInt32(dr["idstarecivil"]);
                testare.StareCivil = dr["starecivila"].ToString();
                testare.Functia = dr["functia"].ToString();
                testare.IdGradul = Convert.ToInt32(dr["idgradul"]);
                testare.Gradul = dr["gradul"].ToString();
                testare.IdInstitutia = Convert.ToInt32(dr["idinstitutia"]);
                testare.Institutia = dr["institutia"].ToString();
                testare.IdMotivExaminare = Convert.ToInt32(dr["idmotivexaminare"]);
                testare.MotivExaminare = dr["motivexaminare"].ToString();
                testare.IdStatut = Convert.ToInt32(dr["idstatut"]);
                testare.Statut = dr["statut"].ToString();
            }
            connection.Close();
            return testare;

        }



    }
}
