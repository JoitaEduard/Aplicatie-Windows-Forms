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
    public partial class FormularPrincipal : Form
    {
        List<Companie> companii = new List<Companie>();
        List<Ruta> rute = new List<Ruta>();
        List<Rezervare> rezervari = new List<Rezervare>();

        public FormularPrincipal()
        {
            InitializeComponent();
        }

        private void vizualizeazaCompaniiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareCompanie ac = new AdaugareCompanie();
            ac.ShowDialog();
        }

        private void vizualizeazaRuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaRezervari lr = new ListaRezervari();
            lr.ShowDialog();
        }

        private void buttonCompanie_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareCompanie ac = new AdaugareCompanie();
            ac.ShowDialog();
            this.companii = ac.companii;
            this.rute = ac.rute;
            this.Show();
        }

        private void buttonRezervare_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareRezervari ar = new AdaugareRezervari(companii);
            ar.ShowDialog();
            this.Show();
        }
    }
}
