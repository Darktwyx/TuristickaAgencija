using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KontrolerKorisnickogInterfejsa
    {
        public static Komunikacija komunikacija;
        public static Radnik radnik;
        public static Turista turista;
        public static Destinacija destinacija;
        public static FakultativniIzlet fakultativniIzlet;
        public static FotografijeDestinacije fotografijeDestinacije;
        public static Rezervacija rezervacija;
        public static RealizacijaIzleta r;
        public static string url;
        public static int br;

        public static BindingList<FakultativniIzlet> listaB = new BindingList<FakultativniIzlet>();
        public static BindingList<Rezervacija> listaBR = new BindingList<Rezervacija>();
        public static BindingList<Destinacija> listaBD = new BindingList<Destinacija>();


        //Za izmenu destinacije!
        internal static void popuniPoljaDestinacije(TextBox txtID,TextBox txtNaziv, TextBox txtOpis, TextBox txtCena, ComboBox cmbPrevoz, TextBox txtDatumPolaska, TextBox txtDatumDolaska, TextBox txtDatumRezervacije, ComboBox cmbFakultativniIzlet)
        {
            //Prvo popunimo polja combo-boxa!

            cmbFakultativniIzlet.DataSource = komunikacija.VratiSveFakultativneIzlete();
            foreach (RealizacijaIzleta real in destinacija.ListaRealizacija)
            {
                cmbFakultativniIzlet.Text = real.FakultativniIzlet.ToString();   
                txtDatumRezervacije.Text = real.DatumRealizacije.ToString("dd/MM/yyyy");
            }

            if(destinacija.ListaRealizacija.Count == 0)
            {
                
                cmbFakultativniIzlet.Text = "Izaberite fakultativni izlet!";
                fakultativniIzlet = null;        
            }

            txtID.Text = destinacija.Id.ToString();
            txtNaziv.Text = destinacija.Naziv.ToString();
            txtOpis.Text = destinacija.Opis.ToString();
            txtCena.Text = destinacija.Cena.ToString();
            cmbPrevoz.Text = destinacija.Prevoz.ToString();
            txtDatumPolaska.Text = destinacija.DatumPolaska.ToString("dd/MM/yyyy");
            txtDatumDolaska.Text = destinacija.DatumDolaska.ToString("dd/MM/yyyy");

           

        }

        //Za izmenu rezervacije!
        internal static void popuniPoljaRezervacije(TextBox txtID, ComboBox cmbTurista, ComboBox cmbDestinacija, ComboBox cmbRadnik, TextBox txtDatum, ComboBox cmbMesto, TextBox txtBroj, GroupBox gbRezervacija)
        {
            gbRezervacija.Enabled = true;
            //Prvo popunimo polja combo-boxa!
            cmbTurista.DataSource = komunikacija.VratiSveTuriste();
            cmbDestinacija.DataSource = komunikacija.VratiSveDestinacije();
            cmbRadnik.DataSource = komunikacija.VratiSveRadnike();

            //Pokupimo vrednosti!
            txtID.Text = rezervacija.Id.ToString();
            cmbTurista.Text = rezervacija.Turista.ToString();
            cmbDestinacija.Text = rezervacija.Destinacija.ToString();
            cmbRadnik.Text = rezervacija.Radnik.ToString();
            txtDatum.Text = rezervacija.DatumRezervacije.ToString("dd/MM/yyyy");
            cmbMesto.Text = rezervacija.MestoPolaska.ToString();
            txtBroj.Text = rezervacija.BrojTurista.ToString();

        }

        internal static void ObrisiRezervaciju(DataGridView dataGridView)
        {
            try
            {
                rezervacija = dataGridView.CurrentRow.DataBoundItem as Rezervacija;
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali rezervaciju za brisanje!");
                return;
            }

            try
            {

                komunikacija.ObrisiRezervaciju(rezervacija);
                listaBR.Remove(rezervacija);
                MessageBox.Show("Rezervacija je obrisana!");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da obrise rezervaciju!");
                return;
            }
        }


        internal static void ObrisiFakultativniIzlet(DataGridView dataGridView)
        {
            try
            {
                fakultativniIzlet = dataGridView.CurrentRow.DataBoundItem as FakultativniIzlet;
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali fakultativni izlet za brisanje!");
                return;
            }

            try
            {

                komunikacija.ObrisiFakultativniIzlet(fakultativniIzlet);
                listaB.Remove(fakultativniIzlet);
                MessageBox.Show("Fakultativni izlet je obrisan!");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da obrise fakultativni izlet!");
                return;
            }
     

        }

        internal static bool SacuvajDestinaciju(TextBox txtID,TextBox txtNaziv, TextBox txtOpis, TextBox txtCena, ComboBox cmbPrevoz, TextBox txtDatumPolaska, TextBox txtDatumDolaska, TextBox txtDatumRealizacije, DataGridView dataGridViewFoto, ComboBox cmbFakultativniIzlet, Label lblGreskaFoto)
        {
            bool greska = false;
            bool empty = false;
            bool emptyDP = false;
            bool emptyDD = false;
            bool greskaParDP = false;
            bool greskaVremeDP = false;
            bool greskaParDD = false;
            bool greskaIspis = false;
            bool emptyRealizacija = false;
  

            destinacija.Naziv = txtNaziv.Text;

            destinacija.Opis = txtOpis.Text;

            if (string.IsNullOrEmpty(txtCena.Text) || txtCena.Text == "Morate uneti cenu!")
            {
                txtCena.BackColor = Color.Red;
                txtCena.Text = "Morate uneti cenu!";
                greska = true;
                empty = true;
            }
            else if (txtCena.Text != "Morate uneti cenu!" || txtCena.Text != "Cena mora biti u realnom zapisu!" || txtCena.Text != "Cena mora biti veca od 0!")
            {
                txtCena.BackColor = Color.GreenYellow;
            }

            if (!empty)
            {
                try
                {
                    destinacija.Cena = Convert.ToDouble(txtCena.Text);
                }
                catch (Exception)
                {
                    txtCena.BackColor = Color.Red;
                    txtCena.Text = "Cena mora biti u realnom zapisu!";
                    greska = true;
                }

                if (destinacija.Cena < 0)
                {
                    txtCena.Text = "Cena mora biti veca od 0!";
                    txtCena.BackColor = Color.Red;
                    greska = true;
                    destinacija.Cena = 0;
                }

            }

            destinacija.Prevoz = cmbPrevoz.SelectedItem as String;

            //JEDINSTVENA VALIDACIJA!

            if (string.IsNullOrEmpty(destinacija.Naziv) || txtNaziv.Text == "Morate uneti naziv destinacije!")
            {
                txtNaziv.BackColor = Color.Red;
                txtNaziv.Text = "Morate uneti naziv destinacije!";
                greska = true;
            }
            else if (txtNaziv.Text != "Morate uneti naziv destinacije!")
            {
                txtNaziv.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(destinacija.Opis) || txtOpis.Text == "Morate uneti opis destinacije!")
            {
                txtOpis.BackColor = Color.Red;
                txtOpis.Text = "Morate uneti opis destinacije!";
                greska = true;
            }
            else if (txtOpis.Text != "Morate uneti opis destinacije!")
            {
                txtOpis.BackColor = Color.GreenYellow;
            }

            if (destinacija.Prevoz == null)
            {
                cmbPrevoz.Text = "Morate odabrati vrstu prevoza!";
                cmbPrevoz.BackColor = Color.Red;
                greska = true;
            }
            else
            {
                cmbPrevoz.BackColor = Color.GreenYellow;
            }

            //1.Nije unet datum polaska, ni datum dolaska! -> "Morate uneti datum polaska!","Morate uneti datum dolaska!"
            //Datum polaska
            if (string.IsNullOrEmpty(txtDatumPolaska.Text) || txtDatumPolaska.Text == "Morate uneti datum polaska!")
            {
                txtDatumPolaska.BackColor = Color.Red;
                txtDatumPolaska.Text = "Morate uneti datum polaska!";
                greska = true;
                emptyDP = true;
            }
            else if (txtDatumPolaska.Text != "Morate uneti datum polaska!" || txtDatumPolaska.Text != "Datum polaska mora biti datum od:" + DateTime.Now.AddDays(1).ToString("dd/MM/yyyy") + "!" || txtDatumPolaska.Text != "Datum polaska mora biti u formatu dd/MM/yyyy!")
            {
                txtDatumPolaska.BackColor = Color.GreenYellow;
            }

            //Datum dolaska
            if (string.IsNullOrEmpty(txtDatumDolaska.Text) || txtDatumDolaska.Text == "Morate uneti datum dolaska!")
            {
                txtDatumDolaska.BackColor = Color.Red;
                txtDatumDolaska.Text = "Morate uneti datum dolaska!";
                greska = true;
                emptyDD = true;
            }
            else if (txtDatumDolaska.Text != "Morate uneti datum dolaska!" || txtDatumDolaska.Text != "Morate uneti datum polaska prvo!")
            {
                txtDatumDolaska.BackColor = Color.GreenYellow;
            }
        
            //2.Nije unet datum polaska, a jeste datum dolaska! -> "Morate uneti datum polaska!","Morate uneti datum polaska prvo!"
            if (emptyDP == true && emptyDD == false)
            {
                txtDatumDolaska.Text = "Morate uneti datum polaska prvo!";
                txtDatumDolaska.BackColor = Color.Red;
                greska = true;
            }

            //3.Unet datum polaska, a nije datum dolaska! -> "Radi nesto...","Morate uneti datum dolaska!"

            //4.Unet datum polaska (lose parsiranje) -> "Datum polaska mora biti u formatu dd/MM/yyyy!", "Morate uneti datum polaska prvo!"
            //5.Unet datum polaska(lose vreme) -> "Datum polaska mora biti od: tog datuma","Morate uneti datum polaska prvo!"
            //6.Unet datum polaska(OK) ---->
            //                               - Provera parsiranja(datuma dolaska) -> "Datum dolaska mora biti u formatu dd/MM/yyyy!"
            //                               - Provera datuma(lose vreme) -> Datum dolaska mora biti nakon datuma polaska!"
            //                               - Unet datum dolaska(OK)

            if (!emptyDP)
            {
                try
                {
                    destinacija.DatumPolaska = DateTime.ParseExact(txtDatumPolaska.Text, "dd/MM/yyyy", null);

                }
                catch (Exception)
                {
                    txtDatumPolaska.Text = "Datum polaska mora biti u formatu dd/MM/yyyy!";
                    txtDatumPolaska.BackColor = Color.Red;
                    greskaParDP = true;

                    txtDatumDolaska.Text = "Morate uneti datum polaska prvo!";
                    txtDatumDolaska.BackColor = Color.Red;
                    greska = true;

                }

                if (!greskaParDP)
                {
                    //Datum polaska mora biti najmanje jedan dan od danasnjeg dana!
                    if (destinacija.DatumPolaska <= DateTime.Now)
                    {
                        txtDatumPolaska.Text = "Datum polaska mora biti datum od:" + DateTime.Now.AddDays(1).ToString("dd/MM/yyyy") + "!";
                        txtDatumPolaska.BackColor = Color.Red;
                        greskaVremeDP = true;

                        txtDatumDolaska.Text = "Morate uneti datum polaska prvo!";
                        txtDatumDolaska.BackColor = Color.Red;
                        greskaIspis = true;
                        greska = true;

                    }
                    if (!greskaVremeDP && emptyDD == false)
                    {
                        try
                        {
                            destinacija.DatumDolaska = DateTime.ParseExact(txtDatumDolaska.Text, "dd/MM/yyyy", null);

                        }
                        catch (Exception)
                        {
                            txtDatumDolaska.Text = "Datum dolaska mora biti u formatu dd/MM/yyyy!";
                            txtDatumDolaska.BackColor = Color.Red;
                            greskaParDD = true;
                            greska = true;
                        }

                        if (!greskaParDD)
                        {
                            //Datum dolaska mora biti nakon datuma polaska!
                            if (destinacija.DatumDolaska < destinacija.DatumPolaska)
                            {
                                txtDatumDolaska.Text = "Datum dolaska mora biti nakon:" + destinacija.DatumPolaska.ToString("dd/MM/yyyy") + "!";
                                txtDatumDolaska.BackColor = Color.Red;
                                greska = true;
                            }
                        }

                    } else if (emptyDD && greskaIspis == false)
                    {
                        txtDatumDolaska.Text = "Morate uneti datum dolaska!";
                        txtDatumDolaska.BackColor = Color.Red;
                    }
       
                }         

            }     
                
            fakultativniIzlet = new FakultativniIzlet();

            fakultativniIzlet = cmbFakultativniIzlet.SelectedItem as FakultativniIzlet;

            if (fakultativniIzlet != null)
            {
                r = new RealizacijaIzleta();
                r.Destinacija = destinacija;
                r.FakultativniIzlet = fakultativniIzlet;
                destinacija.ListaRealizacija.Add(r);
                cmbFakultativniIzlet.BackColor = Color.GreenYellow;


                //Datum realizacije
                if (string.IsNullOrEmpty(txtDatumRealizacije.Text) || txtDatumRealizacije.Text == "Morate uneti datum realizacije!")
                {
                    txtDatumRealizacije.BackColor = Color.Red;
                    txtDatumRealizacije.Text = "Morate uneti datum realizacije!";
                    greska = true;
                    emptyRealizacija = true;
                }
                else if (txtDatumRealizacije.Text != "Morate uneti datum realizacije!" || txtDatumRealizacije.Text != "Morate uneti datum polaska i dolaska prvo!" || txtDatumRealizacije.Text != "Datum realizacije mora biti od " + destinacija.DatumPolaska.ToString("dd/MM/yyyy") + ", a pre " + destinacija.DatumDolaska.ToString("dd/MM/yyyy") + "!")
                {
                    txtDatumRealizacije.BackColor = Color.GreenYellow;
                }
            }
  

            if (!emptyRealizacija)
            {
                try
                {

                    if (r != null)
                    {
                        r.DatumRealizacije = DateTime.ParseExact(txtDatumRealizacije.Text, "dd/MM/yyyy", null);

                        if (txtDatumPolaska.BackColor != Color.GreenYellow && txtDatumDolaska.BackColor != Color.GreenYellow)
                        {
                            txtDatumRealizacije.Text = "Morate uneti datum polaska i dolaska prvo!";
                            txtDatumRealizacije.BackColor = Color.Red;
                            greska = true;
                        }

                        if(txtDatumPolaska.BackColor == Color.GreenYellow && txtDatumDolaska.BackColor == Color.GreenYellow)
                        {
                            if (!(r.DatumRealizacije >= destinacija.DatumPolaska && r.DatumRealizacije <= destinacija.DatumDolaska))
                            {
                                txtDatumRealizacije.Text = "Datum realizacije mora biti od " + destinacija.DatumPolaska.ToString("dd/MM/yyyy") + ", a pre " + destinacija.DatumDolaska.ToString("dd/MM/yyyy") + "!";
                                txtDatumRealizacije.BackColor = Color.Red;
                                greska = true;

                            }
                        }
                       

                    }
                }
                catch (Exception)
                {
                    txtDatumRealizacije.Text = "Morate uneti datum rezervacije u formatu dd/MM/yyyy!";
                    txtDatumRealizacije.BackColor = Color.Red;
                    greska = true;
                }
            } 
            

            if (destinacija.GalerijaFotografija.Count < 1)
            {
                lblGreskaFoto.Text = "Morate uneti barem jednu fotografiju!";
                lblGreskaFoto.BackColor = Color.Red;
                greska = true;
            } else
            {
                lblGreskaFoto.Text = "";
            }

            if (greska)
            {
                MessageBox.Show("Sistem ne moze da zapamti destinaciju!");
                return false;
            }
            else
            {
                Object rez = komunikacija.SacuvajDestinaciju(destinacija);
                if (rez == null)
                {
                    MessageBox.Show("Sistem ne moze da zapamti destinaciju!");
                    return false;
                }
                else
                {
                    if (fakultativniIzlet != null)
                    {
                        try
                        {
                            Object rezRealizacija = komunikacija.SacuvajRealizaciju(r);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Sistem ne moze da zapamti destinaciju!");
                            return false;
                        }
                        
                    }
                    foreach (FotografijeDestinacije fd in destinacija.GalerijaFotografija)
                    {
                        try
                        {
                            Object rezFotoDest = komunikacija.SacuvajFotografije(fd);
                            MessageBox.Show("Sistem je uspesno sacuvao destinaciju!");
                            return true;
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Sistem ne moze da zapamti destinaciju!");
                            return false;
                        }           
                        
                    }
                    MessageBox.Show("Sistem ne moze da zapamti destinaciju!");
                    return false;
                }
            
            } 
           
        }


        internal static bool VratiSifruRezervacije(TextBox txtID, GroupBox gbRezervacija, Button btnKreiraj)
        {
            rezervacija = new Rezervacija();

            try
            {
                rezervacija.Id = (int)komunikacija.VratiSifruRezervacije(rezervacija);
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da kreira rezervaciju!");
                return false;
            }

            txtID.Text = rezervacija.Id.ToString();

            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Sistem ne moze da kreira rezervaciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao rezervaciju!");
                btnKreiraj.Enabled = false;
                gbRezervacija.Enabled = true;

                return true;
            }
        }

        internal static bool KreirajRezervaciju(TextBox txtID, GroupBox gbRezervacija, Button btnKreiraj)
        {
            rezervacija = (Rezervacija)komunikacija.KreirajRezervaciju();

            if (rezervacija == null)
            {
                MessageBox.Show("Sistem ne moze da kreira rezervaciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao rezervaciju!");
                txtID.Text = rezervacija.Id.ToString();
                btnKreiraj.Enabled = false;
                gbRezervacija.Enabled = true;

                return true;

            }
        }

        internal static bool SacuvajRezervaciju(TextBox txtID,ComboBox cmbTurista, ComboBox cmbDestinacija, ComboBox cmbRadnik, ComboBox cmbMesto, TextBox txtDatum, TextBox txtBroj)
        {

            bool greska = false;
            bool empty = false;
            bool emptyDatum = false;
            bool uslov = false;
     

            rezervacija.Turista = cmbTurista.SelectedItem as Turista;

            rezervacija.Destinacija = cmbDestinacija.SelectedItem as Destinacija;

            rezervacija.Radnik = cmbRadnik.SelectedItem as Radnik;

            rezervacija.MestoPolaska = cmbMesto.SelectedItem as String;

            if (string.IsNullOrEmpty(txtDatum.Text) || txtDatum.Text == "Morate uneti datum!")
            {
                txtDatum.BackColor = Color.Red;
                txtDatum.Text = "Morate uneti datum!";
                greska = true;
                emptyDatum = true;
            }
            else if (txtDatum.Text != "Morate uneti datum!" || txtDatum.Text != "Datum mora biti u formatu dd/MM/yyyy!" || txtDatum.Text != "Datum rezervacije mora biti od " + DateTime.Now.ToString("dd/MM/yyyy") + "!")
            {
                txtDatum.BackColor = Color.GreenYellow;
            }

            if (!emptyDatum)
            {
                try
                {
                    rezervacija.DatumRezervacije = DateTime.ParseExact(txtDatum.Text, "dd/MM/yyyy", null);
                }
                catch (Exception)
                {
                    txtDatum.Text = "Datum mora biti u formatu dd/MM/yyyy!";
                    txtDatum.BackColor = Color.Red;
                    greska = true;
                    uslov = true;
                }

                if (!uslov)
                {
                    if (rezervacija.DatumRezervacije < DateTime.Now.AddDays(-1))
                    {
                        txtDatum.Text = "Datum rezervacije mora biti od " + DateTime.Now.ToString("dd/MM/yyyy") + "!";
                        txtDatum.BackColor = Color.Red;
                        greska = true;
                    }
                }
               
            }


            if (rezervacija.Turista == null)
            {
                cmbTurista.Text = "Morate odabrati turistu!";
                cmbTurista.BackColor = Color.Red;
                greska = true;
            } else
            {
                cmbTurista.BackColor = Color.GreenYellow;
            }

            if (rezervacija.Destinacija == null)
            {
                cmbDestinacija.Text = "Morate odabrati destinaciju!";
                cmbDestinacija.BackColor = Color.Red;
                greska = true;
            } else
            {
                cmbDestinacija.BackColor = Color.GreenYellow;
            }

            if (rezervacija.Radnik == null)
            {
                cmbRadnik.Text = "Morate odabrati radnika!";
                cmbRadnik.BackColor = Color.Red;
                greska = true;
            } else
            {
                cmbRadnik.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(rezervacija.MestoPolaska))
            {
                cmbMesto.Text = "Morate odabrati mesto polaska!";
                cmbMesto.BackColor = Color.Red;
                greska = true;
            } else
            {
                cmbMesto.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(txtBroj.Text) || txtBroj.Text == "Morate uneti broj turista!")
            {
                txtBroj.BackColor = Color.Red;
                txtBroj.Text = "Morate uneti broj turista!";
                greska = true;
                empty = true;
            }
            else if (txtBroj.Text != "Morate uneti broj turista!" || txtBroj.Text != "Broj turista mora biti u decimalnom zapisu!" || txtBroj.Text != "Broj turista mora biti veca od 0!")
            {
                txtBroj.BackColor = Color.GreenYellow;
            }

            if (!empty)
            {
                try
                {
                    rezervacija.BrojTurista = Convert.ToInt32(txtBroj.Text);
                }
                catch (Exception)
                {
                    txtBroj.BackColor = Color.Red;
                    txtBroj.Text = "Broj turista mora biti u decimalnom zapisu!";
                    greska = true;
                }

                if (rezervacija.BrojTurista < 0)
                {
                    txtBroj.Text = "Broj turista mora biti veca od 0!";
                    txtBroj.BackColor = Color.Red;
                    greska = true;
                    rezervacija.BrojTurista = 0;
                }

            }

            if (greska)
            {
                MessageBox.Show("Sistem ne moze da zapamti rezervaciju!");
                return false;
            } else
            {
                Object rez = komunikacija.ZapamtiRezervaciju(rezervacija);
                if (rez == null)
                {
                    MessageBox.Show("Sistem ne moze da zapamti rezervaciju!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je uspesno zapamtio rezervaciju!");
                    return true;
                }
            }

           
        }

        internal static bool IzmeniDestinaciju(TextBox txtNaziv, TextBox txtOpis, TextBox txtCena, ComboBox cmbPrevoz,TextBox txtDatumPolaska, TextBox txtDatumDolaska, TextBox txtDatumRealizacije, ComboBox cmbFakultativniIzlet)
        {
            bool greska = false;
            bool empty = false;
            bool emptyDP = false;
            bool emptyDD = false;
            bool greskaParDP = false;
            bool greskaVremeDP = false;
            bool greskaParDD = false;
            bool greskaIspis = false;
            bool emptyRealizacija = false;

            destinacija.Naziv = txtNaziv.Text;

            destinacija.Opis = txtOpis.Text;

            if (string.IsNullOrEmpty(txtCena.Text) || txtCena.Text == "Morate uneti cenu!")
            {
                txtCena.BackColor = Color.Red;
                txtCena.Text = "Morate uneti cenu!";
                greska = true;
                empty = true;
            }
            else if (txtCena.Text != "Morate uneti cenu!" || txtCena.Text != "Cena mora biti u realnom zapisu!" || txtCena.Text != "Cena mora biti veca od 0!")
            {
                txtCena.BackColor = Color.GreenYellow;
            }

            if (!empty)
            {
                try
                {
                    destinacija.Cena = Convert.ToDouble(txtCena.Text);
                }
                catch (Exception)
                {
                    txtCena.BackColor = Color.Red;
                    txtCena.Text = "Cena mora biti u realnom zapisu!";
                    greska = true;
                }

                if (destinacija.Cena < 0)
                {
                    txtCena.Text = "Cena mora biti veca od 0!";
                    txtCena.BackColor = Color.Red;
                    greska = true;
                    destinacija.Cena = 0;
                }

            }

            destinacija.Prevoz = cmbPrevoz.SelectedItem as String;

            //JEDINSTVENA VALIDACIJA!

            if (string.IsNullOrEmpty(destinacija.Naziv) || txtNaziv.Text == "Morate uneti naziv destinacije!")
            {
                txtNaziv.BackColor = Color.Red;
                txtNaziv.Text = "Morate uneti naziv destinacije!";
                greska = true;
            }
            else if (txtNaziv.Text != "Morate uneti naziv destinacije!")
            {
                txtNaziv.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(destinacija.Opis) || txtOpis.Text == "Morate uneti opis destinacije!")
            {
                txtOpis.BackColor = Color.Red;
                txtOpis.Text = "Morate uneti opis destinacije!";
                greska = true;
            }
            else if (txtOpis.Text != "Morate uneti opis destinacije!")
            {
                txtOpis.BackColor = Color.GreenYellow;
            }

            if (destinacija.Prevoz == null)
            {
                cmbPrevoz.Text = "Morate odabrati vrstu prevoza!";
                cmbPrevoz.BackColor = Color.Red;
                greska = true;
            }
            else
            {
                cmbPrevoz.BackColor = Color.GreenYellow;
            }

            //1.Nije unet datum polaska, ni datum dolaska! -> "Morate uneti datum polaska!","Morate uneti datum dolaska!"
            //Datum polaska
            if (string.IsNullOrEmpty(txtDatumPolaska.Text) || txtDatumPolaska.Text == "Morate uneti datum polaska!")
            {
                txtDatumPolaska.BackColor = Color.Red;
                txtDatumPolaska.Text = "Morate uneti datum polaska!";
                greska = true;
                emptyDP = true;
            }
            else if (txtDatumPolaska.Text != "Morate uneti datum polaska!" || txtDatumPolaska.Text != "Datum polaska mora biti datum od:" + DateTime.Now.AddDays(1).ToString("dd/MM/yyyy") + "!" || txtDatumPolaska.Text != "Datum polaska mora biti u formatu dd/MM/yyyy!")
            {
                txtDatumPolaska.BackColor = Color.GreenYellow;
            }

            //Datum dolaska
            if (string.IsNullOrEmpty(txtDatumDolaska.Text) || txtDatumDolaska.Text == "Morate uneti datum dolaska!")
            {
                txtDatumDolaska.BackColor = Color.Red;
                txtDatumDolaska.Text = "Morate uneti datum dolaska!";
                greska = true;
                emptyDD = true;
            }
            else if (txtDatumDolaska.Text != "Morate uneti datum dolaska!" || txtDatumDolaska.Text != "Morate uneti datum polaska prvo!")
            {
                txtDatumDolaska.BackColor = Color.GreenYellow;
            }

            //2.Nije unet datum polaska, a jeste datum dolaska! -> "Morate uneti datum polaska!","Morate uneti datum polaska prvo!"
            if (emptyDP == true && emptyDD == false)
            {
                txtDatumDolaska.Text = "Morate uneti datum polaska prvo!";
                txtDatumDolaska.BackColor = Color.Red;
                greska = true;
            }

            //3.Unet datum polaska, a nije datum dolaska! -> "Radi nesto...","Morate uneti datum dolaska!"

            //4.Unet datum polaska (lose parsiranje) -> "Datum polaska mora biti u formatu dd/MM/yyyy!", "Morate uneti datum polaska prvo!"
            //5.Unet datum polaska(lose vreme) -> "Datum polaska mora biti od: tog datuma","Morate uneti datum polaska prvo!"
            //6.Unet datum polaska(OK) ---->
            //                               - Provera parsiranja(datuma dolaska) -> "Datum dolaska mora biti u formatu dd/MM/yyyy!"
            //                               - Provera datuma(lose vreme) -> Datum dolaska mora biti nakon datuma polaska!"
            //                               - Unet datum dolaska(OK)

            if (!emptyDP)
            {
                try
                {
                    destinacija.DatumPolaska = DateTime.ParseExact(txtDatumPolaska.Text, "dd/MM/yyyy", null);

                }
                catch (Exception)
                {
                    txtDatumPolaska.Text = "Datum polaska mora biti u formatu dd/MM/yyyy!";
                    txtDatumPolaska.BackColor = Color.Red;
                    greskaParDP = true;

                    txtDatumDolaska.Text = "Morate uneti datum polaska prvo!";
                    txtDatumDolaska.BackColor = Color.Red;
                    greska = true;

                }

                if (!greskaParDP)
                {
                    //Datum polaska mora biti najmanje jedan dan od danasnjeg dana!
                    if (destinacija.DatumPolaska <= DateTime.Now)
                    {
                        txtDatumPolaska.Text = "Datum polaska mora biti datum od:" + DateTime.Now.AddDays(1).ToString("dd/MM/yyyy") + "!";
                        txtDatumPolaska.BackColor = Color.Red;
                        greskaVremeDP = true;

                        txtDatumDolaska.Text = "Morate uneti datum polaska prvo!";
                        txtDatumDolaska.BackColor = Color.Red;
                        greskaIspis = true;
                        greska = true;

                    }
                    if (!greskaVremeDP && emptyDD == false)
                    {
                        try
                        {
                            destinacija.DatumDolaska = DateTime.ParseExact(txtDatumDolaska.Text, "dd/MM/yyyy", null);

                        }
                        catch (Exception)
                        {
                            txtDatumDolaska.Text = "Datum dolaska mora biti u formatu dd/MM/yyyy!";
                            txtDatumDolaska.BackColor = Color.Red;
                            greskaParDD = true;
                            greska = true;
                        }

                        if (!greskaParDD)
                        {
                            //Datum dolaska mora biti nakon datuma polaska!
                            if (destinacija.DatumDolaska < destinacija.DatumPolaska)
                            {
                                txtDatumDolaska.Text = "Datum dolaska mora biti nakon:" + destinacija.DatumPolaska.ToString("dd/MM/yyyy") + "!";
                                txtDatumDolaska.BackColor = Color.Red;
                                greska = true;
                            }
                        }

                    }
                    else if (emptyDD && greskaIspis == false)
                    {
                        txtDatumDolaska.Text = "Morate uneti datum dolaska!";
                        txtDatumDolaska.BackColor = Color.Red;
                    }

                }

            }

            fakultativniIzlet = new FakultativniIzlet();
            fakultativniIzlet = cmbFakultativniIzlet.SelectedItem as FakultativniIzlet;

            if (cmbFakultativniIzlet.Text == "Izaberite fakultativni izlet!")
            {
                fakultativniIzlet = null;
            }

            if (fakultativniIzlet != null)
            {
                r = new RealizacijaIzleta();
                r.Destinacija = destinacija;
                r.FakultativniIzlet = fakultativniIzlet;
                destinacija.ListaRealizacija.Add(r);
                if(cmbFakultativniIzlet.Text != "Izaberite fakultativni izlet!")
                {
                    cmbFakultativniIzlet.BackColor = Color.GreenYellow;
                }

                //Datum realizacije
                if (string.IsNullOrEmpty(txtDatumRealizacije.Text) || txtDatumRealizacije.Text == "Morate uneti datum realizacije!")
                {
                    txtDatumRealizacije.BackColor = Color.Red;
                    txtDatumRealizacije.Text = "Morate uneti datum realizacije!";
                    greska = true;
                    emptyRealizacija = true;
                }
                else if (txtDatumRealizacije.Text != "Morate uneti datum realizacije!" || txtDatumRealizacije.Text != "Morate uneti datum polaska i dolaska prvo!" || txtDatumRealizacije.Text != "Datum realizacije mora biti od " + destinacija.DatumPolaska.ToString("dd/MM/yyyy") + ", a pre " + destinacija.DatumDolaska.ToString("dd/MM/yyyy") + "!")
                {
                    txtDatumRealizacije.BackColor = Color.GreenYellow;
                }
            }


            if (!emptyRealizacija)
            {
                try
                {

                    if (r != null)
                    {
                        r.DatumRealizacije = DateTime.ParseExact(txtDatumRealizacije.Text, "dd/MM/yyyy", null);

                        if (txtDatumPolaska.BackColor != Color.GreenYellow && txtDatumDolaska.BackColor != Color.GreenYellow)
                        {
                            txtDatumRealizacije.Text = "Morate uneti datum polaska i dolaska prvo!";
                            txtDatumRealizacije.BackColor = Color.Red;
                            greska = true;
                        }

                        if (txtDatumPolaska.BackColor == Color.GreenYellow && txtDatumDolaska.BackColor == Color.GreenYellow)
                        {
                            if (!(r.DatumRealizacije >= destinacija.DatumPolaska && r.DatumRealizacije <= destinacija.DatumDolaska))
                            {
                                txtDatumRealizacije.Text = "Datum realizacije mora biti od " + destinacija.DatumPolaska.ToString("dd/MM/yyyy") + ", a pre " + destinacija.DatumDolaska.ToString("dd/MM/yyyy") + "!";
                                txtDatumRealizacije.BackColor = Color.Red;
                                greska = true;

                            }
                        }


                    }
                }
                catch (Exception)
                {
                    txtDatumRealizacije.Text = "Morate uneti datum rezervacije u formatu dd/MM/yyyy!";
                    txtDatumRealizacije.BackColor = Color.Red;
                    greska = true;
                }
            }

            if (greska)
            {
                MessageBox.Show("Sistem ne moze da zapamti destinaciju!");
                return false;
            }
            else
            {
                Object rez = komunikacija.IzmeniDestinaciju(destinacija);
                if (rez == null)
                {
                    MessageBox.Show("Sistem ne moze da zapamti destinaciju!");
                    return false;
                }
                else
                {
                    if (fakultativniIzlet != null)
                    {
                        try
                        {
                            Object rezRealizacija = komunikacija.IzmeniRealizaciju(r);
                            try
                            {
                                Object rezRealizacijaUnos = komunikacija.SacuvajRealizaciju(r);
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("Sistem ne moze da izmeni destinaciju!");
                                return false;
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Sistem ne moze da izmeni destinaciju!");
                            return false;
                        }

                    }

                    MessageBox.Show("Sistem je uspesno izmenio destinaciju!");
                    return true;
                }

            }

            
        }

        internal static bool IzmeniRezervaciju(ComboBox cmbTurista, ComboBox cmbDestinacija, ComboBox cmbRadnik, ComboBox cmbMesto, TextBox txtDatum, TextBox txtBroj)
        {
            bool greska = false;
            bool empty = false;
            bool emptyDatum = false;
            bool uslov = false;

            rezervacija.Turista = cmbTurista.SelectedItem as Turista;

            rezervacija.Destinacija = cmbDestinacija.SelectedItem as Destinacija;

            rezervacija.Radnik = cmbRadnik.SelectedItem as Radnik;

            rezervacija.MestoPolaska = cmbMesto.SelectedItem as String;

            if (string.IsNullOrEmpty(txtDatum.Text) || txtDatum.Text == "Morate uneti datum!")
            {
                txtDatum.BackColor = Color.Red;
                txtDatum.Text = "Morate uneti datum!";
                greska = true;
                emptyDatum = true;
            }
            else if (txtDatum.Text != "Morate uneti datum!" || txtDatum.Text != "Datum mora biti u formatu dd/MM/yyyy!" || txtDatum.Text != "Datum rezervacije mora biti od " + DateTime.Now.ToString("dd/MM/yyyy") + "!")
            {
                txtDatum.BackColor = Color.GreenYellow;
            }

            if (!emptyDatum)
            {
                try
                {
                    rezervacija.DatumRezervacije = DateTime.ParseExact(txtDatum.Text, "dd/MM/yyyy", null);
                }
                catch (Exception)
                {
                    txtDatum.Text = "Datum mora biti u formatu dd/MM/yyyy!";
                    txtDatum.BackColor = Color.Red;
                    greska = true;
                    uslov = true;
                }

                if (!uslov)
                {
                    if (rezervacija.DatumRezervacije < DateTime.Now.AddDays(-1))
                    {
                        txtDatum.Text = "Datum rezervacije mora biti od " + DateTime.Now.ToString("dd/MM/yyyy") + "!";
                        txtDatum.BackColor = Color.Red;
                        greska = true;
                    }
                }

            }

            if (rezervacija.Turista == null)
            {
                cmbTurista.Text = "Morate odabrati turistu!";
                cmbTurista.BackColor = Color.Red;
                greska = true;
            }
            else
            {
                cmbTurista.BackColor = Color.GreenYellow;
            }

            if (rezervacija.Destinacija == null)
            {
                cmbDestinacija.Text = "Morate odabrati destinaciju!";
                cmbDestinacija.BackColor = Color.Red;
                greska = true;
            }
            else
            {
                cmbDestinacija.BackColor = Color.GreenYellow;
            }

            if (rezervacija.Radnik == null)
            {
                cmbRadnik.Text = "Morate odabrati radnika!";
                cmbRadnik.BackColor = Color.Red;
                greska = true;
            }
            else
            {
                cmbRadnik.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(rezervacija.MestoPolaska))
            {
                cmbMesto.Text = "Morate odabrati mesto polaska!";
                cmbMesto.BackColor = Color.Red;
                greska = true;
            }
            else
            {
                cmbMesto.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(txtBroj.Text) || txtBroj.Text == "Morate uneti broj turista!")
            {
                txtBroj.BackColor = Color.Red;
                txtBroj.Text = "Morate uneti broj turista!";
                greska = true;
                empty = true;
            }
            else if (txtBroj.Text != "Morate uneti broj turista!" || txtBroj.Text != "Broj turista mora biti u decimalnom zapisu!" || txtBroj.Text != "Broj turista mora biti veca od 0!")
            {
                txtBroj.BackColor = Color.GreenYellow;
            }

            if (!empty)
            {
                try
                {
                    rezervacija.BrojTurista = Convert.ToInt32(txtBroj.Text);
                }
                catch (Exception)
                {
                    txtBroj.BackColor = Color.Red;
                    txtBroj.Text = "Broj turista mora biti u decimalnom zapisu!";
                    greska = true;
                }

                if (rezervacija.BrojTurista < 0)
                {
                    txtBroj.Text = "Broj turista mora biti veca od 0!";
                    txtBroj.BackColor = Color.Red;
                    greska = true;
                    rezervacija.BrojTurista = 0;
                }

            }

            if (greska)
            {
                MessageBox.Show("Sistem ne moze da izmeni rezervaciju!");
                return false;
            }
            else
            {
                Object rez = komunikacija.IzmeniRezervaciju(rezervacija);
                if (rez == null)
                {
                    MessageBox.Show("Sistem ne moze da izmeni rezervaciju!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je uspesno izmenio rezervaciju!");
                    return true;
                }
            }
        }


        //internal static void ObrisiRedGridaIzlet(Button btnObrisiIzlet, DataGridView dataGridViewFakultativniIzlet)
        //{

        //    try
        //    {
        //        FakultativniIzlet fi = dataGridViewFakultativniIzlet.CurrentRow.DataBoundItem as FakultativniIzlet;
        //        foreach (DataGridViewCell red in dataGridViewFakultativniIzlet.SelectedCells)
        //        {
        //            if (red.Selected)
        //            {
        //                dataGridViewFakultativniIzlet.Rows.RemoveAt(red.RowIndex);

        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }


        //}

        internal static void ObrisiRedGridaFoto(Button btnObrisiFoto, DataGridView dataGridViewFoto, Label lblGreskaFoto)
        {
            try
            {
                FotografijeDestinacije fd = dataGridViewFoto.CurrentRow.DataBoundItem as FotografijeDestinacije;
                foreach (DataGridViewCell red in dataGridViewFoto.SelectedCells)
                {
                    if (red.Selected)
                    {
                        dataGridViewFoto.Rows.RemoveAt(red.RowIndex);

                    }

                }
                if(dataGridViewFoto.RowCount == 0)
                {
                    lblGreskaFoto.Text = "Morate uneti barem jednu fotografiju!";
                    lblGreskaFoto.BackColor = Color.Red;
                }
            }
            catch (Exception)
            {
                lblGreskaFoto.Text = "Niste odabrali fotografiju za brisanje!";
                lblGreskaFoto.BackColor = Color.Red;
            }


        }

        //internal static void PopuniGrid(Button btnDodajIzlet, ComboBox cmbFakultativniIzlet, DataGridView dataGridViewFakultativniIzlet)
        //{
        //    List<FakultativniIzlet> lista = new List<FakultativniIzlet>();
        //    FakultativniIzlet fi = cmbFakultativniIzlet.SelectedItem as FakultativniIzlet;
        //    dataGridViewFakultativniIzlet.DataSource = null;

        //    if (fi == null)
        //    {
        //        MessageBox.Show("Fakultativni izlet nije dodat!");
        //    } else
        //    {
        //        lista.Add(fi);
        //        MessageBox.Show("Fakultativni izlet je dodat!");

        //    }
        //    dataGridViewFakultativniIzlet.DataSource = lista;
        //}


        internal static void PrikaziPrethodnuFotografiju(Button btnLevo, Button btnDesno, PictureBox pictureBox)
        {
            //Ako imam 1 fotku u galeriji
            if (destinacija.GalerijaFotografija.Count == 1)
            {
                btnLevo.Enabled = false;
                btnDesno.Enabled = false;
                return;
            }

            br--;
            btnDesno.Enabled = true;
  
            if (br == 0) btnLevo.Enabled = false;
            if (br == destinacija.GalerijaFotografija.Count-1) btnDesno.Enabled = false;
            try
            {
                pictureBox.Image = Image.FromFile(destinacija.GalerijaFotografija[br].UrlFoto);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        internal static void PrikaziSledecuFotografiju(Button btnLevo, Button btnDesno, PictureBox pictureBox)
        {

            //Ako imam 1 fotku u galeriji
            if (destinacija.GalerijaFotografija.Count == 1)
            {
                btnLevo.Enabled = false;
                btnDesno.Enabled = false;
                return;
            }

            br++;
            btnLevo.Enabled = true;

            if (br == 0) btnLevo.Enabled = false;
            if (br == destinacija.GalerijaFotografija.Count - 1) btnDesno.Enabled = false;
            try
            {
                pictureBox.Image = Image.FromFile(destinacija.GalerijaFotografija[br].UrlFoto);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal static void prikaziFotografije(PictureBox pictureBox)
        {
            try
            {
                foreach (FotografijeDestinacije fd in destinacija.GalerijaFotografija)
                {
                    try
                    {
                        pictureBox.Image = Image.FromFile(fd.UrlFoto);

                    }
                    catch
                    {
                        MessageBox.Show("File nije pronadjen!");
                    }
                    //System.Diagnostics.Process.Start(@"" + fotografijeDestinacije.UrlFoto + "");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("File nije pronadjen!");
            }   
            
        }

        public static bool poveziSeNaServer()
        {
            if (komunikacija == null)
                komunikacija = new Komunikacija();
            return komunikacija.poveziSeNaServer();  
            
        }

        internal static void VratiSifruFakultativnogIzleta(TextBox txtID, GroupBox gbFakultativniIzlet, Button btnKreiraj)
        {
            fakultativniIzlet = new FakultativniIzlet();

            try
            {
                fakultativniIzlet.Id = (int)komunikacija.VratiSifruFakultativnogIzleta(fakultativniIzlet);
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da kreira fakultativni izlet!");
                return;
            }

           

            txtID.Text = fakultativniIzlet.Id.ToString();

            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Sistem ne moze da kreira fakultativni izlet!");
                return;

            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao fakultativni izlet!");
                btnKreiraj.Enabled = false;
                gbFakultativniIzlet.Enabled = true;
            }
        }

        internal static void KreirajFakultativniIzlet(TextBox txtID, GroupBox gbFakultativniIzlet, Button btnKreiraj)
        {
            fakultativniIzlet = (FakultativniIzlet)komunikacija.KreirajFakultativniIzlet();

            if (fakultativniIzlet == null)
            {
                MessageBox.Show("Sistem ne moze da kreira fakultativni izlet!");
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao fakultativni izlet!");
                txtID.Text = fakultativniIzlet.Id.ToString();
                btnKreiraj.Enabled = false;
                gbFakultativniIzlet.Enabled = true;

            }
        }

        internal static bool UcitajDestinaciju(DataGridView dataGridView)
        {
            try
            {
                destinacija = dataGridView.CurrentRow.DataBoundItem as Destinacija;
                destinacija = (Destinacija)komunikacija.UcitajDestinaciju(destinacija);

                if(destinacija == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita podatke o destinaciji!");
                    return false;
                } else
                {
                    MessageBox.Show("Sistem je ucitao podatke o destinaciji!");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali destinaciju!");
                return false;
            }
        }

        internal static bool UcitajRezervaciju(DataGridView dataGridView)
        {
            try
            {
                rezervacija = dataGridView.CurrentRow.DataBoundItem as Rezervacija;
                rezervacija = (Rezervacija)komunikacija.UcitajRezervaciju(rezervacija);
                if (rezervacija == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita podatke o rezervaciji!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao podatke o rezervaciji!");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali rezervaciju!");
                return false;
            }
        }

        internal static bool SacuvajFakultativniIzlet(TextBox txtID,TextBox txtMesto, TextBox txtOpis, TextBox txtCena)
        {

            bool greska = false;
            bool empty = false;

            //**JEDINSTVENA VALIDACIJA**
            fakultativniIzlet.Mesto = txtMesto.Text;

            fakultativniIzlet.Opis = txtOpis.Text;

            if (string.IsNullOrEmpty(txtCena.Text) || txtCena.Text == "Morate uneti cenu!")
            {
                txtCena.BackColor = Color.Red;
                txtCena.Text = "Morate uneti cenu!";
                greska = true;
                empty = true;
            }
            else if (txtCena.Text != "Morate uneti cenu!" || txtCena.Text != "Cena mora biti u realnom zapisu!" || txtCena.Text != "Cena mora biti veca od 0!")
            {
                txtCena.BackColor = Color.GreenYellow;
            }

            if (!empty)
            {
                try
                {
                    fakultativniIzlet.Cena = Convert.ToDouble(txtCena.Text);
                }
                catch (Exception)
                {
                    txtCena.BackColor = Color.Red;
                    txtCena.Text = "Cena mora biti u realnom zapisu!";
                    greska = true;
                }

                if(fakultativniIzlet.Cena < 0)
                {
                    txtCena.Text = "Cena mora biti veca od 0!";
                    txtCena.BackColor = Color.Red;
                    greska = true;
                    fakultativniIzlet.Cena = 0;
                }

            }
          
            if (string.IsNullOrEmpty(fakultativniIzlet.Mesto) || txtMesto.Text == "Morate uneti naziv mesta!")
            {
                txtMesto.BackColor = Color.Red;
                txtMesto.Text = "Morate uneti naziv mesta!";
                greska = true;
            }
            else if (txtMesto.Text != "Morate uneti naziv mesta!")
            {
                txtMesto.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(fakultativniIzlet.Opis) || txtOpis.Text == "Morate uneti opis!")
            {
                txtOpis.BackColor = Color.Red;
                txtOpis.Text = "Morate uneti opis!";
                greska = true;
            }
            else if (txtOpis.Text != "Morate uneti opis!")
            {
                txtOpis.BackColor = Color.GreenYellow;
            }

            if (greska)
            {
                MessageBox.Show("Sistem ne moze da zapamti fakultativni izlet!");
                return false;
            }
            else
            {
                Object rez = komunikacija.ZapamtiFakultativniIzlet(fakultativniIzlet);
                if (rez == null)
                {
                    MessageBox.Show("Sistem ne moze da zapamti fakultativni izlet!");
                    return false;

                }
                else
                {
                    MessageBox.Show("Sistem je uspesno zapamtio fakultativni izlet!");
                    return true;
                }
            }




            //**PRETHODNI KOD I VALIDACIJA**
            //fakultativniIzlet.Mesto = txtMesto.Text;

            //if (string.IsNullOrEmpty(fakultativniIzlet.Mesto))
            //{
            //    MessageBox.Show("Niste uneli naziv mesta!");
            //    txtMesto.Focus();
            //    return false;
            //}

            //fakultativniIzlet.Opis = txtOpis.Text;

            //if (string.IsNullOrEmpty(fakultativniIzlet.Opis))
            //{
            //    MessageBox.Show("Niste uneli opis za fakultativni izlet!");
            //    txtOpis.Focus();
            //    return false;
            //}

            //if(txtCena.Text == "")
            //{
            //    MessageBox.Show("Niste uneli cenu za fakultativni izlet!");
            //    txtCena.Focus();
            //    return false;
            //}

            //try
            //{
            //    fakultativniIzlet.Cena = Convert.ToDouble(txtCena.Text);

            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Niste uneli validnu cenu!");
            //    return false;
            //}

            //Object rez = komunikacija.ZapamtiFakultativniIzlet(fakultativniIzlet);
            //if (rez == null)
            //{
            //    MessageBox.Show("Sistem ne moze da zapamti fakultativni izlet!");
            //    return false;
            //}
            //else
            //{
            //    MessageBox.Show("Sistem je uspesno zapamtio fakultativni izlet!");
            //    return true;
            //}
        }

        internal bool dodajFotografiju()
        {
            FotografijeDestinacije fd = new FotografijeDestinacije();
            fd.DestId = destinacija.Id;
            fd.FotoId = destinacija.GalerijaFotografija.Count + 1;
            fd.UrlFoto = url;

            if(fd.UrlFoto == "")
            {
                MessageBox.Show("Morate uneti fotografiju!");
                return false;
            }

            destinacija.GalerijaFotografija.Add(fd);
            return true;
        }


        internal static void PrikaziFotografiju(DataGridView dataGridViewFoto, Label lblGreskaFoto)
        {
            try
            {
                // FotografijeDestinacije fd = dataGridViewFoto.CurrentRow.DataBoundItem as FotografijeDestinacije;
                dataGridViewFoto.DataSource = null;
                dataGridViewFoto.DataSource = destinacija.GalerijaFotografija;
                if(dataGridViewFoto.RowCount > 0)
                {
                    lblGreskaFoto.Text = "Fotografija je dodata!";
                    lblGreskaFoto.BackColor = Color.GreenYellow;
                } else
                {
                    lblGreskaFoto.Text = "Fotografija nije dodata!";
                    lblGreskaFoto.BackColor = Color.Red;
                }
               
                try
                {
                  //  System.Diagnostics.Process.Start(@"" + fd.UrlFoto + "");
                }
                catch (Exception)
                {

                    MessageBox.Show("File nije pronadjen!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali fotografiju!");
            }
        }

        internal static void PretraziDestinacije(TextBox txtNaziv, DataGridView dataGridView)
        {
            destinacija =  new Destinacija();
            destinacija.Uslov = " Naziv like '%" + txtNaziv.Text + "%' ";
            List<Destinacija> lista = (List<Destinacija>)komunikacija.PretraziDestinacije(destinacija);
            listaBD = new BindingList<Destinacija>();

            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje destinacije!");
                return;
            }

            if (lista.Count == 0 && txtNaziv.Text == "")
            {
                MessageBox.Show("Sistem ne moze da pronadje destinacije!");
                return;
            }


            foreach (Destinacija d in lista)
            {
                listaBD.Add(d);
            }

            dataGridView.DataSource = listaBD;
            dataGridView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

            bool nema = false;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nema destinacije za uneti naziv!");
                nema = true;

            }
            if (nema)
            {

            } else
            {
                MessageBox.Show("Sistem je pronasao destinacije!");
            }
          
        }

        internal static void PretraziRezervacije(TextBox txtMestoPolaska, DataGridView dataGridView)
        {
            rezervacija = new Rezervacija();
            rezervacija.Uslov = " mestoPolaska like '%" + txtMestoPolaska.Text + "%' ";
            List<Rezervacija> lista = (List<Rezervacija>)komunikacija.PretraziRezervacije(rezervacija);
            listaBR = new BindingList<Rezervacija>();

            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje rezervacije!");
                return;

            }

            if (lista.Count == 0 && txtMestoPolaska.Text == "")
            {
                MessageBox.Show("Sistem ne moze da pronadje rezervacije!");
                return;
            }

            foreach (Rezervacija rez in lista)
            {
                listaBR.Add(rez);
            }

            dataGridView.DataSource = listaBR;
            dataGridView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            bool nema = false;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nema rezervacija za uneto mesto polaska!");
                nema = true;

            }
            if (nema)
            {

            }
            else
            {
                MessageBox.Show("Sistem je pronasao rezervacije!");
            }

        }

        internal static void PretraziFakultativneIzlete(TextBox txtMesto, DataGridView dataGridView)
        {
            fakultativniIzlet = new FakultativniIzlet();
            fakultativniIzlet.Uslov = " Mesto like '%" + txtMesto.Text + "%' ";
            List<FakultativniIzlet> lista = (List<FakultativniIzlet>)komunikacija.PretraziFakultativneIzlete(fakultativniIzlet);
            listaB = new BindingList<FakultativniIzlet>();

            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje fakultativne izlete!");
                return;

            }

            if (lista.Count == 0 && txtMesto.Text == "")
            {
                MessageBox.Show("Sistem ne moze da pronadje fakultativne izlete!");
                return;
            }


            foreach (FakultativniIzlet f in lista)
            {
                listaB.Add(f);
            }

            dataGridView.DataSource = listaB;

            bool nema = false;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nema fakultativnih izleta za uneto mesto!");
                nema = true;
            }

            if (nema)
            {

            } else
            {
                MessageBox.Show("Sistem je pronasao fakultativne izlete!");
            }

    
        }


        internal static string PrikaziUlogovanogRadnika()
        {
            return "Ulogovan je: " + radnik.Ime + " " + radnik.Prezime + " , Vreme prijave: " +DateTime.Now.ToString("HH:mm");
        }

        internal static void PopuniComboFakultativniIzlet(ComboBox cmbFakultativniIzlet)
        {
            cmbFakultativniIzlet.Items.Clear();
            List<FakultativniIzlet> lista = (List<FakultativniIzlet>)komunikacija.VratiSveFakultativneIzlete();
            foreach(FakultativniIzlet fi in lista)
            {
                cmbFakultativniIzlet.Items.Add(fi);
            }
            cmbFakultativniIzlet.Text = "Izaberite fakultativni izlet!";
        }

        internal static void PopuniComboTurista(ComboBox cmbTurista)
        {
            cmbTurista.Items.Clear();
            List<Turista> lista = (List<Turista>)komunikacija.VratiSveTuriste();
            foreach(Turista t in lista)
            {
               cmbTurista.Items.Add(t);
            }
            cmbTurista.Text = "Izaberite turistu!";
        }

        internal static void PopuniComboDestinacija(ComboBox cmbDestinacija)
        {
            cmbDestinacija.Items.Clear();
            List<Destinacija> lista = (List<Destinacija>)komunikacija.VratiSveDestinacije();
            foreach (Destinacija d in lista)
            {
                cmbDestinacija.Items.Add(d);
            }
            cmbDestinacija.Text = "Izaberite destinaciju!";
        }

        internal static void PopuniComboRadnik(ComboBox cmbRadnik)
        {
            cmbRadnik.Items.Clear();
            List<Radnik> lista = (List<Radnik>)komunikacija.VratiSveRadnike();
            foreach (Radnik r in lista)
            {
                cmbRadnik.Items.Add(r);
            }
            cmbRadnik.Text = "Izaberite radnika!";
        }


        internal static bool VratiSifruDestinacije(TextBox txtID, GroupBox gbDestinacija, Button btnKreiraj, Button btnSacuvaj)
        {
            destinacija = new Destinacija();

            try
            {
                destinacija.Id = (int)komunikacija.VratiSifruDestinacije(destinacija);
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da kreira destinaciju!");
                return false;
            }

          

            txtID.Text = destinacija.Id.ToString();

            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Sistem ne moze da kreira destinaciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao destinaciju!");
                btnKreiraj.Enabled = false;
                gbDestinacija.Enabled = true;
                btnSacuvaj.Enabled = true;

                return true;
            }
        }

        internal static bool KreirajDestinaciju(TextBox txtID, GroupBox gbDestinacija, Button btnKreiraj, Button btnSacuvaj)
        {
            destinacija = (Destinacija)komunikacija.KreirajDestinaciju();

            if (destinacija == null)
            {
                MessageBox.Show("Sistem ne moze da kreira destinaciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao destinaciju!");
                txtID.Text = destinacija.Id.ToString();
                btnKreiraj.Enabled = false;
                gbDestinacija.Enabled = true;
                btnSacuvaj.Enabled = true;

                return true;

            }
        }

        internal static void VratiSifruTuriste(TextBox txtID, GroupBox gbTurista, Button btnKreiraj)
        {
            turista = new Turista();

            try
            {
                turista.Id = (int)komunikacija.VratiSifruTuriste(turista);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da kreira turistu!");
                return;

            }

            txtID.Text = turista.Id.ToString();

            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Sistem ne moze da kreira turistu!");

            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao turistu!");
                btnKreiraj.Enabled = false;
                gbTurista.Enabled = true;
            }
        }

        internal static void KreirajTuristu(TextBox txtID, GroupBox gbTurista, Button btnKreiraj)
        {
            turista = (Turista)komunikacija.KreirajTuristu();

            if (turista == null)
            {
                MessageBox.Show("Sistem ne moze da kreira turistu!");
            } else
            {
                MessageBox.Show("Sistem je uspesno kreirao turistu!");
                txtID.Text = turista.Id.ToString();
                btnKreiraj.Enabled = false;
                gbTurista.Enabled = true;

            }
        }
        internal static bool SacuvajTuristu(TextBox txtID,TextBox txtIme, TextBox txtPrezime, TextBox txtAdresa,TextBox txtDatum, TextBox txtBrojTelefona)
        {
            bool greska = false;
            bool empty = false;
         
            //**JEDINSTVENA VALIDACIJA**
            turista.Ime = txtIme.Text;

            turista.Prezime = txtPrezime.Text;

            turista.Adresa = txtAdresa.Text;

            if (string.IsNullOrEmpty(txtDatum.Text) || txtDatum.Text == "Morate uneti datum!")
            {
                txtDatum.BackColor = Color.Red;
                txtDatum.Text = "Morate uneti datum!";
                greska = true;
                empty = true;
            } else if(txtDatum.Text != "Morate uneti datum!" || txtDatum.Text != "Datum mora biti u formatu dd/MM/yyyy!")
            {
                txtDatum.BackColor = Color.GreenYellow;
            }

            if (!empty)
            {
                try
                {
                    turista.DatumRodjenja = DateTime.ParseExact(txtDatum.Text, "dd/MM/yyyy", null);
                }
                catch (Exception)
                {
                    txtDatum.Text = "Datum mora biti u formatu dd/MM/yyyy!";
                    txtDatum.BackColor = Color.Red;
                    greska = true;
                }
            }

            if (turista.DatumRodjenja > DateTime.Now.AddYears(-18))
            {
                txtDatum.Text = "Turista mora imati 18 godina!";
                txtDatum.BackColor = Color.Red;
                greska = true;
            }

            turista.BrojTelefona = txtBrojTelefona.Text;

            if (string.IsNullOrEmpty(turista.Ime) || txtIme.Text == "Morate uneti ime!")
            {
                txtIme.BackColor = Color.Red;
                txtIme.Text = "Morate uneti ime!";
                greska = true;
            } else if(txtIme.Text != "Morate uneti ime!")
            {
                txtIme.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(turista.Prezime) || txtPrezime.Text == "Morate uneti prezime!")
            {
                txtPrezime.BackColor = Color.Red;
                txtPrezime.Text = "Morate uneti prezime!";
                greska = true;
            } else if(txtPrezime.Text != "Morate uneti prezime!")
            {
                txtPrezime.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(turista.Adresa) || txtAdresa.Text == "Morate uneti adresu!")
            {
                txtAdresa.BackColor = Color.Red;
                txtAdresa.Text = "Morate uneti adresu!";
                greska = true;
               
            } else if(txtAdresa.Text != "Morate uneti adresu!")
            {
                txtAdresa.BackColor = Color.GreenYellow;
            }

            if (string.IsNullOrEmpty(turista.BrojTelefona) || txtBrojTelefona.Text == "Morate uneti broj telefona!")
            {
                txtBrojTelefona.BackColor = Color.Red;
                txtBrojTelefona.Text = "Morate uneti broj telefona!";
                greska = true;
            } else if(txtBrojTelefona.Text != "Morate uneti broj telefona!")
            {
                txtBrojTelefona.BackColor = Color.GreenYellow;
            }

            if (greska)
            {
                MessageBox.Show("Sistem ne moze da zapamti turistu!");
                return false;
            } else
            {
                Object rez = komunikacija.ZapamtiTuristu(turista);
                if(rez == null)
                {
                    MessageBox.Show("Sistem ne moze da zapamti turistu!");
                    return false;

                } else
                {
                    MessageBox.Show("Sistem je uspesno zapamtio turistu!");
                    return true;
                }
            }


        }

        internal static void Kraj()
        {
            komunikacija.Kraj();
            komunikacija = null;
        }

        internal static bool PrijaviRadnika(TextBox txtUsername, TextBox txtPassword)
        {
            radnik = new Radnik();
            radnik.Username = txtUsername.Text;
            radnik.Password = txtPassword.Text;

            radnik = komunikacija.PrijavaRadnika(radnik) as Radnik;

            if(radnik == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje korisnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno prijavio radnika!");
                return true;
            }
        }


    }
}
