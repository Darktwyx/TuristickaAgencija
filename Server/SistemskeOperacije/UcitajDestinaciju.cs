using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using ServerConsole;

namespace Server.SistemskeOperacije
{
    public class UcitajDestinaciju : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Destinacija d = Broker.dajSesiju().vratiZaUslovPrimarni(odo) as Destinacija;

            FotografijeDestinacije fd = new FotografijeDestinacije();
            fd.Uslov = "destinacijaID=" + d.Id;

            List<FotografijeDestinacije> lista = Broker.dajSesiju().vratiSveZaUslovOstalo(fd).OfType<FotografijeDestinacije>().ToList<FotografijeDestinacije>();

            foreach(FotografijeDestinacije f in lista)
            { 
                d.GalerijaFotografija.Add(f);
            }

            RealizacijaIzleta r = new RealizacijaIzleta();

            r.Uslov = "destinacijaID=" + d.Id;

            List<RealizacijaIzleta> listaR = Broker.dajSesiju().vratiSveZaUslovOstalo(r).OfType<RealizacijaIzleta>().ToList<RealizacijaIzleta>();

            foreach(RealizacijaIzleta ri in listaR)
            {
                ri.Destinacija = d;
                ri.FakultativniIzlet = Broker.dajSesiju().vratiZaUslovPrimarni(ri.FakultativniIzlet) as FakultativniIzlet;
                d.ListaRealizacija.Add(ri);
            }

            return d;

        }
    }
}
