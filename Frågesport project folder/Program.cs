using System;

namespace Frågesport_project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool spela = true;
            int score = 0;
            string svar = "";
            string text1 = "";
            string text0 = "";

            while (spela == true)
            {
                score = 0;
                Console.WriteLine("Vad är 9 + 10?");
                Console.WriteLine("a)21  b)19  c)90");
                text1 = "Rätt!";
                text0 = "U stupid";
                svar = LimitInput("21", "19", "90");
                score = Result(score, svar, "b", "19", text1, text0);

                Console.WriteLine("Vad heter den gudalika hunden som Leo alltid använder som placeholder?");
                Console.WriteLine("a)Walter  b)Eggdog  c)Bubba");
                text1 = "Korrekt. Walter är vår enda gud.";
                text0 = "Fel. Må Walter skona din vilsna själ.";
                svar = LimitInput("Walter", "Eggdog", "Bubba");
                score = Result(score, svar, "a", "Walter", text1, text0);

                Console.WriteLine("När kommer man undan matten?");
                Console.WriteLine("a)I trean  b)Efter högskolan  c)Aldrig");
                text1 = "Stämmer. Dread it, run from it, math arrives all the same.";
                text0 = "Nej broder. Du kommer aldrig att kunna fly från matten.";
                svar = LimitInput("I trean", "Efter högskolan", "Aldrig");
                score = Result(score, svar, "c", "Aldrig", text1, text0);

                Slut(score);
                Console.WriteLine("Spela igen? (J/N");
                string igen = Console.ReadLine();
                if (igen == "J" || igen == "j" || igen == "Ja" || igen == "ja")
                { }
                else
                {
                    spela = false;
                }
            }

        }
        static string LimitInput(string alt1, string alt2, string alt3)
        {
            string svarX = "";
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

        static int Result(int scoreX, string svarX, string rätt1, string rätt2, string t1, string t0)
        {
            int newScore = scoreX;
            if (svarX == rätt1 || svarX == rätt2)
            {
                Console.WriteLine(t1);
                Console.WriteLine("+100 poäng");
                newScore = newScore + 100;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(t0);
                Console.ReadLine();
            }
            return newScore;
        }

        static void Slut(int scoreX)
        {
            Console.WriteLine("Slut!");
            Console.WriteLine("Poäng: " + scoreX);
            if (scoreX == 300)
            {
                Console.WriteLine("Perfektion. Du tilldelas härmed titeln av Big Brain, Woke och 200 IQ.");
                Console.ReadLine();
            }
            else if (scoreX == 200)
            {
                Console.WriteLine("Inte illa. Du visar tecken på intellektualitet. Du har dock en väg kvar att gå innan du kan förstå den sanna innebörden av Walter.");
                Console.ReadLine();
            }
            else if (scoreX == 100)
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
    }
}
