using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wizualizacja01;

namespace Projekt_Wizualizacja
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            GetCurrentTime();
            StepTimera = (double)timer1.Interval/1000.0;
                //Inicjalizacja dictionary
                ValueStorage = new Dictionary<TextBox, string>()
            {
                {tb_NMid, "0" },
                {tb_UMid, "0" },
                {tb_NLeft, "0" },
                {tb_ULeft, "0" },
                {tb_NRight, "0" },
                {tb_URight, "0" }
            };
            ValueStorage2 = new Dictionary<TextBox, string>()
            {
                {tb_NMid, "0" },
                {tb_UMid, "0" },
                {tb_NLeft, "0" },
                {tb_ULeft, "0" },
                //{tb_NRight, "0" },
                //{tb_URight, "0" }
            };
            
        }


        #region Zmienne
        bool CzyJestReklama = false;
        bool DoResetowaniareklam = false; //mowi czy ekran zostal juz zresetowany
        double StepTimera=1;
        public double TimeFromLastMove=0; 
        public int TimeOfTransaction=3000; //domyślny czas na kupienie biletu
        int AktualneOkno = 0;
        public double Suma;
        public int RodzajWybranegoBiletuOkresowego = 0;
        public int Flag;    //flaga do treści panelu, może być niepotrzebne (można to pewnie zastąpić AktualneOkno)
        public string[] pJedno_TekstDoTB = new string[4] {"","","",""}; //index 0 znaczy polaczone
        // \/ przechowywanie wartości textboxów
        public double price=0;
        #region kolekcje
        Dictionary<TextBox, string> ValueStorage;
        Dictionary<TextBox, string> ValueStorage2;
        List<double> KolKom24PricesNorm = new List<double>();
        List<double> KolKom24PricesUlg = new List<double>();
        List<string> KolKom24Storage = new List<string>();
        List<string> KolKom24StorageShort = new List<string>();
        #endregion

        //pola do szybszego pisania stringów do summary
        #region Stringi do summary
        static string Normalny = ">Normalny:\tilość - ";
        static string Ulgowy = ">Ulgowy:      \tilość - ";
        static string Cena = ",\tCena - ";
        static string BJP = "Bilet na jeden przejazd na linie zwykłe:";
        static string Godzinny = "Bilet godzinny na linie zwykłe:";
        static string H24 = "Bilet 24-godzinny:";
        static string NBJP = "Bilet nocny na jeden przejazd:";
        static string NGodzinny = "Bilet nocny godzinny:";
        static string KomBJP = "Bilet metropolitalny na jeden przejazd:";
        static string KomJPSpec = "Bilet metropolitalny na jeden przejazd na linie nocne, pospieszne, specjalne i zwykłe:";
        static string Kom24 = "Bilet metropolitalny 24-godzinny komunalny";
        static string Kom72 = "Bilet metropolitalny 72-godzinny komunalny";
        //static string KolKom24 = "\nBilet metropolitalny 24-godzinny kolejowo-komunalny dwóch organizatorów";
        static string KolKom24All = "Bilet metropolitalny 24-godzinny kolejowo-komunalny wszystkich organizatorów";
        static string KolKom72 = "Bilet metropolitalny 72-godzinny kolejowo-komunalny wszystkich organizatorów";
        static string KolKom24GDY = "Bilet metropolitalny 24-godzinny kolejowo-komunalny dwóch organizatorów: ZKM GDYNIA oraz pociągów SKM i PR";
        static string KolKom24GDA = "Bilet metropolitalny 24-godzinny kolejowo-komunalny dwóch organizatorów: ZTM GDAŃSK oraz pociągów SKM i PR";
        static string KolKom24WEJ = "Bilet metropolitalny 24-godzinny kolejowo-komunalny dwóch organizatorów: MZK WEJHEROWO oraz pociągów SKM i PR";
        #endregion
        #endregion

