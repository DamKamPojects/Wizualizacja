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
    public partial class OkresoweGminy : Form
    {
        public OkresoweGminy()
        {
            InitializeComponent();
        }

        public int wybor = 0;
        public string tekst = "na granicach ", Tekst = "";


        public void Kolorowanie()
        {
            b_zatwiedz.Enabled = true;
            b_sopot.BackColor = Color.White;
            b_rumia.BackColor = Color.White;
            b_kosakowo.BackColor = Color.White;
            b_zukowo.BackColor = Color.White;
            b_szemud.BackColor = Color.White;
            b_wejherowo.BackColor = Color.White;

            if (wybor == 1) b_sopot.BackColor = Color.Green;
            if (wybor == 2) b_rumia.BackColor = Color.Green;
            if (wybor == 3) b_kosakowo.BackColor = Color.Green;
            if (wybor == 4) b_zukowo.BackColor = Color.Green;
            if (wybor == 5) b_szemud.BackColor = Color.Green;
            if (wybor == 6) b_wejherowo.BackColor = Color.Green;
        }
        public string Teksty()
        {
            if (wybor == 1) Tekst = tekst + "Sopotu.";
            if (wybor == 2) Tekst = tekst + "Rumii.";
            if (wybor == 3) Tekst = tekst + "Gm. Kosakowo.";
            if (wybor == 4) Tekst = tekst + "Gm. Żukowo.";
            if (wybor == 5) Tekst = tekst + "Gm. Szemud.";
            if (wybor == 6) Tekst = tekst + "Gm. Wejherowo.";

            return Tekst;
        }

        private void b_zatwiedz_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void b_sopot_Click(object sender, EventArgs e)
        {
            wybor = 1;
            Kolorowanie();
        }
        private void b_rumia_Click(object sender, EventArgs e)
        {
            wybor = 2;
            Kolorowanie();
        }
        private void b_kosakowo_Click(object sender, EventArgs e)
        {
            wybor = 3;
            Kolorowanie();
        }
        private void b_zukowo_Click(object sender, EventArgs e)
        {
            wybor = 4;
            Kolorowanie();
        }
        private void b_szemud_Click(object sender, EventArgs e)
        {
            wybor = 5;
            Kolorowanie();
        }

        private void OkresoweGminy_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            b_zatwiedz.Enabled = false;
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

        private void b_wejherowo_Click(object sender, EventArgs e)
        {
            wybor = 6;
            Kolorowanie();
        }
    }
}
