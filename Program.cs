using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Variables";

            char letter = 'D';
            int number = 100;
            float weight = 98.5f;
            double pi = 3.14;
            decimal sum = 1000.0m;
            string name = "Dhamukanna";
            bool IsActive = true;

            Console.WriteLine("char Letter :\t" + letter);
            Console.WriteLine("int Number :\t" + number);
            Console.WriteLine("float Weight :\t" + weight);
            Console.WriteLine("double Pi :\t" + pi);
            Console.WriteLine("decimal Sum :\t" + sum);
            Console.WriteLine("string Name :\t" + name);
            Console.WriteLine("bool Status :\t" + IsActive);
            Console.ReadLine();

                

        }
    }
}