#region Metody
        double JednoCena(int ktoryTB) 
        {
            switch (Flag)
            {
                case 1:
                    {
                        if (ktoryTB == 0) //lewy normalny
                        {
                            return ceny1.JDzienJP;
                        }
                        else if (ktoryTB == 1) //mid norm
                        {
                            return ceny1.JDzienGodz;
                        }
                        else if (ktoryTB == 2) // /rightnorm
                        {
                            return ceny1.J24h;
                        }
                        break;
                    }
                case 2:
                    {
                        if (ktoryTB == 0) //lewy normalny
                        {
                            return ceny1.JNocJP;
                        }
                        else if (ktoryTB == 1) //mid norm
                        {
                            return ceny1.JNocGodz;
                        }
                        else if (ktoryTB == 2) //right norm
                        {
                            return ceny1.J24h;
                        }
                        break;
                    }
                case 3:
                    {
                        if (ktoryTB == 0) //lewy normalny
                        {
                            return ceny1.MetroKomDJP;
                        }
                        else if (ktoryTB == 1) //mid norm
                        {
                            return ceny1.MetroKom24;
                        }
                        else if (ktoryTB == 2) //right norm
                        {
                            return ceny1.MetroKom72;
                        }
                        break;
                    }
                case 4:
                    {
                        if (ktoryTB == 0) //lewy normalny
                        {
                            return ceny1.MetroKomNJP;
                        }
                        else if (ktoryTB == 1) //mid norm
                        {
                            return ceny1.MetroKom24;
                        }
                        else if (ktoryTB == 2) //right norm
                        {
                            return ceny1.MetroKom72;
                        }
                        break;
                    }
                case 5:
                    {
                        if (ktoryTB == 0) //lewy normalny
                        {
                            return ceny1.MetroKolKom24_All;
                        }
                        else if (ktoryTB == 1) //mid norm
                        {
                            return ceny1.MetroKolKom72;
                        }
                        else if (ktoryTB == 2) //right norm
                        {
                            return ceny1.MetroKolKom24_2;
                        }
                        break;
                    }
                case 6:
                    {
                        if (ktoryTB == 0) //lewy normalny
                        {
                            return ceny1.MetroKolKom24_2;
                        }
                        else if (ktoryTB == 1) //mid norm
                        {
                            return ceny1.MetroKolKom24_2;
                        }
                        else if (ktoryTB == 2) //right norm
                        {
                            return ceny1.MetroKolKom24_2;
                        }
                        break;
                    }
                default:
                    break;
            }


            return 0;
        } //zwraca cene biletow w zaleznosci od pozycji i flagi; 0 lewo, 1 srodek, 2 prawo
        private void UsuwanieWartosci()
        {
            pJedno_TekstDoTB = new string[4] { "", "", "", "" };
            Suma = 0;
            Flag = 0;
            price = 0;
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
            if (pb_postep.Value < TimeOfTransaction)
                pb_postep.Value++;
            //else pb_postep.Value = 0;


        }//metoda obslugujaca progressbar
        private void TimeToLeft() // metoda pokazująca ile czasu zostało
        {
            int RemainingTime, min, sec;
            RemainingTime = pb_postep.Maximum/10 - pb_postep.Value/10;
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

            l_postep.Text = "Pozostały czas transakcji: " + Convert.ToString(min) +":"+ sec2;
            //l_postep.Visible = false;
        }
        void Plus(TextBox tb)   //dodawanie 1 do wartości w tb
        {
            ResetujCzasReakcji();
            if (Convert.ToInt32(tb.Text) + 1 < 100) tb.Text = (Convert.ToInt32(tb.Text) + 1).ToString();
            else tb.Text = "99";
            //tb.Text = (Convert.ToInt32(tb.Text)+1).ToString();
            RefreshSummaryRTB();
        }
        void Minus(TextBox tb)  //odejmowanie 1 od wartości w tb
        {
            ResetujCzasReakcji();
            if (Convert.ToInt32(tb.Text) - 1 >= 0) tb.Text = (Convert.ToInt32(tb.Text) - 1).ToString();
            else tb.Text = "0";
            RefreshSummaryRTB();
        }

        void EreaseStorages()
        {
            ValueStorage[tb_NLeft] = "0";
            ValueStorage[tb_ULeft] = "0";
            ValueStorage[tb_NLeft] = "0";
            ValueStorage[tb_ULeft] = "0";

            ValueStorage2[tb_NLeft] = "0";
            ValueStorage2[tb_ULeft] = "0";
            ValueStorage2[tb_NLeft] = "0";
            ValueStorage2[tb_ULeft] = "0";

            tb_NLeft.Text = "0";
            tb_ULeft.Text = "0";
            tb_NMid.Text = "0";
            tb_UMid.Text = "0";
            tb_NRight.Text = "0";
            tb_URight.Text = "0";

            tb_Price.Text = "0,00 zł";
            pJedno_tb_Podsumowanie.Text = null;
            try
            {
                if (Flag == 5)
                {
                    KolKom24PricesNorm.RemoveAll(x => x > 0);
                    KolKom24PricesUlg.RemoveAll(x => x > 0);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        void CheckRemoveButton()
        {
            if (KolKom24Storage.Count > 0) btn_RemoveKolKom24.Enabled = true;
            else btn_RemoveKolKom24.Enabled = false;
        }//To musiałem wrzucić do RefreshSummaryRTB niestety

        //zabwa z pictureboxami i przesuwaniem paneli //to narazie nie działa
        private void ZmianaPictureBoxMetodaRysunki(Image imageL, Image imageM, Image imageR)
        {
            //picb_L.BackgroundImage = imageL;
            //picb_M.BackgroundImage = imageM;
            //picb_R.BackgroundImage = imageR;
        }
        private void ZmianaPictureBox() //trzeba do wrzucić do przycisku jednorazowe i do pozostale bilety
        {
            if (Flag == 1) //bilety jednorazowe
            {
                //Image imageL = new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.logo);
                //Image imageM = new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.logo);
                //Image imageR = new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.logo);
                //ZmianaPictureBoxMetodaRysunki(imageL, imageM, imageR); //metoda do zmiany obrazkow
            }
        }

        //zmienie ceny biletow w labelach pod opisem
        private void JednoLabelZmianaCenBiletow()
        {
            string Zwykly = "Bilet NORMALNY, cena: ";
            string Ulgowy = "Bilet ULGOWY, cena: ";

            pJedno_l_LN.Text = Zwykly + String.Format("{0:0.00} zł", JednoCena(0));
            pJedno_l_LU.Text = Ulgowy + String.Format("{0:0.00} zł", JednoCena(0)/2);

            pJedno_l_MN.Text = Zwykly + String.Format("{0:0.00} zł", JednoCena(1));
            pJedno_l_MU.Text = Ulgowy + String.Format("{0:0.00} zł", JednoCena(1) / 2);

            pJedno_l_RN.Text = Zwykly + String.Format("{0:0.00} zł", JednoCena(2));
            pJedno_l_RU.Text = Ulgowy + String.Format("{0:0.00} zł", JednoCena(2) / 2);
        }
        private void ZmianaTextuBilety()
        {

            if (Flag == 1)
            {
                pJedno_L_T.Text = "Bilet na jeden przejazd na linie zwykłe.";
                pJedno_M_T.Text = "Bilet godzinny na linie zwykłe.";
                pJedno_R_T.Text = "Bilet 24-godzinny.";
                //return;
            }
            else if (Flag == 2)
            {
                pJedno_L_T.Text = "Bilet na jeden przejazd na linie nocne, pośpieczne, specjalne lub zwykłe.";
                pJedno_M_T.Text = "Bilet godzinny na linie nocne, pośpieczne, specjalne lub zwykłe.";
                pJedno_R_T.Text = "Bilet 24-godzinny.";
                //return;
            }
            else if (Flag == 3)
            {
                pJedno_L_T.Text = "Bilet metropolitarny komunalny na jeden przejazd na linie ZWYKŁE.";
                pJedno_M_T.Text = "Bilet metropolitarny komunalny 24-godzinny metropolitarny na wszystkie linie.";
                pJedno_R_T.Text = "Bilet metropolitarny komunalny 72-godzinny metropolitarny na wszystkie linie.";
                //return;
            }
            else if (Flag == 4)
            {
                pJedno_L_T.Text = "Bilet metropolitarny komunalny na jeden przejazd na linie NOCNE.";
                pJedno_M_T.Text = "Bilet metropolitarny komunalny 24-godzinny metropolitarny na wszystkie linie.";
                pJedno_R_T.Text = "Bilet metropolitarny komunalny 72-godzinny metropolitarny na wszystkie linie.";
                //return;
            }
            else if (Flag == 5)
            {
                pJedno_L_T.Text = "Bilet metropolitarny kolejowo-komunalny 24-godzinny na wszystkich organizatorów.";
                pJedno_M_T.Text = "Bilet metropolitarny kolejowo-komunalny 72-godzinny na wszystkich organizatorów.";
                pJedno_R_T.Text = "Bilet metropolitarny kolejowo-komunalny 24-godzinny na dwóch organizatorów: ZKM GDYNIA oraz w pociągach SKM i PR.";
                //return;
            }
            else if (Flag == 6)
            {
                pJedno_L_T.Text = "Bilet metropolitarny kolejowo-komunalny 24-godzinny na dwóch organizatorów: ZTM GDAŃSK oraz w pociągach SKM i PR.";
                pJedno_M_T.Text = "Bilet metropolitarny kolejowo-komunalny 24-godzinny na dwóch organizatorów: MZK WEJHEROWO oraz w pociągach SKM i PR.";
                pJedno_R_T.Text = "Bilet metropolitarny kolejowo-komunalny 24-godzinny na dwóch organizatorów: ZKM GDYNIA oraz w pociągach SKM i PR.";
                //return;
            }
            pJedno_l_Left.Text = pJedno_L_T.Text;
            pJedno_l_Mid.Text = pJedno_M_T.Text;
            pJedno_l_Right.Text = pJedno_R_T.Text;
        } //zmienia tekst w kontrolkach
        private void PrzesuwaniePaneli()
        {
            ZmianaTextuBilety();
            if (AktualneOkno == 0) //okno głowne
            {
                ChowajAllPanele();
                ResetValuesOkresowe();
                EreaseStorages();
                panelMenu.Visible = true;
            }
            else if (AktualneOkno == 1) //bielty jednorazowe, komunalne itd
            {
                //ChowajAllPanele();
                panelJednorazowe.Visible = true;
                panelKoniecWstecz.Visible = true;
            }
            else if (AktualneOkno == 6) //bilety miesieczne
            {
                ChowajAllPanele();
                panelOkresowe.Visible = true;
                panelKoniecWstecz.Visible = true;
            }
            else if (AktualneOkno == 7) //bilety semetsralne
            {
                ChowajAllPanele();
                pSemes.Visible = true;
                panelKoniecWstecz.Visible = true;

            }
        }
        private void ChowajAllPanele() //chowa wszystkie panele
        {
            panelJednorazowe.Visible = false;
            panelKoniecWstecz.Visible = false;
            pSemes.Visible = false;
            panelOkresowe.Visible = false;
            panelMenu.Visible = false;
        }



        #region Do Update summary

        //metoda do aktualizacji tb w jednorazowych
        private string pJedno_OpisBiletuDoTB(string rodzajBiletu, string iloscNorm, string iloscUlga, double cena)
        {
            string tekst = "     ";
            if (iloscNorm != "0" || iloscUlga != "0") //to oznacza ze wybrano jakiś bilet
            {
                tekst += rodzajBiletu + Environment.NewLine;
            }
            if (iloscNorm != "0")
            {
                tekst += Normalny + iloscNorm + Cena + String.Format("{0:0.00} zł", (Convert.ToInt32(iloscNorm) * cena)) + Environment.NewLine;
            }
            if (iloscUlga != "0")
            {
                tekst += Ulgowy + iloscUlga + Cena + String.Format("{0:0.00} zł", (Convert.ToInt32(iloscUlga) * cena / 2)) + Environment.NewLine;
            }
            if (iloscNorm != "0" || iloscUlga != "0") //to oznacza ze wybrano jakiś bilet
            {
                tekst += "-------------------------------------------------------------------"+Environment.NewLine;
            }
            return tekst;
        }
        
        private void JednorazoweObslugaTB() //wpisuje dane do texboxa
        {
            pJedno_TekstDoTB[0] = pJedno_TekstDoTB[1] + pJedno_TekstDoTB[2] + pJedno_TekstDoTB[3];
            //if (pJedno_TekstDoTB[0].Length<20) //20 bo tyle spacji
            //{
            //    pJedno_TekstDoTB[0] = "Nie wybrano jeszcze żadnego biletu";
            //}
            pJedno_tb_Podsumowanie.Text = pJedno_TekstDoTB[0];            
        }

        #region Metody główne
        //jednorazowe
        void Jednorazowe1()
        {
            string teksty = "";
            //Dzienne na jeden przejazd
            teksty+=pJedno_OpisBiletuDoTB(BJP, tb_NLeft.Text, tb_ULeft.Text, ceny1.JDzienJP);
            //Dzienne godzinne
            teksty+=pJedno_OpisBiletuDoTB(Godzinny, tb_NMid.Text, tb_UMid.Text, ceny1.JDzienGodz);
            pJedno_TekstDoTB[1] = teksty; //zapisuje do pierwszego członu
        }
        void Jednorazowe24h()
        {
            //24 godzinne
            pJedno_TekstDoTB[2]=pJedno_OpisBiletuDoTB(H24, tb_NRight.Text, tb_URight.Text, ceny1.J24h);            
        }
        void Jednorazowe2()
        {//Nocne na jeden przejazd
            pJedno_TekstDoTB[3]=pJedno_OpisBiletuDoTB(NBJP, tb_NLeft.Text, tb_ULeft.Text, ceny1.JNocJP)+ pJedno_OpisBiletuDoTB(NGodzinny, tb_NMid.Text, tb_UMid.Text, ceny1.JNocGodz);
        }

        //komunalne
        void Komunalne1()
        {
            pJedno_TekstDoTB[1] = pJedno_OpisBiletuDoTB(KomBJP, tb_NLeft.Text, tb_ULeft.Text, ceny1.MetroKomDJP);
        }
        void Komunalne2()
        {
            pJedno_TekstDoTB[2] = pJedno_OpisBiletuDoTB(KomJPSpec, tb_NLeft.Text, tb_ULeft.Text, ceny1.MetroKomNJP);
        }
        void Komunalne2472()
        {
            pJedno_TekstDoTB[3] = pJedno_OpisBiletuDoTB(Kom24, tb_NMid.Text, tb_UMid.Text, ceny1.MetroKom24)+ pJedno_OpisBiletuDoTB(Kom72, tb_NRight.Text, tb_URight.Text, ceny1.MetroKom72);
        }

        //kolejowo komunalne
        void KolejowoKomunalne()
        {       
            //24h dla wszystkich przewoźników
            pJedno_TekstDoTB[2] = pJedno_OpisBiletuDoTB(KolKom24All, tb_NLeft.Text, tb_ULeft.Text, ceny1.MetroKolKom24_All);
            
            //72h all przewoźnicy
            pJedno_TekstDoTB[2] += pJedno_OpisBiletuDoTB(KolKom72, tb_NMid.Text, tb_UMid.Text, ceny1.MetroKolKom72);            
        }
        void KolejowoKomunalneGdynia()
        {           
            //24h dla 2 przewoznikow: Gdynia
            pJedno_TekstDoTB[1] = pJedno_OpisBiletuDoTB(KolKom24GDY, tb_NRight.Text, tb_URight.Text, ceny1.MetroKolKom24_2);            
        }
        void KolejowoKomunalne2()
        {
            //24h dla 2 przewoznikow: Gdańsk
            pJedno_TekstDoTB[3] = pJedno_OpisBiletuDoTB(KolKom24GDA, tb_NLeft.Text, tb_ULeft.Text, ceny1.MetroKolKom24_2);

            //24h dla 2 przewoznikow: Wejeherowo
            pJedno_TekstDoTB[3] += pJedno_OpisBiletuDoTB(KolKom24WEJ, tb_NMid.Text, tb_UMid.Text, ceny1.MetroKolKom24_2);
        }
        #endregion
        
        #endregion

        /* Odświeżanie Summary w zależności od aktywnego okna na podstawie flagi*/
        void RefreshSummaryRTB()
        {
            pJedno_tb_Podsumowanie.Text = null;
            switch (Flag)
            {
                case 1:
                    {
                        Jednorazowe1();
                        Jednorazowe24h();
                        //Jednorazowe2FromStorage();
                        GetPrice();
                        break;
                    }
                case 2:
                    {
                        // Jednorazowe1FromStorage();
                        Jednorazowe24h();
                        Jednorazowe2();
                        GetPrice();
                        break;
                    }
                case 3:
                    {
                        Komunalne1();
                        Komunalne2472();
                        //Komunalne2FromStorage();
                        GetPrice();
                        break;
                    }
                case 4:
                    {
                        //Komunalne1FromStorage();
                        Komunalne2472();
                        Komunalne2();
                        GetPrice();
                        break;
                    }
                case 5:
                    {
                        KolejowoKomunalne();
                        KolejowoKomunalneGdynia();

                        GetPrice();
                        break;
                    }
                case 6:
                    {
                        KolejowoKomunalne2();
                        KolejowoKomunalneGdynia();

                        GetPrice();
                        break;
                    }
                default:
                    break;
            }
            JednorazoweObslugaTB();
            

        }
        void GetKeyboard(TextBox tb, double price)  //Klawiatura
        {
            ResetujCzasReakcji();
            TimeFromLastMove = -10;
            string input = tb.Text;
            Klawiatura kl = new Klawiatura(tb.Text, price);
            kl.ShowDialog();
            if(kl.take)tb.Text = kl.TBil_bil.Text;
            RefreshSummaryRTB();
        }
        void GetPrice()
        {
             price = 0;
            switch (Flag)
            {
                case 1:
                    {
                        price += Convert.ToInt32(tb_NLeft.Text)* ceny1.JDzienJP;
                        price += Convert.ToInt32(tb_ULeft.Text)* ceny1.JDzienJP/2;
                        price += Convert.ToInt32(tb_NMid.Text)*ceny1.JDzienGodz;
                        price += Convert.ToInt32(tb_UMid.Text)*ceny1.JDzienGodz/2;
                        price += Convert.ToInt32(tb_NRight.Text)*ceny1.J24h;
                        price += Convert.ToInt32(tb_URight.Text)*ceny1.J24h/2;
                        price += Convert.ToInt32(ValueStorage2[tb_NLeft])*ceny1.JNocJP;
                        price += Convert.ToInt32(ValueStorage2[tb_ULeft]) * ceny1.JNocJP/2;
                        price += Convert.ToInt32(ValueStorage2[tb_NMid])*ceny1.JNocGodz;
                        price += Convert.ToInt32(ValueStorage2[tb_UMid]) * ceny1.JNocGodz/2;
                        tb_Price.Text = String.Format("{0:0.00} zł", price);
                        break;

                    }
                case 2:
                    {
                        price += Convert.ToInt32(tb_NLeft.Text) * ceny1.JNocJP;
                        price += Convert.ToInt32(tb_ULeft.Text) * ceny1.JNocJP/2;
                        price += Convert.ToInt32(tb_NMid.Text) * ceny1.JNocGodz;
                        price += Convert.ToInt32(tb_UMid.Text) * ceny1.JNocGodz/2;
                        price += Convert.ToInt32(tb_NRight.Text) * ceny1.J24h;
                        price += Convert.ToInt32(tb_URight.Text) * ceny1.J24h/2;
                        price += Convert.ToInt32(ValueStorage[tb_NLeft]) * ceny1.JDzienJP;
                        price += Convert.ToInt32(ValueStorage[tb_ULeft]) * ceny1.JDzienJP/2;
                        price += Convert.ToInt32(ValueStorage[tb_NMid])* ceny1.JDzienGodz;
                        price += Convert.ToInt32(ValueStorage[tb_UMid])*ceny1.JDzienGodz/2;
                        tb_Price.Text = String.Format("{0:0.00} zł", price);
                        break;

                    }
                case 3:
                    {
                        price += Convert.ToInt32(tb_NLeft.Text) * ceny1.MetroKomDJP;
                        price += Convert.ToInt32(tb_ULeft.Text) * ceny1.MetroKomDJP / 2;
                        price += Convert.ToInt32(tb_NMid.Text) * ceny1.MetroKom24;
                        price += Convert.ToInt32(tb_UMid.Text) * ceny1.MetroKom24 / 2;
                        price += Convert.ToInt32(tb_NRight.Text) * ceny1.MetroKom72;
                        price += Convert.ToInt32(tb_URight.Text) * ceny1.MetroKom72 / 2;
                        price += Convert.ToInt32(ValueStorage2[tb_NLeft]) * ceny1.MetroKomNJP;
                        price += Convert.ToInt32(ValueStorage2[tb_ULeft]) * ceny1.MetroKomNJP / 2;
                        tb_Price.Text = String.Format("{0:0.00} zł", price);
                        break;

                    }
                case 4:
                    {
                        price += Convert.ToInt32(tb_NLeft.Text) * ceny1.MetroKomNJP;
                        price += Convert.ToInt32(tb_ULeft.Text) * ceny1.MetroKomNJP / 2;
                        price += Convert.ToInt32(tb_NMid.Text) * ceny1.MetroKom24;
                        price += Convert.ToInt32(tb_UMid.Text) * ceny1.MetroKom24 / 2;
                        price += Convert.ToInt32(tb_NRight.Text) * ceny1.MetroKom72;
                        price += Convert.ToInt32(tb_URight.Text) * ceny1.MetroKom72 / 2;
                        price += Convert.ToInt32(ValueStorage[tb_NLeft]) * ceny1.MetroKomDJP;
                        price += Convert.ToInt32(ValueStorage[tb_ULeft]) * ceny1.MetroKomDJP / 2;
                        tb_Price.Text = String.Format("{0:0.00} zł", price);
                        break;

                    }
                case 5:
                    {

                        //2 strona
                        price += Convert.ToInt32(ValueStorage2[tb_NLeft]) * ceny1.MetroKolKom24_2;
                        price += Convert.ToInt32(ValueStorage2[tb_ULeft]) * ceny1.MetroKolKom24_2 / 2;

                        price += Convert.ToInt32(ValueStorage2[tb_NMid]) * ceny1.MetroKolKom24_2;
                        price += Convert.ToInt32(ValueStorage2[tb_UMid]) * ceny1.MetroKolKom24_2 / 2;

                        //1 strona

                        price += Convert.ToInt32(tb_NLeft.Text) * ceny1.MetroKolKom24_All;
                        price += Convert.ToInt32(tb_ULeft.Text) * ceny1.MetroKolKom24_All / 2;
                        price += Convert.ToInt32(tb_NMid.Text) * ceny1.MetroKolKom72;
                        price += Convert.ToInt32(tb_UMid.Text) * ceny1.MetroKolKom72 / 2;

                        price += Convert.ToInt32(tb_NRight.Text) * ceny1.MetroKolKom24_2;
                        price += Convert.ToInt32(tb_URight.Text) * ceny1.MetroKolKom24_2 / 2;

                        tb_Price.Text = String.Format("{0:0.00} zł", price);
                        break;

                    }
                case 6:
                    {
                        //z pierwszej strony
                        price += Convert.ToInt32(ValueStorage[tb_NLeft]) * ceny1.MetroKolKom24_All;
                        price += Convert.ToInt32(ValueStorage[tb_ULeft]) * ceny1.MetroKolKom24_All / 2;

                        price += Convert.ToInt32(ValueStorage[tb_NMid]) * ceny1.MetroKolKom72;
                        price += Convert.ToInt32(ValueStorage[tb_UMid]) * ceny1.MetroKolKom72 / 2;

                        //z drugiej strony
                        price += Convert.ToInt32(tb_NLeft.Text) * ceny1.MetroKolKom24_2;
                        price += Convert.ToInt32(tb_ULeft.Text) * ceny1.MetroKolKom24_2 / 2;
                        price += Convert.ToInt32(tb_NMid.Text) * ceny1.MetroKolKom24_2;
                        price += Convert.ToInt32(tb_UMid.Text) * ceny1.MetroKolKom24_2 / 2;
                        price += Convert.ToInt32(tb_NRight.Text) * ceny1.MetroKolKom24_2;
                        price += Convert.ToInt32(tb_URight.Text) * ceny1.MetroKolKom24_2 / 2;
                        tb_Price.Text = String.Format("{0:0.00} zł", price);
                        break;

                    }
                default:
                    break;
            }
        }

        #endregion

        #region Programowanie kontrolek



        private void Main_Load(object sender, EventArgs e)
        {
            ChowajAllPanele();
            PrzesuwaniePaneli();
            WyswietlReklamy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Image imageTlo = new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.niebieskietlo);
            //this.BackgroundImage = imageTlo;
            //pb_postep.Maximum = 1200;
            this.Size=new Size(1328,768); //bazowa wielkość okna
            MoveToTheCenter();
            GetCurrentTime();
            panelKoniecWstecz.Visible = false;
            panelMenu.BringToFront();
            Reklamy reklama = new Reklamy();
            //reklama.ShowDialog();
            //TimeOfTransaction = 64;

        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            //tb_godzina.Text = GetCurrentTime();
            ObslugaReklam(); //oblsuguje reklamy
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
        //private bool CzyWybraneBiletyBylyOkresowe; //potrzebne do komunikatu wyjecia biletu
        void OknoKomunikatKartaMiejska()
        {
            OknoKartyMiejskiej oknoKartyMiejskiej = new OknoKartyMiejskiej();
            oknoKartyMiejskiej.b_Koniec.Visible = false;
            oknoKartyMiejskiej.b_Ok.Text = "(Wyjmuję kartę miejską)";
            oknoKartyMiejskiej.l_Komunikat.Text = "Proszę wyjąć kartę miejską z biletomatu.";
            oknoKartyMiejskiej.ShowDialog();
        }
        private void KoniecButton()
        {
            if (SprawdzyCzyWYbranoJakisBilet() == true)
            {
                AktualneOkno = 0;
                UsuwanieWartosci();
                ResetValuesOkresowe();
                PrzesuwaniePaneli();
            }
        }
        bool SprawdzyCzyWYbranoJakisBilet()
        {
            if (price > 0 || Suma!=0)
            {
                OknoPotwierdzeniaWyjscia ostrzezenieJednorazowe = new OknoPotwierdzeniaWyjscia("Jesteś pewny że chcesz wyjść z tej kategorii biletów? Wciśniecie przycisku TAK spowoduje utracenie dotychczas wybranych biletów.");
                ostrzezenieJednorazowe.ShowDialog();
                return ostrzezenieJednorazowe.Koniec;
            }
            else if (AktualneOkno==6 || AktualneOkno==7) //to znaczy ze sa to okresowe
            {
                OknoPotwierdzeniaWyjscia ostrzezenieOkresowe= new OknoPotwierdzeniaWyjscia("Jesteś pewny że chcesz wyjść z tej kategorii biletów?");
                ostrzezenieOkresowe.ShowDialog();
                if (ostrzezenieOkresowe.Koniec==true)
                {
                    AktualneOkno = 0;
                    UsuwanieWartosci();
                    ResetValuesOkresowe();
                    PrzesuwaniePaneli();
                    OknoKomunikatKartaMiejska();
                    return false;
                }
                return false;
                
            }
            return true;
        }
        private void pKoniecWstecz_b_Wstecz_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            TimeFromLastMove = -5;
            if (Flag == 2 || Flag == 4 || Flag==6) //to znaczy ze przeskoczylismy do drugiej zakladki
            {
                btn_Other_Click(sender, e);
                PrzesuwaniePaneli();
            }
            else
            {
                KoniecButton();
            }
        }

        private void pKoniecWstecz_b_Koniec_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            TimeFromLastMove = -5;
            KoniecButton();
            //AktualneOkno = 0;
        }
        #endregion

#region Menu główne
        //metoda oblsugujaca tekst tutylu strony i buttona other
        void MenuGlowneZmianaTextuButtonow()
        {
            string tekstLabel = "Bilety ";
            string tekstNumerStrony = "";
            string tekstLabel1 = "(Strona 1 z 2)";
            string tekstLabel2 = "(Strona 2 z 2)";
            string tekstButton = "Inne bilety ";
            //jednorazowe
            if (Flag==1 || Flag==2)
            {
                tekstLabel += "jednorazowe ";
                if (Flag==1) //czyli pierwsza zakladka
                {
                    tekstNumerStrony = tekstLabel1;
                    //tekstLabel += "dzienne";
                    tekstButton += "(NOCNE I SPECJALNE)";
                }
                if (Flag == 2) //czyli druga zakladka
                {
                    tekstNumerStrony = tekstLabel2;
                    //tekstLabel2 += " (2 z 2)";

                    //tekstLabel += "nocne";
                    tekstButton += "(DZIENNE)";
                }
            }
            else if (Flag == 3 || Flag == 4)
            {
                tekstLabel += "metropolitarne komunalne ";
                if (Flag == 3) //czyli pierwsza zakladka
                {
                    tekstNumerStrony = tekstLabel1;
                    //tekstLabel += "dzienne";
                    tekstButton += "(NOCNE)";
                }
                if (Flag == 4) //czyli druga zakladka
                {
                    tekstNumerStrony = tekstLabel2;
                    //tekstLabel += "nocne";
                    tekstButton += "(DZIENNE)";
                }
            }
            else if (Flag == 5 || Flag == 6)
            {
                tekstLabel += "metropolitarne komunalno-kolejowe ";
                if (Flag == 5) //czyli pierwsza zakladka
                {
                    tekstNumerStrony = tekstLabel1;
                    //tekstLabel += "czasowe na wszytkie linie oraz na linię Gdynia + SKM i PR";
                    tekstButton += "(NA DWÓCH PRZEWOŹNIKÓW)";
                }
                if (Flag == 6) //czyli druga zakladka
                {
                    tekstNumerStrony = tekstLabel2;
                    //tekstLabel += "na dwóch przewoźników";
                    tekstButton += "(NA WSZYSTKIE LINIE ORAZ NA LINIĘ GDYNIA + SKM i PR)";
                }
            }
            tekstLabel = tekstLabel.ToUpper();
            tekstButton = "INNE BILETY";
            btn_Other.Text = tekstButton.ToUpper();
            pJedno_l_NazwaZakladki.Text = tekstLabel + tekstNumerStrony;
            JednoLabelZmianaCenBiletow();
        }


        private void panelMenu_b_BiletyJednorazowe_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            Flag = 1;
            MenuGlowneZmianaTextuButtonow();
            pJedno_gb_Right.Visible = true;
            panelJednorazowe.BringToFront();
            AktualneOkno = 1;
            
            PrzesuwaniePaneli();
        }

        private void panel1_b_BiletyMiesieczne_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            TimeFromLastMove = -10;
            ResetValuesOkresowe();
            Rodzaj_ulgi = 3;
            OknoKartyMiejskiej oknoKartyMiejskiej = new OknoKartyMiejskiej();
                oknoKartyMiejskiej.ShowDialog();
            if (oknoKartyMiejskiej.CzyPrzylozonoKarte == true)
            {
                WyborMiesieczneSemestralne wyborMiesieczneSemestralne = new WyborMiesieczneSemestralne();
                wyborMiesieczneSemestralne.ShowDialog();
                RodzajWybranegoBiletuOkresowego = wyborMiesieczneSemestralne.RodzajWybranegobiletu;
                if (wyborMiesieczneSemestralne.RodzajWybranegobiletu == 1)
                {
                    //panelOkresowe.BringToFront();
                    AktualneOkno = 6;
                    MiesieczneObslugaKontrolek();
                    PrzesuwaniePaneli();

                }
                else if (wyborMiesieczneSemestralne.RodzajWybranegobiletu == 2)
                {
                    //pSemes.BringToFront();
                    Waznosc_biletu = 1;
                    AktualneOkno = 7;
                    SemestralneObslugaKontrolek();
                    PrzesuwaniePaneli();
                }
            }
            
            
           
        }

        private void panelMenu_b_BiletyMetroKomun_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            Flag = 3;
            MenuGlowneZmianaTextuButtonow();
            pJedno_gb_Right.Visible = true;
            panelJednorazowe.BringToFront();            
            AktualneOkno = 1;
            PrzesuwaniePaneli();

            /*Tutaj wrzucenie obrazków*/

            //panelJednorazowe.BringToFront();

        }

        private void panelMenu_b_BiletyMetroKolKom_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            Flag = 5;
            MenuGlowneZmianaTextuButtonow();
            pJedno_gb_Right.Visible = true;
            panelJednorazowe.BringToFront();
            
            AktualneOkno = 1;
            PrzesuwaniePaneli();
        }

        #region Boczne
        private void panelMenu_b_RozkladJazdy_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            Kalendarz kalendarz = new Kalendarz();
            kalendarz.ShowDialog();
        }

        private void panelMenu_b_JakDojade_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            ZAtrzymanieCzasu = true;
            JakDojade A = new JakDojade();
            A.ShowDialog();
            if (A.Koniec==true)
            {
                ZAtrzymanieCzasu = false;
            }
        }

        private void panelMenu_b_DoladowanieTelefonu_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }
