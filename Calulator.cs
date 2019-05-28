using System;

namespace CalculatorWithClass
{
    class Calulator
    {
        int num1, num2, result; //Initialize the variables

        public string Add(String FirstNumber, String SecondNumber) //Function to perform addition of two numbers
        {
            num1 = int.Parse(FirstNumber);
            num2 = int.Parse(SecondNumber);
            result = num1 + num2;
            return result.ToString();
        }

        public string Sub(String FirstNumber, String SecondNumber) // function to perform subtraction
        {
            num1 = int.Parse(FirstNumber);
            num2 = int.Parse(SecondNumber);
            result = num1 - num2;
            return result.ToString();
        }

        public string Multi(String FirstNumber, String SecondNumber) // function to perform Multiplication
        {
            num1 = int.Parse(FirstNumber);
            num2 = int.Parse(SecondNumber);
            result = num1 * num2;
            return result.ToString();
        }

        public string Div(String FirstNumber, String SecondNumber) //function to perform Division
        {
            num1 = int.Parse(FirstNumber);
            num2 = int.Parse(SecondNumber);
            result = num1 / num2;
            return result.ToString();
        }
    }
}
