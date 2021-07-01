namespace Proiect_paw_wf
{
    partial class FormRute
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
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.labelPlecare = new System.Windows.Forms.Label();
            this.labelDestinatie = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxPlecare = new System.Windows.Forms.TextBox();
            this.textBoxDestinatie = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.buttonAdaugaRuta = new System.Windows.Forms.Button();
            this.buttonVizualizareRute = new System.Windows.Forms.Button();
            this.errorProviderRuta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPlecare = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDestinatie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderData = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPlecare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestinatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(180, 29);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(99, 17);
            this.labelTitlu.TabIndex = 0;
            this.labelTitlu.Text = "Adaugare rute";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(12, 77);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(47, 13);
            this.labelCod.TabIndex = 1;
            this.labelCod.Text = "Cod ruta";
            // 
            // labelPlecare
            // 
            this.labelPlecare.AutoSize = true;
            this.labelPlecare.Location = new System.Drawing.Point(12, 123);
            this.labelPlecare.Name = "labelPlecare";
            this.labelPlecare.Size = new System.Drawing.Size(67, 13);
            this.labelPlecare.TabIndex = 2;
            this.labelPlecare.Text = "Oras plecare";
            // 
            // labelDestinatie
            // 
            this.labelDestinatie.AutoSize = true;
            this.labelDestinatie.Location = new System.Drawing.Point(12, 170);
            this.labelDestinatie.Name = "labelDestinatie";
            this.labelDestinatie.Size = new System.Drawing.Size(79, 13);
            this.labelDestinatie.TabIndex = 3;
            this.labelDestinatie.Text = "Oras Destinatie";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Location = new System.Drawing.Point(12, 260);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(55, 13);
            this.labelKm.TabIndex = 4;
            this.labelKm.Text = "Numar km";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(105, 74);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(315, 20);
            this.textBoxCod.TabIndex = 5;
            this.textBoxCod.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCod_Validating);
            this.textBoxCod.Validated += new System.EventHandler(this.textBoxCod_Validated);
            // 
            // textBoxPlecare
            // 
            this.textBoxPlecare.Location = new System.Drawing.Point(105, 120);
            this.textBoxPlecare.Name = "textBoxPlecare";
            this.textBoxPlecare.Size = new System.Drawing.Size(315, 20);
            this.textBoxPlecare.TabIndex = 6;
            this.textBoxPlecare.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPlecare_Validating);
            this.textBoxPlecare.Validated += new System.EventHandler(this.textBoxPlecare_Validated);
            // 
            // textBoxDestinatie
            // 
            this.textBoxDestinatie.Location = new System.Drawing.Point(105, 167);
            this.textBoxDestinatie.Name = "textBoxDestinatie";
            this.textBoxDestinatie.Size = new System.Drawing.Size(315, 20);
            this.textBoxDestinatie.TabIndex = 7;
            this.textBoxDestinatie.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDestinatie_Validating);
            this.textBoxDestinatie.Validated += new System.EventHandler(this.textBoxDestinatie_Validated);
            // 
            // textBoxKm
            // 
            this.textBoxKm.Location = new System.Drawing.Point(105, 257);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(315, 20);
            this.textBoxKm.TabIndex = 8;
            this.textBoxKm.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKm_Validating);
            this.textBoxKm.Validated += new System.EventHandler(this.textBoxKm_Validated);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(12, 216);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(68, 13);
            this.labelData.TabIndex = 10;
            this.labelData.Text = "Data plecare";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(105, 210);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(315, 20);
            this.dateTimePickerData.TabIndex = 11;
            this.dateTimePickerData.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerData_Validating);
            this.dateTimePickerData.Validated += new System.EventHandler(this.dateTimePickerData_Validated);
            // 
            // buttonAdaugaRuta
            // 
            this.buttonAdaugaRuta.Location = new System.Drawing.Point(249, 312);
            this.buttonAdaugaRuta.Name = "buttonAdaugaRuta";
            this.buttonAdaugaRuta.Size = new System.Drawing.Size(171, 61);
            this.buttonAdaugaRuta.TabIndex = 12;
            this.buttonAdaugaRuta.Text = "Adauga ruta";
            this.buttonAdaugaRuta.UseVisualStyleBackColor = true;
            this.buttonAdaugaRuta.Click += new System.EventHandler(this.buttonAdaugaRuta_Click);
            // 
            // buttonVizualizareRute
            // 
            this.buttonVizualizareRute.Location = new System.Drawing.Point(12, 312);
            this.buttonVizualizareRute.Name = "buttonVizualizareRute";
            this.buttonVizualizareRute.Size = new System.Drawing.Size(171, 61);
            this.buttonVizualizareRute.TabIndex = 13;
            this.buttonVizualizareRute.Text = "Vizualizare rute";
            this.buttonVizualizareRute.UseVisualStyleBackColor = true;
            this.buttonVizualizareRute.Click += new System.EventHandler(this.buttonVizualizareRute_Click);
            // 
            // errorProviderRuta
            // 
            this.errorProviderRuta.ContainerControl = this;
            // 
            // errorProviderPlecare
            // 
            this.errorProviderPlecare.ContainerControl = this;
            // 
            // errorProviderDestinatie
            // 
            this.errorProviderDestinatie.ContainerControl = this;
            // 
            // errorProviderKm
            // 
            this.errorProviderKm.ContainerControl = this;
            // 
            // errorProviderData
            // 
            this.errorProviderData.ContainerControl = this;
            // 
            // FormRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 406);
            this.Controls.Add(this.buttonVizualizareRute);
            this.Controls.Add(this.buttonAdaugaRuta);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.textBoxDestinatie);
            this.Controls.Add(this.textBoxPlecare);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.labelKm);
            this.Controls.Add(this.labelDestinatie);
            this.Controls.Add(this.labelPlecare);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.labelTitlu);
            this.Name = "FormRute";
            this.Text = "Rute";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPlecare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestinatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labelPlecare;
        private System.Windows.Forms.Label labelDestinatie;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxPlecare;
        private System.Windows.Forms.TextBox textBoxDestinatie;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonAdaugaRuta;
        private System.Windows.Forms.Button buttonVizualizareRute;
        private System.Windows.Forms.ErrorProvider errorProviderRuta;
        private System.Windows.Forms.ErrorProvider errorProviderPlecare;
        private System.Windows.Forms.ErrorProvider errorProviderDestinatie;
        private System.Windows.Forms.ErrorProvider errorProviderKm;
        private System.Windows.Forms.ErrorProvider errorProviderData;
    }
}

