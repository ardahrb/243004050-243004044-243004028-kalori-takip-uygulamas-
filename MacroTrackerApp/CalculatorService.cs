using System;

namespace MacroTrackerApp
{
    public class CalculatorService
    {
        public double CalculateBMR(double weightKg, double heightCm, int age, char gender)
        {
            double bmr = (10 * weightKg) + (6.25 * heightCm) - (5 * age);

            if (gender == 'E')
            {
                bmr += 5;
            }
            else if (gender == 'K')
            {
                bmr -= 161;
            }

            return bmr;
        }

        public double CalculateTDEE(double bmr, double activityMultiplier)
        {
            return bmr * activityMultiplier;
        }

        public double CalculateTargetCalories(double tdee, int dailyCalorieDeficit)
        {
            return tdee + dailyCalorieDeficit;
        }

        public (double Protein, double Carbs, double Fat) CalculateMacros(double targetCalories)
        {
            double proteinGrams = (targetCalories * 0.30) / 4.0;
            double carbsGrams = (targetCalories * 0.40) / 4.0;
            double fatGrams = (targetCalories * 0.30) / 9.0;

            return (Math.Round(proteinGrams, 1), Math.Round(carbsGrams, 1), Math.Round(fatGrams, 1));
        }
    }
}
