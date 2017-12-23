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
    public partial class KolKomOrg : Form
    {
        public KolKomOrg()
        {
            InitializeComponent();
            T1 = null;
            T2 = null;
        }

        public string Tekst = null;
        private string T1, T2;

        private int[] buffer = new int[] { 0, 0 };

        private void b_zatwiedz_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void b_ZTM_Click(object sender, EventArgs e)
        {
            Kolorowanie(1);
        }

        private void b_MZK_G_Click(object sender, EventArgs e)
        {
            Kolorowanie(2);
        }

        private void b_MZK_W_Click(object sender, EventArgs e)
        {
            Kolorowanie(3);
        }

        private void b_SKM_Click(object sender, EventArgs e)
        {

            Kolorowanie(4);
        }

        private void b_PR_Click(object sender, EventArgs e)
        {
            Kolorowanie(5);
        }
        private void Kolorowanie(int button)
        {
            if (buffer[0] != button && buffer[0] != 0)
            {
                if (buffer[1] != button && buffer[1] != 0)
                {
                    BUnColor(buffer[0]);
                    buffer[0] = buffer[1];
                    buffer[1] = button;
                    BColor(buffer[1]);
                }
                else
                {
                    if (buffer[1] == 0)
                    {
                        buffer[1] = button;
                        BColor(buffer[1]);
                    }
                    else if (buffer[1] == button)
                    {
                        BUnColor(buffer[1]);
                        buffer[1] = 0;
                    }
                }
            }
            else
            {
                if (buffer[0] == button)
                {
                    BUnColor(button);
                    buffer[0] = buffer[1];
                    buffer[1] = 0;
                }
                else if (buffer[0]==0)
                {
                    buffer[0] = button;
                    BColor(buffer[0]);
                }
            }
        }
        
        void BColor(int button)
        {
            switch (button)
            {
                case 1:
                    b_ZTM.BackColor = Color.Green;
                    break;
                case 2:
                    b_MZK_G.BackColor = Color.Green;
                    break;
                case 3:
                    b_MZK_W.BackColor = Color.Green;
                    break;
                case 4:
                    b_SKM.BackColor = Color.Green;
                    break;
                case 5:
                    b_PR.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }
        void BUnColor(int button)
        {
            switch (button)
            {
                case 1:
                    b_ZTM.BackColor = Color.White;
                    break;
                case 2:
                    b_MZK_G.BackColor = Color.White;
                    break;
                case 3:
                    b_MZK_W.BackColor = Color.White;
                    break;
                case 4:
                    b_SKM.BackColor = Color.White;
                    break;
                case 5:
                    b_PR.BackColor = Color.White;
                    break;
                default:
                    break;
            }
        }
    }
}
