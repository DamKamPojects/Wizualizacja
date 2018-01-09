namespace Projekt_Wizualizacja
{
    partial class JakDojade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panelGorny = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_AktualnaData = new System.Windows.Forms.GroupBox();
            this.l_godzina = new System.Windows.Forms.Label();
            this.l_data = new System.Windows.Forms.Label();
            this.pomoc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelKoniecWstecz = new System.Windows.Forms.Panel();
            this.pKoniecWstecz_b_Wstecz = new System.Windows.Forms.Button();
            this.pKoniecWstecz_b_Koniec = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelGorny.SuspendLayout();
            this.gb_AktualnaData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelKoniecWstecz.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 120);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1328, 630);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://jakdojade.pl/trojmiasto", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            this.webBrowser1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowser1_PreviewKeyDown);
            // 
            // panelGorny
            // 
            this.panelGorny.BackColor = System.Drawing.Color.Teal;
            this.panelGorny.Controls.Add(this.button2);
            this.panelGorny.Controls.Add(this.gb_AktualnaData);
            this.panelGorny.Controls.Add(this.pomoc);
            this.panelGorny.Controls.Add(this.pictureBox1);
            this.panelGorny.Controls.Add(this.panelKoniecWstecz);
            this.panelGorny.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGorny.Location = new System.Drawing.Point(0, 0);
            this.panelGorny.Name = "panelGorny";
            this.panelGorny.Size = new System.Drawing.Size(1328, 120);
            this.panelGorny.TabIndex = 13;
            this.panelGorny.Click += new System.EventHandler(this.panelGorny_Click);
            this.panelGorny.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGorny_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(338, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // gb_AktualnaData
            // 
            this.gb_AktualnaData.Controls.Add(this.l_godzina);
            this.gb_AktualnaData.Controls.Add(this.l_data);
            this.gb_AktualnaData.Location = new System.Drawing.Point(510, 11);
            this.gb_AktualnaData.Name = "gb_AktualnaData";
            this.gb_AktualnaData.Size = new System.Drawing.Size(320, 90);
            this.gb_AktualnaData.TabIndex = 13;
            this.gb_AktualnaData.TabStop = false;
            // 
            // l_godzina
            // 
            this.l_godzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.l_godzina.ForeColor = System.Drawing.Color.SeaShell;
            this.l_godzina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_godzina.Location = new System.Drawing.Point(11, 37);
            this.l_godzina.Name = "l_godzina";
            this.l_godzina.Size = new System.Drawing.Size(300, 40);
            this.l_godzina.TabIndex = 5;
            this.l_godzina.Text = "14:04:04";
            this.l_godzina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_godzina.Click += new System.EventHandler(this.l_godzina_Click);
            // 
            // l_data
            // 
            this.l_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.l_data.ForeColor = System.Drawing.Color.SeaShell;
            this.l_data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_data.Location = new System.Drawing.Point(14, 10);
            this.l_data.Name = "l_data";
            this.l_data.Size = new System.Drawing.Size(300, 30);
            this.l_data.TabIndex = 4;
            this.l_data.Text = "PONIEDZIAŁEK, 12.12.2012";
            this.l_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pomoc
            // 
            this.pomoc.BackColor = System.Drawing.Color.White;
            this.pomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.pomoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pomoc.Location = new System.Drawing.Point(309, 48);
            this.pomoc.Name = "pomoc";
            this.pomoc.Size = new System.Drawing.Size(180, 40);
            this.pomoc.TabIndex = 3;
            this.pomoc.Text = "Pomoc";
            this.pomoc.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.logo_zkm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(36, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 80);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelKoniecWstecz
            // 
            this.panelKoniecWstecz.Controls.Add(this.pKoniecWstecz_b_Wstecz);
            this.panelKoniecWstecz.Controls.Add(this.pKoniecWstecz_b_Koniec);
            this.panelKoniecWstecz.Location = new System.Drawing.Point(830, 10);
            this.panelKoniecWstecz.Name = "panelKoniecWstecz";
            this.panelKoniecWstecz.Size = new System.Drawing.Size(480, 130);
            this.panelKoniecWstecz.TabIndex = 14;
            this.panelKoniecWstecz.Click += new System.EventHandler(this.panelKoniecWstecz_Click);
            // 
            // pKoniecWstecz_b_Wstecz
            // 
            this.pKoniecWstecz_b_Wstecz.BackColor = System.Drawing.Color.Silver;
            this.pKoniecWstecz_b_Wstecz.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.Przycisk_wstecz;
            this.pKoniecWstecz_b_Wstecz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pKoniecWstecz_b_Wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.pKoniecWstecz_b_Wstecz.ForeColor = System.Drawing.Color.Black;
            this.pKoniecWstecz_b_Wstecz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pKoniecWstecz_b_Wstecz.Location = new System.Drawing.Point(42, 18);
            this.pKoniecWstecz_b_Wstecz.Name = "pKoniecWstecz_b_Wstecz";
            this.pKoniecWstecz_b_Wstecz.Size = new System.Drawing.Size(180, 60);
            this.pKoniecWstecz_b_Wstecz.TabIndex = 1;
            this.pKoniecWstecz_b_Wstecz.UseVisualStyleBackColor = false;
            this.pKoniecWstecz_b_Wstecz.Click += new System.EventHandler(this.pKoniecWstecz_b_Wstecz_Click);
            // 
            // pKoniecWstecz_b_Koniec
            // 
            this.pKoniecWstecz_b_Koniec.BackColor = System.Drawing.Color.Chocolate;
            this.pKoniecWstecz_b_Koniec.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.Przycisk_ZAKOŃCZ;
            this.pKoniecWstecz_b_Koniec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pKoniecWstecz_b_Koniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.pKoniecWstecz_b_Koniec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pKoniecWstecz_b_Koniec.Location = new System.Drawing.Point(257, 18);
            this.pKoniecWstecz_b_Koniec.Name = "pKoniecWstecz_b_Koniec";
            this.pKoniecWstecz_b_Koniec.Size = new System.Drawing.Size(180, 60);
            this.pKoniecWstecz_b_Koniec.TabIndex = 0;
            this.pKoniecWstecz_b_Koniec.UseVisualStyleBackColor = false;
            this.pKoniecWstecz_b_Koniec.Click += new System.EventHandler(this.pKoniecWstecz_b_Koniec_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JakDojade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 750);
            this.ControlBox = false;
            this.Controls.Add(this.panelGorny);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1334, 756);
            this.MinimumSize = new System.Drawing.Size(1334, 756);
            this.Name = "JakDojade";
            this.Load += new System.EventHandler(this.aaa_Load);
            this.panelGorny.ResumeLayout(false);
            this.gb_AktualnaData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelKoniecWstecz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panelGorny;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gb_AktualnaData;
        private System.Windows.Forms.Label l_godzina;
        private System.Windows.Forms.Label l_data;
        private System.Windows.Forms.Button pomoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelKoniecWstecz;
        private System.Windows.Forms.Button pKoniecWstecz_b_Wstecz;
        private System.Windows.Forms.Button pKoniecWstecz_b_Koniec;
        private System.Windows.Forms.Timer timer1;
    }
}