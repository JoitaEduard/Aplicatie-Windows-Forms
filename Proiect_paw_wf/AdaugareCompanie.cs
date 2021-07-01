using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Proiect_paw_wf.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_paw_wf
{
    public partial class AdaugareCompanie : Form
    {
        public List<Companie> companii = new List<Companie>();
        public List<Ruta> rute = new List<Ruta>();
        ALApplicationContext ctx;

        public AdaugareCompanie()
        {
            InitializeComponent();
            ctx = new ALApplicationContext();
        }

        private void buttonAdaugaRute_Click(object sender, EventArgs e)
        {
            if (textBoxNumeCompanie.Text != "")
            {
                FormRute AdaugareRute = new FormRute();
                AdaugareRute.ShowDialog();

                rute.Clear();
                foreach (Ruta r in AdaugareRute.rute)
                {
                    rute.Add(r);
                }
                MessageBox.Show("Rutele pentru compania " + textBoxNumeCompanie.Text + " au fost adugate");

                if(AdaugareRute.ShowDialog() == DialogResult.Cancel)
                {
                    listBoxRute.Items.Clear();
                    String[] coduri = new string[rute.Count];
                    int index = 0;
                    foreach(Ruta r in rute)
                    {
                        coduri[index] = r.Cod;
                        index++;
                    }
                    listBoxRute.DataSource = coduri;
                    statusStripLabel.Text = "Numar rute: " + rute.Count;
                }
            }
            else
            {
                MessageBox.Show("Adaugati numele companiei mai intai.", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdaugareCompanie_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                bool valid;

                string nume;
                nume = textBoxNumeCompanie.Text;
                if (String.IsNullOrEmpty(nume) || String.IsNullOrWhiteSpace(nume) || nume.Length < 3)
                {
                    valid = false;
                }

                string tipBilete;
                tipBilete = textBoxBilete.Text;
                if (String.IsNullOrEmpty(tipBilete) || String.IsNullOrWhiteSpace(tipBilete) || tipBilete.Length < 3)
                {
                    valid = false;
                }

                if (valid = true)
                {
                    Companie c = new Companie(nume, rute, tipBilete);
                    companii.Add(c);

                    ctx.Companii.Add(c);

                    MessageBox.Show("Compania " + nume + " a fost adaugata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxBilete.Clear();
                    textBoxNumeCompanie.Clear();
                }
                else
                {
                    MessageBox.Show("Eroare la datele din formular", "Esec!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Companie c = companieBindingSource.Current as Companie;
                c.Nume = textBoxNumeCompanie.Text;
                c.TipBilete = textBoxBilete.Text;
                c.Rute = rute;
                ctx.Companii.Update(c);

                Companie c1 = new Companie(textBoxNumeCompanie.Text, rute, textBoxBilete.Text);

                textBoxBilete.Clear();
                textBoxNumeCompanie.Clear();

            }

            ctx.SaveChanges();
            companieBindingSource.DataSource = ctx.Companii.ToList();


        }

        private void AdaugareCompanie_Load(object sender, EventArgs e)
        {
            companieBindingSource.DataSource = ctx.Companii.ToList();
            int i = ctx.Companii.Count();
            Companie c = new Companie();
            for(int j=0; j<i;j++)
            {
                c = companieBindingSource[j] as Companie;
                companii.Add(c);
            }

            rute = ctx.Rute.ToList();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doriti sa stergeti compania?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ctx.Companii.Remove(companieBindingSource.Current as Companie);
                    ctx.SaveChanges();
                    companieBindingSource.DataSource = ctx.Companii.ToList();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularPrincipal fp = new FormularPrincipal();
            fp.ShowDialog();
            this.Close();
        }
    }
}
