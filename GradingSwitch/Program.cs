using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib, mis hinde kasutaja sai
            //Kui kasutaja sai ´A´, konsool kuvab "Suurepärane!";
            //´B´, konsool kuvab "Väga hea!";
            //´C´, konsool kuvab "Hea!";
            //´D´, konsool kuvab "Rahuldav";
            //´E´, konsool kuvab "Kasin";
            //´F´, konsool kuvab "Puudulik";
            //Kui kasutaja sisestab midagi muud, konsool kuvab "Vale väärtus";

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Vale väärtus");
                    break;


            }
            Console.WriteLine("Kena päeva!");









        }
    }
}
