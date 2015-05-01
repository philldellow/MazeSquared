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
            var actual = testEngine.gameBoard[34];
            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void RandomStart()
        {
            //arrange
            GameEngine testEngine = new GameEngine();
            testEngine.randomStart();
            //act
            var expected = testEngine.gameBoard.ContainsValue("start") ;
            //assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestActiveSquare()
        {
            //arrange
            GameEngine testEngine = new GameEngine();
            testEngine.activeSquare();
            //act
            var expected = testEngine.gameBoard.ContainsValue("active");
            //assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestNextedActiveSquare()
        {
            //arrange
            GameEngine testEngine = new GameEngine();
            testEngine.nextSquare();
            //act
            var expected = testEngine.gameBoard.ContainsValue("active");
            //assert
            Assert.IsTrue(expected);
          
        }

        [TestMethod]
        public void TestWeIsUpToHere()
        {
            //arrange
            GameEngine testEngine = new GameEngine();

            //act
            var firstroll = testEngine.weIsUpToHere;
            testEngine.randomStart();
            var secondroll = testEngine.weIsUpToHere;
            testEngine.nextSquare();
            var thirdroll = testEngine.weIsUpToHere;
            testEngine.activeSquare();
            var fourthroll = testEngine.weIsUpToHere;

            //assert
            Assert.AreNotEqual(firstroll,secondroll);
            Assert.AreNotEqual(secondroll,thirdroll);
            Assert.AreNotEqual(thirdroll,fourthroll);
           // Assert.AreNotEqual(fourthroll,firstroll);


        }
    }
}
