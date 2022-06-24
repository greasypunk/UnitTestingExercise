using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 1: Add a reference to your UnitTestingExercise project:
        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // and add your reference to the UnitTestingExercise project
        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 
        // Step 4: 
        // Create a Subtract method that accepts 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        // Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method
        // Step 6: 
        // Create a Multiply method that passes 2 integers
        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 
        // Step 8: 
        // Create a Divide method that passes 2 integers
        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 
        //*****NOW RUN ALL OF YOUR TESTS*********//

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int product1, int product2)
        {
            return product1 * product2;
        }

        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0 || divisor == 0)
                    return 0;
            return dividend / divisor;
        }
    }
}
