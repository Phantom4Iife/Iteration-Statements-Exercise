using System;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            DisplayNumbersInRange();
            ShowEveryThirdNumber();
            
            Console.Write("Enter the first number: ");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondValue = int.Parse(Console.ReadLine());
            Console.WriteLine(CompareNumbers(firstValue, secondValue) ? "Both numbers are the same." : "The numbers are different.");
            
            Console.Write("Enter a number to check if it's even or odd: ");
            int evenOddNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckIfEven(evenOddNumber) ? "This is an even number." : "This is an odd number.");
            
            Console.Write("Enter a number to determine positivity: ");
            int positiveNegativeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckIfPositive(positiveNegativeNumber) ? "This is a positive number." : "This is a negative number.");
            
            Console.Write("Enter your age to determine voting eligibility: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine(VerifyVotingEligibility(userAge) ? "You are allowed to vote!" : "Sorry, you are not old enough to vote yet.");
            
            Console.Write("Enter a number to verify if it falls within the range (-10 to 10): ");
            int rangeCheckNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckRange(rangeCheckNumber) ? "The number is within range." : "The number is out of range.");
            
            Console.Write("Enter a number to generate its multiplication table: ");
            int multiplicationBase = int.Parse(Console.ReadLine());
            GenerateMultiplicationTable(multiplicationBase);
        }

        static void DisplayNumbersInRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void ShowEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        static bool CompareNumbers(int numberOne, int numberTwo)
        {
            return numberOne == numberTwo;
        }

        static bool CheckIfEven(int value)
        {
            return value % 2 == 0;
        }

        static bool CheckIfPositive(int value)
        {
            return value > 0;
        }

        static bool VerifyVotingEligibility(int age)
        {
            return age >= 18;
        }

        static bool CheckRange(int value)
        {
            return value >= -10 && value <= 10;
        }

        static void GenerateMultiplicationTable(int baseNumber)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {baseNumber} = {i * baseNumber}");
            }
        }
    }
}

