using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Psiholog

{
    public partial class FCautClasificator : Form
    {
        private string denumire;
        private int idCautareClasificator;
        private CautClasificator itemclasificator;
//        private CautObjectClasificator objclasificator;

        public FCautClasificator( CautClasificator _cautclasificator)
        {
            InitializeComponent();
            idCautareClasificator = -1;
            denumire = "";
            itemclasificator = _cautclasificator;
        }

 /*       public FCautClasificator(CautClasificator _cautclasificator, CautObjectClasificator _objclasificator)
        {
            InitializeComponent();
            idCautareClasificator = -1;
            denumire = "";
            itemclasificator = _cautclasificator;
            objclasificator = _objclasificator;
            
        }*/


        private void SearchValue()
        {
            if (toolStripTextBoxCautCautareClasificator.Text.Trim() != "")
                denumire = toolStripTextBoxCautCautareClasificator.Text + "%";
            else denumire = "";

            if (denumire != "")
            {
                MySqlDataReader dr = itemclasificator.Search(denumire);

                int i = 0;
                listViewCautareClasificator.Items.Clear();
                while (dr.Read())
                {
                    listViewCautareClasificator.Items.Add(dr[1].ToString());
                    listViewCautareClasificator.Items[i].SubItems[0].Name = dr[0].ToString();
                    i++;
                }
                dr.Close();
                itemclasificator.Closeconnection();
                if (listViewCautareClasificator.Items.Count > 0)
                {
                    listViewCautareClasificator.Items[0].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Eroare ! - Nu este indicat nici un parametru de cautare.", "Cautare clasificator",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void toolStripButtonCautCautareClasificator_Click(object sender, EventArgs e)
        {
            SearchValue();
        }

        public int GetIdClasificator()
        {
            return idCautareClasificator;
        }

        public string GetDenumireClasificator()
        {
            return denumire;
        }

        private void listViewCautareClasificator_Click(object sender, EventArgs e)
        {
            if (listViewCautareClasificator.SelectedItems.Count > 0)
            {
                int i;
                for (i = 0; i < listViewCautareClasificator.Items.Count; i++)
                {
                    if (listViewCautareClasificator.Items[i].Selected)
                    {
                        idCautareClasificator = Convert.ToInt32(listViewCautareClasificator.Items[i].SubItems[0].Name);
                        denumire = listViewCautareClasificator.Items[i].SubItems[0].Text;
                        break;
                    }
                }
            }
        }

        private void listViewCautareClasificator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCautareClasificator.SelectedItems.Count <= 0)
            {
                idCautareClasificator = 0;
                denumire = "";
            }
            else
            {
                int i;
                for (i = 0; i < listViewCautareClasificator.Items.Count; i++)
                {
                    if (listViewCautareClasificator.Items[i].Selected)
                    {
                        idCautareClasificator = Convert.ToInt32(listViewCautareClasificator.Items[i].SubItems[0].Name);
                        denumire = listViewCautareClasificator.Items[i].SubItems[0].Text;
                        break;
                    }
                }
            }
        }

        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            if (idCautareClasificator <= 0)
            {
                MessageBox.Show("Eroare: nu a fost selectat nici un element din lista", "Cautare Clasificator",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void listViewCautareClasificator_DoubleClick(object sender, EventArgs e)
        {
            buttonAcceptare_Click(sender, e);
         //   this.DialogResult = DialogResult.OK;
        }

        private void FCautCautareClasificator_Load(object sender, EventArgs e)
        {
            listViewCautareClasificator.Items.Clear();

            //selectarea tuturor CautareClasificatorelor si afisarea lor in lista
            MySqlDataReader dr = itemclasificator.GetValues(); //wgrd.GetLCautareClasificatore();
            /*
             * indicile de la dr = 0 pentru id-uri;
             *                     1 pentru denumire clasificator;
             * */
            int i = 0;
            while (dr.Read())
            {
               /* if (i >= 10)
                {
                    listViewCautareClasificator.Items.Add("...");
                    listViewCautareClasificator.Items[i].SubItems[0].Name = "0";

                    break;
                }
                */
                listViewCautareClasificator.Items.Add(dr[1].ToString());
                listViewCautareClasificator.Items[i].SubItems[0].Name = dr[0].ToString();

                i++;
            }
            dr.Close();
            itemclasificator.Closeconnection();           
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            itemclasificator.Add();
            FCautCautareClasificator_Load(sender,e);
        }

        private void toolStripTextBoxCautCautareClasificator_Click(object sender, EventArgs e)
        {
            toolStripTextBoxCautCautareClasificator.SelectAll();
        }

        private void toolStripTextBoxCautCautareClasificator_KeyUp(object sender, KeyEventArgs e)
        {
            SearchValue();
        }

        private void toolStripTextBoxCautCautareClasificator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                listViewCautareClasificator.Focus();
            }
        }

        private void listViewCautareClasificator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcceptare.Focus();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewCautareClasificator.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti Obiectul Selectat din Baza de Date?", "Stergerea Obiectului din Baza de Date",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < listViewCautareClasificator.Items.Count; i++)
                    {
                        if (listViewCautareClasificator.Items[i].Selected == true)
                        {
                            idCautareClasificator = Convert.ToInt32(listViewCautareClasificator.Items[i].SubItems[0].Name);
                            itemclasificator.Delete(idCautareClasificator);

                            listViewCautareClasificator.Items[i].Remove();
                            break;
                        }
                    }//for
                }
            }
            else
            {
                MessageBox.Show("Atentie ! - Nu este selectata nici un element din lista", "Stergerea unui Element din lista",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            if (listViewCautareClasificator.SelectedItems.Count > 0)
            {
                    for (int i = 0; i < listViewCautareClasificator.Items.Count; i++)
                    {
                        if (listViewCautareClasificator.Items[i].Selected == true)
                        {
                            idCautareClasificator = Convert.ToInt32(listViewCautareClasificator.Items[i].SubItems[0].Name);
                            itemclasificator.Edit(idCautareClasificator);
                          
                            FCautCautareClasificator_Load(sender, e);                            
                            break;
                        }
                    }//for
            }
            else
            {
                MessageBox.Show("Atentie ! - Nu este selectata nici un element din lista", "Stergerea unui Element din lista",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

    }
}
