using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisetada numbrit - 10 kuni 10;
            //programm kontrollib numbrit;
            //kui number on positiivne, konsool kuvab "positive";
            //kui number on negatiivne, konsool kuvan "negative";
            //kui number on 0, siis konsool kuvab "null";

            Console.WriteLine("Sisesta number - 10 kuni 10");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("negative");

            }
            else 
            {
                Console.WriteLine("null");
            }
        }   

    }
}
