namespace Proiect_paw_wf.Modele
{
    partial class ListaRute
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
            this.components = new System.ComponentModel.Container();
            this.labelListaRute = new System.Windows.Forms.Label();
            this.listViewRute = new System.Windows.Forms.ListView();
            this.Cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plecare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destinatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Km = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEditeaza = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripSalvare = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPreluare = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListaRute
            // 
            this.labelListaRute.AutoSize = true;
            this.labelListaRute.Location = new System.Drawing.Point(12, 28);
            this.labelListaRute.Name = "labelListaRute";
            this.labelListaRute.Size = new System.Drawing.Size(50, 13);
            this.labelListaRute.TabIndex = 0;
            this.labelListaRute.Text = "Lista rute";
            // 
            // listViewRute
            // 
            this.listViewRute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod,
            this.Plecare,
            this.Destinatie,
            this.Data,
            this.Km});
            this.listViewRute.FullRowSelect = true;
            this.listViewRute.HideSelection = false;
            this.listViewRute.HoverSelection = true;
            this.listViewRute.Location = new System.Drawing.Point(12, 44);
            this.listViewRute.Name = "listViewRute";
            this.listViewRute.Size = new System.Drawing.Size(359, 324);
            this.listViewRute.TabIndex = 1;
            this.listViewRute.UseCompatibleStateImageBehavior = false;
            this.listViewRute.View = System.Windows.Forms.View.Details;
            this.listViewRute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewRute_MouseClick);
            this.listViewRute.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRute_MouseDoubleClick);
            // 
            // Cod
            // 
            this.Cod.Text = "Cod";
            this.Cod.Width = 33;
            // 
            // Plecare
            // 
            this.Plecare.Text = "Oras plecare";
            this.Plecare.Width = 75;
            // 
            // Destinatie
            // 
            this.Destinatie.Text = "Oras destinatie";
            this.Destinatie.Width = 88;
            // 
            // Data
            // 
            this.Data.Text = "Data plecare";
            this.Data.Width = 80;
            // 
            // Km
            // 
            this.Km.Text = "Numar km";
            // 
            // buttonEditeaza
            // 
            this.buttonEditeaza.Location = new System.Drawing.Point(30, 374);
            this.buttonEditeaza.Name = "buttonEditeaza";
            this.buttonEditeaza.Size = new System.Drawing.Size(130, 45);
            this.buttonEditeaza.TabIndex = 2;
            this.buttonEditeaza.Text = "Editeaza";
            this.buttonEditeaza.UseVisualStyleBackColor = true;
            this.buttonEditeaza.Click += new System.EventHandler(this.buttonEditeaza_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(222, 374);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(130, 45);
            this.buttonSterge.TabIndex = 3;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripSalvare,
            this.menuStripPreluare});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(383, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuStripSalvare
            // 
            this.menuStripSalvare.Name = "menuStripSalvare";
            this.menuStripSalvare.Size = new System.Drawing.Size(82, 20);
            this.menuStripSalvare.Text = "Salvare date";
            this.menuStripSalvare.Click += new System.EventHandler(this.menuStripSalvare_Click);
            // 
            // menuStripPreluare
            // 
            this.menuStripPreluare.Name = "menuStripPreluare";
            this.menuStripPreluare.Size = new System.Drawing.Size(88, 20);
            this.menuStripPreluare.Text = "Preluare date";
            this.menuStripPreluare.Click += new System.EventHandler(this.menuStripPreluare_Click);
            // 
            // ListaRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 445);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonEditeaza);
            this.Controls.Add(this.listViewRute);
            this.Controls.Add(this.labelListaRute);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ListaRute";
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListaRute;
        private System.Windows.Forms.ListView listViewRute;
        private System.Windows.Forms.ColumnHeader Cod;
        private System.Windows.Forms.ColumnHeader Plecare;
        private System.Windows.Forms.ColumnHeader Destinatie;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Km;
        private System.Windows.Forms.Button buttonEditeaza;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripSalvare;
        private System.Windows.Forms.ToolStripMenuItem menuStripPreluare;
    }
}