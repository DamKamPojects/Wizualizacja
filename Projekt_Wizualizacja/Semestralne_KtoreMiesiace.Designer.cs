namespace Projekt_Wizualizacja
{
    partial class Semestralne_KtoreMiesiace
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
            this.b_letni = new System.Windows.Forms.Button();
            this.l_Komunikat = new System.Windows.Forms.Label();
            this.b_zimowy = new System.Windows.Forms.Button();
            this.b_zatwiedz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_letni
            // 
            this.b_letni.BackColor = System.Drawing.Color.White;
            this.b_letni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_letni.Location = new System.Drawing.Point(304, 103);
            this.b_letni.Name = "b_letni";
            this.b_letni.Size = new System.Drawing.Size(180, 150);
            this.b_letni.TabIndex = 5;
            this.b_letni.Text = "Bilety semestralne";
            this.b_letni.UseVisualStyleBackColor = false;
            this.b_letni.Click += new System.EventHandler(this.b_letni_Click);
            // 
            // l_Komunikat
            // 
            this.l_Komunikat.BackColor = System.Drawing.Color.Transparent;
            this.l_Komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Komunikat.ForeColor = System.Drawing.Color.White;
            this.l_Komunikat.Location = new System.Drawing.Point(64, 9);
            this.l_Komunikat.Name = "l_Komunikat";
            this.l_Komunikat.Size = new System.Drawing.Size(420, 75);
            this.l_Komunikat.TabIndex = 4;
            this.l_Komunikat.Text = "Wybierz miesiące, w którym bilet będzie ważny:";
            this.l_Komunikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_zimowy
            // 
            this.b_zimowy.BackColor = System.Drawing.Color.White;
            this.b_zimowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_zimowy.Location = new System.Drawing.Point(71, 103);
            this.b_zimowy.Name = "b_zimowy";
            this.b_zimowy.Size = new System.Drawing.Size(180, 150);
            this.b_zimowy.TabIndex = 3;
            this.b_zimowy.Text = "Bilety miesięczne i 30-dniowe";
            this.b_zimowy.UseVisualStyleBackColor = false;
            this.b_zimowy.Click += new System.EventHandler(this.b_zimowy_Click);
            // 
            // b_zatwiedz
            // 
            this.b_zatwiedz.BackColor = System.Drawing.Color.White;
            this.b_zatwiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_zatwiedz.Location = new System.Drawing.Point(136, 281);
            this.b_zatwiedz.Name = "b_zatwiedz";
            this.b_zatwiedz.Size = new System.Drawing.Size(300, 100);
            this.b_zatwiedz.TabIndex = 6;
            this.b_zatwiedz.Text = "Zatwierdź";
            this.b_zatwiedz.UseVisualStyleBackColor = false;
            this.b_zatwiedz.Click += new System.EventHandler(this.b_zatwiedź_Click);
            // 
            // Semestralne_KtoreMiesiace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(570, 393);
            this.ControlBox = false;
            this.Controls.Add(this.b_zatwiedz);
            this.Controls.Add(this.b_letni);
            this.Controls.Add(this.l_Komunikat);
            this.Controls.Add(this.b_zimowy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Semestralne_KtoreMiesiace";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Semestralne_KtoreMiesiace_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_letni;
        private System.Windows.Forms.Label l_Komunikat;
        private System.Windows.Forms.Button b_zimowy;
        private System.Windows.Forms.Button b_zatwiedz;
    }
}