using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var nb = rnd.Next(100) + 1;

            while (true)
            {
                Console.WriteLine("saissisez un nombre entre 1 et 100");
                int value = Convert.ToInt32(Console.ReadLine());

                if (value > nb)
                {
                    Console.WriteLine("plus grand");
                }
                else if (value < nb)
                {
                    Console.WriteLine("plus petit");
                }
                //il faut gérer le cas ou le nombre est égale au nombre aléatoire générer
                else
                {
                    Console.WriteLine("égalité");
                    Console.ReadLine();
                    // je met un break pour quitter la boucle parce que j'ai trouver le même nombre
                    break;
                }
            }
        }
    }
}
