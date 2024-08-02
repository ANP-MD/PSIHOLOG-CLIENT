namespace Psiholog
{
    partial class FExaminarePsihologica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExaminarePsihologica));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSalvareFisa = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRevocare = new System.Windows.Forms.Button();
            this.buttonAcceptare = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerDataExaminare = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMersulExaminare = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(49, 49);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSalvareFisa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 56);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSalvareFisa
            // 
            this.toolStripButtonSalvareFisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSalvareFisa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSalvareFisa.Image")));
            this.toolStripButtonSalvareFisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalvareFisa.Name = "toolStripButtonSalvareFisa";
            this.toolStripButtonSalvareFisa.Size = new System.Drawing.Size(53, 53);
            this.toolStripButtonSalvareFisa.Text = "Salvare Fisa";
            this.toolStripButtonSalvareFisa.Click += new System.EventHandler(this.toolStripButtonSalvareFisa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRevocare);
            this.panel1.Controls.Add(this.buttonAcceptare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 39);
            this.panel1.TabIndex = 8;
            // 
            // buttonRevocare
            // 
            this.buttonRevocare.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonRevocare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevocare.Image = global::Psiholog.Properties.Resources.cancel;
            this.buttonRevocare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRevocare.Location = new System.Drawing.Point(236, 3);
            this.buttonRevocare.Name = "buttonRevocare";
            this.buttonRevocare.Size = new System.Drawing.Size(108, 32);
            this.buttonRevocare.TabIndex = 10;
            this.buttonRevocare.Text = "Revocare";
            this.buttonRevocare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRevocare.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptare
            // 
            this.buttonAcceptare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAcceptare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptare.Image = global::Psiholog.Properties.Resources.tick;
            this.buttonAcceptare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcceptare.Location = new System.Drawing.Point(28, 3);
            this.buttonAcceptare.Name = "buttonAcceptare";
            this.buttonAcceptare.Size = new System.Drawing.Size(113, 32);
            this.buttonAcceptare.TabIndex = 9;
            this.buttonAcceptare.Text = "Acceptare";
            this.buttonAcceptare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAcceptare.UseVisualStyleBackColor = true;
            this.buttonAcceptare.Click += new System.EventHandler(this.buttonAcceptare_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxMersulExaminare);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.dateTimePickerDataExaminare);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 393);
            this.panel2.TabIndex = 9;
            // 
            // dateTimePickerDataExaminare
            // 
            this.dateTimePickerDataExaminare.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDataExaminare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDataExaminare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataExaminare.Location = new System.Drawing.Point(151, 12);
            this.dateTimePickerDataExaminare.Name = "dateTimePickerDataExaminare";
            this.dateTimePickerDataExaminare.Size = new System.Drawing.Size(128, 26);
            this.dateTimePickerDataExaminare.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Data Examinare";
            // 
            // textBoxMersulExaminare
            // 
            this.textBoxMersulExaminare.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMersulExaminare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMersulExaminare.Location = new System.Drawing.Point(151, 44);
            this.textBoxMersulExaminare.Multiline = true;
            this.textBoxMersulExaminare.Name = "textBoxMersulExaminare";
            this.textBoxMersulExaminare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMersulExaminare.Size = new System.Drawing.Size(470, 343);
            this.textBoxMersulExaminare.TabIndex = 99;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 20);
            this.label19.TabIndex = 98;
            this.label19.Text = "Mersul Examinare:";
            // 
            // FExaminarePsihologica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FExaminarePsihologica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Examinare Psihologica";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvareFisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRevocare;
        private System.Windows.Forms.Button buttonAcceptare;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker dateTimePickerDataExaminare;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxMersulExaminare;
        private System.Windows.Forms.Label label19;
    }
}