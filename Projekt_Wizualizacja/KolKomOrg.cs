using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wizualizacja01;

namespace Projekt_Wizualizacja
{
    public partial class KolKomOrg : Form
    {
        /* NOTE: Ceny powinny być klasa statyczną*/
        public KolKomOrg()
        {
            InitializeComponent();
            CenterToScreen();
            T1 = null;
            T2 = null;
        }

        public string TextToSend = null;
        public bool SendText;
        public double PriceNorm;
        public double PriceUlg;
        public string T1, T2;
        public string QuantN, QuantU;

        private Ceny_biletow Price = new Ceny_biletow();
        private int[] buffer = new int[] { 0, 0 };


        const string SKM = "SKM";
        const string ZTM = "ZTM Gdańsk";
        const string MZK_G = "ZKM Gdynia";
        const string MZK_W = "ZKM Wejherowo";
        const string PR = "PR"; // nie wiem co to za przewoźnik
        const string prefix = "\nBilet metropolitalny 24-godzinny kolejowo-komunalny dwóch organizatorów ważny dla: ";
        const string lacz = " oraz ";
        const string norm = "\n\tNormalny: ilość - ";
        const string ugl = "\n\tUlgowy: ilość - ";
        const string cena = ", cena - ";


        #region klikanie

        private void b_zatwiedz_Click(object sender, EventArgs e)
        {
            if (ButtonCheck())
            {
                SendText = true;
                Przewoznicy();
                Close();
            }
            else if(tb_U.Text=="0" && tb_N.Text=="0") MessageBox.Show("Należy wybrać przynajmniej jeden bilet dowolnego rodzaju!");
            else MessageBox.Show("Należy wybrać dwóch przewoźników!");
        }

        private void b_Anuluj_Click(object sender, EventArgs e)
        {
            SendText = false;
            Close();
        }
        #region nudy
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

        private void btn_PN_Click(object sender, EventArgs e)
        {
            Plus(tb_N);
        }

        private void btn_PU_Click(object sender, EventArgs e)
        {
            Plus(tb_U);
        }

        private void btn_MN_Click(object sender, EventArgs e)
        {
            Minus(tb_N);
        }

        private void btn_MU_Click(object sender, EventArgs e)
        {
            Minus(tb_U);
        }
        #endregion
        #endregion

        #region Metody

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

        void Plus(TextBox tb)
        {
            tb.Text = (Convert.ToInt32(tb.Text) + 1).ToString();
        }
        void Minus(TextBox tb)
        {
            if (Convert.ToInt32(tb.Text) - 1 >= 0) tb.Text = (Convert.ToInt32(tb.Text) - 1).ToString();
            else tb.Text = "0";
        }
        private void tb_N_Click(object sender, EventArgs e)
        {
            GetKeyboard(tb_N, Price.MetroKolKom24_2);
        }
        private void tb_U_Click(object sender, EventArgs e)
        {
            GetKeyboard(tb_U, Price.MetroKolKom24_2/2);
        }
        void GetKeyboard(TextBox tb, double price)
        {
            string input = tb.Text;
            Klawiatura kl = new Klawiatura(tb.Text, price);
            kl.ShowDialog();
            while (!kl.closed)
            {
            }
            if (kl.take) tb.Text = kl.TBil_bil.Text;
        }

        void Przewoznicy()
        {
            T1 = GetPrzewoznik(buffer[0]);
            T2 = GetPrzewoznik(buffer[1]);
            QuantN = tb_N.Text;
            QuantU = tb_U.Text;
            PriceNorm = Convert.ToInt32(tb_N.Text) * Price.MetroKolKom24_2;
            PriceUlg = Convert.ToInt32(tb_U.Text) * Price.MetroKolKom24_2 / 2;
            if (tb_N.Text!="0" && tb_U.Text!="0") TextToSend = prefix + T1 + lacz + T2 + norm + QuantN + cena + String.Format("{0:0.00} zł", PriceNorm) + ugl + QuantU + cena + String.Format("{0:0.00} zł", PriceUlg);
            if (tb_N.Text!="0" && tb_U.Text=="0") TextToSend = prefix + T1 + lacz + T2 + norm + QuantN  + cena + String.Format("{0:0.00} zł", PriceNorm);
            if (tb_N.Text=="0" && tb_U.Text!="0") TextToSend = prefix + T1 + lacz + T2 + ugl + QuantU + cena + String.Format("{0:0.00} zł", PriceUlg);
        }
        string GetPrzewoznik(int input)
        {
            switch (input)
            {
                case 1: return ZTM;
                case 2: return MZK_G;
                case 3: return MZK_W;
                case 4: return SKM;
                case 5: return PR;
                default: return "Blad";
            }
        }
        bool ButtonCheck()
        {
            if (buffer.Contains(0)) return false;
            else if (tb_N.Text == "0" && tb_U.Text == "0") return false;
            else return true;
        }

        #endregion
    }
}
