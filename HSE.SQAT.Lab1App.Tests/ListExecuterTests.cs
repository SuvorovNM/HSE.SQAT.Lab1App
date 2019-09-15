using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace HSE.SQAT.Lab1App.Tests
{
    [TestClass]
    public class ListExecuterTests
    {
        // DeleteEverySecondElement.
        // Длина последовательности
        [TestMethod]
        public void DeleteEverySecondElement_EmptyString_NullReturned()
        {
            // Arrange.
            var str = string.Empty;            
            // Act.
            var actual = ListExecuter.DeleteEverySecondElement(str);
            // Assert.
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void DeleteEverySecondElement_OneElement_OneElementReturned()
        {
            // Arrange.
            var str = "44.5";
            var expectedCount = 1;
            var expectedElement = "44.5";
            // Act.
            var actual = ListExecuter.DeleteEverySecondElement(str);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.Count, expectedCount);
            Assert.AreEqual(actual[0], expectedElement);
        }

        [TestMethod]
        public void DeleteEverySecondElement_TwoElements_FirstElementReturned()
        {
            // Arrange.
            var str = "12, 96";
            var expectedCount = 1;
            var expectedElement = "12";
            // Act.
            var actual = ListExecuter.DeleteEverySecondElement(str);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.AreEqual(expectedElement, actual[0]);           
        }

        [TestMethod]
        public void DeleteEverySecondElement_ThreeElemets_FirstAndThirdElementsReturned()
        {
            // Arrange.
            var str = "12, 96, 14.44";
            var expectedCount = 2;
            var expectedFirstElement = "12";
            var expectedSecondElement = " 14.44";
            var expectedList = new List<string>() { expectedFirstElement, expectedSecondElement };
            // Act.
            var actual = ListExecuter.DeleteEverySecondElement(str);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.IsTrue(actual.SequenceEqual(expectedList));            
        }

        [TestMethod]
        public void DeleteEverySecondElement_FiveElements_FirstThirdFifthReturned()
        {
            // Arrange.
            var str = "fsd, 14, 66, 78.5,0";
            var expectedCount = 3;
            var expectedList = new List<string>() { "fsd", " 66", "0" };
            // Act. 
            var actual = ListExecuter.DeleteEverySecondElement(str);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.IsTrue(actual.SequenceEqual(expectedList));
        }
        //Набор данных

        [TestMethod]
        public void DeleteEverySecondElement_FiveEmptyElements_FirstThirdFifthReturned()
        {
            // Arrange.
            var str = ",,,,";
            var expectedCount = 3;
            var expectedList = new List<string>() { "", "", "" };
            // Act. 
            var actual = ListExecuter.DeleteEverySecondElement(str);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.IsTrue(actual.SequenceEqual(expectedList));
        }

        [TestMethod]
        public void DeleteEverySecondElement_DeletingEmptyElementsSavingNotEmpty_NotEmptyReturned()
        {
            // Arrange.
            var str = "12,,f,, a s r,";
            var expectedCount = 3;
            var expectedList = new List<string>() { "12", "f", " a s r" };
            // Act. 
            var actual = ListExecuter.DeleteEverySecondElement(str);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.IsTrue(actual.SequenceEqual(expectedList));
        }

        [TestMethod]
        public void DeleteEverySecondElement_DeletingNotEmptyElementsSavingEmpty_EmptyReturned()
        {
            // Arrange.
            var str = ",asd,,fdf123 ,,44.9374";
            var expectedCount = 3;
            var expectedList = new List<string>() { "", "", "" };
            // Act. 
            var actual = ListExecuter.DeleteEverySecondElement(str);
            // Assert.
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.IsTrue(actual.SequenceEqual(expectedList));
        }
    }
}
