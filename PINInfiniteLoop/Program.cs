using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui issestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //kasutajal on kolm katset. i < 3;

            bool loopActive = true; //boolean --> true/false == 1/0
            int i = 0;

            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere Tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++; // i = i + 1;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-i sisestanud {i} korda");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
