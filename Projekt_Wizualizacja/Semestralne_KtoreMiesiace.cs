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
    public partial class Semestralne_KtoreMiesiace : Form
    {
        public int KtoreMiesiace = 3; // ktore miesiace zostaly wybrane
        int IleMiesiecy = 3; //wartosc wejsciowa; jaki przycisk wcisnieto
        public string tekst_KtoreMiesiaceWazny = "";

        public Semestralne_KtoreMiesiace()
        {
            InitializeComponent();
        }
        public Semestralne_KtoreMiesiace(int semestralneIleMiesiecy)
        {
            InitializeComponent();
            IleMiesiecy = semestralneIleMiesiecy;
            TekstButonow();
            
        } //potrzebne do tekstow w przyciskach
        
        private bool PotwiedzenieZlegoBiltu() //jesli wybralismy bilet ziomowy i tracimy kilka miesiecy
        {
            OknoPotwierdzeniaWyjscia oknoPotwierdzenia = new OknoPotwierdzeniaWyjscia("Czy jesteś pewny że chcesz wybrać bilet w tym okresie?");
            oknoPotwierdzenia.ShowDialog();
            if (oknoPotwierdzenia.Koniec == true)
            {
                return true;
            }
            return false;
        }
        private void TworzenieTesktu() //ustawianie tekstu do okna podsumowania
        {
            if (IleMiesiecy==0) //4 miesiace
            {

                if (KtoreMiesiace==0) //zimowy
                {
                    tekst_KtoreMiesiaceWazny = " 01.10.2017-31.01.2018";
                }
                else if (KtoreMiesiace==1) //letni
                {
                    tekst_KtoreMiesiaceWazny = " 01.02.2017-31.05.2018";
                }
            }
            else if (true)
            {
                if (KtoreMiesiace == 0) //zimowy
                {
                    tekst_KtoreMiesiaceWazny = " 01.09.2017-31.01.2018";
                }
                else if (KtoreMiesiace == 1)
                {
                    tekst_KtoreMiesiaceWazny = " 01.02.2017-30.06.2018";
                }
            }
        }
        public void TekstButonow()
        {
            if (IleMiesiecy == 4)
            {
                b_letni.Text = "01.02.2017 - 31.05.2018";
                b_zimowy.Text = "01.10.2017 - 31.01.2018";
            }
            else 
            {
                b_letni.Text = "01.02.2017-30.06.2018";
                b_zimowy.Text = "01.09.2017-31.01.2018";
            }
        }

        private void b_zimowy_Click(object sender, EventArgs e)
        {
            if (PotwiedzenieZlegoBiltu() == true)
            {
                KtoreMiesiace = 0;
                b_zimowy.BackColor = Color.Green;
                b_letni.BackColor = Color.White;
                TworzenieTesktu();
                b_zatwiedz.Enabled = true;
            }
        }

        private void b_letni_Click(object sender, EventArgs e)
        {
            KtoreMiesiace = 1;
            b_zimowy.BackColor = Color.White;
            b_letni.BackColor = Color.Green;
            TworzenieTesktu();
            b_zatwiedz.Enabled = true;
        }

        private void b_zatwiedź_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Semestralne_KtoreMiesiace_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            b_zatwiedz.Enabled = false;
            TekstButonow();
        }
    }
}
