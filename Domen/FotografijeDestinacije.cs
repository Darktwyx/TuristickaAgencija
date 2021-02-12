using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class FotografijeDestinacije:OpstiDomenskiObjekat
    {
        //Atributi
        int fotoId;
        int destId;
        string urlFoto;

       
        public int FotoId { get => fotoId; set => fotoId = value; }

        public int DestId { get => destId; set => destId = value; }

        public string UrlFoto { get => urlFoto; set => urlFoto = value; }

        //ODO deo
        [Browsable(false)]
        public string nazivTabele => "FotografijeDestinacije";
        [Browsable(false)]
        public string primarniKljuc => "fotografijaID and destinacijaID";
        [Browsable(false)]
        public string uslovPrimarni => "fotografijaID=" + FotoId + " and destinacijaID="+DestId;
        [Browsable(false)]
        public string Uslov = "";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => "URLFotografije="+UrlFoto;
        [Browsable(false)]
        public string unos => " values ("+FotoId+","+DestId+",'"+UrlFoto+"')";


        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            FotografijeDestinacije fd = new FotografijeDestinacije();
            fd.FotoId = Convert.ToInt32(red["fotografijaID"]);
            //Destinacija d = new Destinacija();
            fd.DestId = Convert.ToInt32(red["destinacijaID"]);
            fd.UrlFoto = red["URLFotografije"].ToString();
        

            return fd;
        }

    }
}
