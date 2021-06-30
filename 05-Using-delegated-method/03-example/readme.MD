# Example 1 for delegation #
```c#
using System;

namespace Delegation
{
    class Program
    {
        public delegate int MathOperation(int x, int y);
        static void Main(string[] args)
        {
            //instatiating delegation
            MathOperation mathOperation = new MathOperation(AddNumber);
            Console.WriteLine(mathOperation.Invoke(2, 3));

            //instantiating delegation
            MathOperation math = new MathOperation(Subtract);
            Console.WriteLine(math.Invoke(5, 2));

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

```

# Example 2 for delegation #
```c#
using System;

namespace Delegation
{
    class Program
    {
        public delegate int MathOperation(int x, int y);
        static void Main(string[] args)
        {
            //invoke can be removed
            MathOperation mathOperation = new MathOperation(AddNumber);
            Console.WriteLine(mathOperation(2, 3));

            //invoke can be removed
            MathOperation math = new MathOperation(Subtract);
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

```

# Example 3 delegate example #
```c#
using System;

namespace Delegation
{
    class Program
    {
        public delegate int MathOperation(int x, int y);
        static void Main(string[] args)
        {
            //new can be removed
            MathOperation mathOperation = AddNumber;
            Console.WriteLine(mathOperation(2, 3));

            //new can be removed
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

```