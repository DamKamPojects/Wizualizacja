using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_Wizualizacja;

namespace Wizualizacja01
{
    public partial class Klawiatura : Form
    {
        string bilety = "0";
        string Cyfra = "0";
        double suma=0.00, cena = 0.00;
        public bool closed, take = false;

        public void EdycjaTextBoxow()
        {
            suma = Convert.ToDouble(bilety) * cena;
            TBil_bil.Text = bilety;
            l_IloscBiletow.Text = bilety;
            l_CenaBIletow.Text= String.Format("{0:0.00} zł", suma);
            TBcen_bil.Text = String.Format("{0:0.00} zł", suma);
        }

        public void WpisywanieDoTB(string cyfra) //metoda edytująca pole tekstowe ilość biletów oraz cene po wcisnieciu klawisza
        {
            // ten if sprawdza czy
            if (bilety=="0")   bilety = cyfra;   
            else if(bilety.Length<2)  bilety = bilety + cyfra; 
            else bilety = "99";
            
            EdycjaTextBoxow();
        }

        public Klawiatura(string wej)
        {
            InitializeComponent();
            bilety = wej;
            EdycjaTextBoxow();
        }
        public Klawiatura(string wej, double price)
        {
            InitializeComponent();
            bilety = wej;
            cena = price;
            EdycjaTextBoxow();
        }
        public Klawiatura(ref string input, double price)
        {
            InitializeComponent();
            TBil_bil.Text=input;
            cena = price;
            EdycjaTextBoxow();
        }

        public Klawiatura()
        {
            InitializeComponent();
        }
             
        private void Klawiatura_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            TBil_bil.Text = bilety;
           // u można by wrzucić domyślne wartości do textboxa, np + bądź minusem wybrałem ileś tam biletów to po odpaleniu klawiaturki wyskoczy tyle w textboxie
        }

        private void P_1_Click(object sender, EventArgs e)
        {
            Cyfra = "1";
            WpisywanieDoTB(Cyfra);
        }
        private void p_2_Click(object sender, EventArgs e)
        {
            Cyfra = "2";
            WpisywanieDoTB(Cyfra);
        }
        private void p_3_Click_1(object sender, EventArgs e)
        {
            Cyfra = "3";
            WpisywanieDoTB(Cyfra);
        }
        private void p_4_Click(object sender, EventArgs e)
        {
            Cyfra = "4";
            WpisywanieDoTB(Cyfra);
        }
        private void p_5_Click(object sender, EventArgs e)
        {
            Cyfra = "5";
            WpisywanieDoTB(Cyfra);
        }
        private void p_6_Click(object sender, EventArgs e)
        {
            Cyfra = "6";
            WpisywanieDoTB(Cyfra);
        }
        private void p_7_Click(object sender, EventArgs e)
        {
            Cyfra = "7";
            WpisywanieDoTB(Cyfra);
        }
        private void p_8_Click(object sender, EventArgs e)
        {
            Cyfra = "8";
            WpisywanieDoTB(Cyfra);
        }
        private void p_9_Click(object sender, EventArgs e)
        {
            Cyfra = "9";
            WpisywanieDoTB(Cyfra);
        }
        private void p_0_Click(object sender, EventArgs e)
        {
            Cyfra = "0";
            WpisywanieDoTB(Cyfra);
        }

        // to musi coś jeszcze zrobić
        private void AnulujBut_Click(object sender, EventArgs e)
        {
            take = false;
            //closed = true;
            this.Close();
        }

        private void TBil_bil_TextChanged(object sender, EventArgs e)
        {

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

        // To Be Continued...
        private void PotwiedzBut_Click(object sender, EventArgs e)
        {
            //TBcen_bil.Text = Convert.ToString(bilety.Length);
            take = true;
            //closed = true;
            this.Close();
        }

        private void KasujBut_Click(object sender, EventArgs e)
        {
            if (bilety.Length > 1) bilety=bilety.Remove(bilety.Length-1);
            else if (bilety != "0" && bilety.Length == 1) bilety = "0";

            EdycjaTextBoxow();            
        }
    }
}
