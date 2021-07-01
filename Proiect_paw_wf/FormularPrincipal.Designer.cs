namespace Proiect_paw_wf
{
    partial class FormularPrincipal
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
            this.labelTitlu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRezervare = new System.Windows.Forms.Button();
            this.buttonCompanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(207, 44);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(154, 22);
            this.labelTitlu.TabIndex = 0;
            this.labelTitlu.Text = "GestionareAirLine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doresti sa adaugi o rezervare?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doresti sa adaugi o companie?";
            // 
            // buttonRezervare
            // 
            this.buttonRezervare.Location = new System.Drawing.Point(30, 139);
            this.buttonRezervare.Name = "buttonRezervare";
            this.buttonRezervare.Size = new System.Drawing.Size(201, 58);
            this.buttonRezervare.TabIndex = 3;
            this.buttonRezervare.Text = "Adauga rezervare";
            this.buttonRezervare.UseVisualStyleBackColor = true;
            this.buttonRezervare.Click += new System.EventHandler(this.buttonRezervare_Click);
            // 
            // buttonCompanie
            // 
            this.buttonCompanie.Location = new System.Drawing.Point(331, 139);
            this.buttonCompanie.Name = "buttonCompanie";
            this.buttonCompanie.Size = new System.Drawing.Size(201, 58);
            this.buttonCompanie.TabIndex = 4;
            this.buttonCompanie.Text = "Adauga companie";
            this.buttonCompanie.UseVisualStyleBackColor = true;
            this.buttonCompanie.Click += new System.EventHandler(this.buttonCompanie_Click);
            // 
            // FormularPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 221);
            this.Controls.Add(this.buttonCompanie);
            this.Controls.Add(this.buttonRezervare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitlu);
            this.Name = "FormularPrincipal";
            this.Text = "Gestionare Air Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRezervare;
        private System.Windows.Forms.Button buttonCompanie;
    }
}