#endregion
        #endregion

#region Bilety okresowe 30 dniowe i miesieczne

        Ceny_biletow ceny1 = new Ceny_biletow();
        //zmienne
        
        public string komunikat_info, komunikat_suma, pocz, kategoria_tekst = "";// kom1, kom2, kom3, kom4, kom5, pocz;
        public int bilet = 3, Rodzaj_ulgi = 3, Typ_biletu = 3, Waznosc_biletu = 3, kategoria_biletu = 0, SposobPlatnosci = 0; //0-pierwszy po lewej, 1 pierwszy po prawej
        public bool sprawdzenie = false, SprawdzenieWyboruBiletu = false;
        public bool ClickKategori = false;
        public double CenaOkresowego;
        bool OkresoweCzyJestPrzed16;
        DateTime AktualnieWybranaData = new DateTime(2000,1,1);
        string Okresowy30dniTekst;

        //metody
        private bool PotwiedzenieZlegoBiltu() //jesli wybralismy bilet ziomowy i tracimy kilka miesiecy
        {
            OknoPotwierdzeniaWyjscia oknoPotwierdzenia = new OknoPotwierdzeniaWyjscia("Wybrany przez Ciebie bilet będzie obowiązywał w miesiącu " + OkresoweMiesiac().ToUpper() + ", który się już zaczął. Bilet miesięczny obowiązujący w kolejnym miesiącu możesz zakupić dopiero po 16-tym dniu poprzedzającego miesiąca."+Environment.NewLine+" Czy jesteś pewny że chcesz wybrać bilet na ten okres?");
            oknoPotwierdzenia.ShowDialog();
            if (oknoPotwierdzenia.Koniec == true)
            {
                return true;
            }
            return false;
        }
        string OkresoweMiesiac() //zwraca nazwe miesiaca do  biletu miesiecznego
        {
            DateTime thisDay = DateTime.Now; //pobiera aktualna date

            //potrzebne do utworzenia nowej daty z ewentualnie przesunietym miesiacem
            int Day = Convert.ToInt32(String.Format("{0:dd}", thisDay).TrimStart('0'));
            int Month = Convert.ToInt32((String.Format("{0:MM}", thisDay).TrimStart('0')));
            int Year = Convert.ToInt32((String.Format("{0:yyyy}", thisDay).TrimStart('0')));
            DateTime dt;


            //jesli jest 16 lub pozniej, bilet miesieczny jest na kolejny miesiac
            if (Day < 16)
            {
                dt = new DateTime(Year, Month, Day);
                OkresoweCzyJestPrzed16 = true;
            }
            else
            {
                dt = new DateTime(Year, Month + 1, Day);
                OkresoweCzyJestPrzed16 = false;
            }

            return String.Format("{0:MMMM}", dt);
        }
        public void Nazwa_poczatek() //metoda do tworzdenia początku
        {
            string spacje = "    >";
            if (RodzajWybranegoBiletuOkresowego==1)
            {
                pocz = "Bilet okresowy:\n " + Environment.NewLine;
                if (bilet == 0) pocz = pocz +spacje+ "30 DNIOWY, obowiązujący "+Okresowy30dniTekst+"," + Environment.NewLine; else if(bilet==1) pocz = pocz + spacje + "MIESIĘCZNY na miesiąc " + OkresoweMiesiac().ToUpper()+"," + Environment.NewLine;
                if (Rodzaj_ulgi == 0) pocz = pocz + spacje + "ZWYKŁY, " + Environment.NewLine; else if(Rodzaj_ulgi==1) pocz = pocz + spacje + "ULGOWY, " + Environment.NewLine;
                if (Typ_biletu == 0) pocz = pocz + spacje + "IMIENNY, " + Environment.NewLine; else if(Typ_biletu==1) pocz = pocz + spacje + "NA OKAZICIELA, " + Environment.NewLine;
                if (Waznosc_biletu == 0) pocz = pocz + spacje + "obowiązujący od PONIEDZIAŁKU do PIĄTKU, "; else if(Waznosc_biletu==1) pocz = pocz + spacje + "obowiązujący we WSZYSTKIE DNI TYGODNIA,";
            }
            else if (RodzajWybranegoBiletuOkresowego == 2)
            {
                pocz = "Bilet semestralny:\n " + Environment.NewLine;
                if (SemestralnyIleMiesiecy == 4) pocz += spacje + "4-miesięczny" + Environment.NewLine; else if (SemestralnyIleMiesiecy == 5) pocz += spacje + "5-miesięczny" + Environment.NewLine;
                pocz = pocz + spacje + "ważny we WSZYSTKIE DNI TYGODNIA," + DataDzialaniaSemestralnego+Environment.NewLine;                
                if (Rodzaj_ulgi == 0) pocz = pocz + spacje + "ZWYKŁY, "; else if(Rodzaj_ulgi==1) pocz = pocz + spacje + "ULGOWY, ";
                
            }

            if (kategoria_biletu!=0)
            {
                pocz += Environment.NewLine + "na linie ";
            }
            switch (kategoria_biletu)
            {
                case 0:
                    {
                       // pocz = "Nie wybrano żadnego biletu.";
                        break;
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
                        pocz = pocz + "nocne, pospieszne i zwykłe "; break;
                    }
                case 5:
                    {
                        pocz = pocz + "nocne, pospieszne i zwykłe w obrębie sieci komunikacyjnej [w tym linie G, N1, 101 i 171]"; break;
                    }
            }
            komunikat_info = pocz + kategoria_tekst+Environment.NewLine+"------------------------------------------------------------";
            //return pocz;
        }
        public void Spr_wszystkich_opcji() //metoda do sprawdzenia czy wszystkoe opcje zostały zaznaczone
        {
            if (bilet != 3 && Rodzaj_ulgi != 3 && Typ_biletu != 3 && Waznosc_biletu != 3) sprawdzenie = true;
            else sprawdzenie = false;
        }
        public double Cena_biletu(int jaki_bilet)
        {
            Spr_wszystkich_opcji();
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
                        if (typ == 1) CenaOkresowego = ceny1.M30I_PP_Zwykly;
                        else if (typ == 3) CenaOkresowego = ceny1.M30I_PN_Zwykly;
                        else CenaOkresowego = ceny1.M30NO_PN_Zwykly;
                        break;
                    }
                case 2:
                    {
                        if (typ == 1) CenaOkresowego = ceny1.M30I_PP_Nocny;
                        else if (typ == 3) CenaOkresowego = ceny1.M30I_PN_Nocny;
                        else CenaOkresowego = ceny1.M30NO_PN_Nocny;
                        break;
                    }
                case 3:
                    {
                        if (typ == 1) CenaOkresowego = ceny1.M30I_PP_NocnyGminy;
                        else if (typ == 3) CenaOkresowego = ceny1.M30I_PN_NocnyGminy;
                        else CenaOkresowego = ceny1.M30NO_PN_NocnyGminy;
                        break;
                    }
                case 4:
                    {
                        if (typ == 1) CenaOkresowego = ceny1.M30I_PP_NocnyRRW;
                        else if (typ == 3) CenaOkresowego = ceny1.M30I_PN_NocnyRRW;
                        else CenaOkresowego = ceny1.M30NO_PN_NocnyRRW;
                        break;
                    }
                case 5:
                    {
                        if (typ == 1) CenaOkresowego = ceny1.M30I_PP_NocnySieci;
                        else if (typ == 3) CenaOkresowego = ceny1.M30I_PN_NocnySieci;
                        else CenaOkresowego = ceny1.M30NO_PN_NocnySieci;
                        break;
                    }
            } // do określenia ceny biletów

            if (Rodzaj_ulgi == 1 && Typ_biletu == 0) CenaOkresowego = CenaOkresowego / 2; //naliczanie ulgi
            return CenaOkresowego;
        }
        public void MiesieczneWpisywanie_Do_TB()
        {
            if (sprawdzenie != true || kategoria_biletu == 0)
            {
                CenaOkresowego = 0;
                kategoria_tekst = "";
            } //wyczyszenie buforu tekstu

            Nazwa_poczatek();
            panelOkresowe_tb_Podsumowanie.Text = "\n" + komunikat_info;//kom1 + kom2 + kom3 + kom4 + kom5;
            komunikat_suma = String.Format("{0:0.00} zł",Cena_biletu(kategoria_biletu));
            panelOkresowe_tb_Suma.Text = komunikat_suma;

            if (SprawdzenieWyboruBiletu == true && sprawdzenie == true)
            {
                
                //pSemes_tb_Suma.Text = panelOkresowe_tb_Suma.Text;
                //pSemes_tb_Podsumowanie.Text = panelOkresowe_tb_Podsumowanie.Text;
            }
            else
            {
                //panelOkresowe_tb_Podsumowanie.Text = "Nie wybrano żadnego biletu.";
                //komunikat_suma = "0,00 zł.";
                //panelOkresowe_tb_Suma.Text = komunikat_suma;
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
            SemestralnyIleMiesiecy = 3;
            CenaOkresowego = 0;

            //to zmieniłem
            //MiesieczneObslugaKontrolek();
            //SemestralneObslugaKontrolek();
        }
        public void ZmianaKoloruKontrolekOkresowe() //zmienia na biale
        {
            panelOkresowe_b_zwykleGdy.BackColor = Color.White;
            panelOkresowe_b_Nocny.BackColor = Color.White;
            panelOkresowe_b_NocnyGminy.BackColor = Color.White;
            panelOkresowe_b_NocnyRRW.BackColor = Color.White;
            panelOkresowe_b_NocnySieci.BackColor = Color.White;

            pSemes_b_zwykleGdy.BackColor = Color.White;
            pSemes_b_Nocny.BackColor = Color.White;
            pSemes_b_NocnyGminy.BackColor = Color.White;
            pSemes_b_NocnyRRW.BackColor = Color.White;
            pSemes_b_NocnySieci.BackColor = Color.White;
            //panelOkresowe_b_okaziciela.BackColor = Color.White;
            //panelOkresowe_tb_Podsumowanie.Text = "Nie wybrano żadnego biletu.";
        }

        public void PokazywanieKontrolekOkresowe()
        {
            if (bilet == 0 || bilet == 1)
            {
                pOkres_tb_TypBiletu.Visible = true;
            }
            else pOkres_tb_TypBiletu.Visible = false;

            if (Typ_biletu == 0)
            {
                panelOkresowe_b_ulgowy.Enabled = true;
                panelOkresowe_b_PonPia.Enabled = true;

                pOkres_gb_RodzajBiletu.Visible = true;
            }
            else if (Typ_biletu == 1)
            {
                panelOkresowe_b_ulgowy.Enabled = false;
                panelOkresowe_b_PonPia.Enabled = false;

                pOkres_gb_RodzajBiletu.Visible = true;
            }
            else pOkres_gb_RodzajBiletu.Visible = false;

            if (Rodzaj_ulgi == 0 || Rodzaj_ulgi == 1)
            {
                pOkres_gb_Waznosc.Visible = true;
            }
            else pOkres_gb_Waznosc.Visible = false;

            if (Waznosc_biletu == 0 || Waznosc_biletu == 1)
            {
                panelOkresowe_gb_RodzajeBiletow.Visible = true;
            }
            else panelOkresowe_gb_RodzajeBiletow.Visible = false;

            if (kategoria_biletu == 0)
            {
                SprawdzenieWyboruBiletu = false;
            }
            else SprawdzenieWyboruBiletu = true;

        }
        public void MiesieczneObslugaKontrolek() //sluzy do pokazywania i ukrywania 
        {
            ResetujCzasReakcji();
            Spr_wszystkich_opcji();
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
                        break;
                    }
                default:
                    {
                        panelOkresowe_b_imienny.BackColor = Color.White;
                        panelOkresowe_b_okaziciela.BackColor = Color.White;
                        break;
                    }
            }

            switch (Rodzaj_ulgi)
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
                        if (sprawdzenie == true && ClickKategori==true)
                        {
                            OkresoweGminy okresoweGminy = new OkresoweGminy();
                            okresoweGminy.ShowDialog();
                            ClickKategori = false;
                            kategoria_tekst = okresoweGminy.Teksty();
                        }
                        ZmianaKoloruKontrolekOkresowe();
                        panelOkresowe_b_NocnyGminy.BackColor = Color.Green;
                        break;
                    }
                case 4:
                    {
                        if (sprawdzenie == true && ClickKategori == true)
                        {
                            OkresowyRRW okresowyRRW = new OkresowyRRW();
                            okresowyRRW.ShowDialog();
                            kategoria_tekst = okresowyRRW.Teksty();
                            ClickKategori = false;
                            MiesieczneWpisywanie_Do_TB();
                        }
                        ZmianaKoloruKontrolekOkresowe();
                        panelOkresowe_b_NocnyRRW.BackColor = Color.Green;
                        break;
                    }
                case 5:
                    {
                        Spr_wszystkich_opcji();

                        if (sprawdzenie == true)
                        {
                            MiesieczneWpisywanie_Do_TB();
                        }
                        ZmianaKoloruKontrolekOkresowe();
                        panelOkresowe_b_NocnySieci.BackColor = Color.Green;
                        break;
                    }
            }

            Suma = CenaOkresowego;
            MiesieczneWpisywanie_Do_TB();
            TimeFromLastMove = -5;
        }

        //przyciski
        private void panelOkresowe_b_30dni_Click(object sender, EventArgs e)
        {
            TimeFromLastMove = -10;
            if (bilet==3) //to znaczy że jeszcze nie zostal wybrany wczesniej
            {
                Kalendarz kalendarz30Dni = new Kalendarz();
                kalendarz30Dni.ShowDialog();
                AktualnieWybranaData = kalendarz30Dni.AktualnieWybranaData;
                Okresowy30dniTekst = kalendarz30Dni.Dni30Tekst;
            }
            else
            {
                Kalendarz kalendarz30Dni = new Kalendarz(AktualnieWybranaData);
                kalendarz30Dni.ShowDialog();
                AktualnieWybranaData = kalendarz30Dni.AktualnieWybranaData;
                Okresowy30dniTekst = kalendarz30Dni.Dni30Tekst;
            }
            bilet = 0;
            MiesieczneObslugaKontrolek();
           
        }
        private void panelOkresowe_b_mies_Click(object sender, EventArgs e)
        {
            OkresoweMiesiac();
            if (OkresoweCzyJestPrzed16 == true && bilet!=1)
            {
                if (PotwiedzenieZlegoBiltu() == true)
                {
                    bilet = 1;
                    MiesieczneObslugaKontrolek();
                }
                else
                {
                    return;
                }
            }
            bilet = 1;
            MiesieczneObslugaKontrolek();
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
            MiesieczneObslugaKontrolek();
        }
        private void panelOkresowe_b_okaziciela_Click(object sender, EventArgs e)
        {
            Typ_biletu = 1;
            Rodzaj_ulgi = 0;
            Waznosc_biletu = 1;
            MiesieczneObslugaKontrolek();
        }
        private void panelOkresowe_b_zwykly_Click(object sender, EventArgs e)
        {
            Rodzaj_ulgi = 0;
            MiesieczneObslugaKontrolek();
        }
        private void panelOkresowe_b_ulgowy_Click(object sender, EventArgs e)
        {
            Rodzaj_ulgi = 1;
            MiesieczneObslugaKontrolek();
        }

        

        private void panelOkresowe_b_PonPia_Click(object sender, EventArgs e)
        {
            Waznosc_biletu = 0;
            MiesieczneObslugaKontrolek();
        }
        private void panelOkresowe_szDni_Click(object sender, EventArgs e)
        {
            Waznosc_biletu = 1;
            MiesieczneObslugaKontrolek();
        }

        //wybor kategorii biletu
        private void panelOkresowe_b_zwykleGdy_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 1;
            SprawdzenieWyboruBiletu = true;
            MiesieczneObslugaKontrolek();
        }
        private void panelOkresowe_b_Nocny_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 2;

            MiesieczneObslugaKontrolek();
        }
        private void panelOkresowe_b_NocnyGminy_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 3;
            ClickKategori = true;
            MiesieczneObslugaKontrolek();
        }
        private void panelOkresowe_b_NocnyRRW_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 4;
            ClickKategori = true;
            MiesieczneObslugaKontrolek();

        }
        private void panelOkresowe_b_NocnySieci_Click(object sender, EventArgs e)
        {
            kategoria_biletu = 5;
            MiesieczneObslugaKontrolek();

        }


        private void panelOkresowe_b_Platnosc_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            if (CenaOkresowego > 0)
            {
                WyborKartaCzyGotowka wyborKartaCzyGotowka = new WyborKartaCzyGotowka(komunikat_suma);                
                wyborKartaCzyGotowka.ShowDialog();
                SposobPlatnosci = wyborKartaCzyGotowka.SposobPlatnosci;
                wyborKartaCzyGotowka.Close();

                AktualneOkno = 10;
                Podsumowanie podsumowanie = new Podsumowanie(komunikat_info, komunikat_suma, SposobPlatnosci, pb_postep.Value, CenaOkresowego);
                podsumowanie.RodzajKupowanegoBiletu = 1;
                podsumowanie.ShowDialog();

                AktualneOkno = 6;
                if (podsumowanie.Koniec == true)
                {
                    ResetValuesOkresowe();
                    AktualneOkno = 0;
                    PrzesuwaniePaneli();
                    OknoKomunikatKartaMiejska();                    
                }
                podsumowanie.Close();
                //podsumowanie.Visible = true;
            }
            else
            {
                OknoKomunikatu oknoKomunikatu = new OknoKomunikatu("Nie wybrano żadnego biletu.");
                oknoKomunikatu.ShowDialog();
            }


        }
        #endregion

