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
    public partial class PretragaRezervacije : Form
    {
        public PretragaRezervacije()
        {
            InitializeComponent();
        }

        private void txtNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KontrolerKorisnickogInterfejsa.PretraziRezervacije(txtMestoPolaska, dataGridView);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.UcitajRezervaciju(dataGridView))
            {
                this.Hide();
                new DetaljiRezervacije().ShowDialog();
                this.Show();

                //Osvezavanje
                KontrolerKorisnickogInterfejsa.PretraziRezervacije(txtMestoPolaska, dataGridView);
            }
        }

        private void PretragaRezervacije_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.PretraziRezervacije(txtMestoPolaska, dataGridView);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.ObrisiRezervaciju(dataGridView);
        }
    }
}
