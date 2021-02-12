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
    public partial class DetaljiRezervacije : Form
    {
        public DetaljiRezervacije()
        {
            InitializeComponent();
        }

        private void DetaljiRezervacije_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.popuniPoljaRezervacije(txtID, cmbTurista, cmbDestinacija, cmbRadnik, txtDatum, cmbMesto, txtBroj, gbRezervacija);
        }

        private void btnSacuvaj_Click_1(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.IzmeniRezervaciju(cmbTurista, cmbDestinacija, cmbRadnik, cmbMesto, txtDatum, txtBroj)) this.Close();
        }
    }
}
