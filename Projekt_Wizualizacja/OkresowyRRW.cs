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
    public partial class OkresowyRRW : Form
    {
        public OkresowyRRW()
        {
            InitializeComponent();
        }

        public int wybor = 0;
        public string tekst = "na granicach ", Tekst = "";


        public void Kolorowanie()
        {
            b_zatwiedz.Enabled = true;
            b_RRW.BackColor = Color.White;
            b_RgW.BackColor = Color.White;


            if (wybor == 1) b_RRW.BackColor = Color.Green;
            if (wybor == 2) b_RgW.BackColor = Color.Green;

        }
        public string Teksty()
        {
            if (wybor == 1) Tekst = tekst + "Rumii, Redy oraz miasta Wejherowa.";
            if (wybor == 2) Tekst = tekst + "Rumii oraz gminy Wejherowo.";
            return Tekst;
        }


        private void b_zatwiedz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void b_RgW_Click(object sender, EventArgs e)
        {
            wybor = 2;
            Kolorowanie();
        }

        private void OkresowyRRW_Load(object sender, EventArgs e)
        {
            b_zatwiedz.Enabled = false;

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }

        private void b_RRW_Click(object sender, EventArgs e)
        {
            wybor = 1;
            Kolorowanie();
        }
    }
}
