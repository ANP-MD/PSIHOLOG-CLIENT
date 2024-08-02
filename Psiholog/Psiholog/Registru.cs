using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Psiholog
{
    class Registru
    {
        protected MySqlConnection connection;

        public Registru(MySqlConnection _connection)
        {
            connection = _connection;

        }

        public void ListaCandidati(DateTime dt1, DateTime dt2)
        {
            Application oWord = new Application();
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Document oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            oDoc.PageSetup.PaperSize = WdPaperSize.wdPaperA4;
            //oDoc.PageSetup.TogglePortrait();
            oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
            oDoc.PageSetup.LeftMargin = 25;
            oDoc.PageSetup.BottomMargin = 30;

            /*  object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              Paragraph lineinof = oDoc.Paragraphs.Add(ref oRng);

              lineinof.Range.Text = "Registru:";
              lineinof.Range.InsertParagraphAfter();

              oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              */
            //Deseneaza tabelul
            Table oTable;
            Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 1, 6, ref oMissing, ref oMissing);
            oTable.Borders.Enable = 1;
            oTable.Range.Paragraphs.SpaceAfter = 0;

            oTable.Cell(1, 1).Range.Text = "Nr. fisei individuale";
            oTable.Cell(1, 2).Range.Text = "Data evaluării";
            oTable.Cell(1, 3).Range.Text = "N.P.P. Candidatului";
            oTable.Cell(1, 4).Range.Text = "Solicitant";
            oTable.Cell(1, 5).Range.Text = "Scopul evaluării";
            oTable.Cell(1, 6).Range.Text = "Avizul";

            oTable.Columns[1].SetWidth(75, WdRulerStyle.wdAdjustSameWidth);
            oTable.Columns[2].SetWidth(100, WdRulerStyle.wdAdjustSameWidth);
            oTable.Columns[3].SetWidth(275, WdRulerStyle.wdAdjustSameWidth);
            oTable.Columns[4].SetWidth(150, WdRulerStyle.wdAdjustSameWidth);
            oTable.Columns[5].SetWidth(100, WdRulerStyle.wdAdjustSameWidth);
            oTable.Columns[6].SetWidth(100, WdRulerStyle.wdAdjustSameWidth);
            oTable.Rows[1].Range.Font.Bold = 1;//First row bold
            oTable.Rows[1].Range.Font.Size = 11;
            oTable.Rows[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;






            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();


            string strcommand = "";

            strcommand = " SELECT  c.`Id` AS Id, c.`Nume` AS Nume, c.`Prenume` AS Prenume, c.`Patronimic` AS Patronimic, c.`DataNastere` AS DataNastere, f.`NrFisa` AS NrFisa, f.`IndiceNrFisa` AS IndiceNrFisa, et.`DataEvaluare` AS DataEvaluare, sfp.`Name` AS Avizul, p.`Name` AS Penitenciarul, motiv.`Name` AS ScopEvaluare   FROM `Candidat` c INNER JOIN FisaIndividuala f ON (f.IdCandidat = c.Id) INNER JOIN `EvolutieTestare` et ON (et.`IdFisa` = f.`Id`) INNER JOIN Penitenciare p ON(et.`IdInstitutie` = p.`Id`) INNER JOIN MotivExaminare motiv ON( et.`IdMotiv` = motiv.`Id`) INNER JOIN StatutFisaIndividuala sfp ON(et.`IdStatut` = sfp.ID) WHERE ";

            string wheretext = "";

            wheretext += " (et.DataEvaluare between '" + dt1.ToString("yyyy-MM-dd") + "' AND '" + dt2.ToString("yyyy-MM-dd") + "')  ORDER BY et.`DataEvaluare`";

            MySqlCommand cmd = new MySqlCommand(strcommand + wheretext, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            MySqlDataReader dr = cmd.ExecuteReader();

            int count = 1;
            if (dr.HasRows == true)
            {

                while (dr.Read())
                {
                    Row row = oTable.Rows.Add(ref oMissing);
                    count++;
                    oTable.Rows[count].Range.Font.Bold = 0;

                    row.Cells[1].Range.Text = string.Format(dr["NrFisa"].ToString());
                    if (Convert.ToInt32(dr["IndiceNrFisa"]) > 0)
                        row.Cells[1].Range.Text += "/" + dr["IndiceNrFisa"].ToString();
                    // row.Cells[1].WordWrap = true;
                    row.Cells[1].Range.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

                    row.Cells[2].Range.Text = string.Format(Convert.ToDateTime(dr["DataEvaluare"]).Date.ToString("dd.MM.yyyy"));
                    row.Cells[2].WordWrap = true;

                    row.Cells[3].Range.Text = string.Format(dr["Nume"].ToString() + " " + dr["Prenume"].ToString() + " " + dr["Patronimic"].ToString());
                    row.Cells[3].WordWrap = true;
                    row.Cells[3].Range.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    //oTable.Rows[count].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

                    row.Cells[4].Range.Text = string.Format(dr["Penitenciarul"].ToString());
                    row.Cells[4].WordWrap = true;
                    row.Cells[4].Range.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

                    row.Cells[5].Range.Text = string.Format(dr["ScopEvaluare"].ToString());
                    row.Cells[5].WordWrap = true;

                    row.Cells[6].Range.Text = string.Format(dr["Avizul"].ToString());
                    row.Cells[6].WordWrap = true;

                }
                dr.Close();
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            oTable.Rows[1].HeadingFormat = -1;
            oTable.ApplyStyleHeadingRows = true;
            oWord.Visible = true;

        }

        /*  public void ListaDareDeSeamaPeInterval(DateTime dt1, DateTime dt2)
          {
              object oMissing = System.Reflection.Missing.Value;
              object oEndOfDoc = "\\endofdoc";

              ApplicationClass oWord = new ApplicationClass();

              Document oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);

              object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              Paragraph lineinof = oDoc.Paragraphs.Add(ref oRng);
             // WDocIntrare wdocin = new WDocIntrare(connection, idserviciu);

              lineinof.Range.Text = wdocin.DSnrTotalPetitii(dt1, dt2);
              lineinof.Range.InsertParagraphAfter();

              oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              Paragraph lineinof2 = oDoc.Paragraphs.Add(ref oRng);
              lineinof2.Range.Text = "Petiții parvenite din Instituțiile Penitenciare:";
              lineinof2.Range.InsertParagraphAfter();
              lineinof2.SpaceAfter = 1;

              //nr petitii pe penitenciare
              Table oTable;
              Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              oTable = oDoc.Tables.Add(wrdRng, 1, 2, ref oMissing, ref oMissing);
              oTable.Borders.Enable = 1;
              oTable.Range.Paragraphs.SpaceAfter = 0;

              oTable.Cell(1, 1).Range.Text = "PENITENCIARUL ";
              oTable.Cell(1, 2).Range.Text = "NUMARUL";

              oTable.Columns[1].SetWidth(150, WdRulerStyle.wdAdjustSameWidth);
              oTable.Columns[2].SetWidth(100, WdRulerStyle.wdAdjustSameWidth);

              ArrayList dstabel = new ArrayList();

            //  DSTable tempdstable = new DSTable();

            //  dstabel = wdocin.DSpetitiiPePenitenciare(dt1, dt2);

              for (int i = 0; i < dstabel.Count; i++)
              {
                //  tempdstable = (DSTable)dstabel[i];
                  Row row = oTable.Rows.Add(ref oMissing);

                  row.Cells[1].Range.Text = string.Format(tempdstable.denumire);
                  row.Cells[1].WordWrap = true;

                  row.Cells[2].Range.Text = string.Format(tempdstable.valoare);
                  row.Cells[2].WordWrap = true;
              }

              oTable.Rows[1].Range.Font.Bold = 1;//First row bold



              object oRng2 = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              Paragraph oPara3 = oDoc.Content.Paragraphs.Add(ref oRng2);
              oPara3.Range.InsertParagraphBefore();
              oPara3.Range.Text = "Petiții parvenite de la deținuți, pe îtrebări abordate:";
              oPara3.Format.SpaceAfter = 1;
              oPara3.Range.InsertParagraphAfter();

              wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              oTable = oDoc.Tables.Add(wrdRng, 1, 2, ref oMissing, ref oMissing);
              oTable.Borders.Enable = 1;
              oTable.Range.Paragraphs.SpaceAfter = 0;
              oTable.Cell(1, 1).Range.Text = "ÎNTREBAREA ";
              oTable.Cell(1, 2).Range.Text = "NUMĂRUL";

              oTable.Columns[1].SetWidth(270, WdRulerStyle.wdAdjustSameWidth);
              oTable.Columns[2].SetWidth(70, WdRulerStyle.wdAdjustSameWidth);

              dstabel.Clear();

              dstabel = wdocin.DSpetDetIntrebari(dt1, dt2);

              for (int i = 0; i < dstabel.Count; i++)
              {
                  tempdstable = (DSTable)dstabel[i];
                  Row row = oTable.Rows.Add(ref oMissing);

                  row.Cells[1].Range.Text = string.Format(tempdstable.denumire);
                  row.Cells[1].WordWrap = true;

                  row.Cells[2].Range.Text = string.Format(tempdstable.valoare);
                  row.Cells[2].WordWrap = true;
              }

              oTable.Rows[1].Range.Font.Bold = 1;//First row bold


              //petitii pe intrebari parvenite de la persoane fizice

              oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              Paragraph oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
              oPara4.Range.InsertParagraphBefore();
              oPara4.Range.Text = "Petiții parvenite de la persoane fizice, pe îtrebări abordate:";
              oPara4.Format.SpaceAfter = 1;
              oPara4.Range.InsertParagraphAfter();


              wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              oTable = oDoc.Tables.Add(wrdRng, 1, 2, ref oMissing, ref oMissing);
              oTable.Borders.Enable = 1;
              oTable.Range.Paragraphs.SpaceAfter = 0;
              oTable.Cell(1, 1).Range.Text = "ÎNTREBAREA ";
              oTable.Cell(1, 2).Range.Text = "NUMĂRUL";

              oTable.Columns[1].SetWidth(270, WdRulerStyle.wdAdjustSameWidth);
              oTable.Columns[2].SetWidth(70, WdRulerStyle.wdAdjustSameWidth);

              dstabel.Clear();

              dstabel = wdocin.DSpetFizicIntrebari(dt1, dt2);

              for (int i = 0; i < dstabel.Count; i++)
              {
                  tempdstable = (DSTable)dstabel[i];
                  Row row = oTable.Rows.Add(ref oMissing);

                  row.Cells[1].Range.Text = string.Format(tempdstable.denumire);
                  row.Cells[1].WordWrap = true;

                  row.Cells[2].Range.Text = string.Format(tempdstable.valoare);
                  row.Cells[2].WordWrap = true;
              }

              oTable.Rows[1].Range.Font.Bold = 1;//First row bold

              //petitii parvenite de la instante superioare

              oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              Paragraph oPara5 = oDoc.Content.Paragraphs.Add(ref oRng);
              oPara5.Range.InsertParagraphBefore();
              oPara5.Range.Text = "Petiții parvenite prin intermediul Instantelor superioare:";
              oPara5.Format.SpaceAfter = 1;
              oPara5.Range.InsertParagraphAfter();


              wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              oTable = oDoc.Tables.Add(wrdRng, 1, 2, ref oMissing, ref oMissing);
              oTable.Borders.Enable = 1;
              oTable.Range.Paragraphs.SpaceAfter = 0;
              oTable.Cell(1, 1).Range.Text = "INSTANŢA ";
              oTable.Cell(1, 2).Range.Text = "NUMĂRUL";

              oTable.Columns[1].SetWidth(200, WdRulerStyle.wdAdjustSameWidth);
              oTable.Columns[2].SetWidth(70, WdRulerStyle.wdAdjustSameWidth);

              dstabel.Clear();

              dstabel = wdocin.DSpetitiiOrganeSuperioare(dt1, dt2);

              for (int i = 0; i < dstabel.Count; i++)
              {
                  tempdstable = (DSTable)dstabel[i];
                  Row row = oTable.Rows.Add(ref oMissing);

                  row.Cells[1].Range.Text = string.Format(tempdstable.denumire);
                  row.Cells[1].WordWrap = true;

                  row.Cells[2].Range.Text = string.Format(tempdstable.valoare);
                  row.Cells[2].WordWrap = true;
              }

              oTable.Rows[1].Range.Font.Bold = 1;//First row bold


              //petitii procesate de Direcţiile dip

              oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              Paragraph oPara6 = oDoc.Content.Paragraphs.Add(ref oRng);
              oPara6.Range.InsertParagraphBefore();
              oPara6.Range.Text = "Petiții procesate de serviciile DIP:";
              oPara5.Format.SpaceAfter = 1;
              oPara5.Range.InsertParagraphAfter();

              wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
              oTable = oDoc.Tables.Add(wrdRng, 1, 2, ref oMissing, ref oMissing);
              oTable.Borders.Enable = 1;
              oTable.Range.Paragraphs.SpaceAfter = 0;
              oTable.Cell(1, 1).Range.Text = "Serviciul ";
              oTable.Cell(1, 2).Range.Text = "NUMĂRUL";

              oTable.Columns[1].SetWidth(200, WdRulerStyle.wdAdjustSameWidth);
              oTable.Columns[2].SetWidth(70, WdRulerStyle.wdAdjustSameWidth);

              dstabel.Clear();

              dstabel = wdocin.DSpetitiiServicii(dt1, dt2);

              for (int i = 0; i < dstabel.Count; i++)
              {
                  tempdstable = (DSTable)dstabel[i];
                  Row row = oTable.Rows.Add(ref oMissing);

                  row.Cells[1].Range.Text = string.Format(tempdstable.denumire);
                  row.Cells[1].WordWrap = true;

                  row.Cells[2].Range.Text = string.Format(tempdstable.valoare);
                  row.Cells[2].WordWrap = true;
              }

              oTable.Rows[1].Range.Font.Bold = 1;//First row bold

              oWord.Visible = true;
          }*/


    }
}
