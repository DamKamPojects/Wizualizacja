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
    }
}
