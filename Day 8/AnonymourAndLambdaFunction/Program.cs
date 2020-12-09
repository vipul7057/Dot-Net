using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon
{
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            Action o = d.display;
            // o();
            Func<int, int, int> o1 = d.add;
            Console.WriteLine(o1(10,20));

            Console.WriteLine();

            Func<string, byte, int> o2 = d.show;
            Console.WriteLine(o2("a",0));
            Console.WriteLine();
            Func<string,byte,int> o3 = delegate(string a, byte b)
             {
                return 100;
            };

            Console.WriteLine(o3("a",9));


            Func<int, int, int> l1 = (a, b) => a + b;

            Console.WriteLine(l1(200,300));

            Func<int, int, int> l2 = (a, b) =>
              {
                  int c = a + b;
                  int d1 = c + 10;
                  return d1;
  
              };
            Console.WriteLine(l2(1,2));

            Console.ReadLine();
        }
    }

    public class demo
    {
        public  void display()
        {
            Console.WriteLine("This is display function");
        }
        public int add(int a,int b)
        {
            return a + b;
        }

        public int show(string a,byte b)
        {
            return 1;
        }
    }
}
