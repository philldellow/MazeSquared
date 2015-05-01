using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace MazeSquared.Models
{
    public class GameEngine
    {
        public Dictionary<int, string> gameBoard = new Dictionary<int, string>();
        public List<int> badsquare;
        public Random rnd = new Random();

        public GameEngine()
        {
            for (int i = 0; i < 64; i++)
            {
                gameBoard.Add(i,"deNada");
            }
        }

        public int randmonStart()
        {
            int j = rnd.Next(0, 63);
            gameBoard.Add(j, "start");
            return j;
        }

        public int activeSquare()
        {
            int weGo = rnd.Next(0, 3);
            List<int> activatedSquare = new List<int>();
            activatedSquare.Add(randmonStart()- 1);
            activatedSquare.Add(randmonStart() + 1);
            activatedSquare.Add(randmonStart() + 8);
            activatedSquare.Add(randmonStart() - 8);
            int low = activatedSquare[weGo];
            gameBoard.Add(low,"active");
            return activatedSquare[weGo];
        }

        public int nextSquare()
        {
            int inWeGo = rnd.Next(0, 3);
            List<int> nextedSquare = new List<int>();
            nextedSquare.Add(activeSquare() - 1);
            nextedSquare.Add(activeSquare() + 1);
            nextedSquare.Add(activeSquare() + 8);
            nextedSquare.Add(activeSquare() - 8);
            int low = nextedSquare[inWeGo];
            gameBoard.Add(low, "active");
            return low;
        }

    }
}