﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsniTestC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prvi zadatak
            //primeri incijalizacije
            int broj;

            //drugi primer
            string text;

            //treci primer
            float decBroj;

            //Drugi zadatak

            string[] niz = new string[25];

            //Treci zadatak
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Cica");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Maca");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Cica Maca");
                }
                Console.ReadKey();

            }

        }
    }
}
