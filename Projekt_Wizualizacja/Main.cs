using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Wizualizacja01;

namespace Projekt_Wizualizacja
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }


    #region Zmienne
        public int TimeOfTransaction=120; //domyślny czas na kupienie biletu
        int AktualneOkno = 0;
    #endregion

    #region Metody
        private void WsteczButton()
        {
            ResetValuesOkresowe();
            switch (AktualneOkno)
            {
                case 0:
                    {
                        panelMenu.BringToFront();
                        panelOkresowe.SendToBack();
                        if (AktualneOkno == 0)
                            panelKoniecWstecz.Visible = false;
                        break;
                    }
                case 2:
                    {
                        panelMenu.BringToFront();
                        panelOkresowe.SendToBack();
                        AktualneOkno = 0;
                        if (AktualneOkno == 0)
                            panelKoniecWstecz.Visible = false;
                        break;
                    }
            }
        }
        private void KoniecButton() //metoda do przycisku koniec
        {

        }
        private void MoveToTheCenter() //metoda przesuwające okno do środka
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }
        private void GetCurrentTime()
        {
            DateTime thisDay = DateTime.Now;
            //http://www.csharp-examples.net/string-format-datetime/
            //data + godzina aktualna
            //string Time = "Dziś jest "  + thisDay.ToString("D") + Environment.NewLine + "Aktualna godzina:\n" + Environment.NewLine+ thisDay.ToString(" HH:mm:ss");
            //aktualna godzina
            //string Time = "Aktualna godzina:\n" + Environment.NewLine + thisDay.ToString(" HH:mm:ss");
            string dzien = (thisDay.ToString("dddd")).ToUpper();             
            l_data.Text =dzien + ", "+ thisDay.ToString("dd.MM.yyyy");
            l_godzina.Text = thisDay.ToString("HH:mm:ss");
            
           
        } //moetoda pobierajaca aktualną datę
        private void ValueOfTheProgressBar()
        {
            if (pb_postep.Value < 1200)
                pb_postep.Value++;
            //else pb_postep.Value = 0;


        }//metoda obslugujaca progressbar
        private void TimeToLeft() // metoda pokazująca ile czasu zostało
        {
            int RemainingTime, min, sec;
            RemainingTime = TimeOfTransaction - pb_postep.Value/10;
            string sec2;
            min = RemainingTime/60;
            sec = RemainingTime % 60;

            if (sec < 10)
            {
                sec2 = "0" + Convert.ToString(sec);
            }
            else
            {
                sec2 = Convert.ToString(sec);
            }

           // l_postep.Text = Convert.ToString(min) +":"+ sec2;
            l_postep.Visible = false;
        }

    #endregion

    #region Programowanie kontrolek

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size=new Size(1328,748); //bazowa wielkość okna
            MoveToTheCenter();
            GetCurrentTime();
            panelKoniecWstecz.Visible = false;
            //TimeOfTransaction = 64;

        }

        private void timer1_Tick(object sender, EventArgs e) // czas ticku ustawiony na 1s - zmiana na inny spowoduje wiele problemów ze wszystkimi funckjami. Poki co lepiej zostawić ta 1 s
        {
            //tb_godzina.Text = GetCurrentTime();
            GetCurrentTime();
            if (this.pb_postep.Value < pb_postep.Maximum)
                this.pb_postep.Value++;
            else this.pb_postep.Value = 0;
            TimeToLeft();
            //this.pb_postep.Value = this.pb_postep.Value + 10;
            if (AktualneOkno != 0)
                panelKoniecWstecz.Visible = true;
        }

        #endregion

    #region Panel wstecz i Koniec
        private void panelKoniecWstecz_b_Wstecz_Click(object sender, EventArgs e)
        {
            WsteczButton();
        }
        private void panelKoniecWstecz_b_Koniec_Click(object sender, EventArgs e)
        {
            AktualneOkno = 0;
            WsteczButton();
        }
