using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using ServerConsole;

namespace Server.SistemskeOperacije
{
    public class VratiSveDestinacije : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Destinacija d = new Destinacija();
            d.Uslov = " Naziv is null";
            Broker.dajSesiju().obrisiZaUslovOstalo(d);

            return Broker.dajSesiju().vratiSve(odo).OfType<Destinacija>().ToList<Destinacija>();
        }
    }
}
