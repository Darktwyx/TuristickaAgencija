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
    public class Destinacija:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv;
        }

        //Atributi
        int id;
        string naziv;
        string opis;
        DateTime datumPolaska;
        DateTime datumDolaska;
        string prevoz;
        double cena;

        List<RealizacijaIzleta> listaRealizacija;

        BindingList<FotografijeDestinacije> galerijaFotografija;


        public BindingList<FotografijeDestinacije> GalerijaFotografija { get => galerijaFotografija; set => galerijaFotografija = value; }

        public List<RealizacijaIzleta> ListaRealizacija { get => listaRealizacija; set => listaRealizacija = value; }

        public Destinacija()
        {
            galerijaFotografija = new BindingList<FotografijeDestinacije>();
            listaRealizacija = new List<RealizacijaIzleta>();
        }
        public int Id { get => id; set => id = value; }
        
        public string Naziv { get => naziv; set => naziv = value; }
        
        public string Opis { get => opis; set => opis = value; }
        [DisplayName("Datum polaska")]
        public DateTime DatumPolaska { get => datumPolaska; set => datumPolaska = value; }
        [DisplayName("Datum dolaska")]
        public DateTime DatumDolaska { get => datumDolaska; set => datumDolaska = value; }
        
        public string Prevoz { get => prevoz; set => prevoz = value; }
   
        public double Cena { get => cena; set => cena = value; }

        //ODO deo
        [Browsable(false)]
        public string nazivTabele => "Destinacija";
        [Browsable(false)]
        public string primarniKljuc => "destinacijaID";
        [Browsable(false)]
        public string Uslov = " Naziv is null";
        [Browsable(false)]
        public string uslovPrimarni => "destinacijaID=" + Id;
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " Naziv='"+Naziv+"', Opis='"+Opis+"', datumPolaska='"+DatumPolaska.ToShortDateString()+"', datumDolaska='"+DatumDolaska.ToShortDateString()+"', Prevoz='"+Prevoz+"', Cena="+Cena+"";
        [Browsable(false)]
        public string unos => " values ("+Id+",'"+Naziv+"','"+Opis+"','"+DatumPolaska.ToShortDateString()+"','"+DatumDolaska.ToShortDateString()+"','"+Prevoz+"',"+Cena+")";

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Destinacija d = new Destinacija();
            d.Id = Convert.ToInt32(red["destinacijaID"]);
            d.Naziv = red["Naziv"].ToString();
            d.Opis = red["Opis"].ToString();
            d.DatumPolaska = Convert.ToDateTime(red["datumPolaska"]);
            d.DatumDolaska = Convert.ToDateTime(red["datumDolaska"]);
            d.Prevoz = red["Prevoz"].ToString();
            d.Cena = Convert.ToDouble(red["Cena"]);
            

            return d;
        }



    }
}
