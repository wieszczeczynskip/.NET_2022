using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace Lab06
{
    internal class Program
    {

//==================================================================================================================================================

        static void Tuples((string, string, int, int) krotka)
        {
            Console.WriteLine(krotka.Item1 + krotka.Item2 + krotka.Item3 + krotka.Item4);
            var krotka2 = (imie: krotka.Item1, nazwisko: krotka.Item2, wiek: krotka.Item3, placa: krotka.Item4);
            Console.WriteLine(krotka2.imie + krotka2.nazwisko + krotka2.wiek + krotka2.placa);
            (string imie, string nazwisko, int wiek, int placa) krotka3 = (krotka.Item1, krotka.Item2, krotka.Item3, krotka.Item4);
            Console.WriteLine(krotka3.imie + krotka3.nazwisko + krotka3.wiek + krotka3.placa);
        }

        static void Z1()
        {
            (string imie, string nazwisko, int wiek, int placa) = ("Jan", "Nowak", 25, 5000);
            Tuples((imie, nazwisko, wiek, placa));
        }

//==================================================================================================================================================

        static void Z2()
        {
            var @class = 5;
            Console.WriteLine(@class);
        }

//==================================================================================================================================================

        static void Z3()
        {
            String[] arr1 = new String[5] {"1", "2", "3", "4", "5"};
            foreach(String str in arr1)
            {
                Console.Write(str);
            }
            Console.WriteLine();
            String[] arr2 = new string[5];
            foreach (String str in arr2)
            {
                Console.Write(str);
            }
            Console.WriteLine();
            //1
            System.Array.Fill<String>(arr2, "0");
            foreach (String str in arr2)
            {
                Console.Write(str);
            }
            Console.WriteLine();
            //2
            System.Array.Copy(arr1, arr2, 4);
            foreach (String str in arr2)
            {
                Console.Write(str);
            }
            Console.WriteLine();
            //3
            Console.WriteLine(arr1.Equals(arr2));
            //4
            Console.WriteLine(arr1.Length);
            //5
            Console.WriteLine(System.Array.IndexOf<String>(arr1, "2"));
        }

        //==================================================================================================================================================

        static void Tuples4(dynamic krotka)
        {
            Console.WriteLine(krotka.imie + krotka.nazwisko + krotka.wiek + krotka.placa);
            var krotka2 = (imie: krotka.imie, nazwisko: krotka.nazwisko, wiek: krotka.wiek, placa: krotka.placa);
            Console.WriteLine(krotka2.imie + krotka2.nazwisko + krotka2.wiek + krotka2.placa);
            (string imie, string nazwisko, int wiek, int placa) krotka3 = (krotka.imie, krotka.nazwisko, krotka.wiek, krotka.placa);
            Console.WriteLine(krotka3.imie + krotka3.nazwisko + krotka3.wiek + krotka3.placa);
        }

        static void Z4()
        {
            var krotka = new { imie = "Jan", nazwisko = "Nowak", wiek = 25, placa = 5000};
            Tuples4(krotka);    
        }

//==================================================================================================================================================

        static void BusinessCard(string line1, string line2 = "", string borderStyle = "X", int borderWidth = 2, int minWidth = 20)
        {
            minWidth = Math.Max(minWidth, Math.Max(line1.Length, line2.Length) + 2 * borderWidth + 2);
            int blankWidth = minWidth - 2 * borderWidth;
            string borderUp = new string(Char.Parse(borderStyle), minWidth);
            string borderLeft = new string(Char.Parse(borderStyle), borderWidth);
            for(int i = 0; i < borderWidth; i++)
            {
                Console.WriteLine(borderUp);
            }
            foreach(string x in new string[] {line1, line2})
            {
                double indexLine = (blankWidth - x.Length) / 2.0;
                string line = new string(' ', blankWidth).Remove((int)Math.Ceiling(indexLine), x.Length).Insert((int)Math.Ceiling(indexLine), x);
                Console.WriteLine(borderLeft + line + borderLeft);
            }
            for (int i = 0; i < borderWidth; i++)
            {
                Console.WriteLine(borderUp);
            }
        }

        static void Z5()
        {
            BusinessCard("Brzęczyszczykiewicz", "Jacek", "Y", 4, 20);
            BusinessCard("Kowalski", "Adam", borderWidth: 3);
            BusinessCard(line1: "Kowalczyk", borderStyle: "O", minWidth: 21);
        }

 //==================================================================================================================================================

        static int[] CountMyTypes(params object[] stream)
        {
            int[] res = new int[4] { 0, 0, 0, 0 };  // 0 = even Int, 1 - double, 2 - string w/ 5 or more char, 3 - others
            foreach (object x in stream)
            {
                switch (x)
                {
                    case int num when (num % 2 == 0):
                        res[0] += 1;
                        break;
                    case double:
                        res[1] += 1;
                        break;
                    case string str when str.Length > 4:
                        res[2] += 1;
                        break;
                    default:
                        res[3] += 1;
                        break;
                }
            }
            return res;
        }

        static void Z6()
        {
            int[] arr1 = CountMyTypes(1.0, "asdasd", 1, "asd", 2, 5.123, 2, 5, 5, "asdasdasd", "asdasdasd", "sss", 2);
            Console.Write("Even ints: ");
            Console.WriteLine(arr1[0]);
            Console.Write("Doubles: ");
            Console.WriteLine(arr1[1]);
            Console.Write("Strings w/ 5 or more chars: ");
            Console.WriteLine(arr1[2]);
            Console.Write("Others: ");
            Console.WriteLine(arr1[3]);
            Console.Write("Total: ");
            Console.WriteLine(arr1[0] + arr1[1] + arr1[2] + arr1[3]);
        }

//==================================================================================================================================================

        static void Main(string[] args)
        {
            //Z1();
            //Z2();
            //Z3();
            //Z4();
            //Z5();
            Z6();
        }

    }
}
