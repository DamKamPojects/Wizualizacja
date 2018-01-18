using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Wizualizacja
{
    public partial class Podsumowanie : Form
    {
        double StepSize;
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

            panelPodsum_tb_Podsumowanie.Text = tekst_podsumowanie + Environment.NewLine + "WARTOŚĆ ZAKUPU: " + String.Format("{0:0.00} zł",suma);
            pGotow_tb_Podsumowanie.Text = tekst_podsumowanie +Environment.NewLine+ "WARTOŚĆ ZAKUPU: " + String.Format("{0:0.00} zł",suma);

            panelPodsumowanie_tb_Suma.Text = doZaplaty;
            pGotow_l_DoZaplaty.Text = doZaplaty;
            l_doZaplaty.Text = doZaplaty;
            tb_SposobPlatnosci();
            StepSize = (double)timer1.Interval / 1000.0;
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
                l_SposPaltnosci.Text = panelPodsumowanie_tb_SposobPlatnosci.Text;
            }
            else if (SposobPlatnosci == 2)
            {
                panelPodsumowanie_tb_SposobPlatnosci.Text = "Karta płatnicza";
                l_SposPaltnosci.Text = panelPodsumowanie_tb_SposobPlatnosci.Text;
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
                ResetujCzasReakcji();
                CzasStop = true;
                ObslugaKomunikatow();
                OknoKomunikatu okno = new OknoKomunikatu(list, SposobPlatnosci);
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
                list.Add("Proszę postępować zgodnie z intrukcjami na terminalu płatniczym.\n\n\n\n\n");
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
                    list.Add("Prosimy wyjąć kartę miejską z biletomatu.");
                    if (DoZaplaty < 0)
                    {
                        list.Add("Prosimy odebrać resztę z biletomatu.");
                    }
                    list.Add("Bilet został kupiony pomyślnie.");
                }

                if (RodzajKupowanegoBiletu != 1)
                {
                    list.Add("Trwa drukowanie biletu... \n Prosimy o cierpliwość...");
                    if (DoZaplaty < 0)
                    {
                        list.Add("Prosimy odebrać bilety oraz resztę.");
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
            //Image imageTlo = new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.niebieskietlo);
            //this.BackgroundImage = imageTlo;
            GetCurrentTime();
            pPodsu.BringToFront();
            pKoniecWstecz_b_Wstecz.Visible = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            AkutalneOkno = 1;
            DoZaplaty = Suma;
            pb_postep.Maximum = 5000;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ObslugaReklam();
            GetCurrentTime();
        }

        private void pKoniecWstecz_b_Wstecz_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            if (AkutalneOkno == 1)
            {
                this.Close();
            }
            else
            {
                AkutalneOkno = 1;
                pPodsu.BringToFront();
            }
        }

        private void pKoniecWstecz_b_Koniec_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            OknoPotwierdzeniaWyjscia oknoPotwierdzeniaWyjscia = new OknoPotwierdzeniaWyjscia();
            oknoPotwierdzeniaWyjscia.ShowDialog();
            if (oknoPotwierdzeniaWyjscia.Koniec == true)
            {
                Koniec = true;
                this.Close();
            }
            oknoPotwierdzeniaWyjscia.Close();
        }
        private void pPodsu_b_ZmienPlactnosci_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            WyborKartaCzyGotowka wyborKartaCzyGotowka = new WyborKartaCzyGotowka(Komunikat_suma);
            wyborKartaCzyGotowka.ShowDialog();
            SposobPlatnosci = wyborKartaCzyGotowka.SposobPlatnosci;
            tb_SposobPlatnosci();
            wyborKartaCzyGotowka.Close();
        }
        private void pPodsu_b_Potwiedz_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            if (SposobPlatnosci==1)
            {
                pGotow.BringToFront();
                AkutalneOkno = 2;
                pKoniecWstecz_b_Wstecz.Visible = false;
            }

            else
            {
                ObslugaKomunikatow();
                OknoKomunikatu okno = new OknoKomunikatu(list, SposobPlatnosci);
                okno.ShowDialog();
                okno.ZmianaKomunikatow();
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

        private void panelGorny_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pGotow_b_50gr_Click(object sender, EventArgs e)
        {
            Zaplacono += 0.50;
            LabelsOperating();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }


        #region >>>>>>>Inne
        double TimeFromLastMove;
        bool DoResetowaniareklam = false;
        bool CzyJestReklama = false;
        public bool CzasStop=false;
        int PoziomReklamy = 0; //potrzebne do zmiany kimunikatów 
        public void ResetujCzasReakcji()//po wcisnieciu jakiegokolwiek buttona
        {
            TimeFromLastMove = 0;
            DoResetowaniareklam = false;
        }

        #region DUzo guzikow
        private void panelGorny_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pGotow_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pGotow_tb_Podsumowanie_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pGotowka_l_pobrrr_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pGotowka_l_Pobrano_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pGotow_l_DoZaplaty_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pPodsu_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelPodsum_tb_Podsumowanie_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void l_SposPaltnosci_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void l_doZaplaty_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }
        #endregion

        private void panelMenu_b_Pomoc_Click(object sender, EventArgs e)
        {
            Informacje informacje = new Informacje();
            informacje.ShowDialog();
        }

        void ObslugaReklam()
        {
            Czas czas = new Czas();

            double CzasReklama = czas.CzasDoReklam;
            double CzasKoniecSesji = czas.CzasDoReset;


            //sprawdza czy juz nie jest czas by wyswietlic reklame
            if (TimeFromLastMove > CzasReklama && CzyJestReklama == false && PoziomReklamy==0)
            {
                CzyJestReklama = true;
                PoziomReklamy = 1;
                WyswietlReklamy();
            }
            else if (TimeFromLastMove > CzasKoniecSesji && CzyJestReklama == true && PoziomReklamy == 1)
            {
                Koniec = true;                
                PoziomReklamy = 2; //czyli kolejna sesja
                DoResetowaniareklam = true;
                this.Close();
            }

            if (CzasStop ==false)
            {
                TimeFromLastMove += StepSize;
            }
        }
        public void WyswietlReklamy() //wyswietla reklamy
        {

            Reklamy reklamy = new Reklamy();
            reklamy.ShowDialog();
            timer1.Enabled = true;
            if (reklamy.Koniec == true)
            {
                ResetujCzasReakcji();
                PoziomReklamy = 0;
                CzyJestReklama = !reklamy.Koniec;
            }
        }
        #endregion
    }
}