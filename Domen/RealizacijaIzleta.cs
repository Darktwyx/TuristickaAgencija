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
    public class RealizacijaIzleta : OpstiDomenskiObjekat
    {

        FakultativniIzlet fakultativniIzlet;
        Destinacija destinacija;
        DateTime datumRealizacije;

        //public int FakIzlID { get => fakIzlID; set => fakIzlID = value; }
        //public int DestID { get => destID; set => destID = value; }
        public DateTime DatumRealizacije { get => datumRealizacije; set => datumRealizacije = value; }
        public FakultativniIzlet FakultativniIzlet { get => fakultativniIzlet; set => fakultativniIzlet = value; }
        public Destinacija Destinacija { get => destinacija; set => destinacija = value; }

        [Browsable(false)]
        public string nazivTabele => "RealizacijaIzleta";
        [Browsable(false)]
        public string primarniKljuc => "destinacijaID and fakultativniIzletID";
        [Browsable(false)]
        public string uslovPrimarni => "destinacijaID="+Destinacija.Id+" and fakultativniIzletID="+FakultativniIzlet.Id;
        [Browsable(false)]
        public string Uslov = "";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " destinacijaID=" + Destinacija.Id + ", fakultativniIzletID=" + FakultativniIzlet.Id+", datumRealizacije = '"+DatumRealizacije+"'";
        [Browsable(false)]
        public string unos => " values ("+Destinacija.Id+","+FakultativniIzlet.Id+",'"+DatumRealizacije.ToShortDateString()+"')";

    

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            RealizacijaIzleta ri = new RealizacijaIzleta();
            Destinacija d = new Destinacija();
            FakultativniIzlet f = new FakultativniIzlet();

            ri.Destinacija = d;
            ri.FakultativniIzlet = f;

            ri.Destinacija.Id = Convert.ToInt32(red["destinacijaID"]);
            ri.FakultativniIzlet.Id = Convert.ToInt32(red["fakultativniIzletID"]);
            ri.DatumRealizacije = Convert.ToDateTime(red["datumRealizacije"]);


            return ri;
        }

    }
}
