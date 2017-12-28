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
    public partial class KolKom24Remover : Form
    {

        List<string> Tickets;
        List<string> TicketsShort;
        bool DRY;


        public KolKom24Remover(List<string> input, List<string> inputShort)
        {
            InitializeComponent();
            Tickets = input;
            TicketsShort = inputShort;
            foreach (var item in TicketsShort)
            {
                lstBox_Tickets.Items.Add(item);
            }
            DRY = false;
            CenterToScreen();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBox_Tickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DRY)
            {
                var result = MessageBox.Show("Czy na pewno chcesz usunąć ten rodzaj biletu?", "Potwierdź usunięcie", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int i = lstBox_Tickets.SelectedIndex;
                    Tickets.RemoveAt(i);
                    TicketsShort.RemoveAt(i);
                    DRY = true;
                    lstBox_Tickets.Items.Remove(lstBox_Tickets.SelectedItem);
                }
            }
            else DRY = false;
        }
    }
}
