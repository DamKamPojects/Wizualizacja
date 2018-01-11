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
    public partial class OknoKomunikatu : Form
    {
        List<string> komunikaty = new List<string>();
        int index = 0;

        int SposobPlatnosci;
        public OknoKomunikatu()
        {
            InitializeComponent();
        }
        public OknoKomunikatu(string komunikat)
        {
            InitializeComponent();
            komunikaty.Add(komunikat);
            b_OK.Visible = true;
            l_Komunikat.Size=new Size(684, 217);
            //l_Komunikat.Text = komunikat;
        }
        public OknoKomunikatu(List<string> lista, int wyborPlatnosci)
        {
            InitializeComponent();
            komunikaty = lista;
            SposobPlatnosci = wyborPlatnosci;
        }

        public void ZmianaKomunikatow()
        {
            //while (index< komunikaty.Count)
            //{
            //    l_Komunikat.Text = komunikaty[index];
            //    //Thread.Sleep(2000);
            //    index++;
            //}
            //Thread.Sleep(4000);
            //this.Close();
            if (index >= komunikaty.Count)
            {
                this.Close();
            }
            else
            {
                l_Komunikat.Text = komunikaty[index];
            }
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            b_koniec.Visible = false;
            b_OK.Visible = false;
            index++;
            ZmianaKomunikatow();
            
        }

        private void OknoKomunikatu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            if (index == 0 && SposobPlatnosci == 2)
            {
                ZmianaKomunikatow();
                b_koniec.Visible = true;
                b_OK.Visible = true;
                timer1.Enabled = false;
            }
            else
            {
                ZmianaKomunikatow();
            }
            
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
            //ZamykanieOknaPoCzasie();
            //if (index!=0 && SposobPlatnosci==2)
            //{
            //    b_koniec.Visible = false;
            //    b_OK.Visible = false;
            //}
            
            index++;
            ZmianaKomunikatow();
        }

        private void l_Komunikat_Click(object sender, EventArgs e)
        {

        }

        private void b_koniec_Click(object sender, EventArgs e)
        {
            OknoPotwierdzeniaWyjscia oknoPotwierdzeniaWyjscia = new OknoPotwierdzeniaWyjscia();
            oknoPotwierdzeniaWyjscia.ShowDialog();
            if (oknoPotwierdzeniaWyjscia.Koniec==true)
            {
                this.Close();
            }
        }
    }
}
