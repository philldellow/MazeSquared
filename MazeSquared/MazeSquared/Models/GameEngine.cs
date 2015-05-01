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
        
        public Random rnd = new Random();
        
        public int weIsUpToHere;

        public GameEngine()
        {
            for (int i = 0; i < 64; i++)
            {
                gameBoard.Add(i,"deNada");
            }
        }

        public int randomStart()
        {
            int j = rnd.Next(0, 63);
            gameBoard.Remove(j);
            gameBoard.Add(j,"start");
            return weIsUpToHere = j;
        }

        public int activeSquare()
        {
            int weGo = rnd.Next(0, 3);
            List<int> activatedSquare = new List<int>();
            activatedSquare.Add(weIsUpToHere- 1);
            activatedSquare.Add(weIsUpToHere + 1);
            activatedSquare.Add(weIsUpToHere + 8);
            activatedSquare.Add(weIsUpToHere - 8);
            
            int low = activatedSquare[weGo];
            gameBoard.Remove(low);
            gameBoard.Add(low,"active");
            return weIsUpToHere=low;
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
            gameBoard.Remove(low);
            gameBoard.Add(low, "active");
            return weIsUpToHere = low;
        }

    }
}