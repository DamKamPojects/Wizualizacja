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
    public partial class OknoKartyMiejskiej : Form
    {
        public OknoKartyMiejskiej()
        {
            InitializeComponent();
        }
        public bool CzyPrzylozonoKarte=false;


        private void b_Koniec_Click(object sender, EventArgs e)
        {
            CzyPrzylozonoKarte = false;
            this.Close();
        }

        private void b_Ok_Click(object sender, EventArgs e)
        {
            CzyPrzylozonoKarte = true;
            this.Close();
        }

        private void OknoKartyMiejskiej_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }
    }
}
