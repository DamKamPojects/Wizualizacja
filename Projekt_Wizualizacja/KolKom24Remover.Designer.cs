namespace Projekt_Wizualizacja
{
    partial class KolKom24Remover
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
            this.lstBox_Tickets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox_Tickets
            // 
            this.lstBox_Tickets.FormattingEnabled = true;
            this.lstBox_Tickets.Location = new System.Drawing.Point(12, 38);
            this.lstBox_Tickets.Name = "lstBox_Tickets";
            this.lstBox_Tickets.Size = new System.Drawing.Size(396, 342);
            this.lstBox_Tickets.TabIndex = 0;
            this.lstBox_Tickets.SelectedIndexChanged += new System.EventHandler(this.lstBox_Tickets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naciśnij na bilet aby skasować go z podsumowania";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(13, 388);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(395, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Zakończ usuwanie";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // KolKom24Remover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBox_Tickets);
            this.Name = "KolKom24Remover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Tickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
    }
}