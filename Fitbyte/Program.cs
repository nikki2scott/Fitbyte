// See https://aka.ms/new-console-template for more information

// Create FitByte object 
FitByte myFitByte = new FitByte(30, 60); // age 30, resting HR 60
        
// Create Workout object 
Workout myWorkout = new Workout("Strength Training", 45); // strength workout for 45 minutes

// method to calculate target heart rate at 75% max effort
double targetHR = myFitByte.TargetHeartRate(0.75);
Console.WriteLine($"Target Heart Rate at 75% effort:{targetHR:F2} bpm");

// FitByte void method to display tip
 myFitByte.DisplayTip();

// method to calculate calories burned assuming 8 calories per minute
double calories = myWorkout.CaloriesBurned(8);
Console.WriteLine($"Estimated Calories Burned: {calories:F2}");

// Workout void method to print summary
myWorkout.PrintSummary();

