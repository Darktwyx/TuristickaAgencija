using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using ServerConsole;

namespace Server.SistemskeOperacije
{
    public class UcitajRezervaciju : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = Broker.dajSesiju().vratiZaUslovPrimarni(odo) as Rezervacija;

            r.Destinacija = Broker.dajSesiju().vratiZaUslovPrimarni(r.Destinacija) as Destinacija;
            
            r.Turista = Broker.dajSesiju().vratiZaUslovPrimarni(r.Turista) as Turista;

            r.Radnik = Broker.dajSesiju().vratiZaUslovPrimarni(r.Radnik) as Radnik;

            return r;
            
        }
    }
}
