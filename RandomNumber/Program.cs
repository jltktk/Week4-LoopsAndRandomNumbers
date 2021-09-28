using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1-st kuni 10-ni;
            //kui genereeritud number on 5, programm lõpertab tööd ja soovib kasutajale "Kena päeva!";
            //kui genereeritud mumber on midagi muud, siis programm jätkab oma tööd.

            Random rnd = new Random();
            int i = 0;

            while (i != 5) //kuni i ei võrdu 5-ga
            {
                int myRandomNumber = rnd.Next(1, 11); // Next argumendid(esimene number, viimane nr + 1)
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
