using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotCleaner.Tests
{
    [TestClass]
    public class LocationTests
    {
        [TestMethod]
        public void CreateLocation_CorrectPosition()
        {
            //Arrange

            //Act
            Location location = new Location(300, 500);

            //Assert
            Assert.AreEqual(300, location.X);
            Assert.AreEqual(500, location.Y);
        }

        [TestMethod]
        public void CompareLocation_SmallXvsLargeX_ReturnTheSmaller()
        {
            //Arrange
            Location location1 = new Location(100, 100);
            Location location2 = new Location(200, 100);
            //Act

            //Assert
            Assert.AreEqual(-1, location1.CompareTo(location2));
        }

        [TestMethod]
        public void CompareLocation_LargeXvsSmallX_ReturnTheLarger()
        {
            //Arrange
            Location location1 = new Location(200, 100);
            Location location2 = new Location(100, 400);
            //Act

            //Assert
            Assert.AreEqual(1, location1.CompareTo(location2));
        }

        [TestMethod]
        public void CompareLocation_LargeYvsSmallY_ReturnTheSmaller()
        {
            //Arrange
            Location location1 = new Location(100, 500);
            Location location2 = new Location(100, 100);
            //Act

            //Assert
            Assert.AreEqual(1, location1.CompareTo(location2));
        }

        [TestMethod]
        public void CompareLocation_SameXandY_ReturnSame()
        {
            //Arrange
            Location location1 = new Location(100, 400);
            Location location2 = new Location(100, 400);
            //Act

            //Assert
            Assert.AreEqual(0, location1.CompareTo(location2));
        }
    }
}
