using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FitByteNamespace; 

namespace FitByteTests
{
    /// <summary>
    /// Author: Nikki
    /// Testing: FitByte.cs
    /// </summary>
    [TestClass]
    public class FitByteTests
    {
        // Test that TargetHeartRate returns correct value using known inputs
        [TestMethod]
        public void TargetHeartRate_ReturnsCorrectValue()
        {
            var fitByte = new FitByte(30, 60);
            double expected = (206.3 - (0.711 * 30) - 60) * 0.75 + 60;
            double actual = fitByte.TargetHeartRate(0.75);
            Assert.AreEqual(expected, actual, 0.01);
        }

        // Test GetAge returns expected age
        [TestMethod]
        public void GetAge_ReturnsCorrectAge()
        {
            var fitByte = new FitByte(28, 55);
            Assert.AreEqual(28, fitByte.GetAge());
        }

        // Test SetAge correctly changes age
        [TestMethod]
        public void SetAge_ChangesAge()
        {
            var fitByte = new FitByte();
            fitByte.SetAge(35);
            Assert.AreEqual(35, fitByte.GetAge());
        }

        // Test GetRestingHeartRate returns expected value
        [TestMethod]
        public void GetRestingHeartRate_ReturnsCorrectValue()
        {
            var fitByte = new FitByte(22, 62);
            Assert.AreEqual(62, fitByte.GetRestingHeartRate());
        }

        // Test SetRestingHeartRate updates resting HR
        [TestMethod]
        public void SetRestingHeartRate_ChangesValue()
        {
            var fitByte = new FitByte();
            fitByte.SetRestingHeartRate(70);
            Assert.AreEqual(70, fitByte.GetRestingHeartRate());
        }
    }
}
