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
    public partial class DodajFotografiju : Form
    {
        KontrolerKorisnickogInterfejsa kki = new KontrolerKorisnickogInterfejsa();
        public DodajFotografiju()
        {
            InitializeComponent();
        }

        private void DodajFotografiju_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.url = "";
        }

     
        private void btnPlus_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.InitialDirectory = "C:\\";
            openFD.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            openFD.Title = "Izaberi fotografiju!";
            openFD.Multiselect = false;
            DialogResult result = openFD.ShowDialog();
            openFD.Multiselect = false;
            try
            {
                pictureBox.Image = Image.FromFile(openFD.FileName);
                KontrolerKorisnickogInterfejsa.url = openFD.FileName;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.url = "";
            pictureBox.Image = new Bitmap(@"D:\FON\Projektovanje softvera\Seminarski radovi\Seminarski\Design\product_image_not_available.png");
   
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (kki.dodajFotografiju()) this.Close();
        }
    }
}
