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
    public partial class WyborKartaCzyGotowka : Form
    {
        public int SposobPlatnosci = 0;

        public WyborKartaCzyGotowka(string doZaplaty)
        {
            InitializeComponent();
            l_DoZaplaty.Text = doZaplaty;
        }

        private void WyborKartaCzyGotowka_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }

        private void b_gotowka_Click(object sender, EventArgs e)
        {
            SposobPlatnosci = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SposobPlatnosci = 2;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ZamykanieOknaPoCzasie();
        }
    }
}
