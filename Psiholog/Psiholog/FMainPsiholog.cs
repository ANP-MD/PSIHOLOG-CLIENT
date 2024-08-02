using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Psiholog
{
    public partial class FMainPsiholog : Form
    {
        protected MySqlConnection connection;
        private ConnectorBD cbd;
        private int idinstitutia;



        public FMainPsiholog(string password)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            idinstitutia = 0;
            cbd = new ConnectorBD("XYZ", "psiholog");
            cbd.SetPassword(password);
            cbd.SetUser("XYZ");
            cbd.CreateConnectionBD();


            if (VerifyConnection() == 0)
            {
                MessageBox.Show("Atentie! Conexiunea nu a fost cu succes", "Logare",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButtonAddFisa_Click(object sender, EventArgs e)
        {
            FFisaIndividuala findivid = new FFisaIndividuala(cbd.GetConnectionBD());

            if (findivid.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private int VerifyConnection()
        {
            connection = cbd.GetConnectionBD();
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                //if(ex.)
                MessageBox.Show(ex.Message);
                return 0;
            }

            connection.Close();
            return 1;
        }

        private void buttonCautCandidat_Click(object sender, EventArgs e)
        {


            if (textBoxNume.Text != "" || textBoxPrenume.Text != "" || textBoxPatronimic.Text != "")
            {
                WCandidat wc = new WCandidat(cbd.GetConnectionBD());

                MySqlDataReader dr;

                dr = wc.SelectCandidatByNPP(textBoxNume.Text.Trim(), textBoxPrenume.Text.Trim(), textBoxPatronimic.Text.Trim(), idinstitutia);

                listViewRezultatulCautarii.Items.Clear();

                int count = 0;
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        listViewRezultatulCautarii.Items.Add(dr["nume"].ToString());
                        count = listViewRezultatulCautarii.Items.Count;
                        // listViewRezultatulCautarii.Items[count - 1].Name = dr["idnp"].ToString();
                        listViewRezultatulCautarii.Items[count - 1].SubItems.Add(dr["prenume"].ToString());
                        listViewRezultatulCautarii.Items[count - 1].SubItems[1].Name = dr["id"].ToString();
                        listViewRezultatulCautarii.Items[count - 1].SubItems.Add(dr["patronimic"].ToString());
                        listViewRezultatulCautarii.Items[count - 1].SubItems.Add(Convert.ToDateTime(dr["datanastere"]).Date.ToString("dd.MM.yyyy"));
                        if (idinstitutia > 0) listViewRezultatulCautarii.Items[count - 1].SubItems.Add(dr["NrFisa"].ToString());

                    }
                    dr.Close();
                }
            }
            else
            {
                listViewRezultatulCautarii.Items.Clear();
            }

        }

        private void listViewRezultatulCautarii_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewRezultatulCautarii.Items.Count; i++)
            {
                if (listViewRezultatulCautarii.Items[i].Selected == true)
                {
                    FFisaIndividuala findivid = new FFisaIndividuala(cbd.GetConnectionBD(), Convert.ToInt32(listViewRezultatulCautarii.Items[i].SubItems[1].Name));

                    if (findivid.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;
                }
            }
        }

        private void toolStripButtonStatistica_Click(object sender, EventArgs e)
        {
            FCautFisa fcaut = new FCautFisa(cbd.GetConnectionBD());

            fcaut.ShowDialog();

        }

        private void buttonCautPenitenciar_Click(object sender, EventArgs e)
        {
            FCautClasificator fcc = new FCautClasificator(new CautClasificator(new WPenitenciare(cbd.GetConnectionBD())));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                idinstitutia = fcc.GetIdClasificator();
                textBoxInstitutia.Text = fcc.GetDenumireClasificator();
            }
        }

        private void listaCandidatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FMainPsiholog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
