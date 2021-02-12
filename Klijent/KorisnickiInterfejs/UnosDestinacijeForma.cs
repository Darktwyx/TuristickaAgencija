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
    public partial class UnosDestinacijeForma : Form
    {
        

        public UnosDestinacijeForma()
        {
            InitializeComponent();
        }

        private void UnosDestinacijeForma_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            //if (KontrolerKorisnickogInterfejsa.KreirajDestinaciju(txtID, gbDestinacija, btnKreiraj, btnSacuvaj))
            //{
            //    KontrolerKorisnickogInterfejsa.PopuniComboFakultativniIzlet(cmbFakultativniIzlet);

            //}
            if (KontrolerKorisnickogInterfejsa.VratiSifruDestinacije(txtID, gbDestinacija, btnKreiraj, btnSacuvaj))
            {
                KontrolerKorisnickogInterfejsa.PopuniComboFakultativniIzlet(cmbFakultativniIzlet);
            }
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.SacuvajDestinaciju(txtID,txtNaziv, txtOpis, txtCena, cmbPrevoz, txtDatumPolaska,txtDatumDolaska,txtDatumRealizacije ,dataGridViewFoto, cmbFakultativniIzlet, lblGreskaFoto)) this.Close();
        }

        private void btnDodajFoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DodajFotografiju().ShowDialog(); 
            this.Show();
            KontrolerKorisnickogInterfejsa.PrikaziFotografiju(dataGridViewFoto,lblGreskaFoto);
        }

        //private void btnDodajIzlet_Click(object sender, EventArgs e)
        //{
        //    //KontrolerKorisnickogInterfejsa.PopuniGrid(btnDodajIzlet, cmbFakultativniIzlet, dataGridViewFakultativniIzlet);
           
        //}

        //private void btnObrisiIzlet_Click(object sender, EventArgs e)
        //{
        //    //KontrolerKorisnickogInterfejsa.ObrisiRedGridaIzlet(btnObrisiIzlet, dataGridViewFakultativniIzlet);
        //}

        private void btnObrisiFoto_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.ObrisiRedGridaFoto(btnObrisiFoto, dataGridViewFoto, lblGreskaFoto);
        }
    }
}
