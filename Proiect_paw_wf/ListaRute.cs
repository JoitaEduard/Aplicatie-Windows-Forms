using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proiect_paw_wf.Modele
{
    public partial class ListaRute : Form
    {
        public List<Ruta> rute = new List<Ruta>();
        public ListaRute()
        {
            InitializeComponent();
        }

        public ListaRute(List<Ruta> rute)
        {
            this.rute = rute;
            InitializeComponent();
        }

        public void AdaugaRuta(Ruta r)
        {
            rute.Add(r);
            string cod = r.GetCod();
            string plecare = r.GetPlecare();
            string destinatie = r.GetDestinatie();
            DateTime data = r.GetData();
            int km = r.GetKm();
            ListViewItem lvi = new ListViewItem(new string[] { cod, plecare, destinatie, data.ToString(), km.ToString() });
            listViewRute.Items.Add(lvi);
        }

        public void ClearRuta()
        {
            listViewRute.Items.Clear();
        }

        public void ClearRute()
        {
            rute.Clear();
        }

        private void ListaRuteClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void buttonEditeaza_Click(object sender, EventArgs e)
        {
            if (listViewRute.SelectedItems.Count != 0)
            {
                Ruta r = rute.ElementAt(listViewRute.SelectedIndices[0]);

                FormularEditareRute editare = new FormularEditareRute(r);
                editare.ShowDialog();
                PopulareListView();
                //actualizare informatie in list view
            }
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if(listViewRute.SelectedItems.Count != 0)
            {
                string mesaj = "Doresti sa stergi ruta " + listViewRute.SelectedItems[0].Text + "?";
                if (DialogResult.Yes == MessageBox.Show(mesaj, "Stergere ruta", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    rute.RemoveAt(listViewRute.SelectedIndices[0]);
                    PopulareListView();
                    
                }
            }
        }

        private void PopulareListView()
        {
            ClearRuta();
            foreach (Ruta ru in rute)
            {
                string cod = ru.GetCod();
                string plecare = ru.GetPlecare();
                string destinatie = ru.GetDestinatie();
                DateTime data = ru.GetData();
                int km = ru.GetKm();

                ListViewItem lvi = new ListViewItem(new string[] { cod, plecare, destinatie, data.ToString(), km.ToString() });
                listViewRute.Items.Add(lvi);
            }
        }

        private void listViewRute_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonEditeaza_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSterge_Click(sender, e);
        }

        private void listViewRute_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && listViewRute.FocusedItem.Bounds.Contains(e.Location))
            {
                buttonEditeaza_Click(sender, e);
            }
        }

        #region salvare/preluare
        private void menuStripSalvare_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Selecteaza fisierul: ";
            sfd.Filter = "Text files (*.txt)|*.txt|Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            sfd.FilterIndex = 3;

            if(sfd.ShowDialog() == DialogResult.OK && sfd.FileName!= "")
            {
                if (sfd.FilterIndex == 1 || sfd.FilterIndex == 3)
                {
                    //export fisier text
                    StreamWriter writer = new StreamWriter(sfd.FileName);
                    writer.Write("Cod Plecare Destinatie Data Plecare Pret Nr. Km\n");
                    foreach (Ruta ru in rute)
                    {
                        writer.Write(ru.GetCod() + " " + ru.GetPlecare() + " " + ru.GetDestinatie() + " " + ru.GetData() + " " + ru.GetPret() + " " + ru.GetKm() + "\n");
                    }
                    writer.Close();
                }
                else
                {
                    //export binar
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream stream = new FileStream(sfd.FileName, FileMode.CreateNew);
                    binaryFormatter.Serialize(stream, rute);
                    stream.Close();
                    MessageBox.Show("Fisierul " + sfd.FileName +  " a fost salvat!", "Succes", MessageBoxButtons.OK);
                }
            }           
        }

        private void menuStripPreluare_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisierul: ";
            ofd.Filter = "Text files (*.txt)|*.txt|Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName != "")
            {
                if (ofd.FilterIndex == 1 || ofd.FilterIndex == 3)
                {
                    listViewRute.Items.Clear();
                    rute.Clear();
                    StreamReader reader = new StreamReader(ofd.FileName);
                    string line = reader.ReadLine();
                    while((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            String[] tokens = line.Split(' ');
                            string cod = tokens[0];
                            string plecare = tokens[1];
                            string destinatie = tokens[2];
                            DateTime data = Convert.ToDateTime(tokens[3] + " " + tokens[4]);
                            float pret = float.Parse(tokens[5]);
                            int km = int.Parse(tokens[6]);
                            Ruta r = new Ruta(cod, plecare, destinatie, data, km);
                            rute.Add(r);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    reader.Close();
                    PopulareListView();
                }
                else
                {
                    //import binar
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream fileStream = File.OpenRead(ofd.FileName);
                    rute = binaryFormatter.Deserialize(fileStream) as List<Ruta>;
                    fileStream.Close();
                    PopulareListView();
                }
            }
        }
        #endregion
    }
}
