﻿using System;

namespace Frågesport_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            score = 0;
            string svar;
            svar = "";

            Console.WriteLine("Vad är 9 + 10?");
            Console.WriteLine("a)21  b)19  c)90");
            svar = LimitInput("21", "19", "90");
            if (svar == "b" || svar == "19")
            {
                Console.WriteLine("Rätt!");
                Console.WriteLine("+100 poäng");
                score = score + 100;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("U stupid");
                Console.ReadLine();
            }

            Console.WriteLine("Vad heter den gudalika hunden som Leo alltid använder som placeholder?");
            Console.WriteLine("a)Walter  b)Eggdog  c)Bubba");
            svar = LimitInput("Walter", "Eggdog", "Bubba");
            if (svar == "a" || svar == "Walter")
            {
                Console.WriteLine("Korrekt. Walter är vår enda gud.");
                Console.WriteLine("+100 poäng");
                score = score + 100;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Fel. Må Walter skona din vilsna själ.");
                Console.ReadLine();
            }

            Console.WriteLine("När kommer man undan matten?");
            Console.WriteLine("a)I trean  b)Efter högskolan  c)Aldrig");
            svar = LimitInput("I trean", "Efter högskolan", "Aldrig");
            if (svar == "c" || svar == "Aldrig")
            {
                Console.WriteLine("Stämmer. Dread it, run from it, math arrives all the same.");
                Console.WriteLine("+100 poäng");
                score = score + 100;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nej broder. Du kommer aldrig att kunna fly från matten.");
                Console.ReadLine();
            }

            Console.WriteLine("Slut!");
            Console.WriteLine("Poäng: " + score);
            if (score == 300)
            {
                Console.WriteLine("Perfektion. Du tilldelas härmed titeln av Big Brain, Woke och 200 IQ.");
                Console.ReadLine();
            }
            else if (score == 200)
            {
                Console.WriteLine("Inte illa. Du visar tecken på intellektualitet. Du har dock en väg kvar att gå innan du kan förstå den sanna innebörden av Walter.");
                Console.ReadLine();
            }
            else if (score == 100)
            {
                Console.WriteLine("Din prestation kan knappast kallas imponerande. Ändå finns det kanske hopp för din arma själ. Studera Walters lära, så kanske du en dag kan uppnå Medium Sized Brain.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bro. You just posted cringe. SMALL BRAIN!");
                Console.ReadLine();
            }
        }
        static string LimitInput(string alt1, string alt2, string alt3)
        {
            string svarX;
            svarX = "";
            while (svarX != "a" && svarX != "b" && svarX != "c" && svarX != alt1 && svarX != alt2 && svarX != alt3)
            {
                svarX = Console.ReadLine();
                if (svarX != "a" && svarX != "b" && svarX != "c" && svarX != alt1 && svarX != alt2 && svarX != alt3)
                {
                    Console.WriteLine("Skriv något av alternativen.");
                }
            }
            return svarX;
        }
    }
}
