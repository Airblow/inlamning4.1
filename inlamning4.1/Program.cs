using System;
namespace inlamning4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 10; i <= 30; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i);
            }

            for (int i = 200; i >=180;i--)
            {
                Console.WriteLine();
                Console.WriteLine(i);
            }

            for (int i = 1000; i <= 1400;i += 50)
            {   
                Console.WriteLine();
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }

    }

}