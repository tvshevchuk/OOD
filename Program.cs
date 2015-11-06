using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using OOD.CreationalPatterns.FactoryMethod;
//using OOD.BehaviourPatterns.Strategy;
//using OOD.StructuralPatterns.Decorator;

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
            /*
            Player player = new Player("Messi", new FootKick());
            player.Kick.Algorithm();
            player.Kick = new HeadKick();
            player.Kick.Algorithm();
            player.Kick = new KneeKick();
            player.Kick.Algorithm();
            */

            //DECORATOR
            /*
            Component team1 = new FootballTeam();
            team1 = new TeamWithStadium(team1);
            Console.WriteLine("{0} - Value: {1}$", team1.Name, team1.getValue());
            Component team2 = new BasketballTeam();
            team2 = new TeamWithInfrastructure(team2);
            Console.WriteLine("{0} - Value: {1}$", team2.Name, team2.getValue());
            Component team3 = new FootballTeam();
            team3 = new TeamWithStadium(team3);
            team3 = new TeamWithInfrastructure(team3);
            Console.WriteLine("{0} - Value: {1}$", team3.Name, team3.getValue());
            */

            Console.ReadLine();
        }
    }
}
