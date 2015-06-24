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
        public static Dictionary<int, int> partner = new Dictionary<int, int>();
        
        public static Random rnd = new Random();
        
        public static int weIsUpToHere;

        static GameEngine()
        {
            for (int i = 1; i < 64; i++)
            {
                gameBoard.Add(i,"deNada");
            }
        }

        public static int randomStart()
        {
            int j = selectRandomStart();
            gameBoard.Remove(j);
            gameBoard.Add(j,"start");
            return weIsUpToHere = j;
        }

        public static List<int> borderSquares()
        {
            List<int> outlineSquares = new List<int>();
            outlineSquares.InsertRange(outlineSquares.Count, new int[] { 2, 3, 4, 5, 6, 7, 9, 17, 25, 33, 41, 49, 16, 24, 32, 40, 48, 56, 58, 59, 60, 61, 62, 63 });          
            return outlineSquares;
        }

        public static int selectRandomStart()
        {
            int countOfBorderSquares = borderSquares().Count;
            int r = rnd.Next(0,countOfBorderSquares-1);
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

        public static int internalPartner()
        {
            partner.Add(2, 10);
            partner.Add(3, 11);
            partner.Add(4, 12);
            partner.Add(5, 13);
            partner.Add(6, 14);
            partner.Add(7, 15);
            partner.Add(9, 10);
            partner.Add(16, 15);
            partner.Add(17, 18);
            partner.Add(24, 23);
            partner.Add(25, 26);
            partner.Add(32, 31);
            partner.Add(33, 34);
            partner.Add(40, 39);
            partner.Add(41, 42);
            partner.Add(48, 47);
            partner.Add(49, 50);
            partner.Add(56, 55);
            partner.Add(58, 50);
            partner.Add(59, 51);
            partner.Add(60, 52);
            partner.Add(61, 53);
            partner.Add(62, 54);
            partner.Add(63, 55); 
            return partner[weIsUpToHere];
    }
    }
}