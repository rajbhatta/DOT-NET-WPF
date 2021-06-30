# Using multicast in delegation #
```c#
using System;

namespace MutlicastDelegation
{

    class Program
    {
        public delegate void PrintDelegate();

        public static void Method1()
        {
            Console.WriteLine("This is method1");
        }

        public static void Method2()
        {
            Console.WriteLine("This is method2");
        }

        static void Main(string[] args)
        {
            PrintDelegate myPrinter = Method1;
            myPrinter();

            //Using multicast that prints Method1 along with Method2
            myPrinter += Method2;
            myPrinter();
        }
    }
}

```

<img src="result.png"/>

- The delegation printed method1 first then printed method1 and method 2 together.