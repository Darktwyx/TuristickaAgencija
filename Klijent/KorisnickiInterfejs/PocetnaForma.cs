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
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.Text = KontrolerKorisnickogInterfejsa.PrikaziUlogovanogRadnika();
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKorisnickogInterfejsa.Kraj();
        }

        private void unosTuristeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosTuristeForma().ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void unosDestinacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosDestinacijeForma().ShowDialog();
            this.Show();
        }

        private void pretragaDestinacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaDestinacija().ShowDialog();
            this.Show();
        }

        private void unosFakultativnogIzletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosFakultativnogIzleta().ShowDialog();
            this.Show();
        }

        private void dodajFotografijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DodajFotografiju().ShowDialog();
        }

        private void pretragaFakultativnogIzletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaFakultativnihIzleta().ShowDialog();
            this.Show();
        }

        private void unosRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosRezervacije().ShowDialog();
            this.Show();
        }

        private void pretragaRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaRezervacije().ShowDialog();
            this.Show();
        }
    }
}
