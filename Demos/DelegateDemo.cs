using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    class Program
    {
        //Regular Delegate
        public delegate string MyDelegate(int i, int s);
        static int MyFunction(int i, int s)
        {
            return (i + s).ToString();
        }

        static void Main(string[] args)
        {
            //
            MyDelegate myDelegate = MyFunction;
            myDelegate(4, 10);

            //Anonymous Delegate
            MyDelegate myDelegate1 = delegate(int i, string s)
            {
                return (i + s).ToString();
            }
            myDelegate1(10, 20);

            //Composable or Chain Delegate

            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            myDelegate2(10, 50);

        }
    }
}
