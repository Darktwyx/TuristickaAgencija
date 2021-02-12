using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
   
    public enum Operacije { Kraj=1,
        PrijaviRadnika = 2,
        KreirajTuristu = 3,
        ZapamtiTuristu = 4,
        KreirajDestinaciju = 5,
        VratiSveFakultativneIzlete = 6,
        VratiSveDestinacije = 7,
        ZapamtiDestinaciju = 8,
        PretraziRezervacije = 9,
        PretraziDestinacije = 10,
        UcitajDestinaciju = 11,
        ObrisiFakultativniIzlet = 12,
        ObrisiRezervaciju = 13,
        PrikaziFotografije = 14,
        KreirajFakultativniIzlet = 15,
        ZapamtiFakultativniIzlet = 16,
        PretraziFakultativneIzlete = 17,
        UcitajRezervaciju = 18,
        KreirajRezervaciju = 19,
        VratiSveTuriste = 20,
        VratiSveRadnike = 21,
        ZapamtiRezervaciju = 22,
        SacuvajFotografije = 24,
        ZapamtiRealizaciju = 26,
        VratiSifruDestinacije = 27,
        VratiSifruTuriste = 28,
        VratiSifruFakultativnogIzleta = 29,
        VratiSifruRezervacije = 30,
        SacuvajRealizaciju = 31,
        SacuvajDestinaciju = 32,
        IzmeniRezervaciju = 33,
        IzmeniDestinaciju = 34,
        IzmeniRealizaciju = 35,
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
        public bool UgasenServer;
    }
}
