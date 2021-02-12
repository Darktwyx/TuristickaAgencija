using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.KorisnickiInterfejs
{
    public partial class UnosTuristeForma : Form
    {
        public UnosTuristeForma()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            //KontrolerKorisnickogInterfejsa.KreirajTuristu(txtID, gbTurista, btnKreiraj);
            KontrolerKorisnickogInterfejsa.VratiSifruTuriste(txtID, gbTurista, btnKreiraj);

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.SacuvajTuristu(txtID,txtIme, txtPrezime, txtAdresa, txtDatum, txtBrojTelefona)) this.Close();
        }

        private void UnosTuristeForma_Load(object sender, EventArgs e)
        {

        }
    }
}
