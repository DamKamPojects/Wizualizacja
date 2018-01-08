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
    public partial class Reklamy : Form
    {
        public Reklamy()
        {
            InitializeComponent();
            DodawanieReklamDoListy();
            panel1.BackgroundImage = ListaReklam[Losowanie()];

        }

        public bool Koniec = false;
        int PoprzedniObrazek = 0;
        int NumerObrazka = 0;
        List<Image> ListaReklam = new List<Image>();
        int Time = 0;
        
        void DodawanieReklamDoListy() //dodawnie reklam do listy
        {
            ListaReklam.Add(new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.Reklama1));
            ListaReklam.Add(new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.reklama2));
            ListaReklam.Add(new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.reklama3));
            ListaReklam.Add(new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.reklama4));
            ListaReklam.Add(new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.reklama5));
            ListaReklam.Add(new Bitmap(global::Projekt_Wizualizacja.Properties.Resources.reklama6));
        }
            
        private void Reklamy_Click(object sender, EventArgs e)
        {
            Koniec = true;
            this.Close();
        }
        //losowanie olbiczeniozerne troche
        int Losowanie()
        {

            long Liczba=1;

            int Zakres = ListaReklam.Count;
            int min = 0, max = Zakres * 10;
            do
            {
                Random x = new Random(System.DateTime.Now.Millisecond*DateTime.Now.Second);
                return PoprzedniObrazek = x.Next(min, Zakres);
                //Liczba = 1;
                //List<int> list = new List<int>();
                //for (int i = 0; i < Zakres * (PoprzedniObrazek+1)*17; i++)
                //{
                //    Random x = new Random(System.DateTime.Now.Millisecond);
                //    Random y = new Random(System.DateTime.Now.Millisecond);
                //    Random z = new Random(System.DateTime.Now.Millisecond);
                //    z = new Random(System.DateTime.Now.Millisecond);

                //    int k = x.Next(min, max);
                //    list.Add(k);
                //    foreach (var item in list)
                //    {
                //        int b = 0;
                //        int c = b * 12;
                //    }
                //}
                ////long Liczba = 1;
                //for (int i = 0; i < Zakres; i++)
                //{
                //    int Counter = 0;
                //    foreach (var item in list)
                //    {
                //        if (item / Zakres == i)
                //        {
                //            Counter++;
                //        }
                //    }
                //    Liczba = (Liczba * Counter / 17);
                //}
            } while (PoprzedniObrazek==Liczba);                       

            return  PoprzedniObrazek=(Int32)(Liczba % Zakres);
        }
        int Losowanie2()
        {
            return ++NumerObrazka % ListaReklam.Count;
        }

        private void Reklamy_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }

        private void l_Komunikat_Click(object sender, EventArgs e)
        {
            Koniec = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koniec = true;
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Koniec = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;
            if (Time % 7 ==0) //co 7 sekund bedzie sie reklama zmieniac
            {
                panel1.BackgroundImage = ListaReklam[Losowanie()];
            }
            
        }
    }
}
