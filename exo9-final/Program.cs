using System;

namespace exo9_final
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance;
            int shops = 0;

            double.TryParse(Console.ReadLine(), out balance);
            while (balance > 0)
            {
                double spent = balance / 2 + 1;

                if (spent > balance)
                {
                    break;
                }
                    

                shops++;
                balance -= spent;
            }

            Console.WriteLine("Visited"+shops +"shop(s).");
        }
        
    }
}
