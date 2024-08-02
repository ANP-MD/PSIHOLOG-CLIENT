namespace Psiholog
{
    partial class FMainPsiholog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainPsiholog));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddFisa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStatistica = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdaugInformatie = new System.Windows.Forms.ToolStripButton();
            this.buttonCautCandidat = new System.Windows.Forms.Button();
            this.groupBoxCautareCandidat = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCautPenitenciar = new System.Windows.Forms.Button();
            this.textBoxInstitutia = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPatronimic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewRezultatulCautarii = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatronimic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataNasterii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFisaNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.groupBoxCautareCandidat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(49, 49);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddFisa,
            this.toolStripButtonStatistica,
            this.toolStripButtonAdaugInformatie});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(926, 56);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddFisa
            // 
            this.toolStripButtonAddFisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddFisa.Image = global::Psiholog.Properties.Resources.Document_icon;
            this.toolStripButtonAddFisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddFisa.Name = "toolStripButtonAddFisa";
            this.toolStripButtonAddFisa.Size = new System.Drawing.Size(53, 53);
            this.toolStripButtonAddFisa.Text = "Adaug Fisa Individuală";
            this.toolStripButtonAddFisa.Click += new System.EventHandler(this.toolStripButtonAddFisa_Click);
            // 
            // toolStripButtonStatistica
            // 
            this.toolStripButtonStatistica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStatistica.Image = global::Psiholog.Properties.Resources.Search48LaExecut;
            this.toolStripButtonStatistica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStatistica.Name = "toolStripButtonStatistica";
            this.toolStripButtonStatistica.Size = new System.Drawing.Size(53, 53);
            this.toolStripButtonStatistica.Text = "Statistica";
            this.toolStripButtonStatistica.Click += new System.EventHandler(this.toolStripButtonStatistica_Click);
            // 
            // toolStripButtonAdaugInformatie
            // 
            this.toolStripButtonAdaugInformatie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdaugInformatie.Image = global::Psiholog.Properties.Resources.add_persoanafizica;
            this.toolStripButtonAdaugInformatie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdaugInformatie.Name = "toolStripButtonAdaugInformatie";
            this.toolStripButtonAdaugInformatie.Size = new System.Drawing.Size(53, 53);
            this.toolStripButtonAdaugInformatie.Text = "AdaugaInregistrare";
            this.toolStripButtonAdaugInformatie.Visible = false;
            // 
            // buttonCautCandidat
            // 
            this.buttonCautCandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCautCandidat.Image = global::Psiholog.Properties.Resources.search_24;
            this.buttonCautCandidat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCautCandidat.Location = new System.Drawing.Point(10, 196);
            this.buttonCautCandidat.Name = "buttonCautCandidat";
            this.buttonCautCandidat.Size = new System.Drawing.Size(296, 31);
            this.buttonCautCandidat.TabIndex = 48;
            this.buttonCautCandidat.Text = "Cautare";
            this.buttonCautCandidat.UseVisualStyleBackColor = true;
            this.buttonCautCandidat.Click += new System.EventHandler(this.buttonCautCandidat_Click);
            // 
            // groupBoxCautareCandidat
            // 
            this.groupBoxCautareCandidat.Controls.Add(this.label5);
            this.groupBoxCautareCandidat.Controls.Add(this.buttonCautPenitenciar);
            this.groupBoxCautareCandidat.Controls.Add(this.textBoxInstitutia);
            this.groupBoxCautareCandidat.Controls.Add(this.dateTimePickerDataNasterii);
            this.groupBoxCautareCandidat.Controls.Add(this.buttonCautCandidat);
            this.groupBoxCautareCandidat.Controls.Add(this.label4);
            this.groupBoxCautareCandidat.Controls.Add(this.textBoxPatronimic);
            this.groupBoxCautareCandidat.Controls.Add(this.label3);
            this.groupBoxCautareCandidat.Controls.Add(this.textBoxPrenume);
            this.groupBoxCautareCandidat.Controls.Add(this.label2);
            this.groupBoxCautareCandidat.Controls.Add(this.textBoxNume);
            this.groupBoxCautareCandidat.Controls.Add(this.label1);
            this.groupBoxCautareCandidat.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCautareCandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCautareCandidat.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCautareCandidat.Name = "groupBoxCautareCandidat";
            this.groupBoxCautareCandidat.Size = new System.Drawing.Size(312, 241);
            this.groupBoxCautareCandidat.TabIndex = 49;
            this.groupBoxCautareCandidat.TabStop = false;
            this.groupBoxCautareCandidat.Text = "Căutare Candidat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Penitenciarul";
            // 
            // buttonCautPenitenciar
            // 
            this.buttonCautPenitenciar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCautPenitenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCautPenitenciar.Image = global::Psiholog.Properties.Resources.search_16;
            this.buttonCautPenitenciar.Location = new System.Drawing.Point(128, 161);
            this.buttonCautPenitenciar.Name = "buttonCautPenitenciar";
            this.buttonCautPenitenciar.Size = new System.Drawing.Size(30, 29);
            this.buttonCautPenitenciar.TabIndex = 92;
            this.buttonCautPenitenciar.UseVisualStyleBackColor = false;
            this.buttonCautPenitenciar.Click += new System.EventHandler(this.buttonCautPenitenciar_Click);
            // 
            // textBoxInstitutia
            // 
            this.textBoxInstitutia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInstitutia.Location = new System.Drawing.Point(158, 163);
            this.textBoxInstitutia.Name = "textBoxInstitutia";
            this.textBoxInstitutia.ReadOnly = true;
            this.textBoxInstitutia.Size = new System.Drawing.Size(148, 26);
            this.textBoxInstitutia.TabIndex = 91;
            // 
            // dateTimePickerDataNasterii
            // 
            this.dateTimePickerDataNasterii.Checked = false;
            this.dateTimePickerDataNasterii.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDataNasterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataNasterii.Location = new System.Drawing.Point(128, 126);
            this.dateTimePickerDataNasterii.Name = "dateTimePickerDataNasterii";
            this.dateTimePickerDataNasterii.ShowCheckBox = true;
            this.dateTimePickerDataNasterii.Size = new System.Drawing.Size(178, 26);
            this.dateTimePickerDataNasterii.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Data Nasterii";
            // 
            // textBoxPatronimic
            // 
            this.textBoxPatronimic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPatronimic.Location = new System.Drawing.Point(128, 94);
            this.textBoxPatronimic.Name = "textBoxPatronimic";
            this.textBoxPatronimic.Size = new System.Drawing.Size(178, 26);
            this.textBoxPatronimic.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Patronimic";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPrenume.Location = new System.Drawing.Point(128, 60);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(178, 26);
            this.textBoxPrenume.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Prenume";
            // 
            // textBoxNume
            // 
            this.textBoxNume.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNume.Location = new System.Drawing.Point(128, 28);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(178, 26);
            this.textBoxNume.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nume";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxCautareCandidat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 457);
            this.panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewRezultatulCautarii);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(312, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 457);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezultatul Cutarii";
            // 
            // listViewRezultatulCautarii
            // 
            this.listViewRezultatulCautarii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderPatronimic,
            this.columnHeaderDataNasterii,
            this.columnHeaderFisaNr});
            this.listViewRezultatulCautarii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRezultatulCautarii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRezultatulCautarii.FullRowSelect = true;
            this.listViewRezultatulCautarii.GridLines = true;
            this.listViewRezultatulCautarii.HideSelection = false;
            this.listViewRezultatulCautarii.Location = new System.Drawing.Point(3, 16);
            this.listViewRezultatulCautarii.MultiSelect = false;
            this.listViewRezultatulCautarii.Name = "listViewRezultatulCautarii";
            this.listViewRezultatulCautarii.Size = new System.Drawing.Size(608, 438);
            this.listViewRezultatulCautarii.TabIndex = 9;
            this.listViewRezultatulCautarii.UseCompatibleStateImageBehavior = false;
            this.listViewRezultatulCautarii.View = System.Windows.Forms.View.Details;
            this.listViewRezultatulCautarii.DoubleClick += new System.EventHandler(this.listViewRezultatulCautarii_DoubleClick);
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 150;
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "Prenume";
            this.columnHeaderPrenume.Width = 100;
            // 
            // columnHeaderPatronimic
            // 
            this.columnHeaderPatronimic.Text = "Patronimic";
            this.columnHeaderPatronimic.Width = 100;
            // 
            // columnHeaderDataNasterii
            // 
            this.columnHeaderDataNasterii.Text = "DataNasterii";
            this.columnHeaderDataNasterii.Width = 100;
            // 
            // columnHeaderFisaNr
            // 
            this.columnHeaderFisaNr.Text = "Fișa Nr";
            this.columnHeaderFisaNr.Width = 120;
            // 
            // FMainPsiholog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMainPsiholog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Psiholog 2.0 - Made by Caty ♥";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMainPsiholog_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxCautareCandidat.ResumeLayout(false);
            this.groupBoxCautareCandidat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdaugInformatie;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddFisa;
        private System.Windows.Forms.Button buttonCautCandidat;
        private System.Windows.Forms.GroupBox groupBoxCautareCandidat;
        public System.Windows.Forms.DateTimePicker dateTimePickerDataNasterii;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxPatronimic;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewRezultatulCautarii;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderPatronimic;
        private System.Windows.Forms.ColumnHeader columnHeaderDataNasterii;
        private System.Windows.Forms.ColumnHeader columnHeaderFisaNr;
        private System.Windows.Forms.ToolStripButton toolStripButtonStatistica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCautPenitenciar;
        private System.Windows.Forms.TextBox textBoxInstitutia;
    }
}

