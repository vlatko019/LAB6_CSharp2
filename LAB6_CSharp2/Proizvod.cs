using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_CSharp2
{
    class Proizvod
    {
        private string Naziv;
        private decimal BrojProizvodaUPaketu;
        private decimal BrojPaketa;
        private StatusProizvoda Status;

        public enum StatusProizvoda { Narucen, USkladistu, UProdaji };

        public void SetNaziv(string Naziv)
        {
            this.Naziv = Naziv;
        }

        public void SetBPUP(decimal BrojProizvodaUPaketu)
        {
            this.BrojProizvodaUPaketu = BrojProizvodaUPaketu;
        }

        public void SetBP(decimal BrojPaketa)
        {
            this.BrojPaketa = BrojPaketa;
        }

        public void SetStatus(StatusProizvoda Status)
        {
            this.Status = Status;
        }

        public string Get()
        {
            return (Naziv + " " + Status + " kolicina:" + BrojPaketa*BrojProizvodaUPaketu);
        }

        public StatusProizvoda GetStatus()
        {
            return 0;
        }

        public static void SaveToFile()
        {

        }

    }
}
