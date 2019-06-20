using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
    //Projekt Bartłomiej Słodyczka
{
    class Kalkulator
    {
        public static double DoOperation(double x, double y, string ll)
        {
            double wynik = double.NaN;

            // FUnkcja switch do liczenia
            switch (ll)
            {
                case "dd":
                    wynik = x + y;
                    break;
                case "od":
                    wynik = x - y;
                    break;
                case "pm":
                    wynik = x * y;
                    break;
                case "pd":
                    // Podaj liczbę różną od zera
                    if (y != 0)
                    {
                        wynik = x / y;
                    }
                    break;
                default:
                    break;
            }
            return wynik;
        }
    }

}