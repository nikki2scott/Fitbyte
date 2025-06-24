using System;
/// <summary>
/// Class contains fields age and restingHeartRate
/// </summary>
public class FitByte
{
    private int age; // private field for user's age
    private int restingHeartRate; // private field for resting heart rate

    // Default constructor sets fixed default values
    public FitByte()
    {
        age = 30; // default age
        restingHeartRate = 60; // default resting HR
    }

    // Non-default constructor sets all fields from parameters
    public FitByte(int age, int restingHeartRate)
    {
        this.age = age; // assign age from parameter
        this.restingHeartRate = restingHeartRate; // assign resting HR
    }

    // Public getter for age
    public int GetAge()
    {
        return age; // return current age
    }

    // Public setter for age
    public void SetAge(int newAge)
    {
        age = newAge; // update age
    }

    // Public getter for restingHeartRate
    public int GetRestingHeartRate()
    {
        return restingHeartRate; // return resting heart rate
    }

    // Public setter for restingHeartRate
    public void SetRestingHeartRate(int newHR)
    {
        restingHeartRate = newHR; // update resting HR
    }

    // Method to calculate target heart rate using Karvonen formula
    public double TargetHeartRate(double percentageOfMaximum)
    {
        double maxHR = 206.3 - (0.711 * age); // calculate max heart rate based on age
        double targetHR = (maxHR - restingHeartRate) * percentageOfMaximum + restingHeartRate; // calculate target HR
        return targetHR; // return calculated target heart rate
    }

    // Void method to display a motivational tip
    public void DisplayTip()
    {
        Console.WriteLine("Warm up before starting exercise and stay hydrated!"); // display tip
    }
}
