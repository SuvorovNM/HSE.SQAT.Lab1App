using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HSE.SQAT.Lab1App.Tests
{
    [TestClass]
    public class ChessCheckerTests
    {
        //SearchForStrikingQueens. 
        //Исключительная ситуация
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SearchForStrikingQueens_EqualPositions_Exception()
        {
            // Arrange.
            sbyte aX = 3, aY = 5, bX = 3, bY = 5;
            // Act.
            ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            //Assert.Fail
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SearchForStrikingQueens_InvalidFirstXPosition_Exception()
        {
            // Arrange.
            sbyte aX = -3, aY = 5, bX = 3, bY = 5;
            // Act.
            ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            //Assert.Fail
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SearchForStrikingQueens_InvalidFirstYPosition_Exception()
        {
            // Arrange.
            sbyte aX = 4, aY = 12, bX = 3, bY = 5;
            // Act.
            ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            //Assert.Fail
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SearchForStrikingQueens_InvalidSecondXPosition_Exception()
        {
            // Arrange.
            sbyte aX = 4, aY = 6, bX = 9, bY = 5;
            // Act.
            ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            //Assert.Fail
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SearchForStrikingQueens_InvalidSecondYPosition_Exception()
        {
            // Arrange.
            sbyte aX = 4, aY = 6, bX = 5, bY = 0;
            // Act.
            ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            //Assert.Fail
        }

        //Тестирование набора данных

        [TestMethod]
        public void SearchForStrikingQueens_CannotStrike_FalseReturned()
        {
            // Arrange.
            sbyte aX = 8, aY = 8, bX = 1, bY = 2;
            bool expected = false;
            // Act.
            var actual=ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchForStrikingQueens_StrikeOnVertical_FalseReturned()
        {
            // Arrange.
            sbyte aX = 8, aY = 8, bX = 8, bY = 2;
            bool expected = true;
            // Act.
            var actual = ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchForStrikingQueens_StrikeOnHorizontal_FalseReturned()
        {
            // Arrange.
            sbyte aX = 3, aY = 4, bX = 8, bY = 4;
            bool expected = true;
            // Act.
            var actual = ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchForStrikingQueens_StrikeOnMainDiagonal_FalseReturned()
        {
            // Arrange.
            sbyte aX = 3, aY = 4, bX = 5, bY = 6;
            bool expected = true;
            // Act.
            var actual = ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchForStrikingQueens_StrikeOnSideDiagonal_FalseReturned()
        {
            // Arrange.
            sbyte aX = 5, aY = 4, bX = 3, bY = 6;
            bool expected = true;
            // Act.
            var actual = ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchForStrikingQueens_StrikeNearby_FalseReturned()
        {
            // Arrange.
            sbyte aX = 5, aY = 4, bX = 5, bY = 5;
            bool expected = true;
            // Act.
            var actual = ChessChecker.SearchForStrikingQueens(aX, aY, bX, bY);
            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}
