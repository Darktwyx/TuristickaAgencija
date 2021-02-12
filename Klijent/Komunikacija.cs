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

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;
        public static bool UgasenServer=false;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                UgasenServer = false;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public Object primiPoruku()
        {
            var transfer= ((TransferKlasa)formater.Deserialize(tok));

            if (transfer.UgasenServer)
            {
                UgasenServer = true;
                return null;
            }
            else return transfer.Rezultat;
        }

        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object SacuvajRealizaciju(RealizacijaIzleta realizacija)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajRealizaciju;
            transfer.TransferObjekat = realizacija;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object SacuvajDestinaciju(Destinacija d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajDestinaciju;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object IzmeniRezervaciju(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniRezervaciju;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }
        public Object IzmeniDestinaciju(Destinacija d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniDestinaciju;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object IzmeniRealizaciju(RealizacijaIzleta ri)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniRealizaciju;
            transfer.TransferObjekat = ri;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object PrijavaRadnika(Radnik r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrijaviRadnika;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object VratiSifruDestinacije(Destinacija d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSifruDestinacije;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object VratiSifruRezervacije(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSifruRezervacije;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object VratiSifruFakultativnogIzleta(FakultativniIzlet f)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSifruFakultativnogIzleta;
            transfer.TransferObjekat = f;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object VratiSifruTuriste(Turista t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSifruTuriste;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object VratiSveFakultativneIzlete()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveFakultativneIzlete;
            transfer.TransferObjekat = new FakultativniIzlet();
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object VratiSveRadnike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveRadnike;
            transfer.TransferObjekat = new Radnik();
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object VratiSveDestinacije()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveDestinacije;
            transfer.TransferObjekat = new Destinacija();
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object VratiSveTuriste()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveTuriste;
            transfer.TransferObjekat = new Turista();
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object KreirajTuristu()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajTuristu;
            transfer.TransferObjekat = new Turista();
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }


        public Object ZapamtiTuristu(Turista t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiTuristu;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object ZapamtiDestinaciju(Destinacija d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiDestinaciju;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object ZapamtiRealizaciju(RealizacijaIzleta r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiDestinaciju;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object ZapamtiFakultativniIzlet(FakultativniIzlet fi)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiFakultativniIzlet;
            transfer.TransferObjekat = fi;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }


        public Object ZapamtiRezervaciju(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiRezervaciju;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }
        public Object SacuvajFotografije(FotografijeDestinacije fd)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajFotografije;
            transfer.TransferObjekat = fd;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object KreirajDestinaciju()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajDestinaciju;
            transfer.TransferObjekat = new Destinacija();
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object ObrisiFakultativniIzlet(FakultativniIzlet fi)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiFakultativniIzlet;
            transfer.TransferObjekat = fi;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object ObrisiRezervaciju(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiRezervaciju;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object KreirajRezervaciju()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajRezervaciju;
            transfer.TransferObjekat = new Rezervacija();
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object PretraziDestinacije(Destinacija d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziDestinacije;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object PretraziRezervacije(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziRezervacije;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object PretraziFakultativneIzlete(FakultativniIzlet fi)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziFakultativneIzlete;
            transfer.TransferObjekat = fi;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object UcitajDestinaciju(Destinacija d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajDestinaciju;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object UcitajRezervaciju(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajRezervaciju;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object PrikaziFotografije(Destinacija d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziFotografije;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }

        public Object KreirajFakultativniIzlet()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajFakultativniIzlet;
            transfer.TransferObjekat = new FakultativniIzlet();
            formater.Serialize(tok, transfer);

            return primiPoruku();
        }
    }
}
