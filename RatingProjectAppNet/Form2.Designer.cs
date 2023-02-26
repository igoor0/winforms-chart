namespace RatingProjectAppNet
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.c_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_showgrid = new System.Windows.Forms.Button();
            this.b_randomize = new System.Windows.Forms.Button();
            this.b_showlegend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c_histogram)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_histogram
            // 
            this.c_histogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "Przedziały liczbowe ocen";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.Title = "Ilość ocen";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.Name = "c_area";
            this.c_histogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.c_histogram.Legends.Add(legend1);
            this.c_histogram.Location = new System.Drawing.Point(0, 0);
            this.c_histogram.Name = "c_histogram";
            series1.ChartArea = "c_area";
            series1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.Name = "Oceny";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.c_histogram.Series.Add(series1);
            this.c_histogram.Size = new System.Drawing.Size(627, 351);
            this.c_histogram.TabIndex = 0;
            this.c_histogram.Text = "chart1";
            title1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            title1.Text = "Wykres histogramu ocen";
            this.c_histogram.Titles.Add(title1);
            this.c_histogram.Click += new System.EventHandler(this.c_histogram_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.b_showlegend);
            this.panel1.Controls.Add(this.b_randomize);
            this.panel1.Controls.Add(this.b_showgrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 157);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // b_showgrid
            // 
            this.b_showgrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.b_showgrid.FlatAppearance.BorderSize = 0;
            this.b_showgrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_showgrid.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_showgrid.Location = new System.Drawing.Point(-2, -2);
            this.b_showgrid.Name = "b_showgrid";
            this.b_showgrid.Size = new System.Drawing.Size(212, 157);
            this.b_showgrid.TabIndex = 0;
            this.b_showgrid.Text = "Pokaż / Wyłącz siatkę";
            this.b_showgrid.UseVisualStyleBackColor = false;
            this.b_showgrid.Click += new System.EventHandler(this.b_showgrid_Click);
            // 
            // b_randomize
            // 
            this.b_randomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.b_randomize.FlatAppearance.BorderSize = 0;
            this.b_randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_randomize.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_randomize.Location = new System.Drawing.Point(205, -2);
            this.b_randomize.Name = "b_randomize";
            this.b_randomize.Size = new System.Drawing.Size(212, 157);
            this.b_randomize.TabIndex = 1;
            this.b_randomize.Text = "Losuj kolor wykresu";
            this.b_randomize.UseVisualStyleBackColor = false;
            this.b_randomize.Click += new System.EventHandler(this.b_randomize_Click);
            // 
            // b_showlegend
            // 
            this.b_showlegend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.b_showlegend.FlatAppearance.BorderSize = 0;
            this.b_showlegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_showlegend.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_showlegend.Location = new System.Drawing.Point(413, -2);
            this.b_showlegend.Name = "b_showlegend";
            this.b_showlegend.Size = new System.Drawing.Size(212, 157);
            this.b_showlegend.TabIndex = 2;
            this.b_showlegend.Text = "Włącz / Wyłącz legendę";
            this.b_showlegend.UseVisualStyleBackColor = false;
            this.b_showlegend.Click += new System.EventHandler(this.b_showlegend_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(627, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c_histogram);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(645, 550);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_histogram)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart c_histogram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_showlegend;
        private System.Windows.Forms.Button b_randomize;
        private System.Windows.Forms.Button b_showgrid;
    }
}