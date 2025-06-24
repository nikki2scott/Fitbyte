using System;
/// <summary>
/// Class contains fields workoutType and durationMinutes
/// </summary>
public class Workout
{
    private string workoutType; // type of workout (cardio, strength)
    private int durationMinutes; // duration of workout in minutes

    // Default constructor sets fixed values
    public Workout()
    {
        workoutType = "Cardio"; // default workout type
        durationMinutes = 30; // default duration
    }

    // Non-default constructor to set fields
    public Workout(string workoutType, int durationMinutes)
    {
        this.workoutType = workoutType; // assign workout type
        this.durationMinutes = durationMinutes; // assign duration
    }

    // Getter for workoutType
    public string GetWorkoutType()
    {
        return workoutType; // return current workout type
    }

    // Setter for workoutType
    public void SetWorkoutType(string newType)
    {
        workoutType = newType; // update workout type
    }

    // Getter for durationMinutes
    public int GetDurationMinutes()
    {
        return durationMinutes; // return workout duration
    }

    // Setter for durationMinutes
    public void SetDurationMinutes(int newDuration)
    {
        durationMinutes = newDuration; // update duration
    }

    // Method that returns calories burned estimation (value returning method)
    public double CaloriesBurned(double caloriesPerMinute)
    {
        double totalCalories = durationMinutes * caloriesPerMinute; // calculate calories burned
        return totalCalories; // return total calories
    }

    // Void method that prints workout summary
    public void PrintSummary()
    {
        Console.WriteLine($"Workout Type: {workoutType}, Duration: {durationMinutes} minutes."); // print summary
    }
}
