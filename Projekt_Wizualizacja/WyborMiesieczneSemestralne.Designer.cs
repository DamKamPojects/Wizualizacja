namespace Projekt_Wizualizacja
{
    partial class WyborMiesieczneSemestralne
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
            this.b_Miesięczne = new System.Windows.Forms.Button();
            this.l_Komunikat = new System.Windows.Forms.Label();
            this.b_Semestralny = new System.Windows.Forms.Button();
            this.b_wstecz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Miesięczne
            // 
            this.b_Miesięczne.BackColor = System.Drawing.Color.White;
            this.b_Miesięczne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_Miesięczne.Location = new System.Drawing.Point(60, 80);
            this.b_Miesięczne.Name = "b_Miesięczne";
            this.b_Miesięczne.Size = new System.Drawing.Size(180, 150);
            this.b_Miesięczne.TabIndex = 0;
            this.b_Miesięczne.Text = "Bilety miesięczne i 30-dniowe";
            this.b_Miesięczne.UseVisualStyleBackColor = false;
            this.b_Miesięczne.Click += new System.EventHandler(this.b_Miesięczne_Click);
            // 
            // l_Komunikat
            // 
            this.l_Komunikat.BackColor = System.Drawing.Color.Transparent;
            this.l_Komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Komunikat.ForeColor = System.Drawing.Color.White;
            this.l_Komunikat.Location = new System.Drawing.Point(53, 9);
            this.l_Komunikat.Name = "l_Komunikat";
            this.l_Komunikat.Size = new System.Drawing.Size(427, 60);
            this.l_Komunikat.TabIndex = 1;
            this.l_Komunikat.Text = "Wybierz rodzaj biletu:";
            this.l_Komunikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_Semestralny
            // 
            this.b_Semestralny.BackColor = System.Drawing.Color.White;
            this.b_Semestralny.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_Semestralny.Location = new System.Drawing.Point(300, 80);
            this.b_Semestralny.Name = "b_Semestralny";
            this.b_Semestralny.Size = new System.Drawing.Size(180, 150);
            this.b_Semestralny.TabIndex = 2;
            this.b_Semestralny.Text = "Bilety semestralne";
            this.b_Semestralny.UseVisualStyleBackColor = false;
            this.b_Semestralny.Click += new System.EventHandler(this.b_Semestralny_Click);
            // 
            // b_wstecz
            // 
            this.b_wstecz.BackColor = System.Drawing.Color.White;
            this.b_wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_wstecz.Location = new System.Drawing.Point(120, 260);
            this.b_wstecz.Name = "b_wstecz";
            this.b_wstecz.Size = new System.Drawing.Size(300, 80);
            this.b_wstecz.TabIndex = 3;
            this.b_wstecz.Text = "WSTECZ";
            this.b_wstecz.UseVisualStyleBackColor = false;
            this.b_wstecz.Click += new System.EventHandler(this.b_wstecz_Click);
            // 
            // WyborMiesieczneSemestralne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(544, 384);
            this.ControlBox = false;
            this.Controls.Add(this.b_wstecz);
            this.Controls.Add(this.b_Semestralny);
            this.Controls.Add(this.l_Komunikat);
            this.Controls.Add(this.b_Miesięczne);
            this.Name = "WyborMiesieczneSemestralne";
            this.Load += new System.EventHandler(this.WyborMiesieczneSemestralne_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Miesięczne;
        private System.Windows.Forms.Label l_Komunikat;
        private System.Windows.Forms.Button b_Semestralny;
        private System.Windows.Forms.Button b_wstecz;
    }
}