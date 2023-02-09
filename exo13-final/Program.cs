using System;

namespace exo13_final
{
    class Program
    {
        static void Main(string[] args)
        {
            int young = 0;
            int old = 0;
            int impossible = 0;
            int badEntry = 0;

            Console.WriteLine("Entrez les valeurs");
            string[] values = Console.ReadLine().Split(' ');
            for(int i = 0; i < values.Length; i++){
                if (double.TryParse(values[i], out double age)){
                    if (age < 50 && age > 1){
                        young++;
                    }
                    else if(age >=50){
                        old++;
                    }
                    else if(age <= 0){
                        impossible++;
                    }
                    
                }
                else{
                    badEntry++;
                }
            }
            Console.WriteLine("Personnes jeunes : " + young + "\nPersonnes agees: " + old + "\nImpossibles : " + impossible + "\nMauvaises entrees : " + badEntry);

        }
    }
}
