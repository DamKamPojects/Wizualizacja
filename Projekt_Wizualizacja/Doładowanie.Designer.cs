namespace Projekt_Wizualizacja
{
    partial class Doładowanie
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
            this.b_virgin = new System.Windows.Forms.Button();
            this.b_nju = new System.Windows.Forms.Button();
            this.b_play = new System.Windows.Forms.Button();
            this.b_tmobile = new System.Windows.Forms.Button();
            this.b_orange = new System.Windows.Forms.Button();
            this.b_plus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz operatora, sieci komórkowej:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_virgin
            // 
            this.b_virgin.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.tel_virgin;
            this.b_virgin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_virgin.Location = new System.Drawing.Point(478, 276);
            this.b_virgin.Name = "b_virgin";
            this.b_virgin.Size = new System.Drawing.Size(140, 140);
            this.b_virgin.TabIndex = 6;
            this.b_virgin.UseVisualStyleBackColor = true;
            this.b_virgin.Click += new System.EventHandler(this.b_virgin_Click);
            // 
            // b_nju
            // 
            this.b_nju.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.tel_nju;
            this.b_nju.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_nju.Location = new System.Drawing.Point(278, 276);
            this.b_nju.Name = "b_nju";
            this.b_nju.Size = new System.Drawing.Size(140, 140);
            this.b_nju.TabIndex = 5;
            this.b_nju.UseVisualStyleBackColor = true;
            this.b_nju.Click += new System.EventHandler(this.b_nju_Click);
            // 
            // b_play
            // 
            this.b_play.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.tel_play1;
            this.b_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_play.Location = new System.Drawing.Point(78, 276);
            this.b_play.Name = "b_play";
            this.b_play.Size = new System.Drawing.Size(140, 140);
            this.b_play.TabIndex = 4;
            this.b_play.UseVisualStyleBackColor = true;
            this.b_play.Click += new System.EventHandler(this.b_play_Click);
            // 
            // b_tmobile
            // 
            this.b_tmobile.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.tel_tmobile;
            this.b_tmobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_tmobile.Location = new System.Drawing.Point(478, 76);
            this.b_tmobile.Name = "b_tmobile";
            this.b_tmobile.Size = new System.Drawing.Size(140, 140);
            this.b_tmobile.TabIndex = 3;
            this.b_tmobile.UseVisualStyleBackColor = true;
            this.b_tmobile.Click += new System.EventHandler(this.b_tmobile_Click);
            // 
            // b_orange
            // 
            this.b_orange.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.tel_orange;
            this.b_orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_orange.Location = new System.Drawing.Point(278, 76);
            this.b_orange.Name = "b_orange";
            this.b_orange.Size = new System.Drawing.Size(140, 140);
            this.b_orange.TabIndex = 2;
            this.b_orange.UseVisualStyleBackColor = true;
            this.b_orange.Click += new System.EventHandler(this.b_orange_Click);
            // 
            // b_plus
            // 
            this.b_plus.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.tel_plus;
            this.b_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_plus.Location = new System.Drawing.Point(78, 76);
            this.b_plus.Name = "b_plus";
            this.b_plus.Size = new System.Drawing.Size(140, 140);
            this.b_plus.TabIndex = 0;
            this.b_plus.UseVisualStyleBackColor = true;
            this.b_plus.Click += new System.EventHandler(this.b_plus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.b_virgin);
            this.panel1.Controls.Add(this.b_nju);
            this.panel1.Controls.Add(this.b_play);
            this.panel1.Controls.Add(this.b_tmobile);
            this.panel1.Controls.Add(this.b_orange);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.b_plus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 481);
            this.panel1.TabIndex = 8;
            // 
            // b_close
            // 
            this.b_close.BackgroundImage = global::Projekt_Wizualizacja.Properties.Resources.Przycisk_Anuluj1;
            this.b_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_close.Location = new System.Drawing.Point(644, 0);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(60, 60);
            this.b_close.TabIndex = 7;
            this.b_close.UseVisualStyleBackColor = true;
            // 
            // Doładowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.panel1);
            this.Name = "Doładowanie";
            this.Text = "Doładowanie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_plus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_orange;
        private System.Windows.Forms.Button b_tmobile;
        private System.Windows.Forms.Button b_play;
        private System.Windows.Forms.Button b_nju;
        private System.Windows.Forms.Button b_virgin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_close;
    }
}