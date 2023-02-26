using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RatingProjectAppNet
{
    public class FileReader
    {
        // Deklaracja zmiennych używanych w klasie
        public static List<Int32> ratings = new List<Int32>();   // Lista wartości liczbowych ocen z pliku
        public static string file_text = "";
        public static Boolean loaded = true;   // Flaga oznaczająca czy plik został prawidłowo załadowany
        public static Boolean saved = false;   // Flaga oznaczająca czy plik został prawidłowo zapisany

        public void load_file()
        // Funkcja load_file() powoduje otworzenie okna dialogowego z opcją wyboru ścieżki do pliku .txt,
        // z którego planujemy pobrać dane
        // Wyrzuca komunikat o powodzeniu lub niepowodzeniu operacji w przypadku, gdy plik jest pusty
        {
            string path = "";
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open txt File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                path = theDialog.FileName.ToString();
            }

            Regex expression = new Regex("^[0-9]*$");   // Regex wybierający tylko liczby

            string[] lines = File.ReadAllLines(path);   // Pobieranie danych z pliku

            // Czyszczenie / zerowanie listy w przypadku, gdy dane zostały już wcześniej załadowane
            // oraz chcemy pobrać nowe wartości do listy
            if (ratings.Any())
                ratings.Clear();

            foreach (string line in lines)
            {
                Match m = expression.Match(line);   // Zmienna typu System.Text.RegularExpressions.Match zawiera informacje o matchu

                // Wykonywanie operacji tylko, gdy trafimy na match, odrzucanie wartości innych niż liczby
                if (m.Success)
                {
                    int number = int.Parse(m.Value);   // Przekonwertowanie zmiennej m na wartość liczbową
                    ratings.Add(number);   // Wpisanie prawidłowej wartości liczbowej do listy ratings

                    int intStr; bool result = int.TryParse(number.ToString(), out intStr);
                    if (result == true)   // Jeśli konwersja się powiodła
                    {
                        file_text += intStr.ToString() + "\r\n";
                    }
                }
            }

            if (ratings == null || file_text == "")   // Jeśli lista ratings jest pusta oraz nie uzyskano wartości liczbowych
            {
                MessageBox.Show("Plik musi zawierać wartości liczbowe!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saved = false;
            }
            else
            {
                MessageBox.Show("Pomyślnie załadowano plik!", "Powiadomienie",MessageBoxButtons.OK, MessageBoxIcon.Information);
                saved = true;
            }
        }

        public static int count(int num)
        // Metoda count(int num) zwraca wartość tekstową ilości ocen dla przedziału od num do num+1
        // Używana do tworzenia wykresu w pętli iteracyjnej for
        {
            // Uzyskiwanie liczby powtórzeń dla przedziału od num do num+1 i sumowanie tych wartości
            int count1 = ratings.Where(x => x.Equals(num)).Count();
            int count2 = ratings.Where(x => x.Equals(num+1)).Count();
            int quant = count1 + count2;   // Sumowanie zliczeń
            
            return quant;
        }

        public static string num_range(int num)
        // Metoda num_range() zwraca wartość tekstową, która określa zakres danego przedziału liczbowego
        // Np. dla num=1 zwraca string "1-2"
        // Używane w pętli iteracyjnej for przy wstawianiu opisu tekstowego osi X
        {
            string range = String.Format("{0}-{1}", num, num+1);
            return range;
        }
        public void save_file()
        // Metoda save_file() służy do zapisania wykresu do pliku o podanej ścieżce podanej w oknie dialogowym
        // Wyświetla kominikat o powodzeniu operacji
        {
            string saved_text = "";
            string save_path = "";

            if (loaded)
            {
                int max_value = FileReader.ratings.Max();
                int min_value = FileReader.ratings.Min();

                // Tekst do wpisania w plik zapisu histogramu
                saved_text = String.Format("Histogram ocen z zakresu od {0} do {1}: \n", min_value, max_value);

                for (int i = 0; i < max_value; i++)
                {
                    int range1 = i;   // Pierwsza liczba zakresu przedziału
                    int range2 = i + 1;   // Druga liczba zakresu przedziału
                    saved_text += String.Format("{0}-{1}) {2}\n", range1, range2, count(i));
                }

                SaveFileDialog saveFile = new SaveFileDialog();   // Tworzenie nowego dialogu do zapisu pliku
                saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFile.Filter = "TXT files|*.txt";
                saveFile.DefaultExt = "txt";
                saveFile.Title = "Save histogram file";
                if (saveFile.ShowDialog() == DialogResult.OK)   // Jeśli operacja wyboru ścieżki się powiodła
                {
                    MessageBox.Show("Pomyślnie zapisano plik!", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    save_path = saveFile.FileName.ToString();   // Uzyskiwanie ścieżki do zapisu pliku
                    saved = true;   // Ustawianie flagi saved na true w przypadku powodzenia
                }

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(save_path, false))   // Otwieranie strumienia danych
                {
                    sw.WriteLine(saved_text);   // Wpisywanie tekstu do pliku
                    sw.Close();   // Zamykanie strumienia
                }


            }

        }
    }
}