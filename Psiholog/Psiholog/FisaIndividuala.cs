using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psiholog
{
    class FisaIndividuala
    {

        public int Id { get; set; }
        public int IdCandidat { get; set; }
        public int NrFisa { get; set; }
        public int IndexNrfisa { get; set; }
        public DateTime DataEvaluare { get; set; }
        public string Domiciliu { get; set; }
        public string Traume { get; set; }
        public string Family { get; set; }
        public int IdStareCivil { get; set; }
        public string StareCivil { get; set; }
        public int IdStudii { get; set; }
        public string Studii { get; set; }
        public string Specialitate { get; set; }
        public string ExperientaProfesionala { get; set; }
        public string Functia { get; set; }
        public int IdGradul { get; set; }
        public string Gradul { get; set; }
        public int IdInstitutia { get; set; }
        public string Institutia { get; set; }
        public int IdMotivExaminare { get; set;}
        public string MotivExaminare { get; set; }
        public string MotivatieAngajare { get; set; }
        public string Nota { get; set; }
        public string CaracteristicIndividual { get; set; }
        public string CaracteristicEmotionala { get; set; }
        public string CaracteristicMotivationala { get; set; }
        public string PercepereaProprie { get; set; }
        public string CaracteristicComunicare { get; set; }
        public string CaracteristicProfesionala { get; set; }
        public string Concluzie { get; set; }
        public string ActivitateProfesionala { get; set; }
        public string ExaminareInterventie { get; set; }

        public int IdStatut { get; set; }
        public string Statut { get; set; }


        public FisaIndividuala()
        {
            Init();
        }
        public void Init()
        {
            Id = -1;
            IdCandidat = 0;
            NrFisa = 1;
            IndexNrfisa = 0;
            DataEvaluare = DateTime.Now.Date;

            Domiciliu = "";
            Traume = "";
            Family = "";
            IdStareCivil = 1;
            StareCivil = "";
            IdStudii = 1;
            Studii = "";
            Specialitate = "";
            ExperientaProfesionala = "";
            Functia = "";
            IdGradul = 1;
            Gradul = "";
            IdInstitutia = 1;
            Institutia = "";
            IdMotivExaminare = 1;
            MotivExaminare = "";   
            MotivatieAngajare = "";
            Nota = "";
            IdStareCivil = 0;
            Statut = "";

            CaracteristicIndividual = "";
            CaracteristicEmotionala = "";
            CaracteristicMotivationala = "";
            PercepereaProprie = "";
            CaracteristicComunicare = "";
            CaracteristicProfesionala = "";
            Concluzie = "";
            ActivitateProfesionala = "";
            ExaminareInterventie = "";
    }

    }
}
