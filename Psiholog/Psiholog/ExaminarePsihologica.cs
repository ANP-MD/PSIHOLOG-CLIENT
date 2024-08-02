using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psiholog
{
    class ExaminarePsihologica
    {
        public int Id { get; set; }
        public int IdCandidat { get; set; }
        public DateTime DataExaminare { get; set; }
        public string Examinare { get; set; }

        public ExaminarePsihologica()
        {
            Init();
        }
        public void Init()
        {
            this.Id = -1;
            this.IdCandidat = -1;
            this.DataExaminare = DateTime.Now.Date;
            this.Examinare = "";



        }




    }
}
