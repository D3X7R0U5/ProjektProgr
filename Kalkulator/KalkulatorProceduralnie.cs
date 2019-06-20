using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
    // Projekt Bartłomiej Słodyczka
{
        class KalkulatorProceduralnie
        {
            static void Main(string[] args)
            {
                bool zakonczApk = false;
            #region TYTUŁ
            // Tytuł
            Console.WriteLine("Kalkulator konsolowy");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            #endregion
            while (!zakonczApk)
            #region Wprowadzenie danych
            {
                // Deklaracja zmiennych
                string numX;
                string numY;
                    double wynik;

                    // Pierwszy numer
                    Console.Write("Wpisz liczbę i naciśnij ENTER: ");
                numX = Console.ReadLine();

                    double delNumX = 0;
                    while (!double.TryParse(numX, out delNumX))
                    {
                        Console.Write("To nie jest liczba, wprowadź liczbę i kliknij ENTER : ");
                    numX = Console.ReadLine();
                    }

                    // Drugi numer
                    Console.Write("Wpisz drugą liczbę: ");
                numY = Console.ReadLine();

                    double delNumY = 0;
                    while (!double.TryParse(numY, out delNumY))
                    {
                        Console.Write("Nieprawidłowa wartość, podaj liczbę i wciśnij ENTER");
                    numY = Console.ReadLine();
                    }

                // Pytanie o wybór opcji
                Console.WriteLine("Wybierz opcje:");
                Console.WriteLine("dd - Dodaj");
                Console.WriteLine("od - Odejmij");
                Console.WriteLine("pm - Pomnóż");
                Console.WriteLine("pd - Podziel");
                Console.Write("Co wybierasz? ");

                string ll = Console.ReadLine();
                #endregion
                #region Wyjątki
                try
                {
                        wynik = Kalkulator.DoOperation(delNumX, delNumY, ll);
                        if (double.IsNaN(wynik))
                        {
                            Console.WriteLine("Niepoprawne działanie!");
                    }
                        else Console.WriteLine("Wynik: {0:0.##}", wynik);
                }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wystąpił wyjątek : " + e.Message);
                }

                    Console.WriteLine("**************");

                Console.Write("Naciśnij n jeśli chcesz zakończyć, w innym przypadku naciśnij dowolny przycisk");
                    if (Console.ReadLine() == "n") zakonczApk = true;

                    Console.WriteLine("");
                }
                return;
            #endregion
        }
        }
    }

