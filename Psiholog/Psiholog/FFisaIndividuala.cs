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
    public partial class FFisaIndividuala : Form
    {

        protected MySqlConnection connection;
        protected MySqlDataReader dr;
        protected FCautClasificator fcc;
        private Candidat candidat;
        private WCandidat wc;

        private FisaIndividuala fisa;
        private EvolutieTestare test;
        private WFisaIndividuala wfi;
        private WEvolutieTestare wtest;

        public FFisaIndividuala()
        {
            InitializeComponent();
            ResetForms();
            MessageBox.Show("Eroare! Fisa Personala nu a fost inițializată cu date !", "Completarea Fisei informative", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.None;


        }

        public FFisaIndividuala(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            candidat = new Candidat();
            wc = new WCandidat(_connection);

            fisa = new FisaIndividuala();
            test = new EvolutieTestare();
            wfi = new WFisaIndividuala(_connection);
            wtest = new WEvolutieTestare(_connection);

            ResetForms();


        }

        public FFisaIndividuala(MySqlConnection _connection, int _idcandidat)
        {
            InitializeComponent();
            connection = _connection;
            candidat = new Candidat();
            wc = new WCandidat(_connection);

            fisa = new FisaIndividuala();
            test = new EvolutieTestare();
            wfi = new WFisaIndividuala(_connection);
            wtest = new WEvolutieTestare(_connection);
            ResetForms();

            labelArhiv.Visible = true;
            comboBoxArhivFisaIndividuala.Visible = true;

            SelectFisaByIdCandidat(_idcandidat);
           
        }

        private void SelectFisaByIdCandidat(int _idcandidat)
        {
            candidat = wc.SelectCandidatById(_idcandidat);
            fisa = wfi.SelectFisaByIdCandidat(_idcandidat);       
                 
            test = wtest.SelectMaxTestareByIdFisa(fisa.Id);           

            test.IdFisa = fisa.Id;
            InitFormWithData();
        }

        private void InitFormWithData()
        {
            if(candidat.Id > 0 )
              {
                textBoxNume.Text = candidat.Nume;
                textBoxPrenume.Text = candidat.Prenume;
                textBoxPatronimic.Text = candidat.Patronimic;
                dateTimePickerDataNasterii.Value = candidat.DataNastere;
                textBoxLoculNaterii.Text = candidat.LoculNastere;
            }

            if(fisa.Id>0)
            {
                numericUpDownNrFisa.Value = Convert.ToDecimal(fisa.NrFisa);
                numericUpDownNrFisa.Enabled = false;

                if (fisa.IndexNrfisa > 0)
                {
                    numericUpDownIndiceNrFisa.Value = Convert.ToDecimal(fisa.IndexNrfisa);
                    checkBoxActivIndiceNrFisa.Checked = true;
                    numericUpDownIndiceNrFisa.Enabled = true;
                }
                else
                {
                    numericUpDownIndiceNrFisa.Value = Convert.ToDecimal(fisa.IndexNrfisa);
                    checkBoxActivIndiceNrFisa.Checked = numericUpDownIndiceNrFisa.Enabled = false;
                }

                dateTimePickerDataFida.Value =  fisa.DataEvaluare;
                dateTimePickerDataTestare.Value = test.DataEvaluare;

                textBoxDomiciliu.Text = test.Domiciliu;
                textBoxTraume.Text = fisa.Traume;
                textBoxComponentaFamilie.Text = fisa.Family;
                textBoxStareCivila.Text = test.StareCivil;
                textBoxStudii.Text = fisa.Studii;
                textBoxSpecialitatea.Text = fisa.Specialitate;
                textBoxEperientaProfesionala.Text = fisa.ExperientaProfesionala;
                listViewExaminariPsiholog.Items.Clear();
                //trebuie de incarcat info
                ShowExaminarePsihologica();

                textBoxFunctia.Text = test.Functia;
                textBoxGradul.Text = test.Gradul;
                textBoxInstitutia.Text = test.Institutia;
                textBoxMotivExaminare.Text = test.MotivExaminare;
                textBoxMotivatieAngajare.Text = fisa.MotivatieAngajare;
                textBoxNota.Text = fisa.Nota;
                textBoxStatutFisaPersonala.Text = test.Statut;

                textBoxCaracteristivIndividual.Text = fisa.CaracteristicIndividual;
                textBoxCaracteristicEmotional.Text = fisa.CaracteristicEmotionala;
                textBoxCaracteristicMotivational.Text = fisa.CaracteristicMotivationala;
                textBoxPercepereProprie.Text = fisa.PercepereaProprie;
                textBoxCaracteristicComunicare.Text = fisa.CaracteristicComunicare;
                textBoxCaracteristicProfesional.Text = fisa.CaracteristicProfesionala;
                textBoxConcluzie.Text = fisa.Concluzie;
                textBoxActivitateProfesionala.Text = fisa.ActivitateProfesionala;
                textBoxExaminariInterventii.Text = fisa.ExaminareInterventie;

                //init arhiv

                dr = wfi.SelectAllFisaByIdCandidat(fisa.IdCandidat);

                if (dr.HasRows == true)
                {
                    Dictionary<int, string> arhiv = new Dictionary<int, string>();
                    while (dr.Read())
                    {
  
                        arhiv.Add(Convert.ToInt32(dr["id"]), "nr."+dr["nrfisa"].ToString()+" din "+ Convert.ToDateTime(dr["dataevaluare"]).Date.ToString("dd.MM.yyyy"));

                    }
                    dr.Close();

                    comboBoxArhivFisaIndividuala.DataSource = new BindingSource(arhiv, null);
                    comboBoxArhivFisaIndividuala.DisplayMember = "Value";
                    comboBoxArhivFisaIndividuala.ValueMember = "Key";
                }

            }
            else
            {
                MessageBox.Show("Ne pare rău, Fisa Personala n-a putut fi identificata, încercați mai tîrziu. Cod Fisa: " + fisa.Id.ToString(), "Fisa personala", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetForms()
        {
            candidat.Init();
            fisa.Init();
            test.Init();


            numericUpDownNrFisa.Value = 0;
            numericUpDownNrFisa.Enabled = true;

            numericUpDownIndiceNrFisa.Value = 0;
            checkBoxActivIndiceNrFisa.Checked = false;
            numericUpDownIndiceNrFisa.Enabled = false;


            dateTimePickerDataFida.Value = DateTime.Now.Date;
            dateTimePickerDataTestare.Value = DateTime.Now.Date;

            if (comboBoxArhivFisaIndividuala.Items.Count > 0)
            {
                comboBoxArhivFisaIndividuala.DataSource = null;
                comboBoxArhivFisaIndividuala.Items.Clear();
            }
              
            labelArhiv.Visible = false;
            comboBoxArhivFisaIndividuala.Visible = false;

            textBoxNume.Text = "";
            textBoxPrenume.Text = "";
            textBoxPatronimic.Text = "";
            dateTimePickerDataNasterii.Value = DateTime.Now.Date.AddYears(-18);
            textBoxLoculNaterii.Text = "";
            textBoxDomiciliu.Text = "";
            textBoxTraume.Text = "";
            textBoxComponentaFamilie.Text = "";
            textBoxStareCivila.Text = "";
            textBoxStudii.Text = "";
            textBoxSpecialitatea.Text = "";
            textBoxEperientaProfesionala.Text = "";
            listViewExaminariPsiholog.Items.Clear();
            textBoxFunctia.Text = "";
            textBoxGradul.Text = "";
            textBoxInstitutia.Text = "";
            textBoxMotivExaminare.Text = "";
            textBoxMotivatieAngajare.Text = "";
            textBoxNota.Text = "";

            textBoxCaracteristivIndividual.Text = "";
            textBoxCaracteristicEmotional.Text = "";
            textBoxCaracteristicMotivational.Text = "";
            textBoxPercepereProprie.Text = "";
            textBoxCaracteristicComunicare.Text = "";
            textBoxCaracteristicProfesional.Text = "";
            textBoxConcluzie.Text = "";
            textBoxActivitateProfesionala.Text = "";
            textBoxExaminariInterventii.Text = "";
            toolStripStatusLabelSalvareDate.Text = "";
            textBoxStatutFisaPersonala.Text = "";

        }

        private void SaveFisa()
        {
            if (numericUpDownNrFisa.Value > 0 && textBoxNume.Text != "" && textBoxPrenume.Text != "" && textBoxLoculNaterii.Text != "")
            {

                candidat.Nume = textBoxNume.Text;
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

                // MessageBox.Show(candidat.Id.ToString());
                fisa.IdCandidat = candidat.Id;
                fisa.NrFisa = Convert.ToInt32(numericUpDownNrFisa.Value);
                fisa.IndexNrfisa = Convert.ToInt32(numericUpDownIndiceNrFisa.Value);
                fisa.DataEvaluare = dateTimePickerDataFida.Value.Date;
                test.DataEvaluare = dateTimePickerDataTestare.Value.Date;

                test.Domiciliu = textBoxDomiciliu.Text;
                fisa.Traume = textBoxTraume.Text;
                fisa.Family = textBoxComponentaFamilie.Text;

                test.StareCivil = textBoxStareCivila.Text;
                fisa.Specialitate = textBoxSpecialitatea.Text;
                fisa.ExperientaProfesionala = textBoxEperientaProfesionala.Text;
                test.Functia = textBoxFunctia.Text;

                fisa.MotivatieAngajare = textBoxMotivatieAngajare.Text;
                fisa.Nota = textBoxNota.Text;
                test.Statut = textBoxStatutFisaPersonala.Text;

                fisa.CaracteristicIndividual = textBoxCaracteristivIndividual.Text;
                fisa.CaracteristicEmotionala = textBoxCaracteristicEmotional.Text;
                fisa.CaracteristicMotivationala = textBoxCaracteristicMotivational.Text;
                fisa.PercepereaProprie = textBoxPercepereProprie.Text;
                fisa.CaracteristicComunicare = textBoxCaracteristicComunicare.Text;
                fisa.CaracteristicProfesionala = textBoxCaracteristicProfesional.Text;
                fisa.Concluzie = textBoxConcluzie.Text;
                fisa.ActivitateProfesionala = textBoxActivitateProfesionala.Text;
                fisa.ExaminareInterventie = textBoxExaminariInterventii.Text;

                if (fisa.Id <= 0)
                {
                    fisa.Id = wfi.Insert(fisa);

                    if (fisa.Id > 0)
                    {
                        test.IdFisa = fisa.Id;
                        test.Id = wtest.Insert(test);
                        if (test.Id > 0)
                        {
                            toolStripStatusLabelSalvareDate.Text = "Fișa candidatului a fost salvată cu succes !!!, nr Fișei: " + fisa.NrFisa.ToString();                         
                            //this.DialogResult = DialogResult.None;
                        }
                        else
                        {
                            MessageBox.Show("Ne pare rău, datale nu au putut fi salvate, încercați mai tîrziu." + fisa.Id.ToString(), "Completarea Fisei informative", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.DialogResult = DialogResult.None;
                        }
                       }
                    else
                    {
                        MessageBox.Show("Ne pare rău, datale nu au putut fi salvate, încercați mai tîrziu."+fisa.Id.ToString(), "Completarea Fisei informative", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.DialogResult = DialogResult.None;
                    }                    
                }
                else
                {
                    wfi.Update(fisa);
                    wtest.Update(test);
                }
            }
            else
            {
                MessageBox.Show("Atentie! Nu au fost completate toate cimpurile necesare", "Completarea Fisei informative", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
            }
        }



        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            SaveFisa();
        }

        private void buttonCautStareCivila_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WStareCivila(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdStareCivil = fcc.GetIdClasificator();
                textBoxStareCivila.Text = fcc.GetDenumireClasificator();
            }
        }

        private void buttonCautStudii_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WStudii(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                fisa.IdStudii = fcc.GetIdClasificator();
                textBoxStudii.Text = fcc.GetDenumireClasificator();
            }
        }

        private void buttonCautGradul_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WGradul(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdGradul = fcc.GetIdClasificator();
                textBoxGradul.Text = fcc.GetDenumireClasificator();
            }
        }

        private void buttonCautPenitenciar_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WPenitenciare(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdInstitutia = fcc.GetIdClasificator();
                textBoxInstitutia.Text = fcc.GetDenumireClasificator();
            }
        }

        private void buttonMotivExaminare_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WMotivExaminare(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdMotivExaminare = fcc.GetIdClasificator();
                textBoxMotivExaminare.Text = fcc.GetDenumireClasificator();
            }
        }

        private void comboBoxArhivFisaIndividuala_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxArhivFisaIndividuala_SelectionChangeCommitted(object sender, EventArgs e)
        {          
            int id = ((KeyValuePair<int,string>)comboBoxArhivFisaIndividuala.SelectedItem).Key;

          //  MessageBox.Show(id.ToString());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStudii_TextChanged(object sender, EventArgs e)
        {

        }


        private void ShowExaminarePsihologica()
        {


            if (candidat.Id > 0)
            {
                listViewExaminariPsiholog.Items.Clear();

                WExaminarePsihologica wexaminarepsihologica = new WExaminarePsihologica(connection);

                MySqlDataReader dr;

                dr = wexaminarepsihologica.SelectExaminareByIdCandidat(candidat.Id);

    
                int count = 0;
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        listViewExaminariPsiholog.Items.Add(Convert.ToDateTime(dr["data"]).Date.ToString("dd.MM.yyyy"));
                        count = listViewExaminariPsiholog.Items.Count;
                        listViewExaminariPsiholog.Items[count - 1].Name = dr["id"].ToString();
                        listViewExaminariPsiholog.Items[count - 1].SubItems.Add(dr["examinare"].ToString());
                       }
                    dr.Close();
                }
                else
                {
                    listViewExaminariPsiholog.Items.Clear();
                }
            }
        }

        private void buttonAddRezultatExaminare_Click(object sender, EventArgs e)
        {
            if (candidat.Id <= 0)
            {
                MessageBox.Show("Atentie! Nu sunt salvate datele primare ale candidatului", "Examinare Medicala", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                FExaminarePsihologica fexaminpsih = new FExaminarePsihologica(connection, candidat.Id);
                fexaminpsih.ShowDialog();
                int idexaminarefisa = 0;
                idexaminarefisa = fexaminpsih._idExaminarePsihologica;
                /* if (idexaminarefisa > 0) MessageBox.Show(idexaminarefisa.ToString());
                 else MessageBox.Show("nu s-a salvat :(");*/
                ShowExaminarePsihologica();
            }

        }

        private void listViewExaminariPsiholog_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewExaminariPsiholog.Items.Count; i++)
            {
                if (listViewExaminariPsiholog.Items[i].Selected == true)
                {
                    WExaminarePsihologica wexaminarepsih = new WExaminarePsihologica (connection);
                    textBoxExaminariInterventii.Text = wexaminarepsih.SelectExaminareByIdExaminare(Convert.ToInt32(listViewExaminariPsiholog.Items[i].SubItems[0].Name));
                    break;
                }
            }
        }

        private void toolStripButtonSalvareFisa_Click(object sender, EventArgs e)
        {
            SaveFisa();
            ResetForms();
        }

        private void textBoxInstitutia_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCautConcluzie_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WStatutFisaPersonala(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                test.IdStatut = fcc.GetIdClasificator();
                textBoxStatutFisaPersonala.Text = fcc.GetDenumireClasificator();
            }
        }

        private void toolStripTestare_Click(object sender, EventArgs e)
        {
            if (fisa.Id > 0)
            {
                FEvolutieTestare fevolutie = new FEvolutieTestare(connection, fisa.Id);
               // MessageBox.Show(fisa.Id.ToString());

                if (fevolutie.ShowDialog() == DialogResult.OK)
                {
                    SelectFisaByIdCandidat(candidat.Id);

                }
            }
            else
            {
                MessageBox.Show("Atentie! Pentru a continua Va rog sa salvati Fisa Personala curenta", "Completarea Evolutiei de Testare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
            }
        }

        private void dateTimePickerDataFida_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDataTestare.Value = dateTimePickerDataFida.Value;
           // MessageBox.Show("A fost modificata Data Testare");
        }

        private void checkBoxActivIndiceNrFisa_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownIndiceNrFisa.Enabled = checkBoxActivIndiceNrFisa.Checked;
        }

        private void numericUpDownNrFisa_ValueChanged(object sender, EventArgs e)
        {

            //Se verifica existenta numarului de fisa inregistrat in baza de date

            if (candidat.Id < 1)
            {
                dr = wfi.IsFisaNrFisaExist(Convert.ToInt32(numericUpDownNrFisa.Value));

                if (dr.HasRows == true)
                {
                    string listafise = "";
                    while (dr.Read())
                    {
                        listafise += " { " + dr["NUME"].ToString() + " " + dr["PRENUME"].ToString() + " " + dr["PATRONIMIC"].ToString() + " d.n. " + Convert.ToDateTime(dr["DATANASTERE"]).ToString("dd.mm.yyyy") + " } ";
                    }
                    dr.Close();

                    if (MessageBox.Show("Atentie ! Sunt identificate Fișe înregistrate nu nr." + numericUpDownNrFisa.Value.ToString() + "\n " + listafise + "\n Doriti sa continuati inregistrarea ??? ", "Fise identificate", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        checkBoxActivIndiceNrFisa.Checked = true;
                        numericUpDownIndiceNrFisa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Eroare ! Fișa personală cu nr. " + numericUpDownNrFisa.Value.ToString() + " nu va fi înregistrată !!!", "Înregistrare Fișă personală", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                }
            }

        }
    }
}
