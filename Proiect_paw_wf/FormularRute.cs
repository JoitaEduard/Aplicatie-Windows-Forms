using Proiect_paw_wf.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_paw_wf
{
    public partial class FormRute : Form
    {
        public List<Ruta> rute = new List<Ruta>();
        ListaRute lr = new ListaRute();

        public FormRute()
        {
            InitializeComponent();
        }

        private void CurataFormular()
        {
            textBoxCod.Clear();
            textBoxPlecare.Clear();
            textBoxDestinatie.Clear();
            textBoxKm.Clear();
            dateTimePickerData.Value = DateTime.Now;
        }

        private void buttonAdaugaRuta_Click(object sender, EventArgs e)
        {
            bool valid = true;

            String cod = textBoxCod.Text;
            if(String.IsNullOrEmpty(cod) || String.IsNullOrWhiteSpace(cod) ||cod.Length < 5)
            {
                valid = false;
            }

            String plecare = textBoxPlecare.Text;
            if(String.IsNullOrEmpty(plecare) || String.IsNullOrWhiteSpace(plecare) || plecare.Length < 3)
            {
                valid = false;
            }

            String destinatie = textBoxDestinatie.Text;
            if(String.IsNullOrEmpty(destinatie) || String.IsNullOrWhiteSpace(destinatie) || destinatie.Length < 3)
            {
                valid = false;
            }

            int.TryParse(textBoxKm.Text, out int km);
            if(km == 0)
            {
                valid = false;
            }

            DateTime data = dateTimePickerData.Value;
            if(DateTime.Compare(data, DateTime.Now) < 0)
            {
                valid = false;
            }

            if (valid)
            {
                Ruta r = new Ruta(cod, plecare, destinatie, data, km);
                rute.Add(r);

                lr.ClearRuta();
                lr.ClearRute();

                foreach (Ruta ru in rute)
                {
                    lr.AdaugaRuta(ru);
                }

                CurataFormular();
                MessageBox.Show("Ruta a fost adaugata!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Formularul contine erori!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonVizualizareRute_Click(object sender, EventArgs e)
        {
            lr.ShowDialog();
            rute.Clear();
            foreach (Ruta r in lr.rute)
            {
                rute.Add(r);
            }
        }

        public void StergeRute()
        {
            rute.Clear();
        }

        #region Validatori
        private void textBoxCod_Validated(object sender, EventArgs e)
        {
            errorProviderRuta.Clear();
        }

        private void textBoxCod_Validating(object sender, CancelEventArgs e)
        {
            String cod = textBoxCod.Text;

            if (String.IsNullOrEmpty(cod) || String.IsNullOrWhiteSpace(cod) || cod.Length < 5)
            {
                //errorProviderRuta.SetError(textBoxCod, "Introduceti un cod valid.");
                errorProviderRuta.SetError((Control)sender, "Introduceti un cod valid.");
                e.Cancel = true;
            }
        }

        private void textBoxPlecare_Validated(object sender, EventArgs e)
        {
            errorProviderPlecare.Clear();
        }

        private void textBoxPlecare_Validating(object sender, CancelEventArgs e)
        {
            String plecare = textBoxPlecare.Text;

            if (String.IsNullOrEmpty(plecare) || String.IsNullOrWhiteSpace(plecare) || plecare.Length < 3)
            {
                errorProviderPlecare.SetError((Control)sender, "Introduceti un oras valid.");
                e.Cancel = true;
            }
        }

        private void textBoxDestinatie_Validated(object sender, EventArgs e)
        {
            errorProviderDestinatie.Clear();
        }

        private void textBoxDestinatie_Validating(object sender, CancelEventArgs e)
        {

            String destinatie = textBoxDestinatie.Text;
            if (String.IsNullOrEmpty(destinatie) || String.IsNullOrWhiteSpace(destinatie) || destinatie.Length < 3)
            {
                errorProviderDestinatie.SetError((Control)sender, "Introduceti un oras valid.");
                e.Cancel = true;
            }
        }

        private void textBoxKm_Validated(object sender, EventArgs e)
        {
            errorProviderKm.Clear();
        }

        private void textBoxKm_Validating(object sender, CancelEventArgs e)
        {
            int km;
            int.TryParse(textBoxKm.Text, out km);
            if (km < 0)
            {
                errorProviderKm.SetError((Control)sender, "Introduceti un numar.");
                e.Cancel = true;
            }
        }

        private void dateTimePickerData_Validated(object sender, EventArgs e)
        {
            errorProviderData.Clear();
        }

        private void dateTimePickerData_Validating(object sender, CancelEventArgs e)
        {
            DateTime data = dateTimePickerData.Value;
            if (DateTime.Compare(data, DateTime.Now) < 0 || DateTime.Compare(data, new DateTime(2021, 09, 30))>0)
            {
                errorProviderData.SetError((Control)sender, "Introduceti o data valida(pana pe 30 septembrie).");
                e.Cancel = true;
            }
        }
        #endregion

    }
}
