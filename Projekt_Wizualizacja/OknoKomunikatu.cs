﻿using System;
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
    public partial class OknoKomunikatu : Form
    {
        List<string> komunikaty = new List<string>();
        int index = 0;
        public OknoKomunikatu()
        {
            InitializeComponent();
        }
        public OknoKomunikatu(string komunikat)
        {
            InitializeComponent();
            komunikaty.Add(komunikat);
            //l_Komunikat.Text = komunikat;
        }
        public OknoKomunikatu(List<string> lista)
        {
            InitializeComponent();
            komunikaty = lista;
        }

        public void ZmianaKomunikatow()
        {
            
            if (index>=komunikaty.Count)
            {
                this.Close();
            }
            else             l_Komunikat.Text = komunikaty[index];
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            index++;
            ZmianaKomunikatow();
            
        }

        private void OknoKomunikatu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            ZmianaKomunikatow();
        }
    }
}
