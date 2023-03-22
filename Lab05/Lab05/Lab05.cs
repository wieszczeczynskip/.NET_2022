using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lab05
{
    internal class Lab05
    {
        public static double[] solveSqEq(double a, double b, double c)
        {
            switch ((a, b, c))
            {
                case (0, 0, 0):
                    return new double[3];
                case (_, 0, 0):
                    return new double[1] { 0 };
                case (0, _, 0):
                    return new double[1] { 0 };
                case (0, 0, _):
                    return new double[0];
                case (_, _, 0):
                    return new double[2] { 0, -b/a };
                case (0, _, _):
                    return new double[1] { -c/b };
                case (_, 0, _):
                    if ((a > 0 && c < 0) || (a < 0 && c > 0))
                    {
                        return new double[2] { Math.Sqrt(-c / a), -Math.Sqrt(-c / a) };
                    }
                    else
                    {
                        return new double[0];
                    }
                default:
                    double delta = b * b - (4 * a * c);
                    switch (delta)
                    {
                        case > 0:
                            return new double[2] { (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a) };
                        case 0:
                            return new double[1] { -b / (2 * a) };
                        default:
                            return new double[0];
                    }
            }
        }

        public static void Z1()
        {
            Console.WriteLine("Podaj współczynnik a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c");
            double c = double.Parse(Console.ReadLine());
            double[] tab = solveSqEq(a, b, c);
            switch (tab.Length)
            {
                case 3:
                    Console.WriteLine("Nieskończoność rozwiązań");
                    break;
                case 2:
                    Console.WriteLine($"Rozwiązania: x1 = {String.Format("{0:N5}", tab[0])}, x2 = {String.Format("{0:N5}", tab[1])}");
                    break;
                case 1:
                    Console.WriteLine("Rozwiązanie: x = {0:0.00000}", tab[0]);
                    break;
                case 0:
                    Console.WriteLine("Brak rozwiązań");
                    break;
            }
        }

        public static void Z2()
        {
            Console.WriteLine("Podaj liczbę większą lub równą 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ciąg liczb oddzielony znakami białymi");
            string x = Console.ReadLine();
            int startIndex = 0;
            double highest = 0;
            double sechighest = 0;
            double current = 0;
            bool isNotOnlyWhite = false;
            string substr = "";
            for (int i = 0; i < x.Length; i++)
            {
                if ((Char.IsWhiteSpace(x[i]) && isNotOnlyWhite) || (i == x.Length - 1 && !Char.IsWhiteSpace(x[i])))
                {
                    if (i != x.Length - 1)
                    {
                        substr = x.Substring(startIndex, i - startIndex);
                    }
                    else
                    {
                        substr = x.Substring(startIndex);
                    }
                    isNotOnlyWhite = false;
                    current = double.Parse(substr);
                    startIndex = i + 1;
                    if (current > highest && current > sechighest)
                    {
                        sechighest = highest;
                        highest = current;
                    }
                    else
                    {
                        if (current > sechighest && current != highest)
                        {
                            sechighest = current;
                        }
                    }
                }
                if (!Char.IsWhiteSpace(x[i]))
                {
                    isNotOnlyWhite = true;
                }
            }
            if (sechighest == highest)
            {
                Console.WriteLine("brak rozwiązania");
            }
            else
            {
                Console.WriteLine(sechighest);
            }
        }

        static void Main(string[] args)
        {
            //Z1();
            Z2();
        }
    }
}
