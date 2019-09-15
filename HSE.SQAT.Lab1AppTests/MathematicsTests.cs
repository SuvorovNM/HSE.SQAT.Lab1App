using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSE.SQAT.Lab1App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.Lab1App.Tests
{
    [TestClass()]
    public class MathematicsTests
    {
        // GetSquareRoots. 
        // Исключение ситуации
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSquareRoots_AIsZero_Exception()
        {
            // Arrange.
            double a = 0, b = 14, c = 3;
            // Act.
            Mathematics.GetSquareRoots(a, b, c);
            // Assert.
            //Assert.Fail
        }
        // Тестирование Набора входных данных
        [TestMethod]
        public void GetSquareRoots_TwoArgumentsAreZero_OneRootReturned()
        {
            // Arrange.
            double a = 1, b = 0, c = 0;
            double expected = 0;
            double expectedCount = 1;
            // Act.
            var actual = Mathematics.GetSquareRoots(a, b, c);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.AreEqual(expected, actual[0]);
        }

        [TestMethod]
        public void GetSquareRoots_BIsZero_TwoRootsReturned()
        {
            // Arrange.
            double a = 1, b = 0, c = -25;
            double expected1 = 5;
            double expected2 = -5;
            double expectedCount = 2;
            // Act.
            var actual = Mathematics.GetSquareRoots(a, b, c);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.AreEqual(expected1, actual[0]);
            Assert.AreEqual(expected2, actual[1]);
        }

        [TestMethod]
        public void GetSquareRoots_CIsZero_TwoRootsReturned()
        {
            // Arrange.
            double a = 1, b = -1, c = 0;
            double expected1 = 1;
            double expected2 = 0;
            double expectedCount = 2;
            // Act.
            var actual = Mathematics.GetSquareRoots(a, b, c);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.IsTrue(actual.Contains(expected1));
            Assert.IsTrue(actual.Contains(expected2));
        }

        //Тестирование выходных данных
        [TestMethod]
        public void GetSquareRoots_DiscrLessThanZero_NullReturned()
        {
            // Arrange.
            double a = 1, b = 6, c = 14;
            // Act.
            var actual = Mathematics.GetSquareRoots(a, b, c);
            // Assert.
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetSquareRoots_DiscrIsZero_OneRootReturned()
        {
            // Arrange.
            double a = 1, b = 4, c = 4;
            double expectedCount = 1;
            double expected = -2;
            // Act.
            var actual = Mathematics.GetSquareRoots(a, b, c);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.AreEqual(expected, actual[0]);
        }
        //Входные не целые и выходные не целые
        [TestMethod]
        public void GetSquareRoots_DiscrMoreThanZero_TwoRootsReturned()
        {
            // Arrange.
            double eps = 0.0000001;
            double a = -1.1, b = 4.5, c = 4.00001;
            double expectedCount = 2;
            // Act.
            var actual = Mathematics.GetSquareRoots(a, b, c);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.IsTrue(Math.Abs(a * actual[0] * actual[0] + b * actual[0] + c) < eps);
            Assert.IsTrue(Math.Abs(a * actual[1] * actual[1] + b * actual[1] + c) < eps);
        }
    }
}