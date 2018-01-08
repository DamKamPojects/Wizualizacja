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
    public partial class OknoPotwierdzeniaWyjscia : Form
    {
        public OknoPotwierdzeniaWyjscia()
        {
            InitializeComponent();
        }

        public OknoPotwierdzeniaWyjscia(string komunikat)
        {
            InitializeComponent();
            l_Ostrzezenie.Text = komunikat;
        }

        public bool Koniec = false; //zmienna sprawdzająca czy wciśnięto koniec 

        private void b_Nie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_Tak_Click(object sender, EventArgs e)
        {
            Koniec = true;
            this.Close();
        }

        private void OknoPotwierdzeniaWyjscia_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }
        #region Zamykanie po czasie
        double StepSize;
        double TimeFromLastMove = 0;

        void ZamykanieOknaPoCzasie()
        {
            StepSize = (double)timer1.Interval / 1000.0;
            Czas czas = new Czas();

            double CzasReklama = czas.CzasDoReklam;
            double CzasKoniecSesji = czas.CzasDoReset;


            //sprawdza czy juz nie jest czas by wyswietlic reklame
            if (TimeFromLastMove > CzasKoniecSesji)
            {
                this.Close();
            }

            TimeFromLastMove += StepSize;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            ZamykanieOknaPoCzasie();
        }
    }
}
