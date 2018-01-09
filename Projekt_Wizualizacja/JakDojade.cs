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
    public partial class JakDojade : Form
    {
        public JakDojade()
        {
            InitializeComponent();
        }
        public bool Koniec = false;

        private void aaa_Load(object sender, EventArgs e)
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
            l_data.Text = dzien + ", " + thisDay.ToString("dd.MM.yyyy");
            l_godzina.Text = thisDay.ToString("HH:mm:ss");
            pomoc.Text = Convert.ToString(TimeFromLastMove);


        } //moetoda pobierajaca aktualną datę

        private void pKoniecWstecz_b_Wstecz_Click(object sender, EventArgs e)
        {
            Koniec = true;
            this.Close();
        }

        private void pKoniecWstecz_b_Koniec_Click(object sender, EventArgs e)
        {
            Koniec = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ObslugaReklam(); //oblsuguje reklamy
            GetCurrentTime();
        }

        #region >>>>>>>Inne
        double TimeFromLastMove;
        bool DoResetowaniareklam = false;
        bool CzyJestReklama = false;
        int PoziomReklamy = 0; //potrzebne do zmiany kimunikatów 

        public void ResetujCzasReakcji()//po wcisnieciu jakiegokolwiek buttona
        {
            TimeFromLastMove = 0;
            DoResetowaniareklam = false;
        }

        void ObslugaReklam()
        {
            Czas czas = new Czas();
            double StepSize = (double)timer1.Interval / 1000.0;
            double CzasReklama = czas.CzasDoReklam*1.5;
            double CzasKoniecSesji = czas.CzasDoReset*1.5;


            //sprawdza czy juz nie jest czas by wyswietlic reklame
            if (TimeFromLastMove > CzasReklama && CzyJestReklama == false && PoziomReklamy == 0)
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

            TimeFromLastMove += StepSize;
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

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelGorny_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGorny_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void l_godzina_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }

        private void panelKoniecWstecz_Click(object sender, EventArgs e)
        {
            ResetujCzasReakcji();
        }
    }
}
