﻿namespace Projekt_Wizualizacja
{
    partial class Podsumowanie
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
            this.panelGorny = new System.Windows.Forms.Panel();
            this.gb_AktualnaData = new System.Windows.Forms.GroupBox();
            this.l_godzina = new System.Windows.Forms.Label();
            this.l_data = new System.Windows.Forms.Label();
            this.pb_postep = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPodsum_tb_Podsumowanie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pPodsu = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.l_SposPaltnosci = new System.Windows.Forms.Label();
            this.panelPodsumowanie_tb_SposobPlatnosci = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.l_doZaplaty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPodsumowanie_tb_Suma = new System.Windows.Forms.TextBox();
            this.pPodsu_b_ZmienPlactnosci = new System.Windows.Forms.Button();
            this.pPodsu_b_Potwierdz = new System.Windows.Forms.Button();
            this.pGotow = new System.Windows.Forms.Panel();
            this.pGotow_b_50gr = new System.Windows.Forms.Button();
            this.pGotow_b_2zl = new System.Windows.Forms.Button();
            this.pGotow_b_20zl = new System.Windows.Forms.Button();
            this.pGotow_b_5zl = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pGotow_l_DoZaplaty = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pGotowka_gb_Pobrano = new System.Windows.Forms.GroupBox();
            this.pGotowka_l_Pobrano = new System.Windows.Forms.Label();
            this.pGotowka_l_pobrrr = new System.Windows.Forms.Label();
            this.pGotow_tb_Podsumowanie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.l_postep = new System.Windows.Forms.Label();
            this.pKoniecWstecz_b_Wstecz = new System.Windows.Forms.Button();
            this.pKoniecWstecz_b_Koniec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGorny.SuspendLayout();
            this.gb_AktualnaData.SuspendLayout();
            this.pPodsu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pGotow.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pGotowka_gb_Pobrano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGorny
            // 
            this.panelGorny.BackColor = System.Drawing.Color.Transparent;
            this.panelGorny.Controls.Add(this.pKoniecWstecz_b_Wstecz);
            this.panelGorny.Controls.Add(this.pKoniecWstecz_b_Koniec);
            this.panelGorny.Controls.Add(this.gb_AktualnaData);
            this.panelGorny.Controls.Add(this.pictureBox1);
            this.panelGorny.Location = new System.Drawing.Point(-1, 1);
            this.panelGorny.Name = "panelGorny";
            this.panelGorny.Size = new System.Drawing.Size(1312, 140);
            this.panelGorny.TabIndex = 13;
            this.panelGorny.Click += new System.EventHandler(this.panelGorny_Click);
            this.panelGorny.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGorny_Paint);
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
            // pb_postep
            // 
            this.pb_postep.BackColor = System.Drawing.Color.White;
            this.pb_postep.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.pb_postep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pb_postep.Location = new System.Drawing.Point(546, 714);
            this.pb_postep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_postep.Maximum = 120;
            this.pb_postep.Name = "pb_postep";
            this.pb_postep.Size = new System.Drawing.Size(162, 25);
            this.pb_postep.Step = 1;
            this.pb_postep.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelPodsum_tb_Podsumowanie
            // 
            this.panelPodsum_tb_Podsumowanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPodsum_tb_Podsumowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.panelPodsum_tb_Podsumowanie.Location = new System.Drawing.Point(93, 49);
            this.panelPodsum_tb_Podsumowanie.Multiline = true;
            this.panelPodsum_tb_Podsumowanie.Name = "panelPodsum_tb_Podsumowanie";
            this.panelPodsum_tb_Podsumowanie.ReadOnly = true;
            this.panelPodsum_tb_Podsumowanie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.panelPodsum_tb_Podsumowanie.Size = new System.Drawing.Size(661, 455);
            this.panelPodsum_tb_Podsumowanie.TabIndex = 270;
            this.panelPodsum_tb_Podsumowanie.Text = "Nie wybrano żadnego biletu.";
            this.panelPodsum_tb_Podsumowanie.Click += new System.EventHandler(this.panelPodsum_tb_Podsumowanie_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 37);
            this.label2.TabIndex = 276;
            this.label2.Text = "Sposób płatności:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 37);
            this.label1.TabIndex = 275;
            this.label1.Text = "PODSUMOWANIE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pPodsu
            // 
            this.pPodsu.BackColor = System.Drawing.Color.Transparent;
            this.pPodsu.Controls.Add(this.groupBox3);
            this.pPodsu.Controls.Add(this.groupBox2);
            this.pPodsu.Controls.Add(this.pPodsu_b_ZmienPlactnosci);
            this.pPodsu.Controls.Add(this.pPodsu_b_Potwierdz);
            this.pPodsu.Controls.Add(this.panelPodsum_tb_Podsumowanie);
            this.pPodsu.Controls.Add(this.label1);
            this.pPodsu.Location = new System.Drawing.Point(0, 140);
            this.pPodsu.Name = "pPodsu";
            this.pPodsu.Size = new System.Drawing.Size(1312, 611);
            this.pPodsu.TabIndex = 34;
            this.pPodsu.Click += new System.EventHandler(this.pPodsu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.l_SposPaltnosci);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.panelPodsumowanie_tb_SposobPlatnosci);
            this.groupBox3.Location = new System.Drawing.Point(1004, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 100);
            this.groupBox3.TabIndex = 282;
            this.groupBox3.TabStop = false;
            // 
            // l_SposPaltnosci
            // 
            this.l_SposPaltnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_SposPaltnosci.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l_SposPaltnosci.Location = new System.Drawing.Point(0, 50);
            this.l_SposPaltnosci.Name = "l_SposPaltnosci";
            this.l_SposPaltnosci.Size = new System.Drawing.Size(230, 40);
            this.l_SposPaltnosci.TabIndex = 280;
            this.l_SposPaltnosci.Text = "Karta płatnicza";
            this.l_SposPaltnosci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_SposPaltnosci.Click += new System.EventHandler(this.l_SposPaltnosci_Click);
            // 
            // panelPodsumowanie_tb_SposobPlatnosci
            // 
            this.panelPodsumowanie_tb_SposobPlatnosci.BackColor = System.Drawing.SystemColors.Control;
            this.panelPodsumowanie_tb_SposobPlatnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelPodsumowanie_tb_SposobPlatnosci.Location = new System.Drawing.Point(26, 46);
            this.panelPodsumowanie_tb_SposobPlatnosci.Multiline = true;
            this.panelPodsumowanie_tb_SposobPlatnosci.Name = "panelPodsumowanie_tb_SposobPlatnosci";
            this.panelPodsumowanie_tb_SposobPlatnosci.ReadOnly = true;
            this.panelPodsumowanie_tb_SposobPlatnosci.Size = new System.Drawing.Size(200, 40);
            this.panelPodsumowanie_tb_SposobPlatnosci.TabIndex = 273;
            this.panelPodsumowanie_tb_SposobPlatnosci.Text = "Karta płatnicza";
            this.panelPodsumowanie_tb_SposobPlatnosci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelPodsumowanie_tb_SposobPlatnosci.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l_doZaplaty);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panelPodsumowanie_tb_Suma);
            this.groupBox2.Location = new System.Drawing.Point(800, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 100);
            this.groupBox2.TabIndex = 281;
            this.groupBox2.TabStop = false;
            // 
            // l_doZaplaty
            // 
            this.l_doZaplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_doZaplaty.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l_doZaplaty.Location = new System.Drawing.Point(0, 50);
            this.l_doZaplaty.Name = "l_doZaplaty";
            this.l_doZaplaty.Size = new System.Drawing.Size(150, 40);
            this.l_doZaplaty.TabIndex = 279;
            this.l_doZaplaty.Text = "10,00 zł";
            this.l_doZaplaty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_doZaplaty.Click += new System.EventHandler(this.l_doZaplaty_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 37);
            this.label3.TabIndex = 278;
            this.label3.Text = "Do zapłaty:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelPodsumowanie_tb_Suma
            // 
            this.panelPodsumowanie_tb_Suma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPodsumowanie_tb_Suma.BackColor = System.Drawing.SystemColors.Control;
            this.panelPodsumowanie_tb_Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.panelPodsumowanie_tb_Suma.Location = new System.Drawing.Point(15, 74);
            this.panelPodsumowanie_tb_Suma.Multiline = true;
            this.panelPodsumowanie_tb_Suma.Name = "panelPodsumowanie_tb_Suma";
            this.panelPodsumowanie_tb_Suma.ReadOnly = true;
            this.panelPodsumowanie_tb_Suma.Size = new System.Drawing.Size(127, 11);
            this.panelPodsumowanie_tb_Suma.TabIndex = 268;
            this.panelPodsumowanie_tb_Suma.Text = "10";
            this.panelPodsumowanie_tb_Suma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelPodsumowanie_tb_Suma.Visible = false;
            // 
            // pPodsu_b_ZmienPlactnosci
            // 
            this.pPodsu_b_ZmienPlactnosci.BackColor = System.Drawing.Color.White;
            this.pPodsu_b_ZmienPlactnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pPodsu_b_ZmienPlactnosci.Location = new System.Drawing.Point(890, 186);
            this.pPodsu_b_ZmienPlactnosci.Name = "pPodsu_b_ZmienPlactnosci";
            this.pPodsu_b_ZmienPlactnosci.Size = new System.Drawing.Size(233, 120);
            this.pPodsu_b_ZmienPlactnosci.TabIndex = 274;
            this.pPodsu_b_ZmienPlactnosci.Text = "Zmień sposób płatności";
            this.pPodsu_b_ZmienPlactnosci.UseVisualStyleBackColor = false;
            this.pPodsu_b_ZmienPlactnosci.Click += new System.EventHandler(this.pPodsu_b_ZmienPlactnosci_Click);
            // 
            // pPodsu_b_Potwierdz
            // 
            this.pPodsu_b_Potwierdz.BackColor = System.Drawing.Color.White;
            this.pPodsu_b_Potwierdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pPodsu_b_Potwierdz.Location = new System.Drawing.Point(800, 380);
            this.pPodsu_b_Potwierdz.Name = "pPodsu_b_Potwierdz";
            this.pPodsu_b_Potwierdz.Size = new System.Drawing.Size(434, 120);
            this.pPodsu_b_Potwierdz.TabIndex = 272;
            this.pPodsu_b_Potwierdz.Text = "POTWIERDŹ";
            this.pPodsu_b_Potwierdz.UseVisualStyleBackColor = false;
            this.pPodsu_b_Potwierdz.Click += new System.EventHandler(this.pPodsu_b_Potwiedz_Click);
            // 
            // pGotow
            // 
            this.pGotow.BackColor = System.Drawing.Color.Transparent;
            this.pGotow.Controls.Add(this.pGotow_b_50gr);
            this.pGotow.Controls.Add(this.pGotow_b_2zl);
            this.pGotow.Controls.Add(this.pGotow_b_20zl);
            this.pGotow.Controls.Add(this.pGotow_b_5zl);
            this.pGotow.Controls.Add(this.label8);
            this.pGotow.Controls.Add(this.label6);
            this.pGotow.Controls.Add(this.label7);
            this.pGotow.Controls.Add(this.label5);
            this.pGotow.Controls.Add(this.label9);
            this.pGotow.Controls.Add(this.groupBox1);
            this.pGotow.Controls.Add(this.pGotowka_gb_Pobrano);
            this.pGotow.Controls.Add(this.pGotow_tb_Podsumowanie);
            this.pGotow.Controls.Add(this.label4);
            this.pGotow.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.pGotow.Location = new System.Drawing.Point(0, 140);
            this.pGotow.Name = "pGotow";
            this.pGotow.Size = new System.Drawing.Size(1312, 650);
            this.pGotow.TabIndex = 36;
            this.pGotow.Click += new System.EventHandler(this.pGotow_Click);
            // 
            // pGotow_b_50gr
            // 
            this.pGotow_b_50gr.Location = new System.Drawing.Point(12, 443);
            this.pGotow_b_50gr.Name = "pGotow_b_50gr";
            this.pGotow_b_50gr.Size = new System.Drawing.Size(40, 40);
            this.pGotow_b_50gr.TabIndex = 287;
            this.pGotow_b_50gr.Text = "50 gr";
            this.pGotow_b_50gr.UseVisualStyleBackColor = true;
            this.pGotow_b_50gr.Click += new System.EventHandler(this.pGotow_b_50gr_Click);
            // 
            // pGotow_b_2zl
            // 
            this.pGotow_b_2zl.Location = new System.Drawing.Point(12, 390);
            this.pGotow_b_2zl.Name = "pGotow_b_2zl";
            this.pGotow_b_2zl.Size = new System.Drawing.Size(40, 40);
            this.pGotow_b_2zl.TabIndex = 286;
            this.pGotow_b_2zl.Text = "2 zł";
            this.pGotow_b_2zl.UseVisualStyleBackColor = true;
            this.pGotow_b_2zl.Click += new System.EventHandler(this.pGotow_b_2zl_Click);
            // 
            // pGotow_b_20zl
            // 
            this.pGotow_b_20zl.Location = new System.Drawing.Point(12, 285);
            this.pGotow_b_20zl.Name = "pGotow_b_20zl";
            this.pGotow_b_20zl.Size = new System.Drawing.Size(40, 40);
            this.pGotow_b_20zl.TabIndex = 285;
            this.pGotow_b_20zl.Text = "20 zł";
            this.pGotow_b_20zl.UseVisualStyleBackColor = true;
            this.pGotow_b_20zl.Click += new System.EventHandler(this.pGotow_b_20zl_Click);
            // 
            // pGotow_b_5zl
            // 
            this.pGotow_b_5zl.Location = new System.Drawing.Point(12, 341);
            this.pGotow_b_5zl.Name = "pGotow_b_5zl";
            this.pGotow_b_5zl.Size = new System.Drawing.Size(40, 40);
            this.pGotow_b_5zl.TabIndex = 284;
            this.pGotow_b_5zl.Text = "5 zł";
            this.pGotow_b_5zl.UseVisualStyleBackColor = true;
            this.pGotow_b_5zl.Click += new System.EventHandler(this.pGotow_b_5zl_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(93, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(661, 41);
            this.label8.TabIndex = 283;
            this.label8.Text = "PROSZĘ ZAPŁAĆ ZA BILET";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(861, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 20);
            this.label6.TabIndex = 282;
            this.label6.Text = "10zł, 20zł";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(861, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 37);
            this.label7.TabIndex = 281;
            this.label7.Text = "Banknoty";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(861, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 56);
            this.label5.TabIndex = 280;
            this.label5.Text = "5gr, 10gr, 20gr, 50gr,\r\n1zł, 2zł, 5zł";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(861, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 37);
            this.label9.TabIndex = 279;
            this.label9.Text = "Monety:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pGotow_l_DoZaplaty);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(861, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 152);
            this.groupBox1.TabIndex = 278;
            this.groupBox1.TabStop = false;
            // 
            // pGotow_l_DoZaplaty
            // 
            this.pGotow_l_DoZaplaty.BackColor = System.Drawing.Color.Transparent;
            this.pGotow_l_DoZaplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pGotow_l_DoZaplaty.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pGotow_l_DoZaplaty.Location = new System.Drawing.Point(-3, 77);
            this.pGotow_l_DoZaplaty.Name = "pGotow_l_DoZaplaty";
            this.pGotow_l_DoZaplaty.Size = new System.Drawing.Size(307, 44);
            this.pGotow_l_DoZaplaty.TabIndex = 277;
            this.pGotow_l_DoZaplaty.Text = "0,00 zł";
            this.pGotow_l_DoZaplaty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pGotow_l_DoZaplaty.Click += new System.EventHandler(this.pGotow_l_DoZaplaty_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(2, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(302, 46);
            this.label11.TabIndex = 276;
            this.label11.Text = "Do zapłaty:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pGotowka_gb_Pobrano
            // 
            this.pGotowka_gb_Pobrano.Controls.Add(this.pGotowka_l_Pobrano);
            this.pGotowka_gb_Pobrano.Controls.Add(this.pGotowka_l_pobrrr);
            this.pGotowka_gb_Pobrano.Location = new System.Drawing.Point(861, 341);
            this.pGotowka_gb_Pobrano.Name = "pGotowka_gb_Pobrano";
            this.pGotowka_gb_Pobrano.Size = new System.Drawing.Size(304, 152);
            this.pGotowka_gb_Pobrano.TabIndex = 277;
            this.pGotowka_gb_Pobrano.TabStop = false;
            // 
            // pGotowka_l_Pobrano
            // 
            this.pGotowka_l_Pobrano.BackColor = System.Drawing.Color.Transparent;
            this.pGotowka_l_Pobrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pGotowka_l_Pobrano.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pGotowka_l_Pobrano.Location = new System.Drawing.Point(-3, 77);
            this.pGotowka_l_Pobrano.Name = "pGotowka_l_Pobrano";
            this.pGotowka_l_Pobrano.Size = new System.Drawing.Size(307, 44);
            this.pGotowka_l_Pobrano.TabIndex = 277;
            this.pGotowka_l_Pobrano.Text = "0,00 zł";
            this.pGotowka_l_Pobrano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pGotowka_l_Pobrano.Click += new System.EventHandler(this.pGotowka_l_Pobrano_Click);
            // 
            // pGotowka_l_pobrrr
            // 
            this.pGotowka_l_pobrrr.BackColor = System.Drawing.Color.Transparent;
            this.pGotowka_l_pobrrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pGotowka_l_pobrrr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pGotowka_l_pobrrr.Location = new System.Drawing.Point(2, 16);
            this.pGotowka_l_pobrrr.Name = "pGotowka_l_pobrrr";
            this.pGotowka_l_pobrrr.Size = new System.Drawing.Size(302, 46);
            this.pGotowka_l_pobrrr.TabIndex = 276;
            this.pGotowka_l_pobrrr.Text = "Pobrano:";
            this.pGotowka_l_pobrrr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pGotowka_l_pobrrr.Click += new System.EventHandler(this.pGotowka_l_pobrrr_Click);
            // 
            // pGotow_tb_Podsumowanie
            // 
            this.pGotow_tb_Podsumowanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGotow_tb_Podsumowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pGotow_tb_Podsumowanie.Location = new System.Drawing.Point(93, 49);
            this.pGotow_tb_Podsumowanie.Multiline = true;
            this.pGotow_tb_Podsumowanie.Name = "pGotow_tb_Podsumowanie";
            this.pGotow_tb_Podsumowanie.ReadOnly = true;
            this.pGotow_tb_Podsumowanie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pGotow_tb_Podsumowanie.Size = new System.Drawing.Size(661, 455);
            this.pGotow_tb_Podsumowanie.TabIndex = 270;
            this.pGotow_tb_Podsumowanie.Text = "Nie wybrano żadnego biletu.";
            this.pGotow_tb_Podsumowanie.Click += new System.EventHandler(this.pGotow_tb_Podsumowanie_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(93, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(706, 37);
            this.label4.TabIndex = 275;
            this.label4.Text = "PODSUMOWANIE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_postep
            // 
            this.l_postep.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.l_postep.BackColor = System.Drawing.Color.Transparent;
            this.l_postep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l_postep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_postep.Location = new System.Drawing.Point(21, 687);
            this.l_postep.Name = "l_postep";
            this.l_postep.Size = new System.Drawing.Size(1214, 25);
            this.l_postep.TabIndex = 37;
            this.l_postep.Text = "Pozostały czas na wykonanie transakcji";
            this.l_postep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pKoniecWstecz_b_Wstecz
            // 
            this.pKoniecWstecz_b_Wstecz.BackColor = System.Drawing.Color.White;
            this.pKoniecWstecz_b_Wstecz.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.Przycisk_wstecz;
            this.pKoniecWstecz_b_Wstecz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pKoniecWstecz_b_Wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.pKoniecWstecz_b_Wstecz.ForeColor = System.Drawing.Color.Black;
            this.pKoniecWstecz_b_Wstecz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pKoniecWstecz_b_Wstecz.Location = new System.Drawing.Point(873, 28);
            this.pKoniecWstecz_b_Wstecz.Name = "pKoniecWstecz_b_Wstecz";
            this.pKoniecWstecz_b_Wstecz.Size = new System.Drawing.Size(180, 60);
            this.pKoniecWstecz_b_Wstecz.TabIndex = 3;
            this.pKoniecWstecz_b_Wstecz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pKoniecWstecz_b_Wstecz.UseVisualStyleBackColor = false;
            this.pKoniecWstecz_b_Wstecz.Click += new System.EventHandler(this.pKoniecWstecz_b_Wstecz_Click);
            // 
            // pKoniecWstecz_b_Koniec
            // 
            this.pKoniecWstecz_b_Koniec.BackColor = System.Drawing.Color.White;
            this.pKoniecWstecz_b_Koniec.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.Przycisk_ZAKOŃCZ;
            this.pKoniecWstecz_b_Koniec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pKoniecWstecz_b_Koniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.pKoniecWstecz_b_Koniec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pKoniecWstecz_b_Koniec.Location = new System.Drawing.Point(1091, 28);
            this.pKoniecWstecz_b_Koniec.Name = "pKoniecWstecz_b_Koniec";
            this.pKoniecWstecz_b_Koniec.Size = new System.Drawing.Size(180, 60);
            this.pKoniecWstecz_b_Koniec.TabIndex = 2;
            this.pKoniecWstecz_b_Koniec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pKoniecWstecz_b_Koniec.UseVisualStyleBackColor = false;
            this.pKoniecWstecz_b_Koniec.Click += new System.EventHandler(this.pKoniecWstecz_b_Koniec_Click);
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
            // Podsumowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1328, 750);
            this.ControlBox = false;
            this.Controls.Add(this.l_postep);
            this.Controls.Add(this.pb_postep);
            this.Controls.Add(this.panelGorny);
            this.Controls.Add(this.pPodsu);
            this.Controls.Add(this.pGotow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Podsumowanie";
            this.Load += new System.EventHandler(this.Podsumowanie_Load);
            this.panelGorny.ResumeLayout(false);
            this.gb_AktualnaData.ResumeLayout(false);
            this.pPodsu.ResumeLayout(false);
            this.pPodsu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pGotow.ResumeLayout(false);
            this.pGotow.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pGotowka_gb_Pobrano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGorny;
        private System.Windows.Forms.GroupBox gb_AktualnaData;
        private System.Windows.Forms.Label l_godzina;
        private System.Windows.Forms.Label l_data;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ProgressBar pb_postep;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox panelPodsum_tb_Podsumowanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pPodsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pPodsu_b_ZmienPlactnosci;
        public System.Windows.Forms.TextBox panelPodsumowanie_tb_SposobPlatnosci;
        private System.Windows.Forms.Button pPodsu_b_Potwierdz;
        public System.Windows.Forms.TextBox panelPodsumowanie_tb_Suma;
        private System.Windows.Forms.Panel pGotow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pGotow_l_DoZaplaty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox pGotowka_gb_Pobrano;
        private System.Windows.Forms.Label pGotowka_l_Pobrano;
        private System.Windows.Forms.Label pGotowka_l_pobrrr;
        public System.Windows.Forms.TextBox pGotow_tb_Podsumowanie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pGotow_b_50gr;
        private System.Windows.Forms.Button pGotow_b_2zl;
        private System.Windows.Forms.Button pGotow_b_20zl;
        private System.Windows.Forms.Button pGotow_b_5zl;
        private System.Windows.Forms.Label l_postep;
        private System.Windows.Forms.Button pKoniecWstecz_b_Wstecz;
        private System.Windows.Forms.Button pKoniecWstecz_b_Koniec;
        private System.Windows.Forms.Label l_SposPaltnosci;
        private System.Windows.Forms.Label l_doZaplaty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}