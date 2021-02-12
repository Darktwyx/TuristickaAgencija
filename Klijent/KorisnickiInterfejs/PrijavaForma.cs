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
    public partial class PrijavaForma : Form
    {
        Timer t;
        public PrijavaForma()
        {
            InitializeComponent();
        }

        private void FormaKlijent_Load(object sender, EventArgs e)
        {
            
        }


        void ProveriServer(object sender, EventArgs e)
        {
            if (Komunikacija.UgasenServer)
            {
                t.Stop();
                MessageBox.Show("Server je ugasen!");
                this.Close();
            }

          
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.poveziSeNaServer())
            {
                t = new Timer();
                t.Interval = 1000;
                t.Tick += ProveriServer;
                t.Start();

                if(txtUsername.Text == "")
                {
                    MessageBox.Show("Niste uneli username!");
                    txtUsername.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Niste uneli password!");
                    txtPassword.Focus();
                    return;
                }
                if (KontrolerKorisnickogInterfejsa.PrijaviRadnika(txtUsername, txtPassword))
                {
                    this.Hide();
                    new PocetnaForma().ShowDialog();
                    try
                    {
                        this.Show();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
