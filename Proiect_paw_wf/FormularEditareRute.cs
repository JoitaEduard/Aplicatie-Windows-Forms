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
    public partial class FormularEditareRute : Form
    {
        Ruta temp;
        public FormularEditareRute(Ruta ruta)
        {
            InitializeComponent();
            temp = ruta;
        }

        private void buttonAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            temp.SetCod(textBoxCod.Text);
            temp.SetPlecare(textBoxPlecare.Text);
            temp.SetDestinatie(textBoxDestinatie.Text);
            temp.SetData(dateTimePickerData.Value);
            temp.SetKm(int.Parse(textBoxKm.Text));

            this.Close();
            MessageBox.Show("Datele au fost salvate cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormularEditareRute_Load(object sender, EventArgs e)
        {
            //preiau datele din FormularRute
            textBoxCod.Text = temp.GetCod();
            textBoxPlecare.Text = temp.GetPlecare();
            textBoxDestinatie.Text = temp.GetDestinatie();
            textBoxKm.Text = temp.GetKm().ToString();
            dateTimePickerData.Value = temp.GetData();
        }
    }
}
