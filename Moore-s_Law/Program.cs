﻿using System;

namespace Moore_s_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Introduceti un numar n pentru a afla in cati ani vom avea o putere de calcul de n ori mai mare fata de cat avem in acest moment:");
            s = Console.ReadLine();
            while (s != "exit")
            {
                try
                {
                    int n;
                    double x;
                    n = int.Parse(s);
                    x = Math.Log(n, 2) * 1.5d;
                    x = Math.Round(x, 2);
                    Console.WriteLine($"Dupa aproximativ {x} ani vom avea o putere de calcul de {n} ori mai mare la acelasi pret.");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Numar nou?");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
