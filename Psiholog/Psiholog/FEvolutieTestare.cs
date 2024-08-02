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
    public partial class FEvolutieTestare : Form
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;
        protected FCautClasificator fcc;
        private EvolutieTestare test;
        private WEvolutieTestare wtest;
        private int idfisacurent;



        public FEvolutieTestare()
        {
            InitializeComponent();
        }

        public FEvolutieTestare(MySqlConnection _connection, int _idfisa)
        {
            InitializeComponent();
            connection = _connection;
            test = new EvolutieTestare();
            wtest = new WEvolutieTestare(_connection);
            ResetForms();
            idfisacurent = _idfisa;
            test.IdFisa = _idfisa;
            InitListaTeste(_idfisa);//initiaza lista de teste    
            GetMaxTestareByIdFisa(_idfisa); //initializaeaza Test
            if(test.Id > 0)
            {
                InitFormsByIdTest(test);
            }
        }

        public FEvolutieTestare(MySqlConnection _connection, int _idfisa, int _idevolutietest)
        {
            InitializeComponent();
            connection = _connection;
            test = new EvolutieTestare();
            wtest = new WEvolutieTestare(_connection);
            ResetForms();
            test.IdFisa = _idfisa;
            test.Id = _idevolutietest;
            idfisacurent = _idfisa;

         //   SelectFisaByIdCandidat(_idcandidat);
        }

        private void InitListaTeste(int _idfisa)
        {
           // MessageBox.Show("-"+_idfisa.ToString());

            MySqlDataReader dr;

            dr = wtest.SelectAllFisaByIdFisa(_idfisa);

            int count = 0;
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    listViewRezultatExaminare.Items.Add(Convert.ToDateTime(dr["DataEvaluare"]).Date.ToString("dd.MM.yyyy"));
                    count = listViewRezultatExaminare.Items.Count;
                    listViewRezultatExaminare.Items[count - 1].Name = dr["Id"].ToString();
                    listViewRezultatExaminare.Items[count - 1].SubItems.Add(dr["Statut"].ToString());

                }
                dr.Close();
            }
            else
            {
                listViewRezultatExaminare.Items.Clear();
            }


        }

        private void ResetForms()
        {            
            dateTimePickerDataExaminare.Value = DateTime.Now.Date;

            textBoxDomiciliu.Text = "";
            textBoxStareCivila.Text = "";
            textBoxFunctia.Text = "";
            textBoxGradul.Text = "";
            textBoxInstitutia.Text = "";
            textBoxMotivExaminare.Text = "";
            textBoxConcluzieTestare.Text = "";
            test.Init();
            test.IdFisa = idfisacurent;

        }

        private void GetMaxTestareByIdFisa (int _idfisa)
        {

            test = wtest.SelectMaxTestareByIdFisa(_idfisa);
        }


        private void InitFormsByIdTest(EvolutieTestare _test)
        {
            dateTimePickerDataExaminare.Value = _test.DataEvaluare.Date;

            textBoxDomiciliu.Text = _test.Domiciliu;
            textBoxStareCivila.Text = _test.StareCivil;
            textBoxFunctia.Text = _test.Functia;
            textBoxGradul.Text = _test.Gradul;
            textBoxInstitutia.Text = _test.Institutia;
            textBoxMotivExaminare.Text = _test.MotivExaminare;
            textBoxConcluzieTestare.Text = _test.Statut;

        }

        private void buttonCautStareCivila_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WStareCivila(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdStareCivil = fcc.GetIdClasificator();
                textBoxStareCivila.Text = fcc.GetDenumireClasificator();
                test.StareCivil = textBoxStareCivila.Text;
            }
        }

        private void buttonCautGradul_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WGradul(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdGradul = fcc.GetIdClasificator();
                textBoxGradul.Text = fcc.GetDenumireClasificator();
                test.Gradul = textBoxGradul.Text;
            }
        }

        private void buttonCautPenitenciar_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WPenitenciare(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdInstitutia = fcc.GetIdClasificator();
                textBoxInstitutia.Text = fcc.GetDenumireClasificator();
                test.Institutia = textBoxInstitutia.Text;
            }
        }

        private void buttonMotivExaminare_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WMotivExaminare(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdMotivExaminare = fcc.GetIdClasificator();
                textBoxMotivExaminare.Text = fcc.GetDenumireClasificator();
                test.MotivExaminare = textBoxMotivExaminare.Text;
            }
        }

        private void buttonCautConcluzie_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WStatutFisaPersonala(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdStatut = fcc.GetIdClasificator();
                textBoxConcluzieTestare.Text = fcc.GetDenumireClasificator();
                test.Statut = textBoxConcluzieTestare.Text;
            }
        }


        private void SaveFisa()
        {
            if (test.IdFisa>0 && test.IdInstitutia > 0 && test.IdMotivExaminare>0 && test.IdStatut > 0)
            {

                test.DataEvaluare = dateTimePickerDataExaminare.Value.Date;
                test.Domiciliu = textBoxDomiciliu.Text;
                test.Functia = textBoxFunctia.Text;


               /* candidat.Nume = textBoxNume.Text;
                candidat.Prenume = textBoxPrenume.Text;
                candidat.Patronimic = textBoxPatronimic.Text;
                candidat.DataNastere = dateTimePickerDataNasterii.Value.Date;
                candidat.LoculNastere = textBoxLoculNaterii.Text;

                if (candidat.Id <= 0)
                {
                    candidat.Id = wc.Insert(candidat);
                }
                else
                {
                    wc.Update(candidat);
                }

            */
                // MessageBox.Show(candidat.Id.ToString());
               
                if (test.Id <= 0)
                {
                    test.Id = wtest.Insert(test);
                        if (test.Id > 0)
                        { MessageBox.Show("Informatia a fost salvată cu succes !!!", "Evolutie Testare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.DialogResult = DialogResult.None;
                           }
                        else
                        {
                            MessageBox.Show("Ne pare rău, datale nu au putut fi salvate, încercați mai tîrziu."+ test.Id.ToString(), "Evolutie Testare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.DialogResult = DialogResult.None;
                        }                      

                }
                else
                {
                    wtest.Update(test);
                }


            }
            else
            {
                MessageBox.Show("Atentie! Nu au fost completate toate cimpurile necesare", "Completarea Evolutiei de Testare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
            }



        }

        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            SaveFisa();
        }

        private void toolStripButtonSalvareFisaEvolutieTestare_Click(object sender, EventArgs e)
        {
            SaveFisa();
            if(test.Id >0)
            {
                listViewRezultatExaminare.Items.Add(test.DataEvaluare.Date.ToString("dd.MM.yyyy"));
                int count = listViewRezultatExaminare.Items.Count;
                listViewRezultatExaminare.Items[count - 1].Name = test.Id.ToString();
                listViewRezultatExaminare.Items[count - 1].SubItems.Add(test.MotivExaminare + " - " + test.Statut);

            }
        }

        private void toolStripAdaugTestare_Click(object sender, EventArgs e)
        {
            ResetForms();
        }

        private void listViewRezultatExaminare_DoubleClick(object sender, EventArgs e)
        {            

            for (int i = 0; i < listViewRezultatExaminare.Items.Count; i++)
            {
                if (listViewRezultatExaminare.Items[i].Selected)
                {
                    test.Init();
                    test = wtest.SelectEvolutieTestareById(Convert.ToInt32(listViewRezultatExaminare.Items[i].Name));
                    InitFormsByIdTest(test);
                    break;
                }
            }
        }
    }
}
