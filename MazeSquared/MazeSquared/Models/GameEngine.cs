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
            //int j = rnd.Next(0, 63);
            int j = selectRandomStart();
            gameBoard.Remove(j);
            gameBoard.Add(j,"start");
            return weIsUpToHere = j;
        }

        public static List<int> borderSquares()
        {
            List<int> outlineSquares = new List<int>();
            outlineSquares.InsertRange(outlineSquares.Count, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 17, 25, 33, 41, 49, 16, 24, 32, 40, 48, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65 });          
            return outlineSquares;
        }

        public static int selectRandomStart()
        {
            int countOfBorderSquares = borderSquares().Count;
            int r = rnd.Next(0,countOfBorderSquares);
            return borderSquares()[r];
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