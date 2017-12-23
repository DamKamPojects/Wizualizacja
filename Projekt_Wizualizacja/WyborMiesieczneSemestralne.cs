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
    public partial class WyborMiesieczneSemestralne : Form
    {
        public WyborMiesieczneSemestralne()
        {
            InitializeComponent();
        }

        public int RodzajWybranegobiletu = 0;        
        private void b_wstecz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_Semestralny_Click(object sender, EventArgs e)
        {
            RodzajWybranegobiletu = 2;
            this.Close();
        }

        private void b_Miesięczne_Click(object sender, EventArgs e)
        {
            RodzajWybranegobiletu = 1;
            
            this.Close();
        }

        private void WyborMiesieczneSemestralne_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }
    }
}
