using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using ServerConsole;

namespace Server.SistemskeOperacije
{
    public class ZapamtiDestinaciju : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Destinacija d = odo as Destinacija;
            Broker.dajSesiju().izmeniUslovPrimarni(odo);

            RealizacijaIzleta ri = new RealizacijaIzleta();
            ri.Uslov = " DestinacijaID="+d.Id;
            Broker.dajSesiju().obrisiZaUslovOstalo(ri);

            foreach (RealizacijaIzleta r in d.ListaRealizacija)
            {
                Broker.dajSesiju().sacuvaj(r);
            }


            return true;
        }
    }
}
