using Domen;
using ServerConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class KreirajNovuDestinaciju:OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Destinacija d = new Destinacija();
            d.Id = Broker.dajSesiju().vratiSifru(d);
            Broker.dajSesiju().sacuvaj(d);

            return d;
        }
    }
}
