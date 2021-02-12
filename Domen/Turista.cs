using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Turista:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime + " " + prezime;
        }

        //Atributi
        int id;
        string ime;
        string prezime;
        string adresa;
        DateTime datumRodjenja;
        string brojTelefona;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        [DisplayName("Datum rodjenja")]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        [DisplayName("Broj telefona")]
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }


        //ODO deo
        [Browsable(false)]
        public string nazivTabele => "Turista";
        [Browsable(false)]
        public string primarniKljuc => "turistaID";
        [Browsable(false)]
        public string uslovPrimarni => "turistaID="+Id;
        [Browsable(false)]
        public string Uslov => " Ime is null";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " Ime='"+Ime+"', Prezime='"+Prezime+"', Adresa='"+Adresa+"', datumRodjenja='"+DatumRodjenja.ToShortDateString()+"', brojTelefona='"+BrojTelefona+"'";
        [Browsable(false)]
        public string unos => " values ("+Id+",'"+Ime+"','"+Prezime+"','"+Adresa+"','"+DatumRodjenja.ToShortDateString()+"','"+BrojTelefona+"')";
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Turista t = new Turista();
            t.Id = Convert.ToInt32(red["turistaID"]);
            t.Ime = red["Ime"].ToString();
            t.Prezime = red["Prezime"].ToString();
            t.Adresa = red["Adresa"].ToString();
            t.DatumRodjenja = Convert.ToDateTime(red["datumRodjenja"]);
            t.BrojTelefona = red["brojTelefona"].ToString();

            return t;

        }
    }
}
