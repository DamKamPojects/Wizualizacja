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
    public partial class Kalendarz : Form
    {
        public Kalendarz()
        {
            //Calendar.MinDate = new DateTime(2018, 1, 11);
            //Calendar.MaxDate = new DateTime(2018, 2, 27);
            InitializeComponent();
            ObslugaKalendarza();
            //AktualnieWybranaData = new DateTime.Now;
            int day = Convert.ToInt32(String.Format("{0:dd}", AktualnieWybranaData).TrimStart('0'));
            int month = Convert.ToInt32((String.Format("{0:MM}", AktualnieWybranaData).TrimStart('0')));
            int year = Convert.ToInt32((String.Format("{0:yyyy}", AktualnieWybranaData).TrimStart('0')));

            Calendar.MinDate = new DateTime(year, month, day);
            l_Od.Text = AktualnieWybranaData.ToString("dd.MM.yyyy");
            l_Do.Text = GetEndDate(year, month, day, 30).ToString("dd.MM.yyyy");
        }

        public Kalendarz(DateTime AktualnieWybrany)
        {
            InitializeComponent();
            Calendar.SelectionRange.Start = AktualnieWybrany;
            Calendar.SelectionRange.End = AktualnieWybrany;
            Calendar.SelectionStart = AktualnieWybrany;
            Calendar.SelectionEnd = AktualnieWybrany;

            ObslugaKalendarza();

            l_Od.Text = Convert.ToString(AktualnieWybrany);

            int day = Convert.ToInt32(String.Format("{0:dd}", AktualnieWybrany).TrimStart('0'));
            int month = Convert.ToInt32((String.Format("{0:MM}", AktualnieWybrany).TrimStart('0')));
            int year = Convert.ToInt32((String.Format("{0:yyyy}", AktualnieWybrany).TrimStart('0')));
            l_Do.Text = Convert.ToString(GetEndDate(year, month, day, 30));
        }
        //zmienne
        public string Dni30Tekst;
        public DateTime AktualnieWybranaData=new DateTime(2018,1,11);
        public bool Dzialaj = false;



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
            //l_godzina.Text = thisDay.ToString("HH:mm:ss");
        } //moetoda pobierajaca aktualną datę

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetCurrentTime();
            ZamykanieOknaPoCzasie();
        }

        private void Kalendarz_Load(object sender, EventArgs e)
        {
            GetCurrentTime();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            //ObslugaKalendarza();
        }

        int ZnajdzIleDniMaMiesiac(int year, int month)
        {
            for (int i = 28; i < 33; i++)
            {
                try
                {
                    DateTime xx = new DateTime(year, month, i);
                }
                catch (Exception)
                {                    
                    return i - 1;
                }
            }
            
            return 0;
        }

        //oblsuguje kalendarz, le dni ma byc pokazanych w kalendarzu
        private void ObslugaKalendarza()
        {
            DateTime thisDay = DateTime.Now; //pobiera aktualna date
            
            int Day = Convert.ToInt32(String.Format("{0:dd}", thisDay).TrimStart('0'));
            int Month = Convert.ToInt32((String.Format("{0:MM}", thisDay).TrimStart('0')));            
            int Year = Convert.ToInt32((String.Format("{0:yyyy}", thisDay).TrimStart('0')));
            DateTime FirstDay = new DateTime(Year, Month, Day);


            DateTime LastDay = new DateTime(Year, Month+1, (Day+29) % ZnajdzIleDniMaMiesiac(Year,Month));
            Calendar.TodayDate = FirstDay;
            Calendar.MinDate = FirstDay;
            Calendar.MaxDate = LastDay;               
        }

        //metoda dajaca jako wynik date o number dni pozniej
        private DateTime GetEndDate(int year, int month, int day, int number)
        {
            DateTime lastDay = new DateTime(2018,1,10);
            //DateTime LastDay = new DateTime(Year, Month + 1, (Day + 29) % ZnajdzIleDniMaMiesiac(Year, Month));
            int IloscDniMiesiaca = ZnajdzIleDniMaMiesiac(year, month);
            if (day+number<=IloscDniMiesiaca)
            {
                lastDay = new DateTime(year, month, (day + number));
            }
            else
            {
                try
                {
                    lastDay = new DateTime(year, month + 1, (day + number) - (ZnajdzIleDniMaMiesiac(year, month)));
                }
                catch (Exception)
                {
                    //luty
                    lastDay = new DateTime(year, month + 2, (day + number) - (ZnajdzIleDniMaMiesiac(year, month)+ZnajdzIleDniMaMiesiac(year,month+1)));
                }
            }

            return lastDay;
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //metoda na klikniecie
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Calendar.SelectionStart
            button1.Enabled = true;
            AktualnieWybranaData = Calendar.SelectionStart;
            int day = Convert.ToInt32(String.Format("{0:dd}", AktualnieWybranaData).TrimStart('0'));
            int month = Convert.ToInt32((String.Format("{0:MM}", AktualnieWybranaData).TrimStart('0')));
            int year = Convert.ToInt32((String.Format("{0:yyyy}", AktualnieWybranaData).TrimStart('0')));

            l_Od.Text = AktualnieWybranaData.ToString("dd.MM.yyyy");
            l_Do.Text = GetEndDate(year, month, day, 30).ToString("dd.MM.yyyy");

            Dni30Tekst = "od "+l_Od.Text + " do " + l_Do.Text;
            Dzialaj = true;

        }
        DateRangeEventArgs eeee;
        private void button1_Click(object sender, EventArgs e)
        {
            Calendar_DateSelected(sender, eeee);
            //AktualnieWybranaData = Calendar.SelectionRange.Start;

            this.Close();
        }


        #region Zamykanie po czasie
        double StepSize;
        double TimeFromLastMove = 0;
       

        #region DUzo guzikow
        
        #endregion

        void ZamykanieOknaPoCzasie()
        {
            StepSize = (double)timer1.Interval / 1000.0;
            Czas czas = new Czas();
            
            double CzasKoniecSesji = czas.CzasDoReset;


            //sprawdza czy juz nie jest czas by wyswietlic reklame
            if (TimeFromLastMove > CzasKoniecSesji)
            {
                this.Close();
            }

            TimeFromLastMove += StepSize;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            //Calendar_DateSelected(sender, eeee);
            //AktualnieWybranaData = Calendar.SelectionRange.Start;

            this.Close();
        }
    }
}
