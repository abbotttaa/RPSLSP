using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazinglebazgo
{
    class GameMechanics
    {
        //member variables
        MatchUpChart comparisons = new MatchUpChart();
        //constructor
        public GameMechanics()
        {
            
        }
        //member methods
        public string choseYourChallenger()
        {
            Console.WriteLine("Are you playing with another person, or agaisnt the computer? Please enter \"Computer\" or \"person\"");
        }

        public void round()
        {
            player1.MakeChoice();
            player2.MakeChoice();
            comparisons.MatchUpWinner();
        }
    }
}
