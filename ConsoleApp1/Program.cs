using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random(Environment.TickCount);
            Random rnd = new Random();
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int rolls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + (int)rolls);
            Console.WriteLine();
            double star;
            

            int[] dice = {0,0,0,0,0,0,0,0,0,0,0};
            for ( int i = 0; i < rolls; ++i)
            {
                int value = 0;
                value = rnd.Next(1, 7);
                value += rnd.Next(1, 7);
                dice[value-2] += 1;
            }
            for (int i = 0; i < dice.Length; ++i)
            {
                
                Console.Write((i+2) + ": ");
                star = dice[i]/(double)rolls*100;
                for (int j = 0; j < star; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for playing dice simulator");
            Console.ReadLine();
        }
    }
}
