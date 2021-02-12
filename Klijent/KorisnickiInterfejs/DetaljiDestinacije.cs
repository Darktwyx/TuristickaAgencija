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
    public partial class DetaljiDestinacije : Form
    {
      
        public DetaljiDestinacije()
        {
            InitializeComponent();
        }

        private void DetaljiDestinacije_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.popuniPoljaDestinacije(txtID,txtNaziv, txtOpis, txtCena, cmbPrevoz, txtDatumPolaska, txtDatumDolaska, txtDatumRealizacije, cmbFakultativniIzlet);
            KontrolerKorisnickogInterfejsa.prikaziFotografije(pictureBox);
            
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.IzmeniDestinaciju(txtNaziv, txtOpis, txtCena, cmbPrevoz, txtDatumPolaska, txtDatumDolaska, txtDatumRealizacije, cmbFakultativniIzlet)) this.Close();
        }

        private void btnLevo_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.PrikaziPrethodnuFotografiju(btnLevo, btnDesno, pictureBox);
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.PrikaziSledecuFotografiju(btnLevo, btnDesno, pictureBox);
        }
    }
}
