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
    public partial class UnosFakultativnogIzleta : Form
    {
        public UnosFakultativnogIzleta()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            //KontrolerKorisnickogInterfejsa.KreirajFakultativniIzlet(txtID, gbFakultativniIzlet, btnKreiraj);
            KontrolerKorisnickogInterfejsa.VratiSifruFakultativnogIzleta(txtID, gbFakultativniIzlet, btnKreiraj);
  
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.SacuvajFakultativniIzlet(txtID,txtMesto, txtOpis, txtCena)) this.Close();
        }

        private void UnosFakultativnogIzleta_Load(object sender, EventArgs e)
        {

        }
    }
}
