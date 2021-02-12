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
    public partial class UnosRezervacije : Form
    {
        public UnosRezervacije()
        {
            InitializeComponent();
        }
        
        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            //if (KontrolerKorisnickogInterfejsa.KreirajRezervaciju(txtID, gbRezervacija, btnKreiraj))
            //{
            //    KontrolerKorisnickogInterfejsa.PopuniComboTurista(cmbTurista);
            //    KontrolerKorisnickogInterfejsa.PopuniComboDestinacija(cmbDestinacija);
            //    KontrolerKorisnickogInterfejsa.PopuniComboRadnik(cmbRadnik);

            //}
            if (KontrolerKorisnickogInterfejsa.VratiSifruRezervacije(txtID, gbRezervacija, btnKreiraj))
            {
                KontrolerKorisnickogInterfejsa.PopuniComboTurista(cmbTurista);
                KontrolerKorisnickogInterfejsa.PopuniComboDestinacija(cmbDestinacija);
                KontrolerKorisnickogInterfejsa.PopuniComboRadnik(cmbRadnik);
            }

        }

        private void UnosRezervacije_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.SacuvajRezervaciju(txtID,cmbTurista,cmbDestinacija,cmbRadnik,cmbMesto,txtDatum,txtBroj)) this.Close();
        }
    }
}
