using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            demo d = new demo();
            d.invalid += D_invalid;
            d.Pa = 1000;
            Console.WriteLine(d.Pa);
            Console.ReadLine();
        }

        private static void D_invalid()
        {
            Console.WriteLine("Invalid value of a");
        }
    }

    public delegate void InvalidPaHandler();
    public class demo
    {

        public event InvalidPaHandler invalid;

        private int a;
        public int Pa
        {
            set
            {
                if(value < 100)
                {
                    a = value;
                }
                else
                {
                    invalid();
                }
            }
            get
            {
                return a;
            }
        }
    }
}
