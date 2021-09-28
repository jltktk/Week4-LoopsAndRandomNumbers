using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            Console.WriteLine("Arva ära arvuti genereeritud number 1-st 10-ni. Sul on kokku kolm katset.");
            
            while (i < 3)
            {
                
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == cpuNumber)
                {
                    Console.WriteLine($"Arvasid ära! Arvuti genereeritud number oli {cpuNumber}");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"See pole õige number. Proovi uuesti! Sul on {3 - i} katset jäänud.");
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
