using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RatingProjectAppNet
{
    public partial class Form2 : Form
    {
        // Deklaracja zmiennych związanych z właściwościami wykresu
        public static ChartArea chartArea;
        Series s_oceny;
        Legend legenda;

        Random random_color = new Random();
        public static Boolean grid_enabled;
        public static Boolean legend_enabled;

        public Form2()
        {
            InitializeComponent();   // Tworzenie wykresu
            this.Text = "Chart";
        }

        private void Form2_Load(object sender, EventArgs e)
        // Metoda Form2_Load wykonuje się przy inicjalizacji wykresu w oknie
        {
            // Przypisanie właściwości wykresu do zmiennych
            chartArea = c_histogram.ChartAreas["c_area"];
            s_oceny = c_histogram.Series["Oceny"];
            legenda = c_histogram.Legends["Legend1"];

            // Przypisanie właściwości używanych do metod b_showgrid_Click() oraz b_showlegend_Click()
            grid_enabled = true;
            legend_enabled = true;
            fillChart();
        }

        private void c_histogram_Click(object sender, EventArgs e)
        {

        }

        private void fillChart()
        // Metoda fillChart() wypełnia wykres o dane z listy wartości numerycznych ratings
        {
            int max_value = FileReader.ratings.Max();
            for (int i = 0; i < max_value; i++)
            {
                s_oceny.Points.AddXY(FileReader.num_range(i), FileReader.count(i));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_showgrid_Click(object sender, EventArgs e)
        // Metoda b_Showgrid_Click() ukrywa/pokazuje siatkę wykresu w zależności od obecnego stanu
        {
            if (grid_enabled == true)
            {
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;
                grid_enabled = false;
            }
            else
            {
                chartArea.AxisX.MajorGrid.Enabled = true;
                chartArea.AxisY.MajorGrid.Enabled = true;
                grid_enabled = true;
            }
        }

        private void b_randomize_Click(object sender, EventArgs e)
        // Metoda b_randomize_CLick() zmienia kolor serii na losowy
        {
            // Generowanie losowego koloru System.Drawings.Color
            int r = random_color.Next(256);
            int g = random_color.Next(256);
            int b = random_color.Next(256);
            Color c = Color.FromArgb(r, g, b);

            for (int i = 0; i < s_oceny.Points.Count; i++)
            {
                s_oceny.Color = c;
            
            }
        
        }

        private void b_showlegend_Click(object sender, EventArgs e)
        // Metoda b_showlegend_Click() ukrywa/pokazuje legendę wykresu w zależności od obecnego stanu
        {
            if (legend_enabled == true)
            {
                legenda.Enabled = false;
                legend_enabled = false;
            }
            else
            {
                legenda.Enabled = true;
                legend_enabled = true;
            }
        }
    }
}
