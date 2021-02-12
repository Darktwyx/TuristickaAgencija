using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using ServerConsole;

namespace Server.SistemskeOperacije
{
    public class PretraziFakultativneIzlete : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().vratiSveZaUslovOstalo(odo).OfType<FakultativniIzlet>().ToList<FakultativniIzlet>();
        }
    }
}
