using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw_wf.Modele
{
    [Serializable]
    public class Ruta
    {
        public int Id { get; set; } //PK
        public int CompanieId { get; set; } //FK

        public string Cod { get; set; }
        public string Plecare { get; set; }
        public string Destinatie { get; set; }
        public DateTime DataPlecare { get; set; }
        public float Pret;
        public int NrKm { get; set; }

        public Ruta()
        {
            this.Cod = "12345";
            this.Plecare = "";
            this.Destinatie = "";
            this.DataPlecare = DateTime.Now;
            this.NrKm = 0;
            this.Pret = this.NrKm / 10.5f;
        }

        public Ruta(string Cod, string Plecare, string Destinatie, DateTime DataPlecare, int NrKm)
        {
            this.Cod = Cod;
            this.Plecare = Plecare;
            this.Destinatie = Destinatie;
            this.DataPlecare = DataPlecare;
            this.NrKm = NrKm;
            this.Pret = this.NrKm / 10.5f;
        }

        #region getteri si setteri
        public string GetCod()
        {
            return this.Cod;
        }

        public string GetPlecare()
        {
            return this.Plecare;
        }

        public string GetDestinatie()
        {
            return this.Destinatie;
        }

        public DateTime GetData()
        {
            return this.DataPlecare;
        }

        public int GetKm()
        {
            return this.NrKm;
        }

        public float GetPret()
        {
            return this.Pret;
        }

        public void SetCod(string Cod)
        {
            this.Cod = Cod;
        }

        public void SetPlecare (string Plecare)
        {
            this.Plecare = Plecare;
        }

        public void SetDestinatie(string Destinatie)
        {
            this.Destinatie = Destinatie;
        }

        public void SetData (DateTime Data)
        {
            this.DataPlecare = Data;
        }

        public void SetKm (int km)
        {
            this.NrKm = km;
        }

        public void SetPret(int NrKm)
        {
            this.Pret = NrKm / 10.5f;
        }
        #endregion
    }
}
