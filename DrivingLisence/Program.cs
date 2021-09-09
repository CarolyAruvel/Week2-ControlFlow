using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana,
            //et juhiluba saada (tingimuseks 18 aastat vana)

            Console.WriteLine("Mis aastal sa sündisid?");
            int YearOfBirth = Convert.ToInt16(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            Console.WriteLine($"Oled sündindud aastal {YearOfBirth}.");

            if (Age >= 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada");

            }
            else 
            {
                Console.WriteLine("Oled liiga noor");
            }

            Console.WriteLine("Kena päeva!");

          

        } 

    }
}
