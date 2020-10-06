using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Consoletest1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Skriv in ditt nummer!");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 50)
            {
                Console.WriteLine("Ditt nummer är mindre än 50!");
            }

            if (number > 50)
            {
                Console.WriteLine("Ditt nummer är högre än 50!");
            }
            Console.Write("Ditt nummer äer " + number);




            {

            }




        }
    }
}