#region Semestralne
        //bool OkresoweOstrzezenie = false;
        string DataDzialaniaSemestralnego = "";
        public int SemestralnyIleMiesiecy = 3; //4-4miesiace 5-5miesiecy , 3 domyslne

        public void SprWszystkichOpcjiSemestralne() //sprawdza czy wszystkie opcje zostaly wybrane
        {
            if (Rodzaj_ulgi != 3 && SemestralnyIleMiesiecy != 3) sprawdzenie = true;
            else sprawdzenie = false;
        }
        public int CenaSemstralne()
        {            
            
                SprWszystkichOpcjiSemestralne();
                Ceny_biletow ceny_Biletow = new Ceny_biletow();
                // określenie rodzaju biletu inaczej jakby okresleniekolumny
                if (sprawdzenie==true)
                {
                    switch(kategoria_biletu)
                    {
                        case 1:
                                {
                                CenaOkresowego = ceny_Biletow.S4_Zwykle / 4;
                                break;
                                }
                        case 2:
                            {
                                CenaOkresowego = ceny_Biletow.S4_Nocny / 4;
                                break;
                            }
                        case 3:
                            {
                                CenaOkresowego = ceny_Biletow.S4_NocnyGminy / 4;
                                break;
                            }
                        case 4:
                            {
                                CenaOkresowego = ceny_Biletow.S4_NocnyRRW / 4;
                                break;
                            }
                        case 5:
                            {
                                CenaOkresowego = ceny_Biletow.S4_NocnySieci / 4;
                                break;
                            }

                    }

                    if (SemestralnyIleMiesiecy==4)
                    {
                    CenaOkresowego = CenaOkresowego * 4;
                    }
                    else if (SemestralnyIleMiesiecy==5)
                    {
                        CenaOkresowego = CenaOkresowego * 5;
                    }
                }

                if (Rodzaj_ulgi == 1) CenaOkresowego = CenaOkresowego / 2; //naliczanie ulgi
                return Convert.ToInt32(CenaOkresowego);
           
        } //sa do delikatatnej poprawy; nieco zle ceny sie wyswietlaja, bodziele i mnoze wartosci
        public void SemestralnePokazwyanieKontrolek()
        {
            if (SemestralnyIleMiesiecy == 4 || SemestralnyIleMiesiecy == 5)
            {
                pSemes_gb_RodzajeBiletow.Visible = true;
            }
            else pSemes_gb_RodzajeBiletow.Visible = false;


            if (Rodzaj_ulgi == 0 || Rodzaj_ulgi==1)
            {
                pSemes_gb_KategorieBiletow.Visible = true;
            }
            else pSemes_gb_KategorieBiletow.Visible = false;

            if (kategoria_biletu == 0)
            {
                SprawdzenieWyboruBiletu = false;
            }
            else SprawdzenieWyboruBiletu = true;
        }
        public void SemestralneObslugaKontrolek()
        {            
            SprWszystkichOpcjiSemestralne(); //sprawdza czy zostaly klikniete obie opcje
            SemestralnePokazwyanieKontrolek(); //pokazuje nowe kontrolki w zaleznosci od wcisnietych klawiszy
            Suma = CenaSemstralne();//obliczenie ceny bileut
            

            switch (SemestralnyIleMiesiecy)
            {
                case 4: //4 mies
                    {
                        pSemes_b_4miesiace.BackColor = Color.Green;
                        pSemes_b_5miesiecy.BackColor = Color.White;
                        break;
                    }
                case 5: //wszy dni
                    {

                        pSemes_b_4miesiace.BackColor = Color.White;
                        pSemes_b_5miesiecy.BackColor = Color.Green;
                        break;
                    }
                default:
                    {
                        pSemes_b_4miesiace.BackColor = Color.White;
                        pSemes_b_5miesiecy.BackColor = Color.White;
                        break;
                    }
            }

            kategoria_tekst = "";
            switch (Rodzaj_ulgi)
            {
                case 0: //zwykly
                    {
                        pSemes_b_zwykly.BackColor = Color.Green;
                        pSemes_b_ulgowy.BackColor = Color.White;
                        break;
                    }
                case 1: //ulgowy
                    {
                        pSemes_b_zwykly.BackColor = Color.White;
                        pSemes_b_ulgowy.BackColor = Color.Green;
                        break;
                    }
                default:
                    {
                        pSemes_b_zwykly.BackColor = Color.White;
                        pSemes_b_ulgowy.BackColor = Color.White;
                        break;
                    }
            }

            switch (kategoria_biletu)
            {
                case 1:
                    {
                        ZmianaKoloruKontrolekOkresowe();
                        pSemes_b_zwykleGdy.BackColor = Color.Green;
                        break;
                    }
                case 2:
                    {
                        ZmianaKoloruKontrolekOkresowe();
                        pSemes_b_Nocny.BackColor = Color.Green;
                        break;
                    }
                case 3:
                    {
                        if (sprawdzenie == true && ClickKategori == true)
                        {
                            OkresoweGminy okresoweGminy = new OkresoweGminy();
                            okresoweGminy.ShowDialog();
                            ClickKategori = false;
                            kategoria_tekst = okresoweGminy.Teksty();
                        }
                        ZmianaKoloruKontrolekOkresowe();
                        pSemes_b_NocnyGminy.BackColor = Color.Green;
                        break;
                    }
                case 4:
                    {
                        if (sprawdzenie == true && ClickKategori == true)
                        {
                            OkresowyRRW okresowyRRW = new OkresowyRRW();
                            okresowyRRW.ShowDialog();
                            kategoria_tekst = okresowyRRW.Teksty();
                            ClickKategori = false;
                            //SemestralneWspiswyanieDoTB();
                        }
                        ZmianaKoloruKontrolekOkresowe();
                        pSemes_b_NocnyRRW.BackColor = Color.Green;
                        break;
                    }
                case 5:
                    {
                        ZmianaKoloruKontrolekOkresowe();
                        pSemes_b_NocnySieci.BackColor = Color.Green;
                        break;
                    }
            }
            SemestralneWspiswyanieDoTB();
        }        
        public void SemestralneWspiswyanieDoTB()            
        {
            SemestralneOtwarcieOkna(); //inaczej nie chcce działać poprawnie
            pSemes_tb_Podsumowanie.Text = "";
            if (sprawdzenie != true || kategoria_biletu == 0)
            {
                CenaOkresowego = 0;
                //kategoria_tekst = "Nie wybrano żadnego biletu.";
                komunikat_suma = "0,00 zł.";
                pSemes_tb_Suma.Text = komunikat_suma;
            } //wyczyszenie buforu tekstu


            Nazwa_poczatek();

            //if (OkresoweOstrzezenie == true)
            //{
            //    pSemes_tb_Podsumowanie.Text = "\t   >>>UWAGA!<<<" + Environment.NewLine+ "WYBRANO BILET NA OKRES KTÓRY ZACZĄŁ SIĘ JAKIŚ CZAS TEMU!!" + Environment.NewLine + Environment.NewLine;
            //}
            pSemes_tb_Podsumowanie.Text += "\n" + komunikat_info;//kom1 + kom2 + kom3 + kom4 + kom5;
            komunikat_suma = String.Format("{0:0.00} zł", CenaSemstralne());
            pSemes_tb_Suma.Text = komunikat_suma;
            if (SprawdzenieWyboruBiletu == true && sprawdzenie == true)
            {
                
            }
            else
            {
               // pSemes_tb_Podsumowanie.Text = "Nie wybrano żadnego biletu.";
                komunikat_suma = "0,00 zł.";
                pSemes_tb_Suma.Text = komunikat_suma;
            }
        }
        public void SemestralneOtwarcieOkna() //otawrcie okna dowyboru jakie miesiace jest ważny
        {
            Semestralne_KtoreMiesiace semestralne_KtoreMiesiace = new Semestralne_KtoreMiesiace(SemestralnyIleMiesiecy);

            //nie pozwalamy na wybór semestru bo bez sensu
            //semestralne_KtoreMiesiace.b_zimowy.Enabled = false;
            //semestralne_KtoreMiesiace.TekstButonow();
            //semestralne_KtoreMiesiace.ShowDialog();
            //if (semestralne_KtoreMiesiace.KtoreMiesiace==0) //to znak ze wybrano juz trwajacy okres
            //{
            //    OkresoweOstrzezenie = true;
            //}
            
            semestralne_KtoreMiesiace.TworzenieTesktu();
            DataDzialaniaSemestralnego = semestralne_KtoreMiesiace.tekst_KtoreMiesiaceWazny;
            semestralne_KtoreMiesiace.Close();
        }


        #region przyciski
        //przyciski
        private void pSemes_b_4miesiace_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            SemestralnyIleMiesiecy = 4;
            SemestralneOtwarcieOkna();
            SemestralneObslugaKontrolek();
        }



        private void pSemes_b_5mies_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            SemestralnyIleMiesiecy = 5;
            SemestralneObslugaKontrolek();
            SemestralneOtwarcieOkna();
        }


        private void pSemes_b_zwykly_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            Rodzaj_ulgi = 0;
            SemestralneObslugaKontrolek();
        }
        private void pSemes_b_ulgowy_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            Rodzaj_ulgi = 1;
            SemestralneObslugaKontrolek();
        }

        private void pSemes_b_zwykleGdy_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            kategoria_biletu = 1;
            ClickKategori = true;
            SemestralneObslugaKontrolek();
        }
        private void pSemes_b_Nocny_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            kategoria_biletu = 2;
            ClickKategori = true;
            SemestralneObslugaKontrolek();
        }
        private void pSemes_b_NocnyGminy_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            TimeFromLastMove = -10;
            kategoria_biletu = 3;
            ClickKategori = true;
            SemestralneObslugaKontrolek();
        }
        private void pSemes_b_NocnyRRW_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            TimeFromLastMove = -10;
            kategoria_biletu = 4;
            ClickKategori = true;
            SemestralneObslugaKontrolek();
        }
        private void pSemes_b_NocnySieci_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            kategoria_biletu = 5;
            ClickKategori = true;
            SemestralneObslugaKontrolek();
        }


        #endregion
        private void pSemes_b_Platnosc_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            TimeFromLastMove = -10;
            if (CenaOkresowego > 0)
            {
                WyborKartaCzyGotowka wyborKartaCzyGotowka = new WyborKartaCzyGotowka(komunikat_suma);
                wyborKartaCzyGotowka.ShowDialog();
                SposobPlatnosci = wyborKartaCzyGotowka.SposobPlatnosci;
                wyborKartaCzyGotowka.Close();

                AktualneOkno = 10;
                //Podsumowanie podsumowanie = new Podsumowanie(komunikat_info, komunikat_suma, SposobPlatnosci, pb_postep.Value, Suma);
                Podsumowanie podsumowanieOkresowe = new Podsumowanie(pSemes_tb_Podsumowanie.Text, komunikat_suma, SposobPlatnosci, pb_postep.Value, Suma);
                podsumowanieOkresowe.RodzajKupowanegoBiletu = 1;
                podsumowanieOkresowe.ShowDialog();
                AktualneOkno = 7;
                if (podsumowanieOkresowe.Koniec == true)
                {
                    AktualneOkno = 0;
                    PrzesuwaniePaneli();
                    ResetValuesOkresowe();
                    UsuwanieWartosci();
                    AktualneOkno = 0;
                    //KoniecButton();
                    OknoKomunikatKartaMiejska();
                }
                
                podsumowanieOkresowe.Close();
                //podsumowanie.Visible = true;
            }
            else
            {
                OknoKomunikatu oknoKomunikatu = new OknoKomunikatu("Nie wybrano żadnego biletu.");
                oknoKomunikatu.ShowDialog();
            }
        }
        #endregion

