using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psiholog
{
    class Candidat
    {
        public int Id { get; set; }
        public string Idnp { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Patronimic { get; set; }
        public DateTime DataNastere { get; set; }
        public string LoculNastere { get; set; }


        public Candidat()
        {
            Init();
        }
        public void Init()
        {
            this.Id = -1;
            this.Idnp = "";
            this.Nume = "";
            this.Prenume = "";
            this.Patronimic = "";
            this.DataNastere = DateTime.Now.Date;
            this.LoculNastere = "";
        


    }


    }
}
