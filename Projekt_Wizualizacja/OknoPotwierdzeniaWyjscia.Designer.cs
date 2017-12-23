namespace Projekt_Wizualizacja
{
    partial class OknoPotwierdzeniaWyjscia
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
            this.l_Ostrzezenie = new System.Windows.Forms.Label();
            this.b_Tak = new System.Windows.Forms.Button();
            this.b_Nie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Ostrzezenie
            // 
            this.l_Ostrzezenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Ostrzezenie.Location = new System.Drawing.Point(0, 0);
            this.l_Ostrzezenie.Name = "l_Ostrzezenie";
            this.l_Ostrzezenie.Size = new System.Drawing.Size(680, 150);
            this.l_Ostrzezenie.TabIndex = 0;
            this.l_Ostrzezenie.Text = "Jesteś pewny że chcesz anulować transakcję?";
            this.l_Ostrzezenie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_Tak
            // 
            this.b_Tak.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_Tak.ForeColor = System.Drawing.Color.Red;
            this.b_Tak.Location = new System.Drawing.Point(60, 150);
            this.b_Tak.Name = "b_Tak";
            this.b_Tak.Size = new System.Drawing.Size(200, 80);
            this.b_Tak.TabIndex = 1;
            this.b_Tak.Text = "TAK";
            this.b_Tak.UseVisualStyleBackColor = true;
            this.b_Tak.Click += new System.EventHandler(this.b_Tak_Click);
            // 
            // b_Nie
            // 
            this.b_Nie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_Nie.ForeColor = System.Drawing.Color.Green;
            this.b_Nie.Location = new System.Drawing.Point(420, 150);
            this.b_Nie.Name = "b_Nie";
            this.b_Nie.Size = new System.Drawing.Size(200, 80);
            this.b_Nie.TabIndex = 2;
            this.b_Nie.Text = "NIE";
            this.b_Nie.UseVisualStyleBackColor = true;
            this.b_Nie.Click += new System.EventHandler(this.b_Nie_Click);
            // 
            // OknoPotwierdzeniaWyjscia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.ControlBox = false;
            this.Controls.Add(this.b_Nie);
            this.Controls.Add(this.b_Tak);
            this.Controls.Add(this.l_Ostrzezenie);
            this.Name = "OknoPotwierdzeniaWyjscia";
            this.Load += new System.EventHandler(this.OknoPotwierdzeniaWyjscia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_Ostrzezenie;
        private System.Windows.Forms.Button b_Tak;
        private System.Windows.Forms.Button b_Nie;
    }
}