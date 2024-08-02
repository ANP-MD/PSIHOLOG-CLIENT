namespace Psiholog
{
    partial class FCautFisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCautFisa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonResetare = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRegistru = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewRezultatulCautarii = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatronimic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataNasterii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxCautareCandidat = new System.Windows.Forms.GroupBox();
            this.numericUpDownNrFisa = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonCautStudii = new System.Windows.Forms.Button();
            this.textBoxStudii = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonMotivExaminare = new System.Windows.Forms.Button();
            this.textBoxMotivExaminare = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePickerDataExaminare2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDataExaminare1 = new System.Windows.Forms.DateTimePicker();
            this.buttonCaut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxCautareCandidat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrFisa)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(49, 49);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonResetare,
            this.toolStripButtonRegistru});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1003, 56);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonResetare
            // 
            this.toolStripButtonResetare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResetare.Image = global::Psiholog.Properties.Resources.Refresh48;
            this.toolStripButtonResetare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResetare.Name = "toolStripButtonResetare";
            this.toolStripButtonResetare.Size = new System.Drawing.Size(53, 53);
            this.toolStripButtonResetare.Text = "Resetare";
            this.toolStripButtonResetare.Click += new System.EventHandler(this.toolStripButtonResetare_Click);
            // 
            // toolStripButtonRegistru
            // 
            this.toolStripButtonRegistru.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRegistru.Image = global::Psiholog.Properties.Resources.RegistruLista;
            this.toolStripButtonRegistru.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRegistru.Name = "toolStripButtonRegistru";
            this.toolStripButtonRegistru.Size = new System.Drawing.Size(53, 53);
            this.toolStripButtonRegistru.Text = "Genereaza Lista cu Aviz";
            this.toolStripButtonRegistru.Click += new System.EventHandler(this.toolStripButtonRegistru_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewRezultatulCautarii);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(405, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 513);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezultatul Cutarii";
            // 
            // listViewRezultatulCautarii
            // 
            this.listViewRezultatulCautarii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderPatronimic,
            this.columnHeaderDataNasterii});
            this.listViewRezultatulCautarii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRezultatulCautarii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRezultatulCautarii.FullRowSelect = true;
            this.listViewRezultatulCautarii.GridLines = true;
            this.listViewRezultatulCautarii.HideSelection = false;
            this.listViewRezultatulCautarii.Location = new System.Drawing.Point(3, 22);
            this.listViewRezultatulCautarii.MultiSelect = false;
            this.listViewRezultatulCautarii.Name = "listViewRezultatulCautarii";
            this.listViewRezultatulCautarii.Size = new System.Drawing.Size(592, 488);
            this.listViewRezultatulCautarii.TabIndex = 9;
            this.listViewRezultatulCautarii.UseCompatibleStateImageBehavior = false;
            this.listViewRezultatulCautarii.View = System.Windows.Forms.View.Details;
            this.listViewRezultatulCautarii.DoubleClick += new System.EventHandler(this.listViewRezultatulCautarii_DoubleClick);
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 100;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxCautareCandidat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 513);
            this.panel1.TabIndex = 44;
            // 
            // groupBoxCautareCandidat
            // 
            this.groupBoxCautareCandidat.Controls.Add(this.numericUpDownNrFisa);
            this.groupBoxCautareCandidat.Controls.Add(this.label20);
            this.groupBoxCautareCandidat.Controls.Add(this.buttonCautStudii);
            this.groupBoxCautareCandidat.Controls.Add(this.textBoxStudii);
            this.groupBoxCautareCandidat.Controls.Add(this.label10);
            this.groupBoxCautareCandidat.Controls.Add(this.buttonMotivExaminare);
            this.groupBoxCautareCandidat.Controls.Add(this.textBoxMotivExaminare);
            this.groupBoxCautareCandidat.Controls.Add(this.label17);
            this.groupBoxCautareCandidat.Controls.Add(this.dateTimePickerDataExaminare2);
            this.groupBoxCautareCandidat.Controls.Add(this.label5);
            this.groupBoxCautareCandidat.Controls.Add(this.dateTimePickerDataExaminare1);
            this.groupBoxCautareCandidat.Controls.Add(this.buttonCaut);
            this.groupBoxCautareCandidat.Controls.Add(this.label4);
            this.groupBoxCautareCandidat.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCautareCandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCautareCandidat.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCautareCandidat.Name = "groupBoxCautareCandidat";
            this.groupBoxCautareCandidat.Size = new System.Drawing.Size(405, 306);
            this.groupBoxCautareCandidat.TabIndex = 49;
            this.groupBoxCautareCandidat.TabStop = false;
            this.groupBoxCautareCandidat.Text = "Parametri de căutare";
            // 
            // numericUpDownNrFisa
            // 
            this.numericUpDownNrFisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNrFisa.Location = new System.Drawing.Point(200, 30);
            this.numericUpDownNrFisa.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownNrFisa.Name = "numericUpDownNrFisa";
            this.numericUpDownNrFisa.Size = new System.Drawing.Size(88, 26);
            this.numericUpDownNrFisa.TabIndex = 101;
            this.numericUpDownNrFisa.ValueChanged += new System.EventHandler(this.numericUpDownNrFisa_ValueChanged);
            this.numericUpDownNrFisa.Leave += new System.EventHandler(this.numericUpDownNrFisa_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(113, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 20);
            this.label20.TabIndex = 100;
            this.label20.Text = "Nr. Fișa :";
            // 
            // buttonCautStudii
            // 
            this.buttonCautStudii.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCautStudii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCautStudii.Image = global::Psiholog.Properties.Resources.search_16;
            this.buttonCautStudii.Location = new System.Drawing.Point(135, 178);
            this.buttonCautStudii.Name = "buttonCautStudii";
            this.buttonCautStudii.Size = new System.Drawing.Size(32, 28);
            this.buttonCautStudii.TabIndex = 99;
            this.buttonCautStudii.UseVisualStyleBackColor = false;
            this.buttonCautStudii.Click += new System.EventHandler(this.buttonCautStudii_Click);
            // 
            // textBoxStudii
            // 
            this.textBoxStudii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStudii.Location = new System.Drawing.Point(173, 180);
            this.textBoxStudii.Name = "textBoxStudii";
            this.textBoxStudii.ReadOnly = true;
            this.textBoxStudii.Size = new System.Drawing.Size(223, 26);
            this.textBoxStudii.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 97;
            this.label10.Text = "Studii :";
            // 
            // buttonMotivExaminare
            // 
            this.buttonMotivExaminare.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMotivExaminare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMotivExaminare.Image = global::Psiholog.Properties.Resources.search_16;
            this.buttonMotivExaminare.Location = new System.Drawing.Point(134, 144);
            this.buttonMotivExaminare.Name = "buttonMotivExaminare";
            this.buttonMotivExaminare.Size = new System.Drawing.Size(32, 28);
            this.buttonMotivExaminare.TabIndex = 96;
            this.buttonMotivExaminare.UseVisualStyleBackColor = false;
            this.buttonMotivExaminare.Click += new System.EventHandler(this.buttonMotivExaminare_Click);
            // 
            // textBoxMotivExaminare
            // 
            this.textBoxMotivExaminare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMotivExaminare.Location = new System.Drawing.Point(172, 146);
            this.textBoxMotivExaminare.Name = "textBoxMotivExaminare";
            this.textBoxMotivExaminare.ReadOnly = true;
            this.textBoxMotivExaminare.Size = new System.Drawing.Size(224, 26);
            this.textBoxMotivExaminare.TabIndex = 95;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 20);
            this.label17.TabIndex = 94;
            this.label17.Text = "Motiv Examinare:";
            // 
            // dateTimePickerDataExaminare2
            // 
            this.dateTimePickerDataExaminare2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDataExaminare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDataExaminare2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataExaminare2.Location = new System.Drawing.Point(200, 105);
            this.dateTimePickerDataExaminare2.Name = "dateTimePickerDataExaminare2";
            this.dateTimePickerDataExaminare2.ShowCheckBox = true;
            this.dateTimePickerDataExaminare2.Size = new System.Drawing.Size(133, 26);
            this.dateTimePickerDataExaminare2.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "pina la";
            // 
            // dateTimePickerDataExaminare1
            // 
            this.dateTimePickerDataExaminare1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDataExaminare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDataExaminare1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataExaminare1.Location = new System.Drawing.Point(200, 73);
            this.dateTimePickerDataExaminare1.Name = "dateTimePickerDataExaminare1";
            this.dateTimePickerDataExaminare1.ShowCheckBox = true;
            this.dateTimePickerDataExaminare1.Size = new System.Drawing.Size(133, 26);
            this.dateTimePickerDataExaminare1.TabIndex = 53;
            // 
            // buttonCaut
            // 
            this.buttonCaut.Image = global::Psiholog.Properties.Resources.search_24;
            this.buttonCaut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaut.Location = new System.Drawing.Point(15, 250);
            this.buttonCaut.Name = "buttonCaut";
            this.buttonCaut.Size = new System.Drawing.Size(116, 33);
            this.buttonCaut.TabIndex = 48;
            this.buttonCaut.Text = "Cautare";
            this.buttonCaut.UseVisualStyleBackColor = true;
            this.buttonCaut.Click += new System.EventHandler(this.buttonCaut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Data Examinare de la:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1003, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FCautFisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCautFisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistica Fise Individuale";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxCautareCandidat.ResumeLayout(false);
            this.groupBoxCautareCandidat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrFisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonResetare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewRezultatulCautarii;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderPatronimic;
        private System.Windows.Forms.ColumnHeader columnHeaderDataNasterii;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxCautareCandidat;
        public System.Windows.Forms.DateTimePicker dateTimePickerDataExaminare2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dateTimePickerDataExaminare1;
        private System.Windows.Forms.Button buttonCaut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonMotivExaminare;
        private System.Windows.Forms.TextBox textBoxMotivExaminare;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonCautStudii;
        private System.Windows.Forms.TextBox textBoxStudii;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton toolStripButtonRegistru;
        private System.Windows.Forms.NumericUpDown numericUpDownNrFisa;
        private System.Windows.Forms.Label label20;
    }
}