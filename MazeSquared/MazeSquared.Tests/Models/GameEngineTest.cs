using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeSquared.Models;

namespace MazeSquared.Tests.Models
{
    [TestClass]
    public class ModelTesting
    {
        [TestMethod]
        public void GameEngine()
        {
            //arrange
            GameEngine testEngine= new GameEngine();
            //act
            var expected = "deNada";
            var actual = MazeSquared.Models.GameEngine.gameBoard[34];
            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void RandomStart()
        {
            //arrange
            GameEngine testEngine = new GameEngine();
            MazeSquared.Models.GameEngine.randomStart();
            //act
            var expected = MazeSquared.Models.GameEngine.gameBoard.ContainsValue("start") ;
            //assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestActiveSquare()
        {
            //arrange
            GameEngine testEngine = new GameEngine();
            MazeSquared.Models.GameEngine.activeSquare();
            //act
            var expected = MazeSquared.Models.GameEngine.gameBoard.ContainsValue("active");
            //assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestNextedActiveSquare()
        {
            //arrange
            GameEngine testEngine = new GameEngine();
            MazeSquared.Models.GameEngine.nextSquare();
            //act
            var expected = MazeSquared.Models.GameEngine.gameBoard.ContainsValue("active");
            //assert
            Assert.IsTrue(expected);
          
        }

        [TestMethod]
        public void TestWeIsUpToHere()
        {
            //arrange
            GameEngine testEngine = new GameEngine();

            //act
            var firstroll = MazeSquared.Models.GameEngine.weIsUpToHere;
            MazeSquared.Models.GameEngine.randomStart();
            var secondroll = MazeSquared.Models.GameEngine.weIsUpToHere;
            MazeSquared.Models.GameEngine.nextSquare();
            var thirdroll = MazeSquared.Models.GameEngine.weIsUpToHere;
            MazeSquared.Models.GameEngine.activeSquare();
            var fourthroll = MazeSquared.Models.GameEngine.weIsUpToHere;

            //assert
            Assert.AreNotEqual(firstroll,secondroll);
            Assert.AreNotEqual(secondroll,thirdroll);
            Assert.AreNotEqual(thirdroll,fourthroll);
           // Assert.AreNotEqual(fourthroll,firstroll);


        }
    }
}
