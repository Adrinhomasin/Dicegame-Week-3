using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas rohkem ongi võitja
            //programm kuulutab võitjat

            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 7);

            string PlayerOne = "Monkey";
            string PlayerTwo = "Monkey2";

            int Monkey = rnd.Next(1, 7);
            int Monkey2 = rnd.Next(1, 7);

            Console.WriteLine($"{PlayerOne} veeretas {Monkey}");
            Console.WriteLine($"{PlayerTwo} veeretas {Monkey2}");


            if (Monkey < Monkey2)
            {
                Console.WriteLine($"{PlayerTwo} võitis numbriga {myRandomNumber}");
            }
            else if (Monkey > Monkey2)
            {
                Console.WriteLine($"{PlayerOne} võitis numbriga {myRandomNumber}");
            }
            else
            {
                Console.WriteLine("Viik!");
            }
                
                    
        }
    }
}
