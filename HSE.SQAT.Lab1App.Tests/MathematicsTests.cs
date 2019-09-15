using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

namespace HSE.SQAT.Lab1App.Tests
{
    [TestClass]
    class MathematicsTests
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
    }
}
