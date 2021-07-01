namespace Proiect_paw_wf
{
    partial class AdaugareCompanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareCompanie));
            this.labelAdauga = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelBilete = new System.Windows.Forms.Label();
            this.textBoxNumeCompanie = new System.Windows.Forms.TextBox();
            this.textBoxBilete = new System.Windows.Forms.TextBox();
            this.buttonAdaugaRute = new System.Windows.Forms.Button();
            this.buttonAdaugareCompanie = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.statusStripLabel = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBoxRute = new System.Windows.Forms.ListBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipBileteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStripLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdauga
            // 
            this.labelAdauga.AutoSize = true;
            this.labelAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdauga.Location = new System.Drawing.Point(121, 45);
            this.labelAdauga.Name = "labelAdauga";
            this.labelAdauga.Size = new System.Drawing.Size(138, 20);
            this.labelAdauga.TabIndex = 0;
            this.labelAdauga.Text = "Adauga companie";
            this.labelAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(12, 103);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(110, 17);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume companie";
            // 
            // labelBilete
            // 
            this.labelBilete.AutoSize = true;
            this.labelBilete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilete.Location = new System.Drawing.Point(12, 150);
            this.labelBilete.Name = "labelBilete";
            this.labelBilete.Size = new System.Drawing.Size(66, 17);
            this.labelBilete.TabIndex = 2;
            this.labelBilete.Text = "Tip bilete";
            // 
            // textBoxNumeCompanie
            // 
            this.textBoxNumeCompanie.Location = new System.Drawing.Point(176, 102);
            this.textBoxNumeCompanie.Name = "textBoxNumeCompanie";
            this.textBoxNumeCompanie.Size = new System.Drawing.Size(171, 20);
            this.textBoxNumeCompanie.TabIndex = 3;
            // 
            // textBoxBilete
            // 
            this.textBoxBilete.Location = new System.Drawing.Point(176, 149);
            this.textBoxBilete.Name = "textBoxBilete";
            this.textBoxBilete.Size = new System.Drawing.Size(171, 20);
            this.textBoxBilete.TabIndex = 4;
            // 
            // buttonAdaugaRute
            // 
            this.buttonAdaugaRute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaRute.Location = new System.Drawing.Point(15, 190);
            this.buttonAdaugaRute.Name = "buttonAdaugaRute";
            this.buttonAdaugaRute.Size = new System.Drawing.Size(332, 30);
            this.buttonAdaugaRute.TabIndex = 5;
            this.buttonAdaugaRute.Text = "Adauga rute";
            this.buttonAdaugaRute.UseVisualStyleBackColor = true;
            this.buttonAdaugaRute.Click += new System.EventHandler(this.buttonAdaugaRute_Click);
            // 
            // buttonAdaugareCompanie
            // 
            this.buttonAdaugareCompanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugareCompanie.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdaugareCompanie.Image")));
            this.buttonAdaugareCompanie.Location = new System.Drawing.Point(15, 374);
            this.buttonAdaugareCompanie.Name = "buttonAdaugareCompanie";
            this.buttonAdaugareCompanie.Size = new System.Drawing.Size(332, 131);
            this.buttonAdaugareCompanie.TabIndex = 6;
            this.buttonAdaugareCompanie.Text = "Adauga companie";
            this.buttonAdaugareCompanie.UseVisualStyleBackColor = true;
            this.buttonAdaugareCompanie.Click += new System.EventHandler(this.buttonAdaugareCompanie_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.tipBileteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(389, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 416);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Companii";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(658, 60);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 11;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
            this.statusStripLabel.Location = new System.Drawing.Point(0, 521);
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(745, 22);
            this.statusStripLabel.TabIndex = 12;
            this.statusStripLabel.Text = "statusStrip1";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(80, 17);
            this.toolStripLabel.Text = "Numar rute: 0";
            // 
            // listBoxRute
            // 
            this.listBoxRute.FormattingEnabled = true;
            this.listBoxRute.Location = new System.Drawing.Point(15, 239);
            this.listBoxRute.Name = "listBoxRute";
            this.listBoxRute.Size = new System.Drawing.Size(332, 121);
            this.listBoxRute.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // tipBileteDataGridViewTextBoxColumn
            // 
            this.tipBileteDataGridViewTextBoxColumn.DataPropertyName = "TipBilete";
            this.tipBileteDataGridViewTextBoxColumn.HeaderText = "TipBilete";
            this.tipBileteDataGridViewTextBoxColumn.Name = "tipBileteDataGridViewTextBoxColumn";
            // 
            // companieBindingSource
            // 
            this.companieBindingSource.DataSource = typeof(Proiect_paw_wf.Modele.Companie);
            // 
            // AdaugareCompanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 543);
            this.Controls.Add(this.listBoxRute);
            this.Controls.Add(this.statusStripLabel);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdaugareCompanie);
            this.Controls.Add(this.buttonAdaugaRute);
            this.Controls.Add(this.textBoxBilete);
            this.Controls.Add(this.textBoxNumeCompanie);
            this.Controls.Add(this.labelBilete);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelAdauga);
            this.Name = "AdaugareCompanie";
            this.Load += new System.EventHandler(this.AdaugareCompanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStripLabel.ResumeLayout(false);
            this.statusStripLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdauga;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelBilete;
        private System.Windows.Forms.TextBox textBoxNumeCompanie;
        private System.Windows.Forms.TextBox textBoxBilete;
        private System.Windows.Forms.Button buttonAdaugaRute;
        private System.Windows.Forms.Button buttonAdaugareCompanie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource companieBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipBileteDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
        private System.Windows.Forms.ListBox listBoxRute;
    }
}