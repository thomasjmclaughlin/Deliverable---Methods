using System;

namespace Deliverable___Methods
{
    class Program
    {
        static void integerOperation(int firstInteger, int secondInteger, string operatorName)
        {
            //Variable to be updated with final calculation value
            int finalCalculation = 0;

            //Convert operatorName to lowercase for normalization purposes
            operatorName = operatorName.ToLower();

            //Determine which operation is to be performed, then conduct calculation to update finalCalculation numeric variable


            //Prints final output of calculation in user-friendly text
            Console.WriteLine("The " + operatorName + " of " + firstInteger.ToString() + " and " + secondInteger.ToString() + " is: " + finalCalculation.ToString());
        }
        static void Main(string[] args)
        {
            //Console prints my Name at program start
            Console.WriteLine("Name: Thomas McLaughlin");

            //Asks users which 2 integers they would like to operate
            //Take first user input, save as variable firstInteger
            Console.WriteLine("Enter first integer to operate on:");
            int firstInteger = Int32.Parse(Console.ReadLine());
            //Take second user input, save as variable secondInteger
            Console.WriteLine("Enter second integer to operate on:");
            int secondInteger = Int32.Parse(Console.ReadLine());
            //Take desired operation, save as variable operatorName
            Console.WriteLine("Enter desired operator for integers: (SUM, DIFFERENCE, PRODUCT, QUOTIENT)");
            string operatorName = Console.ReadLine();
            //Asks user which operations they would like to perform

            //Calls integerOperation method to perform calculation and return output
            integerOperation(firstInteger, secondInteger, operatorName);
        }
    }
}
