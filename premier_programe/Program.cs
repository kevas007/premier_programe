using System;

namespace premier_programe // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //private static string nom;

        static void Main(string[] args)
        {
            // Demmade du nom de la  personne
            Console.WriteLine("Quel est ton nom ? ");

            // recupération de la des données de la varibale
            string? nom = Console.ReadLine();
            // Demmade de l'age de la  personne
  
            int? age_num = 0;

            while (age_num ==0)
            {
               

                // Demmade de l'age de la  personne
                Console.WriteLine("Quel est ton age ? ");

                // recupération de la des données de la varibale
                string? age = Console.ReadLine();
                try
                {
                    age_num = int.Parse(age);
                 
                }
                catch
                {
                    Console.WriteLine("Entrez un age valide");
                    //Console.WriteLine( "Age pas " );
                }
                //age_num !0
                Console.WriteLine("Bonjour" + " " + nom + " " + " j'ai " + age_num + " ans");

                // Bientôt vous aurez  31 ans
                int? age_prochain = age_num + 1;
                Console.WriteLine(" Vous  aurez " + age_prochain + " ans");
            }
         
        

          
            
 
        }
    }
}