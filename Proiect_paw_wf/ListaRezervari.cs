using Proiect_paw_wf.Modele;
using Proiect_paw_wf.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_paw_wf
{
    public partial class ListaRezervari : Form
    {
        public List<Rezervare>  rezervari = new List<Rezervare>();
        float[] preturi = new float[100];
        int i_preturi = 0;
        string[] numeCompanii = new string[100];
        int i_numeCompanii = 0;

        public ListaRezervari()
        {
            InitializeComponent();
        }

        public ListaRezervari(float[] preturi, string[] numeCompanii, List<Rezervare> rezervari)
        {
            this.preturi = new float[preturi.Length];
            this.numeCompanii = new string[numeCompanii.Length];
            this.preturi = preturi;
            this.numeCompanii = numeCompanii;
            this.rezervari = rezervari;
            InitializeComponent();
        }

        public ListaRezervari(List<Rezervare> rezervari)
        {
            this.rezervari = rezervari;
            InitializeComponent();
        }

        public void AdaugaRezervare(Rezervare r, float[] preturi, string[] numeCompanii, int i)
        {
            rezervari.Add(r);
            string nume = r.GetNume();
            string plecare = r.GetPlecare();
            string sosire = r.GetSosire();
            int nrBilete = r.GetBilete();
            this.preturi = preturi;
            this.numeCompanii = numeCompanii;
            float pret = preturi[i];
            string numeCompanie = numeCompanii[i];
            ListViewItem lvi = new ListViewItem(new string[] { nume, plecare, sosire, pret.ToString(), numeCompanie});
            listViewRezervari.Items.Add(lvi);
        }

        public void ClearRezervare()
        {
            listViewRezervari.Items.Clear();
        }

        public void ClearRezervari()
        {
            rezervari.Clear();
        }

        #region Printare

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;

                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 18);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);

            PageSettings settings = printDocument.DefaultPageSettings;

            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalDrawableW;
                totalDrawableW = totalDrawableH;
                totalDrawableH = temp;
            }

            int cellWidth = totalDrawableW / 5;
            int cellHeight = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawString("Lista rezervari", font, brush, totalDrawableW / 3, y);

            y += 100;

            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth * 2, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth * 3, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth * 4, y, cellWidth, cellHeight);

            graphics.DrawString("Nume", font, brush, x, y);
            graphics.DrawString("Plecare", font, brush, x + cellWidth, y);
            graphics.DrawString("Sosire", font, brush, x + cellWidth * 2, y);
            graphics.DrawString("Pret", font, brush, x + cellWidth * 3, y);
            graphics.DrawString("Companie", font, brush, x + cellWidth * 4, y);

            y += cellHeight;
            i_preturi = 0;
                i_numeCompanii = 0;
            foreach(Rezervare r in rezervari)
            {
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth * 2, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth * 3, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth * 4, y, cellWidth, cellHeight);

                graphics.DrawString(r.GetNume(), font, brush, x, y);
                graphics.DrawString(r.GetPlecare(), font, brush, x + cellWidth, y);
                graphics.DrawString(r.GetSosire(), font, brush, x + cellWidth * 2, y);
                graphics.DrawString(preturi[i_preturi].ToString() + "€", font, brush, x + cellWidth * 3, y);
                i_preturi++;
                graphics.DrawString(numeCompanii[i_numeCompanii], font, brush, x + cellWidth * 4, y);
                i_numeCompanii++;


                y += cellHeight;
            }

        }
        #endregion

        private void listViewRezervari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.P && e.Control)
            {
                toolStripButtonPrint_Click(sender, e);
            }
        }
    }
}
