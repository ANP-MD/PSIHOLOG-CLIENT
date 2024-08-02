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
    public partial class FCautFisa : Form
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;
        protected FCautClasificator fcc;

        private int motivexaminare = 0;
        private int studii = 0;

        public FCautFisa(MySqlConnection _connection)
        {
            
            InitializeComponent();
            connection = _connection;
            ResetForm();
        }

        private void ResetForm()
        {

            dateTimePickerDataExaminare1.Value = DateTime.Now.Date.AddDays(-7);
            dateTimePickerDataExaminare2.Value = DateTime.Now.Date;
            motivexaminare = 0;
            textBoxMotivExaminare.Text = "";
            studii = 0;
            textBoxStudii.Text = "";
            listViewRezultatulCautarii.Items.Clear();

        }

        private void toolStripButtonResetare_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void buttonCaut_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();


            string strcommand = "";


    //        strcommand = "SELECT  c.`Id` AS Id, c.`Nume` AS Nume, c.`Prenume` AS Prenume, c.`Patronimic` AS Patronimic, c.`DataNastere` AS DataNastere FROM `Candidat` c INNER JOIN FisaIndividuala f ON (f.IdCandidat = c.Id) WHERE ";

            strcommand = "SELECT  c.`Id` AS Id, c.`Nume` AS Nume, c.`Prenume` AS Prenume, c.`Patronimic` AS Patronimic, c.`DataNastere` AS DataNastere, f.`NrFisa` AS NrFisa, f.`IndiceNrFisa` AS IndiceNrFisa, et.`DataEvaluare` AS DataEvaluare, sfp.`Name` AS Avizul, p.`Name` AS Penitenciarul, motiv.`Name` AS ScopEvaluare   FROM `Candidat` c INNER JOIN FisaIndividuala f ON (f.IdCandidat = c.Id) INNER JOIN `EvolutieTestare` et ON(et.`IdFisa` = f.`Id`) INNER JOIN Penitenciare p ON(et.`IdInstitutie` = p.`Id`) INNER JOIN MotivExaminare motiv ON(et.`IdMotiv` = motiv.`Id`) INNER JOIN StatutFisaIndividuala sfp ON(et.`IdStatut` = sfp.ID) WHERE";

            string wheretext = "";

            if (numericUpDownNrFisa.Value > 0)
            {
                wheretext += " f.NrFisa = "+ Convert.ToInt32(numericUpDownNrFisa.Value).ToString();
            }            

            if (dateTimePickerDataExaminare1.Checked == true)
            {
                if (wheretext != "") wheretext += " AND ";

                if (dateTimePickerDataExaminare2.Checked == true)
                {
                    wheretext += " (et.DataEvaluare between '" + dateTimePickerDataExaminare1.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + dateTimePickerDataExaminare2.Value.Date.ToString("yyyy-MM-dd") + "') ";
                    //wheretext += " (f.DataEvaluare between '" + dateTimePickerDataExaminare1.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + dateTimePickerDataExaminare2.Value.Date.ToString("yyyy-MM-dd") + "') ";
                }
                else
                {
                    wheretext += " (f.DataEvaluare = '" + dateTimePickerDataExaminare1.Value.Date.ToString("yyyy-MM-dd") + "') ";
                }
            }


            if (motivexaminare > 0)
            {
                wheretext += " AND (f.IdMotivExaminare = " + motivexaminare.ToString() + ") ";

            }
            
            if (studii > 0)
            {
                wheretext += "  AND (f.IdStudii = " + studii.ToString() + ") ";
            }

            strcommand += wheretext + "  ORDER BY et.`DataEvaluare`;";


            MySqlCommand cmd = new MySqlCommand(strcommand, connection);
            cmd.CommandType = CommandType.Text;

            dr = cmd.ExecuteReader();
        

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

                    }
                    dr.Close();
                }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            }

        private void buttonCautStudii_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WStudii(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                studii = fcc.GetIdClasificator();
                textBoxStudii.Text = fcc.GetDenumireClasificator();
            }
        }

        private void buttonMotivExaminare_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WMotivExaminare(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                motivexaminare = fcc.GetIdClasificator();
                textBoxMotivExaminare.Text = fcc.GetDenumireClasificator();
            }
        }

        private void listViewRezultatulCautarii_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewRezultatulCautarii.Items.Count; i++)
            {
                if (listViewRezultatulCautarii.Items[i].Selected == true)
                {
                    FFisaIndividuala findivid = new FFisaIndividuala(connection, Convert.ToInt32(listViewRezultatulCautarii.Items[i].SubItems[1].Name));

                    if (findivid.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;
                }
            }
        }

        private void toolStripButtonRegistru_Click(object sender, EventArgs e)
        {
            Registru reg = new Registru(connection);
            reg.ListaCandidati(dateTimePickerDataExaminare1.Value.Date, dateTimePickerDataExaminare2.Value.Date);
        }

        private void numericUpDownNrFisa_Leave(object sender, EventArgs e)
        {
            if (numericUpDownNrFisa.Value > 0)
            {
                dateTimePickerDataExaminare1.Checked = false;
                dateTimePickerDataExaminare2.Checked = false;
            }
        }

        private void numericUpDownNrFisa_ValueChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Value changed");
        }
    }
}
