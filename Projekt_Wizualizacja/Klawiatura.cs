﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TBcen_bil.Text = Convert.ToString(suma);
        }

        public void WpisywanieDoTB(string cyfra) //metoda edytująca pole tekstowe ilość biletów oraz cene po wcisnieciu klawisza
        {
            // ten if sprawdza czy
            if (bilety=="0")   bilety = cyfra;   
            else if(bilety.Length<3)  bilety = bilety + cyfra; 
            else bilety = "999";
            
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
            //else TBcen_bil.Text = "Chuj";

            EdycjaTextBoxow();            
        }
    }
}
