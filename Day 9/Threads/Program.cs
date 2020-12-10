using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before call");
            Action o = display;
            o();
            Console.WriteLine("After call");

            Console.WriteLine("Before call");
            Action o = display;
            o.BeginInvoke(null, null);
            Console.WriteLine("After call");


            Console.WriteLine("Before call");
            Action<string> o2 = display;
            o2.BeginInvoke("Vipul", null, null);
            Console.WriteLine("After call");

            Console.WriteLine("Before");
            Func<string, string> o1 = display;
            demo d = new demo();
            o1.BeginInvoke("vipul zope", delegate (IAsyncResult ar)
             {
                 Console.WriteLine("This is callback function");
                 string name = o1.EndInvoke(ar);
                 Console.WriteLine("name is " + name);
             }, null);

            demo d = new demo();

            Console.WriteLine("Before addition");
            Func<int, int, int> fobj = display;

            fobj.BeginInvoke(10, 20, new AsyncCallback(delegate (IAsyncResult ar)
         {
             Console.WriteLine("This is callback function");
             int a = fobj.EndInvoke(ar);
             Console.WriteLine(a);
         }), null);
            Console.WriteLine("After addition");

            Console.ReadLine();
        }
        public static void display()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("This is display functions");
        }


        public static void display(string name)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("This is display functions " + name);
        }

        public static int display(int a, int b)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("value are {0} and {1}", a, b);
            return a + b;
        }
    }

    public class demo
    {

        public void CallbackFunction(IAsyncResult ar)
        {
            Console.WriteLine("This is callback function");
        }
    }

}
