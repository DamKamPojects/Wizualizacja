namespace Projekt_Wizualizacja
{
    partial class Reklamy
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
            this.l_Komunikat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // l_Komunikat
            // 
            this.l_Komunikat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.l_Komunikat.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_Komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Komunikat.Location = new System.Drawing.Point(0, 0);
            this.l_Komunikat.Name = "l_Komunikat";
            this.l_Komunikat.Size = new System.Drawing.Size(1312, 100);
            this.l_Komunikat.TabIndex = 0;
            this.l_Komunikat.Text = "Dotknij ekranu aby przejść do zakupu biletów";
            this.l_Komunikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_Komunikat.Click += new System.EventHandler(this.l_Komunikat_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.reklama6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 650);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Reklamy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 750);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l_Komunikat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reklamy";
            this.Load += new System.EventHandler(this.Reklamy_Load);
            this.Click += new System.EventHandler(this.Reklamy_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_Komunikat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}