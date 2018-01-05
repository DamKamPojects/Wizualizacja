namespace Projekt_Wizualizacja
{
    partial class OkresowyRRW
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_zatwiedz = new System.Windows.Forms.Button();
            this.b_RgW = new System.Windows.Forms.Button();
            this.b_RRW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Proszę wybrać obszar działania biletu:";
            // 
            // b_zatwiedz
            // 
            this.b_zatwiedz.BackColor = System.Drawing.Color.FloralWhite;
            this.b_zatwiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_zatwiedz.ForeColor = System.Drawing.Color.Black;
            this.b_zatwiedz.Location = new System.Drawing.Point(50, 257);
            this.b_zatwiedz.Name = "b_zatwiedz";
            this.b_zatwiedz.Size = new System.Drawing.Size(358, 62);
            this.b_zatwiedz.TabIndex = 13;
            this.b_zatwiedz.Text = "ZATWIEDŹ WYBÓR";
            this.b_zatwiedz.UseVisualStyleBackColor = false;
            this.b_zatwiedz.Click += new System.EventHandler(this.b_zatwiedz_Click);
            // 
            // b_RgW
            // 
            this.b_RgW.BackColor = System.Drawing.Color.White;
            this.b_RgW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_RgW.ForeColor = System.Drawing.Color.Black;
            this.b_RgW.Location = new System.Drawing.Point(258, 68);
            this.b_RgW.Name = "b_RgW";
            this.b_RgW.Size = new System.Drawing.Size(150, 150);
            this.b_RgW.TabIndex = 12;
            this.b_RgW.Text = "Rumia\r\n oraz \r\nGm. Wejherowo";
            this.b_RgW.UseVisualStyleBackColor = false;
            this.b_RgW.Click += new System.EventHandler(this.b_RgW_Click);
            // 
            // b_RRW
            // 
            this.b_RRW.BackColor = System.Drawing.Color.White;
            this.b_RRW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_RRW.ForeColor = System.Drawing.Color.Black;
            this.b_RRW.Location = new System.Drawing.Point(50, 68);
            this.b_RRW.Name = "b_RRW";
            this.b_RRW.Size = new System.Drawing.Size(150, 150);
            this.b_RRW.TabIndex = 11;
            this.b_RRW.Text = "Rumia, Reda \r\noraz \r\nmiasta Wejherowo";
            this.b_RRW.UseVisualStyleBackColor = false;
            this.b_RRW.Click += new System.EventHandler(this.b_RRW_Click);
            // 
            // OkresowyRRW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(461, 352);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_zatwiedz);
            this.Controls.Add(this.b_RgW);
            this.Controls.Add(this.b_RRW);
            this.Name = "OkresowyRRW";
            this.Load += new System.EventHandler(this.OkresowyRRW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_zatwiedz;
        private System.Windows.Forms.Button b_RgW;
        private System.Windows.Forms.Button b_RRW;
    }
}