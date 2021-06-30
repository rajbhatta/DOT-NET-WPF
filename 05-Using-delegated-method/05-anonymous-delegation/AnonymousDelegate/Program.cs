using System;

namespace AnonymousDelegate
{

    public delegate string GreetingDelgate(string name);
    class Program
    {
        public static string greeting(string name)
        {
            return "hello"+name;
        }
        static void Main(string[] args)
        {
           

            GreetingDelgate obj = delegate (string name) {
                return "Hello" + name;
             };

            obj.Invoke("A");
        }
    }
}
