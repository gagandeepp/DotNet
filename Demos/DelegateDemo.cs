using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    class Program
    {
        //Simple Delegate
        public delegate void SayHello(string name);
        public delegate int Add(int a, int b);
        //public Func<int, int> Square();
        public static void HelloFunction(string input)
        {
            Console.WriteLine("Hello:" + input);
        }
        public static void HiFunction(string input)
        {
            Console.WriteLine("Hi:" + input);
        }

        static void Main(string[] args)
        {
            //Named Delegate
            SayHello obj = HelloFunction;
            obj.Invoke("Gagan");
            //Anonymous Delegate
            Add f1 = delegate(int a, int b)
            {
                return a + b;
            };
            f1.Invoke(4, 3);
            //Composable Delegate
            obj += HiFunction;    //When Line 26 is commented then first Hello Gagan is printed then Hi Gagan is printed
            obj.Invoke("Gagan");
            //Func Delegate -
            Func<int, int> Square = (input) => { return input * input; };
            Console.WriteLine(string.Format("This is output of Func Delegate:" + Square(4)));
            //Action Delegate - No return Type 
            Action<double, double> Power = (input1, input2) => { Console.WriteLine("Action Delegate:"+Math.Pow(input1, input2)); };
            Power(2, 3);
            //Predicate Delegate - Bool return type
            Predicate<int> IsGreateThenZero = (input) => { return input > 0 ? true : false; };
            Console.WriteLine(IsGreateThenZero(5));
            //Comparison Delegate
        }
    }
}
