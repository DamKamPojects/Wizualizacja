namespace Projekt_Wizualizacja
{
    partial class OknoKomunikatu
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
            this.b_OK = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_koniec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Komunikat
            // 
            this.l_Komunikat.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_Komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Komunikat.ForeColor = System.Drawing.Color.White;
            this.l_Komunikat.Location = new System.Drawing.Point(0, 0);
            this.l_Komunikat.Name = "l_Komunikat";
            this.l_Komunikat.Size = new System.Drawing.Size(684, 386);
            this.l_Komunikat.TabIndex = 0;
            this.l_Komunikat.Text = "Jakiś komunikat";
            this.l_Komunikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_Komunikat.Click += new System.EventHandler(this.l_Komunikat_Click);
            // 
            // b_OK
            // 
            this.b_OK.BackColor = System.Drawing.Color.White;
            this.b_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_OK.Location = new System.Drawing.Point(120, 220);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(458, 100);
            this.b_OK.TabIndex = 1;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = false;
            this.b_OK.Visible = false;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b_koniec
            // 
            this.b_koniec.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.Przycisk_Anuluj1;
            this.b_koniec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_koniec.Location = new System.Drawing.Point(609, 0);
            this.b_koniec.Name = "b_koniec";
            this.b_koniec.Size = new System.Drawing.Size(75, 75);
            this.b_koniec.TabIndex = 2;
            this.b_koniec.UseVisualStyleBackColor = true;
            this.b_koniec.Visible = false;
            this.b_koniec.Click += new System.EventHandler(this.b_koniec_Click);
            // 
            // OknoKomunikatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(684, 384);
            this.ControlBox = false;
            this.Controls.Add(this.b_koniec);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.l_Komunikat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OknoKomunikatu";
            this.Load += new System.EventHandler(this.OknoKomunikatu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label l_Komunikat;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_koniec;
    }
}