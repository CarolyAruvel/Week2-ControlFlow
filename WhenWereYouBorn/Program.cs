using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kuvab kasutja vanust

            Console.WriteLine("Mis aastal sa sündinud oled?");

            int YearOfBirth = Convert.ToInt16(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            Console.WriteLine($"Oled {Age} aastat vana");
            Console.ReadLine();




           
        }
    }
}
