using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wirtualna karta pacjenta

            // TYP nazwa = wartość;

            string imie = "Jan";
            string nazwisko = "Kowalski";
            string dataUrodzenia = "24-01-1995";
            string choroba = "Angina";
            string pesel = "00232351241";
            double waga = 85.4;
            int wiek = 16;
            bool czyOsobaPali = false;
            char plec = 'k';
            string historiaChorób = "przeziębienie, katar";

            //typy liczbowe
            //całkowite: int long
            //ułamkowe: float double decimal

            //inne typy
            //tekstowe: string
            //znakowe: char
            //logiczne: bool
            Console.WriteLine("KARTA PACJENTA");
            Console.WriteLine("Imie i nazwisko: " + imie + " " + nazwisko);
            Console.WriteLine("Wiek: " + wiek);
            Console.WriteLine("Waga: " + waga);
            Console.WriteLine("Czy palący: " + czyOsobaPali);
            Console.WriteLine("Pesel: " + pesel);
            Console.WriteLine("Historia Chorób: " + historiaChorób);

            historiaChorób = "przeziębienie, katar, a do tego covid";
            Console.WriteLine("Historia Chorób po aktualizacji: " + historiaChorób);


            //STAŁE
            //stałe służą do zapisu wartości, które nie powinny się zmieniać podczas trwania programu
            const double PI = 3.14;

            //PI = 8; - tego nie wolno wykonać ponieważ stałych nie można edytować

            const string IMIE = "aa";

            //Dodatkowe sposoby łączneia tekstu
            Console.WriteLine();
            Console.WriteLine("Mam na imię " + imie + ", mam " + wiek + "lat, moja waga" + waga);
            Console.WriteLine("Mam na imię {0}, mam {1} lata, moja waga: {2}",imie,wiek,waga);
            Console.WriteLine($"Mam na imię {imie}, mam {wiek} lat, moja waga {waga}");

            Console.ReadLine();
        }
    }
}
