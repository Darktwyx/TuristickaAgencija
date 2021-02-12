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
    public class Radnik:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime + " " + prezime;
        }

        //Atributi
        int id;
        string ime;
        string prezime;
        string username;
        string password;

      
        public int Id { get => id; set => id = value; }
   
        public string Ime { get => ime; set => ime = value; }
     
        public string Prezime { get => prezime; set => prezime = value; }
        
        public string Username { get => username; set => username = value; }
        
        public string Password { get => password; set => password = value; }

        //ODO deo
        [Browsable(false)]
        public string nazivTabele => "Radnik";
        [Browsable(false)]
        public string primarniKljuc => "radnikID";
        [Browsable(false)]
        public string uslovPrimarni => "radnikID="+Id;
        [Browsable(false)]
        public string uslovOstalo =>  " Username='"+Username+"' and Password='"+Password+"'";
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Radnik r = new Radnik();
            r.Id = Convert.ToInt32(red["radnikID"]);
            r.Ime = red["Ime"].ToString();
            r.Prezime = red["Prezime"].ToString();
            r.Username = red["Username"].ToString();
            r.Password = red["Password"].ToString();

            return r;
        }

        

    }
}
