# FitByte: C# Exercise Assistant

## Author
Nikki Scott

## Project Description

This project is a C# console application that simulates a simple exercise assistant. It includes two custom classes:

- **FitByte** – Calculates target heart rate using the Karvonen formula based on age and resting heart rate.
- **Workout** – Tracks basic workout details such as type, duration, and estimated calories burned.

The goal is to practice C# class design using:

- Constructors (default and non-default)
- Private fields with public getters and setters
- Void and value-returning methods
- Object instantiation and method calls in `Program.cs`

## Files Included

- `FitByte.cs` – Defines the FitByte class.
- `Workout.cs` – Defines the Workout class.
- `Program.cs` – Contains the Main method with object creation and method calls.
- `README.md` – Project overview and instructions.

## How to Run the Code

1. Clone the repository:
   ```bash
   git clone https://github.com/nikki2scott/FitByte.git

## Unit Testing Information

**Author:** Nikki  
**Test Framework:** MSTest  
**How to Run Tests:**
dotnet test


**What's Being Tested:**

- `FitByte.cs`
  - `TargetHeartRate()`: Ensures correct heart rate calculation
  - `GetAge()` / `SetAge()`: Age property access
  - `GetRestingHeartRate()` / `SetRestingHeartRate()`: Resting HR access

- `Workout.cs`
  - `CaloriesBurned()`: Calculates total calories
  - `GetWorkoutType()` / `SetWorkoutType()`
  - `GetDurationMinutes()` / `SetDurationMinutes()`



