namespace Projekt_Wizualizacja
{
    partial class OknoKartyMiejskiej
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
            this.b_Koniec = new System.Windows.Forms.Button();
            this.l_Komunikat = new System.Windows.Forms.Label();
            this.b_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Koniec
            // 
            this.b_Koniec.BackColor = System.Drawing.Color.White;
            this.b_Koniec.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.Przycisk_Anuluj1;
            this.b_Koniec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Koniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_Koniec.Location = new System.Drawing.Point(474, 0);
            this.b_Koniec.Name = "b_Koniec";
            this.b_Koniec.Size = new System.Drawing.Size(70, 70);
            this.b_Koniec.TabIndex = 1;
            this.b_Koniec.UseVisualStyleBackColor = false;
            this.b_Koniec.Click += new System.EventHandler(this.b_Koniec_Click);
            // 
            // l_Komunikat
            // 
            this.l_Komunikat.BackColor = System.Drawing.Color.Transparent;
            this.l_Komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Komunikat.ForeColor = System.Drawing.Color.White;
            this.l_Komunikat.Location = new System.Drawing.Point(70, 70);
            this.l_Komunikat.Name = "l_Komunikat";
            this.l_Komunikat.Size = new System.Drawing.Size(400, 160);
            this.l_Komunikat.TabIndex = 2;
            this.l_Komunikat.Text = "Proszę przyłożyć kartę miejską do biletomatu.";
            this.l_Komunikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_Ok
            // 
            this.b_Ok.BackColor = System.Drawing.Color.White;
            this.b_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_Ok.Location = new System.Drawing.Point(3, 0);
            this.b_Ok.Name = "b_Ok";
            this.b_Ok.Size = new System.Drawing.Size(157, 36);
            this.b_Ok.TabIndex = 3;
            this.b_Ok.Text = "(Przykładam kartę miejską)";
            this.b_Ok.UseVisualStyleBackColor = false;
            this.b_Ok.Click += new System.EventHandler(this.b_Ok_Click);
            // 
            // OknoKartyMiejskiej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(544, 284);
            this.ControlBox = false;
            this.Controls.Add(this.b_Ok);
            this.Controls.Add(this.l_Komunikat);
            this.Controls.Add(this.b_Koniec);
            this.Name = "OknoKartyMiejskiej";
            this.Load += new System.EventHandler(this.OknoKartyMiejskiej_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button b_Koniec;
        public System.Windows.Forms.Button b_Ok;
        public System.Windows.Forms.Label l_Komunikat;
    }
}