using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psiholog
{
    class EvolutieTestare
    {

        public int Id { get; set; }
        public int IdFisa { get; set; }
        public DateTime DataEvaluare { get; set; }
        public string Domiciliu { get; set; }
        public int IdStareCivil { get; set; }
        public string StareCivil { get; set; }
        public string Functia { get; set; }
        public int IdGradul { get; set; }
        public string Gradul { get; set; }
        public int IdInstitutia { get; set; }
        public string Institutia { get; set; }
        public int IdMotivExaminare { get; set;}
        public string MotivExaminare { get; set; }

        public int IdStatut { get; set; }
        public string Statut { get; set; }


        public EvolutieTestare()
        {
            Init();
        }
        public void Init()
        {
            Id = -1;
            IdFisa = 0;
            DataEvaluare = DateTime.Now.Date;

            Domiciliu = "";
 
            IdStareCivil = 1;
            StareCivil = "";
 
            Functia = "";
            IdGradul = 1;
            Gradul = "";
            IdInstitutia = 1;
            Institutia = "";
            IdMotivExaminare = 1;
            MotivExaminare = "";   
   
            IdStareCivil = 0;
            Statut = "";
            IdStatut = 0;
    }

    }
}
