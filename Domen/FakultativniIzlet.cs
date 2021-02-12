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
    public class FakultativniIzlet:OpstiDomenskiObjekat
    {
        //Atributi

        int id;
        string mesto;
        string opis;
        double cena;

        
        public int Id { get => id; set => id = value; }
        
        public string Mesto { get => mesto; set => mesto = value; }
       
        public string Opis { get => opis; set => opis = value; }
        
        public double Cena { get => cena; set => cena = value; }

        public override string ToString()
        {
            return mesto + " - " + opis + " - " + cena;
        }

        [Browsable(false)]
        public string nazivTabele => "FakultativniIzlet";
        [Browsable(false)]
        public string primarniKljuc => "fakultativniIzletID";
        [Browsable(false)]
        public string uslovPrimarni => "fakultativniIzletID="+Id;
        [Browsable(false)]
        public string Uslov = " Mesto is null";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " fakultativniIzletId="+Id+", Mesto='"+Mesto+"', Opis='"+Opis+"', Cena="+Cena+"";
        [Browsable(false)]
        public string unos => " values ("+Id+",'"+Mesto+"','"+Opis+"',"+Cena+")";

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            FakultativniIzlet fi = new FakultativniIzlet();
            fi.Id = Convert.ToInt32(red["fakultativniIzletID"]);
            fi.Mesto = red["Mesto"].ToString();
            fi.Opis = red["Opis"].ToString();
            fi.Cena = Convert.ToDouble(red["Cena"]);

            return fi;
        }
    }
}
