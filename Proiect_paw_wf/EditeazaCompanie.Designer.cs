namespace Proiect_paw_wf
{
    partial class EditeazaCompanie
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
            this.labelNume = new System.Windows.Forms.Label();
            this.labelBilete = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxBilete = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(12, 22);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelBilete
            // 
            this.labelBilete.AutoSize = true;
            this.labelBilete.Location = new System.Drawing.Point(12, 57);
            this.labelBilete.Name = "labelBilete";
            this.labelBilete.Size = new System.Drawing.Size(50, 13);
            this.labelBilete.TabIndex = 1;
            this.labelBilete.Text = "Tip bilete";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(148, 19);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(160, 20);
            this.textBoxNume.TabIndex = 2;
            // 
            // textBoxBilete
            // 
            this.textBoxBilete.Location = new System.Drawing.Point(148, 54);
            this.textBoxBilete.Name = "textBoxBilete";
            this.textBoxBilete.Size = new System.Drawing.Size(160, 20);
            this.textBoxBilete.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salveaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditeazaCompanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBilete);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelBilete);
            this.Controls.Add(this.labelNume);
            this.Name = "EditeazaCompanie";
            this.Text = "EditeazaCompanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelBilete;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxBilete;
        private System.Windows.Forms.Button button1;
    }
}