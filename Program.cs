using System;
using System.IO;

//Utwórz plik "biodata.txt" i zapisz do niego tekst „Sekwencja kwasów nukleinowych: 5-AATTGGCC-3".
//Odczytaj plik w taki sposób, by w konsoli wydrukować tylko samą sekwencję: 5-AATTGGCC-3.
//Użyj funkcji Seek(), aby przejść do odpowiedniego bajtu pliku. Na koniec wyczyść konsolę, usuwając plik.

class PoruszanieSiePoPliku
{
    static void Main()
    {
        string filePath = "biodata.txt";
        string sequence = "5-AATTGGCC-3";

        try
        {
            File.WriteAllText(filePath, sequence);
            using(StreamReader reader = new StreamReader(filePath))
            {
                string fullSequence = reader.ReadToEnd();
                Console.WriteLine(fullSequence);
            }

            File.Delete(filePath);
            Console.WriteLine("Operacja zakończona pomyślnie.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }
}