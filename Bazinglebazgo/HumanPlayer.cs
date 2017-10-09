using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazinglebazgo
{
    class HumanPlayer : Player
    {
        //member variables
        //constructor
        //member methods
        public override string MakeChoice()
        {
            Console.WriteLine("Please choose from \"Rock\", \"Paper\", \"Scissors\", \"Lizard\", or \"Spock\"");            
            choice = Console.ReadLine();
            switch (choice)
            {
                case "Rock":
                    return choice;                   
                case "Paper":
                    return choice;
                case "Scissors":
                    return choice;
                case "Lizard":
                    return choice;
                case "Spock":
                    return choice;
                default:
                    Console.WriteLine("No, dummy, you need to enter \"Rock\", \"Paper\", \"Scissors\", \"Lizard\", or \"Spock\"");
                    return MakeChoice();
            }
        }
    }
}
