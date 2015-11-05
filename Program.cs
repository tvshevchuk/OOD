using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using OOD.CreationalPatterns.FactoryMethod;
using OOD.BehaviourPatterns.Strategy;

namespace OOD
{
    class Program
    {
        static void Main(string[] args)
        {
            //FACTORY METHOD
            /*
            BallCompany comp1 = new BallCompany("Adidas");
            Product prod1 = comp1.Create();
            SportwearCompany comp2 = new SportwearCompany("New balance");
            Product prod2 = comp2.Create();
            BootsCompany comp3 = new BootsCompany("Nike");
            Product prod3 = comp3.Create();
            */

            //STRATEGY
            Player player = new Player("Messi", new FootKick());
            player.Kick.Algorithm();
            player.Kick = new HeadKick();
            player.Kick.Algorithm();
            player.Kick = new KneeKick();
            player.Kick.Algorithm();

            Console.ReadLine();
        }
    }
}
