using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using ServerConsole;

namespace Server.SistemskeOperacije
{
    public class KreirajRezervaciju : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = new Rezervacija();
            r.Id = Broker.dajSesiju().vratiSifru(r);
            Broker.dajSesiju().sacuvaj(r);

            return r;
        }
    }
}
