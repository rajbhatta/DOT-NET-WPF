# What is action and func delegate ? #
- Action Delegate
- Action in C# represents a delegate that has void return type and optional parameters.
- An Action delegate can take up to 16 input parameters of different types.
- In our delegate example we declared the delegate as below:

```c#
delegate void ArithmeticOperation(double operand1, double operand2);
```

- If we use an Action delegate we do not need this declaration and we can directly make the assignment as below:

```c#
Action<double,double> sum = Addition;
```

- As you see, parameter types must be the same.
- So our code becomes the following:

```c#
using System;

namespace ActionDelegate
{
    class Program
    {
        static void Addition(double number1, double number2)
        {
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }

        static void Main(string[] args)
        {
            Action<double,double> sum = Addition; //This line changed
            sum(10, 5);
            Console.WriteLine();
        }
    }
}
```

# An anonymous method can be assigned to Action delegate as below: #
```c#
using System;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<double,double> sum = delegate (double number1, double number2)
            {
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            };
            sum(10, 5);
            Console.WriteLine();
        }
    }
}
```

# A lambda expression can also be used with Action delegate as below: #
```c#
using System;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<double,double> sum = (number1, number2) => Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            sum(10, 5);
            Console.WriteLine();
        }
    }
}
```


# Reference #
- https://itnext.io/delegates-anonymous-methods-and-lambda-expressions-5ea4e56bbd05