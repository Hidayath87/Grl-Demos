using System;

namespace Operator
{
    class BitWiseAND
    {
        public static void Main(string[] args)
        {
            int firstNumber = 14, secondNumber = 11, result;
            result = firstNumber & secondNumber;
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result);
        }
    }
}