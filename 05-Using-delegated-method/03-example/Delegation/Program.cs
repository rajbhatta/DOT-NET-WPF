using System;

namespace Delegation
{
    class Program
    {
        public delegate int MathOperation(int x, int y);
        static void Main(string[] args)
        {
            MathOperation mathOperation = AddNumber;
            Console.WriteLine(mathOperation(2, 3));

            MathOperation math = Subtract;
            Console.WriteLine(math(5, 2));

        }

        static public int AddNumber(int x, int y)
        {
            return x + y;
        }

        static public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
