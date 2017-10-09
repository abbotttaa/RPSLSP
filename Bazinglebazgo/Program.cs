using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazinglebazgo
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMechanics testThisSucker = new GameMechanics();
            testThisSucker.ExplainGame();
            testThisSucker.ChooseYourChallenger();
            testThisSucker.StartPlaying();
            testThisSucker.KeepScore();
            testThisSucker.ProclaimVictor();
            Console.ReadLine();
        }
    }
}
