namespace RatingProjectAppNet
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_chart = new System.Windows.Forms.Button();
            this.b_savefile = new System.Windows.Forms.Button();
            this.b_loadfile = new System.Windows.Forms.Button();
            this.p_umg = new System.Windows.Forms.Panel();
            this.l_umg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.p_umg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_exit);
            this.panel1.Controls.Add(this.b_chart);
            this.panel1.Controls.Add(this.b_savefile);
            this.panel1.Controls.Add(this.b_loadfile);
            this.panel1.Controls.Add(this.p_umg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 506);
            this.panel1.TabIndex = 0;
            // 
            // b_exit
            // 
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_exit.Location = new System.Drawing.Point(0, 412);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(218, 100);
            this.b_exit.TabIndex = 4;
            this.b_exit.Text = "Wyjdź";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_chart
            // 
            this.b_chart.Enabled = false;
            this.b_chart.FlatAppearance.BorderSize = 0;
            this.b_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_chart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_chart.Location = new System.Drawing.Point(0, 316);
            this.b_chart.Name = "b_chart";
            this.b_chart.Size = new System.Drawing.Size(218, 100);
            this.b_chart.TabIndex = 3;
            this.b_chart.Text = "Otwórz wykres histogramu";
            this.b_chart.UseVisualStyleBackColor = true;
            this.b_chart.Click += new System.EventHandler(this.b_chart_Click);
            // 
            // b_savefile
            // 
            this.b_savefile.Enabled = false;
            this.b_savefile.FlatAppearance.BorderSize = 0;
            this.b_savefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_savefile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_savefile.Location = new System.Drawing.Point(0, 220);
            this.b_savefile.Name = "b_savefile";
            this.b_savefile.Size = new System.Drawing.Size(218, 100);
            this.b_savefile.TabIndex = 2;
            this.b_savefile.Text = "Zapisz histogram ocen do pliku tekstowego";
            this.b_savefile.UseVisualStyleBackColor = true;
            this.b_savefile.Click += new System.EventHandler(this.b_savefile_Click);
            // 
            // b_loadfile
            // 
            this.b_loadfile.FlatAppearance.BorderSize = 0;
            this.b_loadfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_loadfile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_loadfile.Location = new System.Drawing.Point(0, 125);
            this.b_loadfile.Name = "b_loadfile";
            this.b_loadfile.Size = new System.Drawing.Size(218, 100);
            this.b_loadfile.TabIndex = 1;
            this.b_loadfile.Text = "Wczytaj plik tekstowy z ocenami (.txt)";
            this.b_loadfile.UseVisualStyleBackColor = true;
            this.b_loadfile.Click += new System.EventHandler(this.b_loadfile_Click);
            // 
            // p_umg
            // 
            this.p_umg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.p_umg.Controls.Add(this.l_umg);
            this.p_umg.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_umg.Location = new System.Drawing.Point(0, 0);
            this.p_umg.Name = "p_umg";
            this.p_umg.Size = new System.Drawing.Size(218, 129);
            this.p_umg.TabIndex = 0;
            // 
            // l_umg
            // 
            this.l_umg.AutoSize = true;
            this.l_umg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_umg.ForeColor = System.Drawing.Color.Black;
            this.l_umg.Location = new System.Drawing.Point(12, 9);
            this.l_umg.MaximumSize = new System.Drawing.Size(210, 0);
            this.l_umg.Name = "l_umg";
            this.l_umg.Size = new System.Drawing.Size(201, 105);
            this.l_umg.TabIndex = 0;
            this.l_umg.Text = "Program do wykazywania histogramu ocen danych w pliku tekstowym na wykresie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(217, 506);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(235, 553);
            this.MinimumSize = new System.Drawing.Size(235, 553);
            this.Name = "Form1";
            this.Text = "Rating Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.p_umg.ResumeLayout(false);
            this.p_umg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_chart;
        private System.Windows.Forms.Button b_savefile;
        private System.Windows.Forms.Button b_loadfile;
        private System.Windows.Forms.Panel p_umg;
        private System.Windows.Forms.Label l_umg;
    }
}

