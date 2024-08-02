namespace Psiholog
{
    partial class FCautClasificator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCautClasificator));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxCautCautareClasificator = new System.Windows.Forms.ToolStripTextBox();
            this.listViewCautareClasificator = new System.Windows.Forms.ListView();
            this.columnHeaderDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAcceptare = new System.Windows.Forms.Button();
            this.toolStripButtonCautCautareClasificator = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCautCautareClasificator,
            this.toolStripButtonCautCautareClasificator,
            this.toolStripButtonAdd,
            this.toolStripButtonDelete,
            this.toolStripEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(375, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBoxCautCautareClasificator
            // 
            this.toolStripTextBoxCautCautareClasificator.AcceptsReturn = true;
            this.toolStripTextBoxCautCautareClasificator.AcceptsTab = true;
            this.toolStripTextBoxCautCautareClasificator.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toolStripTextBoxCautCautareClasificator.MaxLength = 64;
            this.toolStripTextBoxCautCautareClasificator.Name = "toolStripTextBoxCautCautareClasificator";
            this.toolStripTextBoxCautCautareClasificator.Size = new System.Drawing.Size(200, 39);
            this.toolStripTextBoxCautCautareClasificator.Text = "SCRIE AICI...";
            this.toolStripTextBoxCautCautareClasificator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxCautCautareClasificator_KeyPress);
            this.toolStripTextBoxCautCautareClasificator.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxCautCautareClasificator_KeyUp);
            this.toolStripTextBoxCautCautareClasificator.Click += new System.EventHandler(this.toolStripTextBoxCautCautareClasificator_Click);
            // 
            // listViewCautareClasificator
            // 
            this.listViewCautareClasificator.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDenumire});
            this.listViewCautareClasificator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCautareClasificator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewCautareClasificator.FullRowSelect = true;
            this.listViewCautareClasificator.GridLines = true;
            this.listViewCautareClasificator.HideSelection = false;
            this.listViewCautareClasificator.Location = new System.Drawing.Point(0, 39);
            this.listViewCautareClasificator.MultiSelect = false;
            this.listViewCautareClasificator.Name = "listViewCautareClasificator";
            this.listViewCautareClasificator.Size = new System.Drawing.Size(375, 287);
            this.listViewCautareClasificator.TabIndex = 2;
            this.listViewCautareClasificator.UseCompatibleStateImageBehavior = false;
            this.listViewCautareClasificator.View = System.Windows.Forms.View.Details;
            this.listViewCautareClasificator.SelectedIndexChanged += new System.EventHandler(this.listViewCautareClasificator_SelectedIndexChanged);
            this.listViewCautareClasificator.Click += new System.EventHandler(this.listViewCautareClasificator_Click);
            this.listViewCautareClasificator.DoubleClick += new System.EventHandler(this.listViewCautareClasificator_DoubleClick);
            this.listViewCautareClasificator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewCautareClasificator_KeyPress);
            // 
            // columnHeaderDenumire
            // 
            this.columnHeaderDenumire.Text = "Denumire";
            this.columnHeaderDenumire.Width = 350;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAcceptare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 36);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = global::Psiholog.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(184, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Revocare";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptare
            // 
            this.buttonAcceptare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAcceptare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAcceptare.Image = global::Psiholog.Properties.Resources.tick;
            this.buttonAcceptare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcceptare.Location = new System.Drawing.Point(31, 7);
            this.buttonAcceptare.Name = "buttonAcceptare";
            this.buttonAcceptare.Size = new System.Drawing.Size(92, 26);
            this.buttonAcceptare.TabIndex = 10;
            this.buttonAcceptare.Text = "Acceptare";
            this.buttonAcceptare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAcceptare.UseVisualStyleBackColor = true;
            this.buttonAcceptare.Click += new System.EventHandler(this.buttonAcceptare_Click);
            // 
            // toolStripButtonCautCautareClasificator
            // 
            this.toolStripButtonCautCautareClasificator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCautCautareClasificator.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCautCautareClasificator.Image")));
            this.toolStripButtonCautCautareClasificator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCautCautareClasificator.Name = "toolStripButtonCautCautareClasificator";
            this.toolStripButtonCautCautareClasificator.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCautCautareClasificator.Text = "Caut";
            this.toolStripButtonCautCautareClasificator.ToolTipText = "Cautare";
            this.toolStripButtonCautCautareClasificator.Click += new System.EventHandler(this.toolStripButtonCautCautareClasificator_Click);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::Psiholog.Properties.Resources.ad_32;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonAdd.Text = "Add";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::Psiholog.Properties.Resources.remove;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEdit.Image = global::Psiholog.Properties.Resources.edit_32;
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(36, 36);
            this.toolStripEdit.Text = "Edit";
            this.toolStripEdit.Click += new System.EventHandler(this.toolStripEdit_Click);
            // 
            // FCautClasificator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 362);
            this.Controls.Add(this.listViewCautareClasificator);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FCautClasificator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clasificator";
            this.Load += new System.EventHandler(this.FCautCautareClasificator_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCautCautareClasificator;
        private System.Windows.Forms.ToolStripButton toolStripButtonCautCautareClasificator;
        private System.Windows.Forms.ListView listViewCautareClasificator;
        private System.Windows.Forms.ColumnHeader columnHeaderDenumire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAcceptare;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
    }
}