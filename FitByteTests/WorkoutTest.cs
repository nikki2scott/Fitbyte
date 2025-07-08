using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FitByteNamespace; 

namespace FitByteTests
{
    /// <summary>
    /// Author: Nikki
    /// Testing: Workout.cs
    /// </summary>
    [TestClass]
    public class WorkoutTests
    {
        // Test that CaloriesBurned returns correct result
        [TestMethod]
        public void CaloriesBurned_ReturnsCorrectTotal()
        {
            var workout = new Workout("Cardio", 45);
            double actual = workout.CaloriesBurned(8.0);
            Assert.AreEqual(360.0, actual, 0.01);
        }

        // Test GetWorkoutType returns correct value
        [TestMethod]
        public void GetWorkoutType_ReturnsCorrectType()
        {
            var workout = new Workout("Strength", 30);
            Assert.AreEqual("Strength", workout.GetWorkoutType());
        }

        // Test SetWorkoutType updates the type
        [TestMethod]
        public void SetWorkoutType_ChangesType()
        {
            var workout = new Workout();
            workout.SetWorkoutType("HIIT");
            Assert.AreEqual("HIIT", workout.GetWorkoutType());
        }

        // Test GetDurationMinutes returns correct value
        [TestMethod]
        public void GetDurationMinutes_ReturnsCorrectDuration()
        {
            var workout = new Workout("Yoga", 60);
            Assert.AreEqual(60, workout.GetDurationMinutes());
        }

        // Test SetDurationMinutes updates the duration
        [TestMethod]
        public void SetDurationMinutes_ChangesDuration()
        {
            var workout = new Workout();
            workout.SetDurationMinutes(90);
            Assert.AreEqual(90, workout.GetDurationMinutes());
        }
    }
}
