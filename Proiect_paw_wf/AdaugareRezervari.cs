using Proiect_paw_wf.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_paw_wf
{
    public partial class AdaugareRezervari : Form
    {
        List<Rezervare> rezervari = new List<Rezervare>();
        ListaRezervari lr = new ListaRezervari();
        List<Companie> companii = new List<Companie>();
        float[] preturi = new float[100];
        int i_preturi = 0;
        string[] numeCompanii = new string[100];
        int i_numeCompanii = 0;

        public AdaugareRezervari()
        {
            InitializeComponent();
        }

        public AdaugareRezervari(List<Companie> c)
        {
            this.companii = c;
            InitializeComponent();
        }

        private void CurataFormular()
        {
            textBoxNume.Clear();
            textBoxPlecare.Clear();
            textBoxSosire.Clear();
            numericUpDown.Value = 0;
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string nume;
            nume = textBoxNume.Text;
            if(String.IsNullOrEmpty(nume) || String.IsNullOrWhiteSpace(nume) || nume.Length < 3)
            {
                valid = false;
            }

            string plecare;
            plecare = textBoxPlecare.Text;
            if (String.IsNullOrEmpty(plecare) || String.IsNullOrWhiteSpace(plecare) || plecare.Length < 3)
            {
                valid = false;
            }

            string sosire;
            sosire = textBoxSosire.Text;
            if (String.IsNullOrEmpty(sosire) || String.IsNullOrWhiteSpace(sosire) || sosire.Length < 3)
            {
                valid = false;
            }

            int nrBilete;
            nrBilete = Convert.ToInt32(numericUpDown.Value);
            if(nrBilete <= 0)
            {
                valid = false;
            }

            if(valid)
            {
                Rezervare r = new Rezervare(nume, plecare, sosire, nrBilete);
                bool semafor = false;
                foreach(Companie c in companii)
                {
                    foreach(Ruta ruta in c.Rute)
                    {
                        if(r.GetPlecare().Equals(ruta.GetPlecare()) && r.GetSosire().Equals(ruta.GetDestinatie()))
                        {
                            if (MessageBox.Show("Rezervarea este posibila la compania "+ c.GetNume() + " si are pretul: " + (ruta.GetKm() /10.5f)*r.GetBilete() + " Euro. Doriti sa continuati?", "Continuare", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                semafor = true;
                                preturi[i_preturi] = (ruta.GetKm() / 10.5f)*r.GetBilete();
                                i_preturi++;
                                numeCompanii[i_numeCompanii] = c.Nume;
                                i_numeCompanii++;
                                MessageBox.Show("Rezervarea a fost facuta.");
                                rezervari.Add(r);

                                lr.ClearRezervare();
                                lr.ClearRezervari();
                                int i = 0;
                                foreach (Rezervare re in rezervari)
                                {
                                    lr.AdaugaRezervare(re, preturi, numeCompanii, i);
                                    i++;
                                }
                                CurataFormular();

                            }
                        }
                    }
                }
                if(semafor == false)
                {
                    MessageBox.Show("Nu exista ruta aleasa.");
                }
            }
            else
            {
                MessageBox.Show("Formularul contine erori.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void vizualizareRezervariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lr = new ListaRezervari(preturi, numeCompanii, rezervari);
            //lr = new ListaRezervari(rezervari);
            lr.ShowDialog();
        }
    }
}