#endregion

    #region Menu główne
        private void panelMenu_b_BiletyJednorazowe_Click(object sender, EventArgs e)
        {

        }

        private void panel1_b_BiletyMiesieczne_Click(object sender, EventArgs e)
        {
            AktualneOkno = 2;
            panelOkresowe.BringToFront();            
        }

        private void panelMenu_b_BiletyMetroKomun_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_b_BiletyMetroKolKom_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_b_RozkladJazdy_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_b_JakDojade_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_b_DoladowanieTelefonu_Click(object sender, EventArgs e)
        {

        }
        #endregion

    #region Bilety okresowe

        Ceny_biletow ceny1 = new Ceny_biletow();
        //zmienne
        public string komunikat_info, komunikat_suma, pocz,kategoria_tekst = "";// kom1, kom2, kom3, kom4, kom5, pocz;
        public int bilet = 3, Rodzaj_ulgi = 3, Typ_biletu = 3, Waznosc_biletu = 3, kategoria_biletu = 0, SposobPlatnosci = 0; //0-pierwszy po lewej, 1 pierwszy po prawej
        public bool sprawdzenie = false, SprawdzenieWyboruBiletu=false;
        public double cena;

        //metody
        public void Nazwa_poczatek() //metoda do tworzdenia początku
        {
            pocz = "Bilet okresowy:\n " +Environment.NewLine;
            if (bilet == 0) pocz = pocz + "\t-30 DNIOWY, " + Environment.NewLine; else pocz = pocz + "\t-MIESIĘCZNY, " + Environment.NewLine;
            if (Rodzaj_ulgi == 0) pocz = pocz + "\n \t-ZWYKŁY, " + Environment.NewLine; else pocz = pocz + "\n \t-ULGOWY, " + Environment.NewLine;
            if (Typ_biletu == 0) pocz = pocz + "\n \t-IMIENNY, " + Environment.NewLine; else pocz = pocz + "\n \t-NA OKAZICIELA, " + Environment.NewLine;
            if (Waznosc_biletu == 0) pocz = pocz + "\n\t-ważny od PON do PT, " + Environment.NewLine + "na linie "; else pocz = pocz + "\n\t-ważny we WSZYSTKIE DNI TYGODNIA," + Environment.NewLine + "na linie ";

            switch (kategoria_biletu)
            {
                case 0:
                    {
                        pocz = "Nie wybrano żadnego biletu.";        break;
                    }
                case 1:
                    {
                        pocz = pocz + "zwykłe w granicach Gdyni.\n"; break;
                    }
                case 2:
                    {
                        pocz = pocz + "nocne, pospieszne i zwykłe w granicach Gdyni."; break;
                    }
                case 3:
                    {
                        pocz = pocz + "nocne, pospieszne i zwykłe "; break;
                    }
                case 4:
                    {
                        pocz = pocz + "nocne, pospieszne i zwykłe ";break;
                    }
                case 5:
                    {
                        pocz = pocz + "nocne, pospieszne i zwykłe w obrębie sieci komunikacyjnej [w tym linie G, N1, 101 i 171]"; break;
                    }
            }
            komunikat_info = pocz + kategoria_tekst;
            //return pocz;
        }
        public void Spr_wszystkich_opcji() //metoda do sprawdzenia czy wszystkoe opcje zostały zaznaczone
        {
            if (bilet != 3 && Rodzaj_ulgi != 3 && Typ_biletu != 3 && Waznosc_biletu != 3) sprawdzenie = true;
            else sprawdzenie = false;
        }
        public double Cena_biletu(int jaki_bilet)
        {
            Spr_wszystkich_opcji(bilet, Rodzaj_ulgi, Typ_biletu, Waznosc_biletu);
            int typ = 0;

            if (sprawdzenie == true)
            {
                if (Typ_biletu == 0)
                {
                    if (Waznosc_biletu == 0)
                    {
                        typ = 1;
                    }
                    else typ = 3;
                }
                else
                {
                    if (Waznosc_biletu == 0)
                    {
                        typ = 5;
                    }
                }
            }

            // określenie rodzaju biletu inaczej jakby okresleniekolumny
            switch (jaki_bilet)
            {
                case 1:
                    {
                        if (typ == 1) cena = ceny1.M30I_PP_Zwykly;
                        else if (typ == 3) cena = ceny1.M30I_PN_Zwykly;
                        else cena = ceny1.M30NO_PN_Zwykly;
                        break;
                    }
                case 2:
                    {
                        if (typ == 1) cena = ceny1.M30I_PP_Nocny;
                        else if (typ == 3) cena = ceny1.M30I_PN_Nocny;
                        else cena = ceny1.M30NO_PN_Nocny;
                        break;
                    }
                case 3:
                    {
                        if (typ == 1) cena = ceny1.M30I_PP_NocnyGminy;
                        else if (typ == 3) cena = ceny1.M30I_PN_NocnyGminy;
                        else cena = ceny1.M30NO_PN_NocnyGminy;
                        break;
                    }
                case 4:
                    {
                        if (typ == 1) cena = ceny1.M30I_PP_NocnyRRW;
                        else if (typ == 3) cena = ceny1.M30I_PN_NocnyRRW;
                        else cena = ceny1.M30NO_PN_NocnyRRW;
                        break;
                    }
                case 5:
                    {
                        if (typ == 1) cena = ceny1.M30I_PP_NocnySieci;
                        else if (typ == 3) cena = ceny1.M30I_PN_NocnySieci;
                        else cena = ceny1.M30NO_PN_NocnySieci;
                        break;
                    }
            } // do określenia ceny biletów

            if (Rodzaj_ulgi == 1 && Typ_biletu == 0) cena = cena / 2; //naliczanie ulgi
            return cena;
        }
        public void Wpisywanie_Do_TB() 
        {
            if (sprawdzenie!=true || kategoria_biletu==0)
            {
                cena = 0;
                kategoria_tekst = "";
            } //wyczyszenie buforu tekstu

            Nazwa_poczatek();
            if (SprawdzenieWyboruBiletu == true && sprawdzenie== true)
            {
                panelOkresowe_tb_Podsumowanie.Text = "\n" + komunikat_info;//kom1 + kom2 + kom3 + kom4 + kom5;
                komunikat_suma = Convert.ToString(Cena_biletu(kategoria_biletu)) + ",00 zł.";
                panelOkresowe_tb_Suma.Text =komunikat_suma;
            }
        }
        public void ResetValuesOkresowe()
        {
            ZmianaKoloruKontrolekOkresowe();
            panelOkresowe_b_30dni.BackColor = Color.White;
            panelOkresowe_b_mies.BackColor = Color.White;
            panelOkresowe_b_ulgowy.BackColor = Color.White;
            panelOkresowe_b_zwykly.BackColor = Color.White;
            panelOkresowe_b_imienny.BackColor = Color.White;
            panelOkresowe_b_PonPia.BackColor = Color.White;
            panelOkresowe_b_WszDni.BackColor = Color.White;
            kategoria_tekst = "";
            
            bilet = 3; Rodzaj_ulgi = 3; Typ_biletu = 3; Waznosc_biletu = 3; kategoria_biletu = 0; SposobPlatnosci = 0;
            cena = 0;
            Wpisywanie_Do_TB();
            
            pOkres_gb_RodzajBiletu.Visible = false;
            pOkres_gb_Waznosc.Visible = false;
            panelOkresowe_gb_RodzajeBiletow.Visible = false;
            pOkres_tb_TypBiletu.Visible = false;
        }
        public void ZmianaKoloruKontrolekOkresowe() //zmienia na biale
        {
            panelOkresowe_b_zwykleGdy.BackColor = Color.White;
            panelOkresowe_b_Nocny.BackColor = Color.White;
            panelOkresowe_b_NocnyGminy.BackColor = Color.White;
            panelOkresowe_b_NocnyRRW.BackColor = Color.White;
            panelOkresowe_b_NocnySieci.BackColor = Color.White;
            panelOkresowe_b_okaziciela.BackColor = Color.White;
            //panelOkresowe_tb_Podsumowanie.Text = "Nie wybrano żadnego biletu.";
        }

        public void PokazywanieKontrolekOkresowe()
        {
            if (bilet==0 || bilet ==1)
            {
                pOkres_tb_TypBiletu.Visible = true;
            }
            else pOkres_tb_TypBiletu.Visible = false;

            if (Typ_biletu==0)
            {
                panelOkresowe_b_ulgowy.Enabled = true;
                panelOkresowe_b_PonPia.Enabled = true;

                pOkres_gb_RodzajBiletu.Visible = true;
            }
            else if (Typ_biletu==1)
            {
                panelOkresowe_b_ulgowy.Enabled = false;
                panelOkresowe_b_PonPia.Enabled = false;

                pOkres_gb_RodzajBiletu.Visible = true;
            }
            else pOkres_gb_RodzajBiletu.Visible = false;

            if(Rodzaj_ulgi==0 || Rodzaj_ulgi==1)
            {
                pOkres_gb_Waznosc.Visible = true;
            }
            else pOkres_gb_Waznosc.Visible = false;

            if (Waznosc_biletu == 0 || Waznosc_biletu == 1)
            {
                panelOkresowe_gb_RodzajeBiletow.Visible = true;
            }
            else panelOkresowe_gb_RodzajeBiletow.Visible = false;
            
        }
        public void ObslugaKontrolek() //sluzy do pokazywania i ukrywania 
        {
            PokazywanieKontrolekOkresowe();
            //zmiana kolorow kontrolek
            switch (bilet)
            {
                case 0:
                    {
                        panelOkresowe_b_30dni.BackColor = Color.Green;
                        panelOkresowe_b_mies.BackColor = Color.White;                        
                        break;
                    }
                case 1:
                    {
                        panelOkresowe_b_30dni.BackColor = Color.White;
                        panelOkresowe_b_mies.BackColor = Color.Green;
                        break;
                    }
                default:
                    {
                        panelOkresowe_b_30dni.BackColor = Color.White;
                        panelOkresowe_b_mies.BackColor = Color.White;
                        break;
                    }
            }

            switch (Typ_biletu)
            {
                case 0:
                    {
                        panelOkresowe_b_imienny.BackColor = Color.Green;
                        panelOkresowe_b_okaziciela.BackColor = Color.White;
                        break;
                    }
                case 1:
                    {
                        panelOkresowe_b_imienny.BackColor = Color.White;
                        panelOkresowe_b_okaziciela.BackColor = Color.Green;
                    }
                default:
                    {
                        panelOkresowe_b_imienny.BackColor = Color.White;
                        panelOkresowe_b_okaziciela.BackColor = Color.White;
                    }
            }

            switch(Rodzaj_ulgi)
            {
                case 0: //zwykly
                    {

                        panelOkresowe_b_zwykly.BackColor = Color.Green;
                        panelOkresowe_b_ulgowy.BackColor = Color.White;
                        break;
                    }
                case 1: //ulgowy
                    {
                        panelOkresowe_b_zwykly.BackColor = Color.White;
                        panelOkresowe_b_ulgowy.BackColor = Color.Green;
                        break;
                    }
                default:
                    {
                        panelOkresowe_b_zwykly.BackColor = Color.White;
                        panelOkresowe_b_ulgowy.BackColor = Color.White;
                        break;
                    }
            }

            switch (Waznosc_biletu)
            {
                case 0: //pon-pia
                    {

                        panelOkresowe_b_PonPia.BackColor = Color.Green;
                        panelOkresowe_b_WszDni.BackColor = Color.White;
                        break;
                    }
                case 1: //wszy dni
                    {

                        panelOkresowe_b_PonPia.BackColor = Color.White;
                        panelOkresowe_b_WszDni.BackColor = Color.Green;
                        break;
                    }
                default:
                    {

                        panelOkresowe_b_PonPia.BackColor = Color.White;
                        panelOkresowe_b_WszDni.BackColor = Color.White;
                        break;
                    }
            }
            
            kategoria_tekst = "";
            switch (kategoria_biletu)
            {
                case 1:
                    {
                        ZmianaKoloruKontrolekOkresowe();
                        panelOkresowe_b_zwykleGdy.BackColor = Color.Green;
                        break;
                    }
                case 2:
                    {
                        ZmianaKoloruKontrolekOkresowe();
                        panelOkresowe_b_Nocny.BackColor = Color.Green;
                        break;
                    }
                case 3:
                    {
                        if (sprawdzenie == true)
                        {
                            OkresoweGminy okresoweGminy = new OkresoweGminy();
                            okresoweGminy.ShowDialog();
                            kategoria_tekst = okresoweGminy.Teksty();
                        }
                        ZmianaKoloruKontrolekOkresowe();
                        panelOkresowe_b_NocnyGminy.BackColor = Color.Green;
                    }
                case 4:
                    {
                        if (sprawdzenie == true)
                        {
                            OkresowyRRW okresowyRRW = new OkresowyRRW();
                            okresowyRRW.ShowDialog();
                            kategoria_tekst = okresowyRRW.Teksty();
                            Wpisywanie_Do_TB();
                        }
                        ZmianaKoloruKontrolekOkresowe();
                        panelOkresowe_b_NocnyRRW.BackColor = Color.Green;
                        break;
                    }
                case 5:
                    {
                        Spr_wszystkich_opcji(bilet, Rodzaj_ulgi, Typ_biletu, Waznosc_biletu);

                        if (sprawdzenie == true)
                        {
                            Wpisywanie_Do_TB();
                        }
                        ZmianaKoloruKontrolekOkresowe();
                        panelOkresowe_b_NocnySieci.BackColor = Color.Green;
                        break;
                    }
            }


            Wpisywanie_Do_TB();
        }

        //przyciski
        private void panelOkresowe_b_30dni_Click(object sender, EventArgs e)
        {
            bilet = 0;
            KolorowanieKontrolekOkresowe();            
        }
        private void panelOkresowe_b_mies_Click(object sender, EventArgs e)
        {
            bilet = 1;
            KolorowanieKontrolekOkresowe();
        }
        private void panelOkresowe_b_imienny_Click(object sender, EventArgs e)
        {
            if (Typ_biletu != 0) ZmianaKoloruKontrolekOkresowe();
            if (Typ_biletu == 1) //jesli byl wybrany na okaziciela
            {                
                //resetowanie wartosci
                Rodzaj_ulgi = 3;
                Waznosc_biletu = 3;
                kategoria_biletu = 0;      
            }

            Typ_biletu = 0;
        }
        private void panelOkresowe_b_okaziciela_Click(object sender, EventArgs e)
        {                       
            Typ_biletu = 1;
            Rodzaj_ulgi = 0;
            Waznosc_biletu = 1;
        }
        private void panelOkresowe_b_zwykly_Click(object sender, EventArgs e)
        {
            Rodzaj_ulgi = 0;
        }
        private void panelOkresowe_b_ulgowy_Click(object sender, EventArgs e)
        {
            Rodzaj_ulgi = 1;
        }
        private void panelOkresowe_b_PonPia_Click(object sender, EventArgs e)
        {
            Waznosc_biletu = 0;
        }
        private void panelOkresowe_szDni_Click(object sender, EventArgs e)
        {
            Waznosc_biletu = 1;
        }

        //wybor kategorii biletu
        private void panelOkresowe_b_zwykleGdy_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 1;
            SprawdzenieWyboruBiletu = true;            
        }
        private void panelOkresowe_b_Nocny_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 2;            
        }
        private void panelOkresowe_b_NocnyGminy_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 3;     
        }
        private void panelOkresowe_b_NocnyRRW_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 4;
            
        }
        private void panelOkresowe_b_NocnySieci_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 5;
            
        }


        private void panelOkresowe_b_Platnosc_Click(object sender, EventArgs e)
        {
            if (cena > 0)
            {
                WyborKartaCzyGotowka wyborKartaCzyGotowka = new WyborKartaCzyGotowka(komunikat_suma);
                wyborKartaCzyGotowka.ShowDialog();
                SposobPlatnosci = wyborKartaCzyGotowka.SposobPlatnosci;
                wyborKartaCzyGotowka.Close();
                

                Podsumowanie podsumowanie = new Podsumowanie(komunikat_info, komunikat_suma,SposobPlatnosci,pb_postep.Value);
                podsumowanie.ShowDialog();
                if (podsumowanie.Koniec==true)
                {
                    ResetValuesOkresowe();
                    panelMenu.BringToFront();
                }
                podsumowanie.Close();
                //podsumowanie.Visible = true;
            }
            else
            {
                //Komunikat komunikat = new Komunikat("Proszę wybrać bilet.");
                //komunikat.Visible = true;
            }            


        }
        #endregion

        private void panelOkresowe_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
