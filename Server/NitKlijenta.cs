using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

using Server.SistemskeOperacije;


namespace ServerConsole
{
    class NitKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradi;
            new Thread(ts).Start();
        }

        void obradi()
        {
            try
            {
                int operacija = 0;
                while(operacija !=(int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                    if (Server.UgasenServer)
                    {
                        transfer.UgasenServer = true;
                        formater.Serialize(tok, transfer);                       
                        return;
                    }

                    switch (transfer.Operacija)
                    {
                        case Operacije.VratiSifruDestinacije:
                            VratiSifruDestinacije vratsifdes = new VratiSifruDestinacije();
                            transfer.Rezultat = vratsifdes.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSifruTuriste:
                            VratiSifruTuriste vratsifrtur = new VratiSifruTuriste();
                            transfer.Rezultat = vratsifrtur.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSifruFakultativnogIzleta:
                            VratiSifruFakultativnogIzleta vratsiffakiz = new VratiSifruFakultativnogIzleta();
                            transfer.Rezultat = vratsiffakiz.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSifruRezervacije:
                            VratiSifruRezervacije vratsifrez = new VratiSifruRezervacije();
                            transfer.Rezultat = vratsifrez.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajRealizaciju:
                            SacuvajRealizaciju sr = new SacuvajRealizaciju();
                            transfer.Rezultat = sr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajDestinaciju:
                            SacuvajDestinaciju sd = new SacuvajDestinaciju();
                            transfer.Rezultat = sd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniRezervaciju:
                            IzmeniRezervaciju izr = new IzmeniRezervaciju();
                            transfer.Rezultat = izr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniDestinaciju:
                            IzmeniDestinaciju izd = new IzmeniDestinaciju();
                            transfer.Rezultat = izd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniRealizaciju:
                            IzmeniRealizaciju izreal = new IzmeniRealizaciju();
                            transfer.Rezultat = izreal.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrijaviRadnika:
                            PrijaviRadnika pr = new PrijaviRadnika();
                            transfer.Rezultat = pr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajTuristu:
                            KreirajNovogTuristu knt = new KreirajNovogTuristu();
                            transfer.Rezultat = knt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;  
                        case Operacije.KreirajDestinaciju:
                            KreirajNovuDestinaciju knd = new KreirajNovuDestinaciju();
                            transfer.Rezultat = knd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajFakultativniIzlet:
                            KreirajNoviFakultativniIzlet knfi = new KreirajNoviFakultativniIzlet();
                            transfer.Rezultat = knfi.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajRezervaciju:
                            KreirajRezervaciju kr = new KreirajRezervaciju();
                            transfer.Rezultat = kr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiTuristu:
                            ZapamtiTuristu zt = new ZapamtiTuristu();
                            transfer.Rezultat = zt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiDestinaciju:
                            ZapamtiDestinaciju zd = new ZapamtiDestinaciju();
                            transfer.Rezultat = zd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiRezervaciju:
                            ZapamtiRezervaciju rz = new ZapamtiRezervaciju();
                            transfer.Rezultat = rz.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiFakultativniIzlet:
                            ZapamtiFakultativniIzlet zfi = new ZapamtiFakultativniIzlet();
                            transfer.Rezultat = zfi.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiRealizaciju:
                            ZapamtiRealizaciju zre = new ZapamtiRealizaciju();
                            transfer.Rezultat = zre.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajFotografije:
                            SacuvajFotografije sf = new SacuvajFotografije();
                            transfer.Rezultat = sf.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveFakultativneIzlete:
                            VratiSveFakultativneIzlete vsfi = new VratiSveFakultativneIzlete();
                            transfer.Rezultat = vsfi.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveDestinacije:
                            VratiSveDestinacije vsd = new VratiSveDestinacije();
                            transfer.Rezultat = vsd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveTuriste:
                            VratiSveTuriste vsvet = new VratiSveTuriste();
                            transfer.Rezultat = vsvet.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveRadnike:
                            VratiSveRadnike vsr = new VratiSveRadnike();
                            transfer.Rezultat = vsr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziRezervacije:
                            PretraziRezervacije prez = new PretraziRezervacije();
                            transfer.Rezultat = prez.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziDestinacije:
                            PretraziDestinacije pdes = new PretraziDestinacije();
                            transfer.Rezultat = pdes.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziFakultativneIzlete:
                            PretraziFakultativneIzlete pfi = new PretraziFakultativneIzlete();
                            transfer.Rezultat = pfi.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajDestinaciju:
                            UcitajDestinaciju ud = new UcitajDestinaciju();
                            transfer.Rezultat = ud.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajRezervaciju:
                            UcitajRezervaciju ur = new UcitajRezervaciju();
                            transfer.Rezultat = ur.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiFakultativniIzlet:
                            ObrisiFakultativniIzlet ofi = new ObrisiFakultativniIzlet();
                            transfer.Rezultat = ofi.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiRezervaciju:
                            ObrisiRezervaciju or = new ObrisiRezervaciju();
                            transfer.Rezultat = or.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrikaziFotografije:
                            PrikaziFotografije pf = new PrikaziFotografije();
                            transfer.Rezultat = pf.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;   
                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokova.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Server.listaTokova.Remove(tok);                
            }
        }
    }
}
