using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Psiholog
{
    class WFisaIndividuala
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;

        public WFisaIndividuala(MySqlConnection _connection)
        {
            connection = _connection;
        }

        public void Closeconnection()
        {
            connection.Close();
        }

        public int Update(FisaIndividuala _fisa)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("UpdateFisaIndividuala", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_Id", _fisa.Id));
            cmd.Parameters.Add(new MySqlParameter("_IdCandidat", _fisa.IdCandidat));
            cmd.Parameters.Add(new MySqlParameter("_NrFisa", _fisa.NrFisa));
            cmd.Parameters.Add(new MySqlParameter("_IndiceNrfisa", _fisa.IndexNrfisa));
            cmd.Parameters.Add(new MySqlParameter("_DataEvaluare", _fisa.DataEvaluare));
            cmd.Parameters.Add(new MySqlParameter("_Domiciliu", _fisa.Domiciliu));
            cmd.Parameters.Add(new MySqlParameter("_Traume", _fisa.Traume));
            cmd.Parameters.Add(new MySqlParameter("_Family", _fisa.Family));
            cmd.Parameters.Add(new MySqlParameter("_IdStareCivil", _fisa.IdStareCivil));
            cmd.Parameters.Add(new MySqlParameter("_IdStudii", _fisa.IdStudii));
            cmd.Parameters.Add(new MySqlParameter("_Specialitate", _fisa.Specialitate));
            cmd.Parameters.Add(new MySqlParameter("_ExperientaProfesionala", _fisa.ExperientaProfesionala));
            cmd.Parameters.Add(new MySqlParameter("_Functia", _fisa.Functia));
            cmd.Parameters.Add(new MySqlParameter("_IdGradul", _fisa.IdGradul));
            cmd.Parameters.Add(new MySqlParameter("_IdInstitutia", _fisa.IdInstitutia));
            cmd.Parameters.Add(new MySqlParameter("_IdMotivExaminare", _fisa.IdMotivExaminare));
            cmd.Parameters.Add(new MySqlParameter("_MotivatieAngajare", _fisa.MotivatieAngajare));
            cmd.Parameters.Add(new MySqlParameter("_Nota", _fisa.Nota));
            cmd.Parameters.Add(new MySqlParameter("_IdStatut", _fisa.IdStatut));

            cmd.Parameters.Add(new MySqlParameter("_CaracteristicIndividual", _fisa.CaracteristicIndividual));
            cmd.Parameters.Add(new MySqlParameter("_CaracteristicEmotionala", _fisa.CaracteristicEmotionala));
            cmd.Parameters.Add(new MySqlParameter("_CaracteristicMotivationala", _fisa.CaracteristicMotivationala));
            cmd.Parameters.Add(new MySqlParameter("_PercepereaProprie", _fisa.PercepereaProprie));
            cmd.Parameters.Add(new MySqlParameter("_CaracteristicComunicare", _fisa.CaracteristicComunicare));
            cmd.Parameters.Add(new MySqlParameter("_CaracteristicProfesionala", _fisa.CaracteristicProfesionala));
            cmd.Parameters.Add(new MySqlParameter("_Concluzie", _fisa.Concluzie));
            cmd.Parameters.Add(new MySqlParameter("_ActivitateProfesionala", _fisa.ActivitateProfesionala));
            cmd.Parameters.Add(new MySqlParameter("_ExaminareInterventie", _fisa.ExaminareInterventie));

            int i = cmd.ExecuteNonQuery();

            connection.Close();
            return i;
        }



        public int Insert(FisaIndividuala _fisa)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("InsertFisaIndividuala", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_Id", _fisa.Id) { Direction = ParameterDirection.Output });
            cmd.Parameters.Add(new MySqlParameter("_IdCandidat", _fisa.IdCandidat));
            cmd.Parameters.Add(new MySqlParameter("_NrFisa", _fisa.NrFisa));
            cmd.Parameters.Add(new MySqlParameter("_IndiceNrfisa", _fisa.IndexNrfisa));
            cmd.Parameters.Add(new MySqlParameter("_DataEvaluare", _fisa.DataEvaluare));
            cmd.Parameters.Add(new MySqlParameter("_Domiciliu", _fisa.Domiciliu));
            cmd.Parameters.Add(new MySqlParameter("_Traume", _fisa.Traume));
            cmd.Parameters.Add(new MySqlParameter("_Family", _fisa.Family));
            cmd.Parameters.Add(new MySqlParameter("_IdStareCivil", _fisa.IdStareCivil));
            cmd.Parameters.Add(new MySqlParameter("_IdStudii", _fisa.IdStudii));
            cmd.Parameters.Add(new MySqlParameter("_Specialitate", _fisa.Specialitate));
            cmd.Parameters.Add(new MySqlParameter("_ExperientaProfesionala", _fisa.ExperientaProfesionala));
            cmd.Parameters.Add(new MySqlParameter("_Functia", _fisa.Functia));
            cmd.Parameters.Add(new MySqlParameter("_IdGradul", _fisa.IdGradul));
            cmd.Parameters.Add(new MySqlParameter("_IdInstitutia", _fisa.IdInstitutia));
            cmd.Parameters.Add(new MySqlParameter("_IdMotivExaminare", _fisa.IdMotivExaminare));
            cmd.Parameters.Add(new MySqlParameter("_MotivatieAngajare", _fisa.MotivatieAngajare));
            cmd.Parameters.Add(new MySqlParameter("_Nota", _fisa.Nota));
            cmd.Parameters.Add(new MySqlParameter("_IdStatut", _fisa.IdStatut));

            cmd.Parameters.Add(new MySqlParameter("_CaracteristicIndividual", _fisa.CaracteristicIndividual));
            cmd.Parameters.Add(new MySqlParameter("_CaracteristicEmotional", _fisa.CaracteristicEmotionala));
            cmd.Parameters.Add(new MySqlParameter("_CaracteristicMotivationala", _fisa.CaracteristicMotivationala));
            cmd.Parameters.Add(new MySqlParameter("_PercepereaProprie", _fisa.PercepereaProprie));
            cmd.Parameters.Add(new MySqlParameter("_CaracteristicComunicare", _fisa.CaracteristicComunicare));
            cmd.Parameters.Add(new MySqlParameter("_CaracteristicProfesionala", _fisa.CaracteristicProfesionala));
            cmd.Parameters.Add(new MySqlParameter("_Concluzie", _fisa.Concluzie));
            cmd.Parameters.Add(new MySqlParameter("_ActivitateProfesionala", _fisa.ActivitateProfesionala));
            cmd.Parameters.Add(new MySqlParameter("_ExaminareInterventie", _fisa.ExaminareInterventie));

            _fisa.Id = cmd.ExecuteNonQuery();

            connection.Close();
            _fisa.Id = Convert.ToInt32(cmd.Parameters["_Id"].Value);
            return _fisa.Id;
        }


        public MySqlDataReader SelectAllFisaByIdCandidat(int _idcandidat)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectAllFisaByIdCandidat", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_IdCandidat", _idcandidat));

            dr = cmd.ExecuteReader();

            FisaIndividuala fisa = new FisaIndividuala();

            return dr;


        }

        public FisaIndividuala SelectFisaByIdCandidat(int _idcandidat)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectFisaByIdCandidat", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_IdCandidat", _idcandidat));

            dr = cmd.ExecuteReader();

            FisaIndividuala fisa = new FisaIndividuala();

            if (dr.Read() && (!dr.IsDBNull(0)))
            {
                fisa.Id = Convert.ToInt32(dr["id"]);
                fisa.IdCandidat = Convert.ToInt32(dr["idcandidat"]);
                fisa.NrFisa = Convert.ToInt32(dr["nrfisa"]);
                fisa.IndexNrfisa = Convert.ToInt32(dr["indicenrfisa"]);
                fisa.DataEvaluare = Convert.ToDateTime(dr["dataevaluare"]);
                /* fisa.Domiciliu = dr["domiciliu"].ToString();*/
                fisa.Traume = dr["traume"].ToString();
                fisa.Family = dr["family"].ToString();
                /*  fisa.IdStareCivil = Convert.ToInt32(dr["idstarecivil"]);
                  fisa.StareCivil = dr["starecivila"].ToString();*/
                fisa.IdStudii = Convert.ToInt32(dr["idstudii"]);
                fisa.Studii = dr["studii"].ToString();
                fisa.Specialitate = dr["specialitate"].ToString();
                fisa.ExperientaProfesionala = dr["experientaprofesionala"].ToString();
                /*  fisa.Functia = dr["functia"].ToString();
                  fisa.IdGradul = Convert.ToInt32(dr["idgradul"]);
                  fisa.Gradul = dr["gradul"].ToString();
                  fisa.IdInstitutia = Convert.ToInt32(dr["idinstitutia"]);
                  fisa.Institutia = dr["institutia"].ToString();
                  fisa.IdMotivExaminare = Convert.ToInt32(dr["idmotivexaminare"]);
                  fisa.MotivExaminare = dr["motivexaminare"].ToString();*/
                fisa.MotivatieAngajare = dr["motivatieangajare"].ToString();
                fisa.Nota = dr["nota"].ToString();
                /* fisa.IdStatut = Convert.ToInt32(dr["idstatut"]);
                 fisa.Statut = dr["statut"].ToString();*/
                fisa.CaracteristicIndividual = dr["caracteristicindividual"].ToString();
                fisa.CaracteristicEmotionala = dr["caracteristicemotionala"].ToString();
                fisa.CaracteristicMotivationala = dr["caracteristicmotivationala"].ToString();
                fisa.PercepereaProprie = dr["percepereaproprie"].ToString();
                fisa.CaracteristicComunicare = dr["caracteristiccomunicare"].ToString();
                fisa.CaracteristicProfesionala = dr["caracteristicprofesionala"].ToString();
                fisa.Concluzie = dr["concluzie"].ToString();
                fisa.ActivitateProfesionala = dr["activitateprofesionala"].ToString();
                fisa.ExaminareInterventie = dr["examinareinterventie"].ToString();

            }
            connection.Close();
            return fisa;

        }

        public MySqlDataReader IsFisaNrFisaExist(int _NrFisa)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("IsNrFisaExist", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_NrFisa", _NrFisa));

            dr = cmd.ExecuteReader();

            FisaIndividuala fisa = new FisaIndividuala();

            return dr;

        }


        public FisaIndividuala SelectMaxFisaByIdCandidat(int _idcandidat)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectMaxFisaByIdCandidat", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_IdCandidat", _idcandidat));

            dr = cmd.ExecuteReader();

            FisaIndividuala fisa = new FisaIndividuala();

            if (dr.Read() && (!dr.IsDBNull(0)))
            {
                fisa.Id = Convert.ToInt32(dr["id"]);
                fisa.IdCandidat = Convert.ToInt32(dr["idcandidat"]);
                fisa.NrFisa = Convert.ToInt32(dr["nrfisa"]);
                fisa.IndexNrfisa = Convert.ToInt32(dr["indicenrfisa"]);
                fisa.DataEvaluare = Convert.ToDateTime(dr["dataevaluare"]);
                fisa.Domiciliu = dr["domiciliu"].ToString();
                fisa.Traume = dr["traume"].ToString();
                fisa.Family = dr["family"].ToString();
                fisa.IdStareCivil = Convert.ToInt32(dr["idstarecivil"]);
                fisa.StareCivil = dr["starecivila"].ToString();
                fisa.IdStudii = Convert.ToInt32(dr["idstudii"]);
                fisa.Studii = dr["studii"].ToString();
                fisa.Specialitate = dr["specialitate"].ToString();
                fisa.ExperientaProfesionala = dr["experientaprofesionala"].ToString();
                fisa.Functia = dr["functia"].ToString();
                fisa.IdGradul = Convert.ToInt32(dr["idgradul"]);
                fisa.Gradul = dr["gradul"].ToString();
                fisa.IdInstitutia = Convert.ToInt32(dr["idinstitutia"]);
                fisa.Institutia = dr["institutia"].ToString();
                fisa.IdMotivExaminare = Convert.ToInt32(dr["idmotivexaminare"]);
                fisa.MotivExaminare = dr["motivexaminare"].ToString();
                fisa.MotivatieAngajare = dr["motivatieangajare"].ToString();
                fisa.Nota = dr["nota"].ToString();
                fisa.IdStatut = Convert.ToInt32(dr["idstatut"]);
                fisa.Statut = dr["statut"].ToString();
                fisa.CaracteristicIndividual = dr["caracteristicindividual"].ToString();
                fisa.CaracteristicEmotionala = dr["caracteristicemotionala"].ToString();
                fisa.CaracteristicMotivationala = dr["caracteristicmotivationala"].ToString();
                fisa.PercepereaProprie = dr["percepereaproprie"].ToString();
                fisa.CaracteristicComunicare = dr["caracteristiccomunicare"].ToString();
                fisa.CaracteristicProfesionala = dr["caracteristicprofesionala"].ToString();
                fisa.Concluzie = dr["concluzie"].ToString();
                fisa.ActivitateProfesionala = dr["activitateprofesionala"].ToString();
                fisa.ExaminareInterventie = dr["examinareinterventie"].ToString();

            }
            connection.Close();
            return fisa;

        }


    }
}
