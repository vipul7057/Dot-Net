using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refAndValueTyoe
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            int j = 200;

            demo d = new demo();
            d.swap(ref i,ref j);
            Console.WriteLine();
            Console.WriteLine("value of i in MAIN function "+i);
            Console.WriteLine("value of j in MAIN function " + j);
            Console.ReadLine();
        }
    }

    public class demo
    {
        public void swap(ref int i,ref int j)
        {
            int temp = i;
            i = j;
            j = temp;

            Console.WriteLine("value of i in function "+i);
            Console.WriteLine("value of j in function " + j);

        }
    }
}
