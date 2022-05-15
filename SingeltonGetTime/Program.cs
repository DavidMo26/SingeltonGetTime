using System;

namespace SingeltonGetTime 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = Clock.GetInstance();
            Clock clock2 = Clock.GetInstance();


            if (clock == clock2)
                Console.WriteLine("Singelton Works");

        }
    }
}