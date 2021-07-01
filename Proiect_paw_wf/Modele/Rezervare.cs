using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Proiect_paw_wf.Modele
{
    public class Rezervare
    {
        private string NumePresoana;
        private string Plecare;
        private string Sosire;
        private int NrBilete;

        public Rezervare(string nume, string plecare, string sosire, int nrBilete)
        {
            this.NumePresoana = nume;
            this.Plecare = plecare;
            this.Sosire = sosire;
            this.NrBilete = nrBilete;
        }

        public string GetNume()
        {
            return this.NumePresoana;
        }

        public string GetPlecare()
        {
            return this.Plecare;
        }

        public string GetSosire()
        {
            return this.Sosire;
        }

        public int GetBilete()
        {
            return this.NrBilete;
        }
    }
}
