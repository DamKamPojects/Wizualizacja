namespace Projekt_Wizualizacja
{
    partial class WyborKartaCzyGotowka
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_DoZaplaty = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.b_gotowka = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(774, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "rodzaj płatności:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(9, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(774, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Do zapłaty:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_DoZaplaty
            // 
            this.l_DoZaplaty.BackColor = System.Drawing.Color.Transparent;
            this.l_DoZaplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_DoZaplaty.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l_DoZaplaty.Location = new System.Drawing.Point(7, 384);
            this.l_DoZaplaty.Name = "l_DoZaplaty";
            this.l_DoZaplaty.Size = new System.Drawing.Size(774, 46);
            this.l_DoZaplaty.TabIndex = 5;
            this.l_DoZaplaty.Text = "4,20 zł.";
            this.l_DoZaplaty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.karta;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(425, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 200);
            this.button2.TabIndex = 1;
            this.button2.Text = "Karta płatnicza";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_gotowka
            // 
            this.b_gotowka.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.gotowka;
            this.b_gotowka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_gotowka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_gotowka.Location = new System.Drawing.Point(175, 120);
            this.b_gotowka.Name = "b_gotowka";
            this.b_gotowka.Size = new System.Drawing.Size(200, 200);
            this.b_gotowka.TabIndex = 0;
            this.b_gotowka.Text = "Gotówka";
            this.b_gotowka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_gotowka.UseVisualStyleBackColor = true;
            this.b_gotowka.Click += new System.EventHandler(this.b_gotowka_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.Przycisk_Anuluj1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(704, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WyborKartaCzyGotowka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_DoZaplaty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b_gotowka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WyborKartaCzyGotowka";
            this.Load += new System.EventHandler(this.WyborKartaCzyGotowka_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_gotowka;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_DoZaplaty;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}