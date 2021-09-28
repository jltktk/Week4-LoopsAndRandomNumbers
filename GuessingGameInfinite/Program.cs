using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool LoopActive = true;

            Console.WriteLine("Arva ära arvuti genereeritud number 1-st 10-ni. Arvamiste arv on lõpmatu.");

            while (LoopActive)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());

                if(userInput == cpuNumber)
                {
                    Console.WriteLine($"Arvasid ära! Arvuti genereeritud number oli {cpuNumber}");
                    LoopActive = false;
                }
                else
                {
                    Console.WriteLine("See pole õige number. Proovi uuesti!");
                }

            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
