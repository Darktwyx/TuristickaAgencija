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
    public partial class PretragaFakultativnihIzleta : Form
    {
        public PretragaFakultativnihIzleta()
        {
            InitializeComponent();
        }

        private void PretragaFakultativnihIzleta_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.PretraziFakultativneIzlete(txtMesto, dataGridView);
        }

        private void txtMesto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                KontrolerKorisnickogInterfejsa.PretraziFakultativneIzlete(txtMesto, dataGridView);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.ObrisiFakultativniIzlet(dataGridView);
        }
    }
}
