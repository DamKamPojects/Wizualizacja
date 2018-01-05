using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Wizualizacja
{
    public partial class Podsumowanie : Form
    {
        public List<string> list = new List<string>();
        int SposobPlatnosci;
        public double Suma, DoZaplaty=10,Zaplacono=0;
        public int RodzajKupowanegoBiletu = 0; //1-okresowy(inne komunikaty)
        public bool Koniec = false;
        public int AkutalneOkno;
        string Komunikat_suma;

        //kontruktory
        public Podsumowanie()
        {
            InitializeComponent();
        }
        public Podsumowanie(string tekst_podsumowanie,string doZaplaty, int sposobPlatnosci, int progressBar, double suma)
        {            
            SposobPlatnosci = sposobPlatnosci;
            Komunikat_suma = doZaplaty;
            InitializeComponent();
            Suma = suma;

            panelPodsum_tb_Podsumowanie.Text = tekst_podsumowanie;
            pGotow_tb_Podsumowanie.Text = tekst_podsumowanie + "\nSUMA: " + Convert.ToString(Suma);

            panelPodsumowanie_tb_Suma.Text = doZaplaty;
            pGotow_l_DoZaplaty.Text = doZaplaty;
            tb_SposobPlatnosci();
            //pb_postep.Value = progressBar;
        }

        //metody
        private void GetCurrentTime()
        {
            DateTime thisDay = DateTime.Now;
            //http://www.csharp-examples.net/string-format-datetime/
            //data + godzina aktualna
            //string Time = "Dziś jest "  + thisDay.ToString("D") + Environment.NewLine + "Aktualna godzina:\n" + Environment.NewLine+ thisDay.ToString(" HH:mm:ss");
            //aktualna godzina
            //string Time = "Aktualna godzina:\n" + Environment.NewLine + thisDay.ToString(" HH:mm:ss");
            string dzien = (thisDay.ToString("dddd")).ToUpper();
            l_data.Text = dzien + ", " + thisDay.ToString("dd.MM.yyyy");
            l_godzina.Text = thisDay.ToString("HH:mm:ss");


        } //moetoda pobierajaca aktualną datę
        public void tb_SposobPlatnosci()
        {
            if (SposobPlatnosci == 1)
            {
                panelPodsumowanie_tb_SposobPlatnosci.Text = "Gotówka";
            }
            else if (SposobPlatnosci == 2)
            {
                panelPodsumowanie_tb_SposobPlatnosci.Text = "Karta płatnicza";
            }
            else panelPodsumowanie_tb_SposobPlatnosci.Text = "Nie wybrano";
        }
        private void ValueOfTheProgressBar()
        {
            if (pb_postep.Value < 1200)
                pb_postep.Value++;
            //else pb_postep.Value = 0;


        }//metoda obslugujaca progressbar
        public void LabelsOperating()
        {
            DoZaplaty = Suma-Zaplacono;
            pGotow_l_DoZaplaty.Text = (String.Format("{0:0.00} zł",DoZaplaty));
            pGotowka_l_Pobrano.Text = String.Format("{0:0.00} zł",Zaplacono);
            if (DoZaplaty<=0)
            {
                ObslugaKomunikatow();
                OknoKomunikatu okno = new OknoKomunikatu(list);
                okno.ShowDialog();
                Koniec = true;
                list.Clear();
                this.Close();

            }
        }
        public void ObslugaKomunikatow()
        {
            if (SposobPlatnosci==2)
            {
                list.Add("Proszę przyłożyć karte płatniczą do terminala płatniczego.");
                list.Add("Trwa przetwarzanie danych... Prosimy czekać.");
                if (RodzajKupowanegoBiletu == 1)
                {
                    list.Add("Transakcja zaakceptowana. ");
                    list.Add("Bilet został kupiony pomyślnie.");
                }
                else
                {
                    list.Add("Transakcja zaakceptowana. Trwa drukowanie biletów...");
                    list.Add("Prosze odebrać bilety z biletomatu.");
                }
                list.Add("Dziękujemy za zakup biletów w naszym biletomacie. Życzymy Państwu miłego dnia!");
            }

            if (SposobPlatnosci==1)
            {
                list.Add("Przetwarzanie danych...");
                if (RodzajKupowanegoBiletu == 1)
                {
                    list.Add("Prosimy wyjąć kartę miejscą z biletomatu.");
                    if (DoZaplaty < 0)
                    {
                        list.Add("Prosimy odebrać resztą z biletomatu.");
                    }
                    list.Add("Bilet został kupiony pomyślnie.");
                }

                if (RodzajKupowanegoBiletu != 1)
                {
                    list.Add("Trwa drukowanie biletu... \n Prosimy o cierpliwość...");
                    if (DoZaplaty < 0)
                    {
                        list.Add("Proszimy odebrać bilety oraz resztę.");
                    }
                    else
                    {
                        list.Add("Prosimy odebrać bilety.");
                    }
                }

                list.Add("Dziękujemy za zakup biletów w naszym biletomacie. Życzymy Państwu miłego dnia!");
            }
            
        }


        //programowanie przyciskow
        private void Podsumowanie_Load(object sender, EventArgs e)
        {
            Image imageTlo = new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.niebieskietlo);
            //this.BackgroundImage = imageTlo;
            pPodsu.BringToFront();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            AkutalneOkno = 1;
            DoZaplaty = Suma;
            pb_postep.Maximum = 5000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //tb_godzina.Text = GetCurrentTime();
            GetCurrentTime();
            if (this.pb_postep.Value < pb_postep.Maximum)
                this.pb_postep.Value++;
            else this.pb_postep.Value = 0;
            //TimeToLeft();
            //this.pb_postep.Value = this.pb_postep.Value + 10;
            //if (AktualneOkno != 0)
            //    panelKoniecWstecz.Visible = true;
        }
        private void panelKoniecWstecz_b_Wstecz_Click(object sender, EventArgs e)
        {
            if (AkutalneOkno==1)
            {
                this.Close();
            }
            else
            {
                AkutalneOkno = 1;
                pPodsu.BringToFront();
            }
        }
        private void pPodsu_b_ZmienPlactnosci_Click(object sender, EventArgs e)
        {
            WyborKartaCzyGotowka wyborKartaCzyGotowka = new WyborKartaCzyGotowka(Komunikat_suma);
            wyborKartaCzyGotowka.ShowDialog();
            SposobPlatnosci = wyborKartaCzyGotowka.SposobPlatnosci;
            tb_SposobPlatnosci();
            wyborKartaCzyGotowka.Close();
        }
        private void panelKoniecWstecz_b_Koniec_Click(object sender, EventArgs e)
        {
            OknoPotwierdzeniaWyjscia oknoPotwierdzeniaWyjscia = new OknoPotwierdzeniaWyjscia();
            oknoPotwierdzeniaWyjscia.ShowDialog();
            if (oknoPotwierdzeniaWyjscia.Koniec==true)
            {                
                Koniec = true;
                this.Close();
            }
            oknoPotwierdzeniaWyjscia.Close();
        }
        private void pPodsu_b_Potwiedz_Click(object sender, EventArgs e)
        {
            if (SposobPlatnosci==1)
            {
                pGotow.BringToFront();
            }

            else
            {
                ObslugaKomunikatow();
                OknoKomunikatu okno = new OknoKomunikatu(list);
                okno.ShowDialog();
                Koniec = true;
                list.Clear();
                this.Close();
            }
        }


        //wrzucanie kasy
        private void pGotow_b_5zl_Click(object sender, EventArgs e)
        {
            Zaplacono += 5.00;
            LabelsOperating();
        }
        private void pGotow_b_20zl_Click(object sender, EventArgs e)
        {
            Zaplacono += 20.00;
            LabelsOperating();
        }
        private void pGotow_b_2zl_Click(object sender, EventArgs e)
        {
            Zaplacono += 2.00;
            LabelsOperating();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public int DoUsunieciaZmienna = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            switch(DoUsunieciaZmienna % 10)
            {
                case 0:
                    {
                        this.BackColor = Color.Yellow;
                        break;
                    }
                case 1:
                    {
                        this.BackColor = Color.WhiteSmoke;
                        break;
                    }
                case 2:
                    {
                        this.BackColor = Color.Maroon;
                        break;
                    }
                case 3:
                    {
                        this.BackColor = Color.MediumBlue;
                        break;
                    }
                case 4:
                    {
                        this.BackColor = Color.Yellow;
                        break;
                    }
                case 5:
                    {
                        this.BackColor = Color.Yellow;
                        break;
                    }
            }
        }

        private void pGotow_b_50gr_Click(object sender, EventArgs e)
        {
            Zaplacono += 0.50;
            LabelsOperating();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}