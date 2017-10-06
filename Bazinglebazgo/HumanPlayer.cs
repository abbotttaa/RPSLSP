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
            return choice;

        }
    }
}
