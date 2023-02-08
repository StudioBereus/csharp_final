using System;

namespace exo6_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer la distance ainsi que son unite de mesure (km / mi");
            string[] rep = Console.ReadLine().Split(' ');
            if(double.TryParse(rep[0], out double dist))
            {
                double res;
                if (rep[1] == "km"){
                    res = dist * 1.609;
                    Console.WriteLine(res);
                }
                else if(rep[1]=="mi"){
                    res = dist / 1.609;
                    Console.WriteLine(res);
                }
                else{
                    Console.WriteLine("Erreur de frappe");
                }
            }
        }
    }
}
