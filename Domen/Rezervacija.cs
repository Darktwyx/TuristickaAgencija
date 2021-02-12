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
    public class Rezervacija : OpstiDomenskiObjekat
    {
        //Atributi
        int id;
        DateTime datumRezervacije;
        string mestoPolaska;
        int brojTurista;
        Destinacija destinacija;
        Turista turista;
        Radnik radnik;

        public int Id { get => id; set => id = value; }
        [DisplayName("Datum rezervacije")]
        public DateTime DatumRezervacije { get => datumRezervacije; set => datumRezervacije = value; }
        [DisplayName("Mesto polaska")]
        public string MestoPolaska { get => mestoPolaska; set => mestoPolaska = value; }
        [DisplayName("Broj turista")]
        public int BrojTurista { get => brojTurista; set => brojTurista = value; }
        [Browsable(false)]
        public Destinacija Destinacija { get => destinacija; set => destinacija = value; }
        [Browsable(false)]
        public Turista Turista { get => turista; set => turista = value; }
        [Browsable(false)]
        public Radnik Radnik { get => radnik; set => radnik = value; }

        //ODO deo
        [Browsable(false)]
        public string nazivTabele => "Rezervacija";
        [Browsable(false)]
        public string primarniKljuc => "rezervacijaID";
        [Browsable(false)]
        public string uslovPrimarni => "rezervacijaID="+Id;
        [Browsable(false)]
        public string Uslov = " datumRezervacije is null";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " datumRezervacije='"+DatumRezervacije+"', mestoPolaska='"+MestoPolaska+"', brojTurista="+BrojTurista+", destinacijaID="+destinacija.Id+", turistaID="+turista.Id+", radnikID="+radnik.Id+"";
        [Browsable(false)]
        public string unos => " values ("+Id+",'"+DatumRezervacije.ToShortDateString()+"','"+MestoPolaska+"',"+BrojTurista+","+Destinacija.Id+","+Turista.Id+","+Radnik.Id+")";


        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Rezervacija r = new Rezervacija();
            r.Id = Convert.ToInt32(red["rezervacijaID"]);
            r.DatumRezervacije = Convert.ToDateTime(red["datumRezervacije"]);
            r.MestoPolaska = red["mestoPolaska"].ToString();
            r.BrojTurista = Convert.ToInt32(red["brojTurista"]);
            r.Destinacija = new Destinacija();
            r.Destinacija.Id = Convert.ToInt32(red["destinacijaID"]);
            r.Turista = new Turista();
            r.Turista.Id = Convert.ToInt32(red["turistaID"]);
            r.Radnik = new Radnik();
            r.Radnik.Id = Convert.ToInt32(red["radnikID"]);

            return r;
        }
    }
}
