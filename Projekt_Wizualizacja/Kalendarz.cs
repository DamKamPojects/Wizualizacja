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
    public partial class Kalendarz : Form
    {
        public Kalendarz()
        {
            InitializeComponent();
        }


        private void GetCurrentTime()
        {
            DateTime thisDay = DateTime.Now;
            //http://www.csharp-examples.net/string-format-datetime/
            //data + godzina aktualna
            //string Time = "Dziś jest "  + thisDay.ToString("D") + Environment.NewLine + "Aktualna godzina:\n" + Environment.NewLine+ thisDay.ToString(" HH:mm:ss");
            //aktualna godzina
            //string Time = "Aktualna godzina:\n" + Environment.NewLine + thisDay.ToString(" HH:mm:ss");
            string dzien = (thisDay.ToString("dddd")).ToUpper();
            l_data.Text = dzien + ", " + thisDay.ToString("dd.MM.yyyy");
            //l_godzina.Text = thisDay.ToString("HH:mm:ss");
        } //moetoda pobierajaca aktualną datę

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetCurrentTime();
        }

        private void Kalendarz_Load(object sender, EventArgs e)
        {
            GetCurrentTime();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            ObslugaKalendarza();
        }

        int ZnajdzIleDniMaMiesiac(int year, int month)
        {
            int dayNumber = 28;
            for (int i = 28; i < 33; i++)
            {
                try
                {
                    DateTime xx = new DateTime(year, month, i);
                }
                catch (Exception)
                {                    
                    return i - 1;
                }
            }
            
            return 0;
        }

        private void ObslugaKalendarza()
        {
            DateTime thisDay = DateTime.Now; //pobiera aktualna date
            
            int Day = Convert.ToInt32(String.Format("{0:dd}", thisDay).TrimStart('0'));
            int Month = Convert.ToInt32((String.Format("{0:MM}", thisDay).TrimStart('0')));            
            int Year = Convert.ToInt32((String.Format("{0:yyyy}", thisDay).TrimStart('0')));
            DateTime FirstDay = new DateTime(Year, Month, Day);


            DateTime LastDay = new DateTime(Year, Month+1, (Day+29) % ZnajdzIleDniMaMiesiac(Year,Month));
            Calendar.TodayDate = FirstDay;
            Calendar.MinDate = FirstDay;
            Calendar.MaxDate = LastDay;     
            
        }

    }
}
