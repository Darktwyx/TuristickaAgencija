using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string nazivTabele { get; } //Naziv tabele u bazi
        string primarniKljuc { get; } //Primarni kljuc
        string uslovPrimarni { get; } //Uslov vezan za  primarni kljuc
        string uslovOstalo { get; } //Ostali uslovi
        string izmena { get; }
        string unos { get; }

        OpstiDomenskiObjekat procitaj(DataRow red);


    }
}
