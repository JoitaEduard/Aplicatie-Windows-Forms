namespace Proiect_paw_wf
{
    partial class FormularEditareRute
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
            this.groupBoxEditare = new System.Windows.Forms.GroupBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.textBoxDestinatie = new System.Windows.Forms.TextBox();
            this.textBoxPlecare = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.labelDestinatie = new System.Windows.Forms.Label();
            this.labelPlecare = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.buttonAnuleaza = new System.Windows.Forms.Button();
            this.buttonSalveaza = new System.Windows.Forms.Button();
            this.groupBoxEditare.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditare
            // 
            this.groupBoxEditare.Controls.Add(this.dateTimePickerData);
            this.groupBoxEditare.Controls.Add(this.textBoxKm);
            this.groupBoxEditare.Controls.Add(this.textBoxDestinatie);
            this.groupBoxEditare.Controls.Add(this.textBoxPlecare);
            this.groupBoxEditare.Controls.Add(this.textBoxCod);
            this.groupBoxEditare.Controls.Add(this.labelData);
            this.groupBoxEditare.Controls.Add(this.labelKm);
            this.groupBoxEditare.Controls.Add(this.labelDestinatie);
            this.groupBoxEditare.Controls.Add(this.labelPlecare);
            this.groupBoxEditare.Controls.Add(this.labelCod);
            this.groupBoxEditare.Location = new System.Drawing.Point(12, 38);
            this.groupBoxEditare.Name = "groupBoxEditare";
            this.groupBoxEditare.Size = new System.Drawing.Size(342, 287);
            this.groupBoxEditare.TabIndex = 20;
            this.groupBoxEditare.TabStop = false;
            this.groupBoxEditare.Text = "Editare rute";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(121, 178);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerData.TabIndex = 24;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Location = new System.Drawing.Point(121, 225);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(214, 20);
            this.textBoxKm.TabIndex = 23;
            // 
            // textBoxDestinatie
            // 
            this.textBoxDestinatie.Location = new System.Drawing.Point(121, 135);
            this.textBoxDestinatie.Name = "textBoxDestinatie";
            this.textBoxDestinatie.Size = new System.Drawing.Size(214, 20);
            this.textBoxDestinatie.TabIndex = 22;
            // 
            // textBoxPlecare
            // 
            this.textBoxPlecare.Location = new System.Drawing.Point(121, 88);
            this.textBoxPlecare.Name = "textBoxPlecare";
            this.textBoxPlecare.Size = new System.Drawing.Size(214, 20);
            this.textBoxPlecare.TabIndex = 21;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(121, 46);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(214, 20);
            this.textBoxCod.TabIndex = 20;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(18, 184);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(68, 13);
            this.labelData.TabIndex = 19;
            this.labelData.Text = "Data plecare";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Location = new System.Drawing.Point(18, 228);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(55, 13);
            this.labelKm.TabIndex = 18;
            this.labelKm.Text = "Numar km";
            // 
            // labelDestinatie
            // 
            this.labelDestinatie.AutoSize = true;
            this.labelDestinatie.Location = new System.Drawing.Point(18, 138);
            this.labelDestinatie.Name = "labelDestinatie";
            this.labelDestinatie.Size = new System.Drawing.Size(79, 13);
            this.labelDestinatie.TabIndex = 17;
            this.labelDestinatie.Text = "Oras Destinatie";
            // 
            // labelPlecare
            // 
            this.labelPlecare.AutoSize = true;
            this.labelPlecare.Location = new System.Drawing.Point(18, 91);
            this.labelPlecare.Name = "labelPlecare";
            this.labelPlecare.Size = new System.Drawing.Size(67, 13);
            this.labelPlecare.TabIndex = 16;
            this.labelPlecare.Text = "Oras plecare";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(18, 49);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(47, 13);
            this.labelCod.TabIndex = 15;
            this.labelCod.Text = "Cod ruta";
            // 
            // buttonAnuleaza
            // 
            this.buttonAnuleaza.Location = new System.Drawing.Point(12, 340);
            this.buttonAnuleaza.Name = "buttonAnuleaza";
            this.buttonAnuleaza.Size = new System.Drawing.Size(136, 52);
            this.buttonAnuleaza.TabIndex = 21;
            this.buttonAnuleaza.Text = "Anuleaza";
            this.buttonAnuleaza.UseVisualStyleBackColor = true;
            this.buttonAnuleaza.Click += new System.EventHandler(this.buttonAnuleaza_Click);
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.Location = new System.Drawing.Point(211, 340);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(136, 52);
            this.buttonSalveaza.TabIndex = 22;
            this.buttonSalveaza.Text = "Salveaza";
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // FormularEditareRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 404);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.buttonAnuleaza);
            this.Controls.Add(this.groupBoxEditare);
            this.Name = "FormularEditareRute";
            this.Text = "Formular editare rute";
            this.Load += new System.EventHandler(this.FormularEditareRute_Load);
            this.groupBoxEditare.ResumeLayout(false);
            this.groupBoxEditare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditare;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.TextBox textBoxDestinatie;
        private System.Windows.Forms.TextBox textBoxPlecare;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Label labelDestinatie;
        private System.Windows.Forms.Label labelPlecare;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Button buttonAnuleaza;
        private System.Windows.Forms.Button buttonSalveaza;
    }
}