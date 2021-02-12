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
    public partial class PretragaDestinacija : Form
    {
        public PretragaDestinacija()
        {
            InitializeComponent();
        }

        private void PretragaDestinacija_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.PretraziDestinacije(txtNaziv, dataGridView);
        }

        private void txtNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                KontrolerKorisnickogInterfejsa.PretraziDestinacije(txtNaziv, dataGridView);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (KontrolerKorisnickogInterfejsa.UcitajDestinaciju(dataGridView))
            {
                this.Hide();
                new DetaljiDestinacije().ShowDialog();
                this.Show();

                //Osvezavanje
                KontrolerKorisnickogInterfejsa.PretraziDestinacije(txtNaziv, dataGridView);
            }
        }

       
    }
}
