using System;
using System.Windows.Forms;

namespace RatingProjectAppNet
{
    public partial class Form1 : Form
    {
        // Inicjalizacja zmiennej obiektowej klasy FileReader zawartej w pliku FileReader.cs
        // służącej do obsługi plików, pobierania i zapisywania danych oraz obliczania histogramu
        FileReader reader = new FileReader();
        public Form1()
        {
            InitializeComponent();
        }

        private void b_loadfile_Click(object sender, EventArgs e)
        // Metoda b_loadfile_Click() otwiera okno dialogowe do wyboru ścieżki pliku tekstowego
        // oraz wyświetla ewentualny komunikat o niepowodzeniu w wypadku wystąpienia wyjątku System.ArgumentException
        {
            try
            {
                reader.load_file();
                if (FileReader.saved == true)
                {
                    b_savefile.Enabled = true;
                    b_chart.Enabled = true;
                }
                else
                {
                    b_savefile.Enabled = false;
                    b_chart.Enabled = false;
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Wybierz poprawny plik do odczytu!", "Błąd odczytu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileReader.loaded = false;
                b_savefile.Enabled = false;
                b_chart.Enabled = false;
            }
        }

        private void b_savefile_Click(object sender, EventArgs e)
        // Metoda b_savefile_Click() otwiera okno dialogowe do wyboru ścieżki pliku, do którego chcemy zapisać
        // rozkład histogramu oraz wyświetla ewentualne komunikaty o niepowodzeniu w wypadku wystąpienia wyjątków
        // System.ArgumentException (niewybrana lub nieprawidłowa ścieżka do pliku) oraz
        // System.InvalidOperationException (plik nie zawiera poprawnych danych liczbowych)
        {
            try
            {
                reader.save_file();
                FileReader.saved = true;
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Wybierz poprawną ścieżkę do zapisu pliku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileReader.saved = false;
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Plik nie może nie zawierać wartości liczbowych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileReader.saved = false;
                b_savefile.Enabled = false;
                b_chart.Enabled = false;
            }
        }

        private void b_chart_Click(object sender, EventArgs e)
        // Metoda b_chart_Click() uruchamia nowy formularz służący do pokazania i modyfikacji histogramu danych
        {
            Form2 chart = new Form2();
            chart.Show();
        }

        private void b_exit_Click(object sender, EventArgs e)
        // Metoda b_exit_Click() powoduje zamknięcie programu
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
