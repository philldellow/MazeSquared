using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace MazeSquared.Models
{
    public class GameEngine
    {
        public static Dictionary<int, string> gameBoard = new Dictionary<int, string>();
        
        public static Random rnd = new Random();
        
        public static int weIsUpToHere;

        static GameEngine()
        {
            for (int i = 0; i < 64; i++)
            {
                gameBoard.Add(i,"deNada");
            }
        }

        public static int randomStart()
        {
            int j = rnd.Next(0, 63);
            gameBoard.Remove(j);
            gameBoard.Add(j,"start");
            return weIsUpToHere = j;
        }

        public static int activeSquare()
        {
            int weGo = rnd.Next(0, 3);
            List<int> activatedSquare = new List<int>();
            activatedSquare.Add(weIsUpToHere - 1);
            activatedSquare.Add(weIsUpToHere + 1);
            activatedSquare.Add(weIsUpToHere + 8);
            activatedSquare.Add(weIsUpToHere - 8);
            
            int low = activatedSquare[weGo];
                if (low >= 64)
                {
                    return weIsUpToHere = low - 8;
                }
            if (low <= 0)
            {
                return weIsUpToHere = low + 8;
            }

            gameBoard.Remove(low);
            gameBoard.Add(low,"active");
            return weIsUpToHere=low;
        }

        public static int nextSquare()
        {
            int inWeGo = rnd.Next(0, 3);
            List<int> nextedSquare = new List<int>();
            nextedSquare.Add(weIsUpToHere - 1);
            nextedSquare.Add(weIsUpToHere + 1);
            nextedSquare.Add(weIsUpToHere + 8);
            nextedSquare.Add(weIsUpToHere - 8);
            int low = nextedSquare[inWeGo];
            if (low >= 64)
            {
                low = weIsUpToHere - 8;
                gameBoard.Remove(low);
                gameBoard.Add(low, "active");
                return weIsUpToHere = low - 8;
            }
            if (low <= 0)
            {
                low = weIsUpToHere + 8;
                gameBoard.Remove(low);
                gameBoard.Add(low, "active");
                return weIsUpToHere = low + 8;
            }
            gameBoard.Remove(low);
            gameBoard.Add(low, "active");
            
            return weIsUpToHere = low;
        }

    }
}