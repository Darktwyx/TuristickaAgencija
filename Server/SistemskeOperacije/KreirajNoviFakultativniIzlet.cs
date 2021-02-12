using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using ServerConsole;

namespace Server.SistemskeOperacije
{
    public class KreirajNoviFakultativniIzlet : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            FakultativniIzlet f = new FakultativniIzlet();
            f.Id = Broker.dajSesiju().vratiSifru(f);
            Broker.dajSesiju().sacuvaj(f);

            return f;
        }
    }
}
