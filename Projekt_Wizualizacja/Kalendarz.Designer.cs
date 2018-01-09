namespace Projekt_Wizualizacja
{
    partial class Kalendarz
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
            this.l_data = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Od = new System.Windows.Forms.Label();
            this.l_Do = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l_godzina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_data
            // 
            this.l_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.l_data.ForeColor = System.Drawing.Color.SeaShell;
            this.l_data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_data.Location = new System.Drawing.Point(6, 43);
            this.l_data.Name = "l_data";
            this.l_data.Size = new System.Drawing.Size(275, 30);
            this.l_data.TabIndex = 6;
            this.l_data.Text = "PONIEDZIAŁEK, 12.12.2012";
            this.l_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.SystemColors.Info;
            this.Calendar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Calendar.Location = new System.Drawing.Point(22, 66);
            this.Calendar.MaxDate = new System.DateTime(2018, 2, 19, 0, 0, 0, 0);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.MinDate = new System.DateTime(2018, 1, 4, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 0;
            this.Calendar.TodayDate = new System.DateTime(2018, 1, 6, 0, 0, 0, 0);
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz dzień, od którego bilet będzie obowiązywał:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dzisiejsza data:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_Od
            // 
            this.l_Od.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.l_Od.ForeColor = System.Drawing.Color.SeaShell;
            this.l_Od.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Od.Location = new System.Drawing.Point(78, 50);
            this.l_Od.Name = "l_Od";
            this.l_Od.Size = new System.Drawing.Size(196, 40);
            this.l_Od.TabIndex = 11;
            this.l_Od.Text = "10.04.2017";
            this.l_Od.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_Do
            // 
            this.l_Do.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.l_Do.ForeColor = System.Drawing.Color.SeaShell;
            this.l_Do.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Do.Location = new System.Drawing.Point(78, 105);
            this.l_Do.Name = "l_Do";
            this.l_Do.Size = new System.Drawing.Size(196, 40);
            this.l_Do.TabIndex = 12;
            this.l_Do.Text = "14.04.2018";
            this.l_Do.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Do:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.l_Do);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.l_Od);
            this.groupBox1.Location = new System.Drawing.Point(366, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 167);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bilet będzie ważny:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Od:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l_data);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(366, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 79);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Calendar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(32, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 252);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(150, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 80);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zatwierdź wybór";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_godzina
            // 
            this.l_godzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.l_godzina.ForeColor = System.Drawing.Color.SeaShell;
            this.l_godzina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_godzina.Location = new System.Drawing.Point(593, 349);
            this.l_godzina.Name = "l_godzina";
            this.l_godzina.Size = new System.Drawing.Size(179, 40);
            this.l_godzina.TabIndex = 18;
            this.l_godzina.Text = "14:04:04";
            this.l_godzina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_godzina.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bilety okresowy 30-dniowy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Kalendarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_godzina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Kalendarz";
            this.Load += new System.EventHandler(this.Kalendarz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label l_data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_Od;
        private System.Windows.Forms.Label l_Do;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_godzina;
        public System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label2;
    }
}