using Delegate_Exercise_CL;
using System;

namespace Delegate_Exercise_Console
{
    internal class Program
    {
        /// <summary>
        /// Application should take a starting number from user - and either invoke an add opertion or substraction
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IBasicArithmeticOp arithmeticInstance = null;
            var initialValue = int.Parse(Console.ReadLine());

            //Instantiate an instance of DoArithmeticOp here with the initial value

            Console.WriteLine(@"
            Select:
            1 - To add to initial value
            2 - To substact from initial value");
            var selection = int.Parse(Console.ReadLine());

            Console.WriteLine(@" Enter value to either add or substract");
            var input = int.Parse(Console.ReadLine());

            // Base on selection, either invoke Add, or Substract
            // You will need to create a substract method in this class
            // define a delegate in the class library that matches the add and substract method signature
            // create a definition in IBasicArithmeticOp that accepts the delegate as input and provide the implementation in the BasicArithmeticOp class

            Console.WriteLine($"Result = {arithmeticInstance.Result}");
            Console.ReadLine();
        }

        public static int Add(int result, int input)
        {
            return result + input;
        }

        public static int Substract(int result, int input)
        {
            return result - input;
        }
    }
}
