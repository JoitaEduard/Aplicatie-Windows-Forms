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
    public partial class EditeazaCompanie : Form
    {
        public EditeazaCompanie()
        {
            InitializeComponent();
        }

        public string NumeNou;
        public string TipBileteNou;

        private void button1_Click(object sender, EventArgs e)
        {
            NumeNou = textBoxNume.Text;
            TipBileteNou = textBoxBilete.Text;
            this.Close();
        }
    }
}
