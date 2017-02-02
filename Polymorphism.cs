using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    //class BaseClass       version 1
    //{
    //    public void SayHello()
    //    {
    //        Console.WriteLine("SayHello in Base");
    //    }
    //    public void SayHi()
    //    {
    //        Console.WriteLine("SayHi in Base");
    //    }
    //}
    //class DerivedClass : BaseClass
    //{
    //    public void SayHello()
    //    {
    //        Console.WriteLine("SayHello in Derived");        //BaseClass obj2 = new DerivedClass();      and same for (method is virtual/non virtual in base class and method used as new in Derived class)
                                                               // obj2.SayHello();  //Say Hello in Base
                                                               //obj2.SayHi();  //Say Hi in Base
    //    }
    //    public void SayHi()
    //    {
    //        Console.WriteLine("SayHi in Derived");
    //    }
    //}


    //class BaseClass  Version 2
    //{
    //    public virtual void SayHello()
    //    {
    //        Console.WriteLine("SayHello in Base");
    //    }
    //    public virtual void SayHi()
    //    {
    //        Console.WriteLine("SayHi in Base");
    //    }
    //}
    //class DerivedClass : BaseClass
    //{
    //    public override void SayHello()
    //    {
    //        Console.WriteLine("SayHello in Derived");                          //BaseClass obj2 = new DerivedClass();
                                                                                // obj2.SayHello();  //Say Hello in Derived
                                                                                //obj2.SayHi();  //Say Hi in Dervied
    //    }
    //    public override void SayHi()
    //    {
    //        Console.WriteLine("SayHi in Derived");
    //    }
    //}

    // abstract class BaseClass
    //{
    //    public abstract void SayHello();
      
    //}
    //class DerivedClass : BaseClass
    //{
    //    public virtual void SayHello()
    //    {
    //        Console.WriteLine("SayHello in Derived");
    //    }
    //}

    interface IHello
    {
        void Hello();
    }

    interface ISayHello
    {
        void Hello();
    }

    class SayHello : IHello,ISayHello
    {
        void IHello.Hello()
        {
            Console.WriteLine("From IHello");
        }
        void ISayHello.Hello()
        {
            Console.WriteLine("From ISayHello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        
            SayHello obj = new SayHello();
            IHello ih = obj;
            ih.Hello();                    // IHello
            ISayHello ish = (ISayHello)ih; // or obj 
            ish.Hello();                   // ISayHello
        }

    }

}
