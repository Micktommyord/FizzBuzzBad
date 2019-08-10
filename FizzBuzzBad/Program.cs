using System;

namespace FizzBuzzBad
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Library.FizzBuzzerBad.GetValue(i));
            }
            Console.Read();
        }
    }
}
