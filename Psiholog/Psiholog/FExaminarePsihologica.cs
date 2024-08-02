using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Psiholog
{
    public partial class FExaminarePsihologica : Form
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;
        private ExaminarePsihologica exampsih;
        private WExaminarePsihologica wexampsih;

        public int _idExaminarePsihologica;


        public FExaminarePsihologica(MySqlConnection _connection, int _idcandidat)
        {
            InitializeComponent();
            connection = _connection;
            exampsih = new ExaminarePsihologica();
            exampsih.IdCandidat = _idcandidat;
            wexampsih = new WExaminarePsihologica(_connection);
            _idExaminarePsihologica = 0;
            ResetForm();
        }

        private void ResetForm()
        {//initializeaza componentele din fereastra

            dateTimePickerDataExaminare.Value = DateTime.Now.Date;
            textBoxMersulExaminare.Text = "";

            exampsih.DataExaminare = DateTime.Now.Date;
            exampsih.Examinare = "";

        }

        private int Save()
        {

            exampsih.DataExaminare = dateTimePickerDataExaminare.Value.Date;
            exampsih.Examinare = textBoxMersulExaminare.Text;

            if ( exampsih.Examinare != "" )
            {
                exampsih.Id = wexampsih.Insert(exampsih);
                return Convert.ToInt32(exampsih.Id);
            }
            else
            {
                MessageBox.Show("Atentie! Nu au fost completate toate cimpurile necesare", "Completarea examinare psihologica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
            }


            return 0;
        }

        private void toolStripButtonSalvareFisa_Click(object sender, EventArgs e)
        {
            _idExaminarePsihologica = Save();
            ResetForm();
        }

        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            _idExaminarePsihologica = Save();
            ResetForm();
        }
    }
}
