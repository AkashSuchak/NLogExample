using System;

namespace NLogExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Display Message
            Console.WriteLine("Welcome To Addition Problem : ");
            Console.WriteLine("------------------------------");

            //User Inputs
            Console.WriteLine("Enter Value Of A : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of B : ");
            int b = Convert.ToInt32(Console.ReadLine());

            //Object of class to do Addition
            AddNumbers addNumbers = new AddNumbers();
            Console.WriteLine("Result Is : " + addNumbers.Sum(a, b));
        }
    }
}
