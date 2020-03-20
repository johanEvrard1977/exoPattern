using Bataille_navale.Models;
using Bataille_navale.Models.commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_navale
{
    class Program
    {
        static void Main(string[] args)
        {
            FabriqueDeBateaux bleu = new Bleus();
            Console.WriteLine("nouveau contre torpilleur bleu:  " + bleu.CreerContreTorpilleur());
            Console.WriteLine("nouveau croiseur bleu:   " + bleu.CreerCroiseur());
            Console.WriteLine("nouveau porte avion bleu:   " + bleu.CreerPorteAvion());
            Console.WriteLine("nouveau torpilleur bleu:   " + bleu.CreerTorpilleur());
            FabriqueDeBateaux rouge = new Rouge();
            Console.WriteLine("nouveau contre torpilleur rouge: " + rouge.CreerContreTorpilleur());
            Console.WriteLine("nouveau croiseur rouge:   " + rouge.CreerCroiseur());
            Console.WriteLine("nouveau porte avion rouge:   " + rouge.CreerPorteAvion());
            Console.WriteLine("nouveau torpilleur rouge:   " + rouge.CreerTorpilleur());

            FabriqueDeCases cases = new Plateau();
            Console.WriteLine("plateau: " + cases.FabriquerCase());
            Console.ReadLine();
        }
    }
}
