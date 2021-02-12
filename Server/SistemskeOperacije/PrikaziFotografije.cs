using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using ServerConsole;

namespace Server.SistemskeOperacije
{
    public class PrikaziFotografije : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Destinacija d = odo as Destinacija;

            FotografijeDestinacije fd = new FotografijeDestinacije();
         
           
            List<FotografijeDestinacije> lista = Broker.dajSesiju().vratiSveZaUslovOstalo(fd).OfType<FotografijeDestinacije>().ToList<FotografijeDestinacije>();
            d.GalerijaFotografija = new System.ComponentModel.BindingList<FotografijeDestinacije>(lista);

            return lista;
        }
    }
}