#region Jednorazowe

        /*Wchuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuj guzików*/
        #region Klikanie guzików

        private void btn_Other_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            if (Flag == 1)  //panel 1 dla jednorazowych
            {
                ValueStorage[tb_NLeft] = tb_NLeft.Text;
                ValueStorage[tb_ULeft] = tb_ULeft.Text;
                ValueStorage[tb_NMid] = tb_NMid.Text;
                ValueStorage[tb_UMid] = tb_UMid.Text;
                tb_NLeft.Text = ValueStorage2[tb_NLeft];
                tb_ULeft.Text = ValueStorage2[tb_ULeft];
                tb_NMid.Text = ValueStorage2[tb_NMid];
                tb_UMid.Text = ValueStorage2[tb_UMid];
                pJedno_gb_Right.Visible = false;
                Flag = 2;
                //pKoniecWstecz_b_Wstecz.Visible = true;
                MenuGlowneZmianaTextuButtonow();
                RefreshSummaryRTB();
                ZmianaTextuBilety();
                return;
            }
            if (Flag == 2)  //panel 2 dla jednorazowych
            {
                //btn_Other.Text = "Bilety NOCNE";
                ValueStorage2[tb_NLeft] = tb_NLeft.Text;
                ValueStorage2[tb_ULeft] = tb_ULeft.Text;
                ValueStorage2[tb_NMid] = tb_NMid.Text;
                ValueStorage2[tb_UMid] = tb_UMid.Text;
                tb_NLeft.Text = ValueStorage[tb_NLeft];
                tb_ULeft.Text = ValueStorage[tb_ULeft];
                tb_NMid.Text = ValueStorage[tb_NMid];
                tb_UMid.Text = ValueStorage[tb_UMid];
                pJedno_gb_Right.Visible = true;
                //pKoniecWstecz_b_Wstecz.Visible = false;
                Flag = 1;
                MenuGlowneZmianaTextuButtonow();
                RefreshSummaryRTB();
                ZmianaTextuBilety();
                return;
            }
            if (Flag == 3)  //panel 1 dla komunalnych
            {
                //btn_Other.Text = "Bilety DZIENNE";
                ValueStorage[tb_NLeft] = tb_NLeft.Text;
                ValueStorage[tb_ULeft] = tb_ULeft.Text;
                tb_NLeft.Text = ValueStorage2[tb_NLeft];
                tb_ULeft.Text = ValueStorage2[tb_ULeft];
                pJedno_gb_Right.Visible = false;
                pJedno_gb_Mid.Visible = false;
                Flag = 4;
                MenuGlowneZmianaTextuButtonow();
                //pKoniecWstecz_b_Wstecz.Visible = true;
                RefreshSummaryRTB();
                ZmianaTextuBilety();
                return;
            }
            if (Flag == 4)  //panel 2 dla komunalnych
            {
                //btn_Other.Text = "Bilety NOCNE";
                ValueStorage2[tb_NLeft] = tb_NLeft.Text;
                ValueStorage2[tb_ULeft] = tb_ULeft.Text;
                tb_NLeft.Text = ValueStorage[tb_NLeft];
                tb_ULeft.Text = ValueStorage[tb_ULeft];
                pJedno_gb_Right.Visible = true;
                pJedno_gb_Mid.Visible = true;
                Flag = 3;
                MenuGlowneZmianaTextuButtonow();
                //pKoniecWstecz_b_Wstecz.Visible = false;
                RefreshSummaryRTB();
                ZmianaTextuBilety();
                return;
            }
            if (Flag == 5)  //panel 1 dla komunalnych-kolejowych
            {
                //btn_Other.Text = "Bilety DZIENNE";
                ValueStorage[tb_NLeft] = tb_NLeft.Text;
                ValueStorage[tb_ULeft] = tb_ULeft.Text;
                ValueStorage[tb_NMid] = tb_NMid.Text;
                ValueStorage[tb_UMid] = tb_UMid.Text;
                tb_NLeft.Text = ValueStorage2[tb_NLeft];
                tb_ULeft.Text = ValueStorage2[tb_ULeft];
                tb_NMid.Text = ValueStorage2[tb_NMid];
                tb_UMid.Text = ValueStorage2[tb_UMid];
                pJedno_gb_Right.Visible = false;
                Flag = 6;
                MenuGlowneZmianaTextuButtonow();
                //pKoniecWstecz_b_Wstecz.Visible = true;
                RefreshSummaryRTB();
                ZmianaTextuBilety();
                return;
            }
            if (Flag == 6)  //panel 2 dla komunalnych-kolejowych
            {
                //btn_Other.Text = "Bilety NOCNE";
                ValueStorage2[tb_NLeft] = tb_NLeft.Text;
                ValueStorage2[tb_ULeft] = tb_ULeft.Text;
                ValueStorage2[tb_NMid] = tb_NMid.Text;
                ValueStorage2[tb_UMid] = tb_UMid.Text;
                tb_NLeft.Text = ValueStorage[tb_NLeft];
                tb_ULeft.Text = ValueStorage[tb_ULeft];
                tb_NMid.Text = ValueStorage[tb_NMid];
                tb_UMid.Text = ValueStorage[tb_UMid];
                pJedno_gb_Right.Visible = true;
                Flag = 5;
                MenuGlowneZmianaTextuButtonow();
                //pKoniecWstecz_b_Wstecz.Visible = false;
                RefreshSummaryRTB();
                ZmianaTextuBilety();
                return;
            }

            //Tutaj wstawić zmianę elementów
        }
        private void btn_RemoveKolKom24_Click(object sender, EventArgs e)
        {
            KolKom24Remover rmv = new KolKom24Remover(KolKom24Storage, KolKom24StorageShort);
            rmv.ShowDialog();
            RefreshSummaryRTB();
        }

        #region plusminus
        private void btn_PNJedn_Click(object sender, EventArgs e)
        {
            Plus(tb_NLeft);
            RefreshSummaryRTB();
        }


        private void btn_MNJedn_Click(object sender, EventArgs e)
        {

            Minus(tb_NLeft);
            RefreshSummaryRTB();
        }


        private void btn_PUJedn_Click(object sender, EventArgs e)
        {
            Plus(tb_ULeft);
            RefreshSummaryRTB();
        }

        private void btn_MUJedn_Click(object sender, EventArgs e)
        {
            Minus(tb_ULeft);
            RefreshSummaryRTB();
        }

        private void btn_PNGodz_Click(object sender, EventArgs e)
        {
            Plus(tb_NMid);
            RefreshSummaryRTB();
        }

        private void btn_MNGodz_Click(object sender, EventArgs e)
        {
            Minus(tb_NMid);
            RefreshSummaryRTB();
        }

        private void btn_PUGodz_Click(object sender, EventArgs e)
        {
            Plus(tb_UMid);
            RefreshSummaryRTB();
        }
        private void btn_MUGodz_Click(object sender, EventArgs e)
        {
            Minus(tb_UMid);
            RefreshSummaryRTB();
        }

        private void btn_PN24_Click(object sender, EventArgs e)
        {
            Plus(tb_NRight);
            RefreshSummaryRTB();
        }



        private void pb_postep_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_MN24_Click(object sender, EventArgs e)
        {
            Minus(tb_NRight);
            RefreshSummaryRTB();
        }

        private void btn_PU24_Click(object sender, EventArgs e)
        {
            Plus(tb_URight);
            RefreshSummaryRTB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        
        #endregion

        private void pJedno_b_platnosc_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
            TimeFromLastMove = -5;
            if (price > 0)
            {
                WyborKartaCzyGotowka wyborKartaCzyGotowka = new WyborKartaCzyGotowka(tb_Price.Text);
                wyborKartaCzyGotowka.ShowDialog();
                SposobPlatnosci = wyborKartaCzyGotowka.SposobPlatnosci;
                wyborKartaCzyGotowka.Close();

                AktualneOkno = 10;
                //string cos = rtb_Summary2.Text;
                Podsumowanie podsumowanie = new Podsumowanie(pJedno_tb_Podsumowanie.Text, tb_Price.Text, SposobPlatnosci, pb_postep.Value, price);
                podsumowanie.RodzajKupowanegoBiletu = 0;
                podsumowanie.ShowDialog();
                AktualneOkno = 1;
                if (podsumowanie.Koniec == true)
                {
                    ResetValuesOkresowe();
                    AktualneOkno = 0;
                    PrzesuwaniePaneli();
                    UsuwanieWartosci();
                }
                podsumowanie.Close();
                //podsumowanie.Visible = true;
            }
            else
            {
                OknoKomunikatu oknoKomunikatu = new OknoKomunikatu("Nie wybrano żadnego biletu.");
                oknoKomunikatu.ShowDialog();
            }
        }

        //private void pJedno_L_T_Click(object sender, EventArgs e)
        //{
        //    if (Flag == 5)
        //    {
        //        KolKomOrg pop = new KolKomOrg();
        //        pop.ShowDialog();
        //        if (pop.SendText)
        //        {
        //            //KolKom24 = pop.TextToSend;
        //            KolKom24 = pJedno_OpisBiletuDoTB(pop.Poczatek, pop.QuantN, pop.QuantU, ceny1.MetroKolKom24_2);
        //            KolKom24Storage.Add(KolKom24);
        //            KolKom24StorageShort.Add("Przewoźnicy: " + pop.T1 + ", " + pop.T2 + "; Norm: " + pop.QuantN + ", " + String.Format("{0:0.00} zł", pop.PriceNorm) + "; Ulg: " + pop.QuantU + ", " + String.Format("{0:0.00} zł", pop.PriceUlg));
        //            KolKom24PricesNorm.Add(pop.PriceNorm);
        //            KolKom24PricesUlg.Add(pop.PriceUlg);

        //            //RefreshSummaryRTB();
        //        }
        //        KolejowoKomunalne();
        //        JednorazoweObslugaTB();
        //    }
        //}
        #endregion




        #region Klikanie Textboxów
            //metoda pobierająca cena w zależości od rodzaju flagi
        

        private void tb_NJedn_Click(object sender, EventArgs e)
        {           

            GetKeyboard(tb_NLeft, JednoCena(0));
        }

        private void tb_UJedn_Click(object sender, EventArgs e)
        {
            GetKeyboard(tb_ULeft, JednoCena(0)/2);
        }

        private void tb_NGodz_Click(object sender, EventArgs e)
        {
            GetKeyboard(tb_NMid, JednoCena(1));
        }

        private void tb_UGodz_Click(object sender, EventArgs e)
        {
            GetKeyboard(tb_UMid, JednoCena(1)/2);
        }

        private void tb_N24_Click(object sender, EventArgs e)
        {
            GetKeyboard(tb_NRight, JednoCena(2));
        }

        private void tb_U24_Click(object sender, EventArgs e)
        {
            GetKeyboard(tb_URight, JednoCena(2) / 2);
        }
        #endregion
        #endregion


        #region >>>>>>>Inne

        bool ZAtrzymanieCzasu = false;
        int PoziomReklamy = 1; //potrzebne do zmiany kimunikatów 
        public void ResetujCzasReakcji()//po wcisnieciu jakiegokolwiek buttona
        {
            TimeFromLastMove = 0;
            DoResetowaniareklam = false;
        }
        bool CzyMaZamykac = false;
        
        void ObslugaReklam()
        {
            Czas czas = new Czas();

            double CzasReklama = czas.CzasDoReklam;
            double CzasKoniecSesji = czas.CzasDoReset;
            
            label12.Text = Convert.ToString(TimeFromLastMove);

            //sprawdza czy juz nie jest czas by wyswietlic reklame
            if (TimeFromLastMove > CzasReklama && CzyJestReklama == false && PoziomReklamy==0)
            {
                CzyJestReklama = true;

                PoziomReklamy = 1;
                WyswietlReklamy();
            }
            else if (TimeFromLastMove > CzasKoniecSesji && CzyJestReklama == true && PoziomReklamy == 1)
            {
                AktualneOkno = 0;
                UsuwanieWartosci();
                ResetValuesOkresowe();
                PrzesuwaniePaneli();
                PoziomReklamy = 2; //czyli kolejna sesja
                DoResetowaniareklam = true;
                CzyMaZamykac = true;
            }

            if (AktualneOkno != 10 && ZAtrzymanieCzasu==false) //inne niz podsumowanie
            {
                TimeFromLastMove += StepTimera;
            }
            
        }

        public void WyswietlReklamy() //wyswietla reklamy
        {            
            Reklamy reklamy = new Reklamy();
            reklamy.ShowDialog();
            timer1.Enabled = true;
            if (reklamy.Koniec == true)
            {
                CzyMaZamykac = false;
                ResetujCzasReakcji();
                CzyJestReklama = !reklamy.Koniec;
                PoziomReklamy = 0;
            }
        }

     #region Do resetowania
        private void panelMenu_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelGorny_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelKoniecWstecz_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pb_jezykPOL_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pSemes_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pSemes_gb_KategorieBiletow_Enter(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pSemes_tb_Suma_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelMenu_Click_1(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pSemes_tb_Podsumowanie_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pJedno_l_Mid_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pJedno_l_Right_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pJedno_l_Left_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelOkresowe_tb_Podsumowanie_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelOkresowe_tb_Suma_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelOkresowe_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void btn_MU24_Click(object sender, EventArgs e)
        {
            Minus(tb_URight);
            RefreshSummaryRTB();
        }
        #endregion guziczki


        #endregion
    }
}
