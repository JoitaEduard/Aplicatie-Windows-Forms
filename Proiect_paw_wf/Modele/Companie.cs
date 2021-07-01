using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw_wf.Modele
{
    [Serializable]
    public class Companie
    {
        public int Id { get; set; } //PK in tabela
        public String Nume { get; set; }
        public List<Ruta> Rute { get; set; }
        public String TipBilete { get; set; }

        public Companie()
        {
            this.Nume = "";
            this.Rute = null;
            this.TipBilete = "";
        }

        public Companie(string nume, string tipBilete)
        {
            this.Nume = nume;
            this.TipBilete = tipBilete;
        }

        public Companie(string nume, List<Ruta> rute, string tipBilete)
        {
            this.Nume = nume;
            this.Rute = new List<Ruta>();
            foreach(Ruta r in rute)
            {
                this.Rute.Add(r);
            }
            this.TipBilete = tipBilete;
        }

        public List<Ruta> GetRute()
        {
            return this.Rute;
        }

        public string GetNume()
        {
            return this.Nume;
        }

        public string GetBilete()
        {
            return this.TipBilete;
        }

        public void SetBilete(string bilete)
        {
            this.TipBilete = bilete;
        }

        public void SetNume(string nume)
        {
            this.Nume = nume;
        }


    }
}
