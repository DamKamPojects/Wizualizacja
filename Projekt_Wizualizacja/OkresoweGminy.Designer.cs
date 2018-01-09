namespace Projekt_Wizualizacja
{
    partial class OkresoweGminy
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
            this.b_zatwiedz = new System.Windows.Forms.Button();
            this.b_wejherowo = new System.Windows.Forms.Button();
            this.b_szemud = new System.Windows.Forms.Button();
            this.b_zukowo = new System.Windows.Forms.Button();
            this.b_kosakowo = new System.Windows.Forms.Button();
            this.b_rumia = new System.Windows.Forms.Button();
            this.b_sopot = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proszę wybrać obszar działania biletu:";
            // 
            // b_zatwiedz
            // 
            this.b_zatwiedz.BackColor = System.Drawing.Color.FloralWhite;
            this.b_zatwiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_zatwiedz.ForeColor = System.Drawing.Color.Black;
            this.b_zatwiedz.Location = new System.Drawing.Point(32, 355);
            this.b_zatwiedz.Name = "b_zatwiedz";
            this.b_zatwiedz.Size = new System.Drawing.Size(397, 62);
            this.b_zatwiedz.TabIndex = 14;
            this.b_zatwiedz.Text = "ZATWIEDŹ WYBÓR";
            this.b_zatwiedz.UseVisualStyleBackColor = false;
            this.b_zatwiedz.Click += new System.EventHandler(this.b_zatwiedz_Click);
            // 
            // b_wejherowo
            // 
            this.b_wejherowo.BackColor = System.Drawing.Color.White;
            this.b_wejherowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_wejherowo.ForeColor = System.Drawing.Color.Black;
            this.b_wejherowo.Location = new System.Drawing.Point(329, 228);
            this.b_wejherowo.Name = "b_wejherowo";
            this.b_wejherowo.Size = new System.Drawing.Size(100, 100);
            this.b_wejherowo.TabIndex = 13;
            this.b_wejherowo.Text = "Gm. Wejherowo";
            this.b_wejherowo.UseVisualStyleBackColor = false;
            this.b_wejherowo.Click += new System.EventHandler(this.b_wejherowo_Click);
            // 
            // b_szemud
            // 
            this.b_szemud.BackColor = System.Drawing.Color.White;
            this.b_szemud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_szemud.ForeColor = System.Drawing.Color.Black;
            this.b_szemud.Location = new System.Drawing.Point(181, 228);
            this.b_szemud.Name = "b_szemud";
            this.b_szemud.Size = new System.Drawing.Size(100, 100);
            this.b_szemud.TabIndex = 12;
            this.b_szemud.Text = "Gm. Szemud";
            this.b_szemud.UseVisualStyleBackColor = false;
            this.b_szemud.Click += new System.EventHandler(this.b_szemud_Click);
            // 
            // b_zukowo
            // 
            this.b_zukowo.BackColor = System.Drawing.Color.White;
            this.b_zukowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_zukowo.ForeColor = System.Drawing.Color.Black;
            this.b_zukowo.Location = new System.Drawing.Point(32, 228);
            this.b_zukowo.Name = "b_zukowo";
            this.b_zukowo.Size = new System.Drawing.Size(100, 100);
            this.b_zukowo.TabIndex = 11;
            this.b_zukowo.Text = "Gm. Żukowo";
            this.b_zukowo.UseVisualStyleBackColor = false;
            this.b_zukowo.Click += new System.EventHandler(this.b_zukowo_Click);
            // 
            // b_kosakowo
            // 
            this.b_kosakowo.BackColor = System.Drawing.Color.White;
            this.b_kosakowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_kosakowo.ForeColor = System.Drawing.Color.Black;
            this.b_kosakowo.Location = new System.Drawing.Point(329, 95);
            this.b_kosakowo.Name = "b_kosakowo";
            this.b_kosakowo.Size = new System.Drawing.Size(100, 100);
            this.b_kosakowo.TabIndex = 10;
            this.b_kosakowo.Text = "Gm. Kosakowo";
            this.b_kosakowo.UseVisualStyleBackColor = false;
            this.b_kosakowo.Click += new System.EventHandler(this.b_kosakowo_Click);
            // 
            // b_rumia
            // 
            this.b_rumia.BackColor = System.Drawing.Color.White;
            this.b_rumia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_rumia.ForeColor = System.Drawing.Color.Black;
            this.b_rumia.Location = new System.Drawing.Point(181, 95);
            this.b_rumia.Name = "b_rumia";
            this.b_rumia.Size = new System.Drawing.Size(100, 100);
            this.b_rumia.TabIndex = 9;
            this.b_rumia.Text = "Rumia";
            this.b_rumia.UseVisualStyleBackColor = false;
            this.b_rumia.Click += new System.EventHandler(this.b_rumia_Click);
            // 
            // b_sopot
            // 
            this.b_sopot.BackColor = System.Drawing.Color.White;
            this.b_sopot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_sopot.ForeColor = System.Drawing.Color.Black;
            this.b_sopot.Location = new System.Drawing.Point(32, 95);
            this.b_sopot.Name = "b_sopot";
            this.b_sopot.Size = new System.Drawing.Size(100, 100);
            this.b_sopot.TabIndex = 8;
            this.b_sopot.Text = "Sopot";
            this.b_sopot.UseVisualStyleBackColor = false;
            this.b_sopot.Click += new System.EventHandler(this.b_sopot_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OkresoweGminy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(476, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_zatwiedz);
            this.Controls.Add(this.b_wejherowo);
            this.Controls.Add(this.b_szemud);
            this.Controls.Add(this.b_zukowo);
            this.Controls.Add(this.b_kosakowo);
            this.Controls.Add(this.b_rumia);
            this.Controls.Add(this.b_sopot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OkresoweGminy";
            this.Load += new System.EventHandler(this.OkresoweGminy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_zatwiedz;
        private System.Windows.Forms.Button b_wejherowo;
        private System.Windows.Forms.Button b_szemud;
        private System.Windows.Forms.Button b_zukowo;
        private System.Windows.Forms.Button b_kosakowo;
        private System.Windows.Forms.Button b_rumia;
        private System.Windows.Forms.Button b_sopot;
        private System.Windows.Forms.Timer timer1;
    }
}