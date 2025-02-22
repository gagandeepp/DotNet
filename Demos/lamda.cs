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
        static void Main(string[] args)
        {
            //Lambda Anonymous Delegate
            MyDelegate myDelegate1 =  (int i, string s)=>
            {
                return (i + s).ToString();
            }
            myDelegate1(10, 20);

        }
    }
}
