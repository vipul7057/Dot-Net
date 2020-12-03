using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 c = new Class1();
            //try
            //{
            //    c.display();
            //    c.display();

            //    c.Dispose();

            //    c.display();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Cannot call anymore");
            //}

            using (Class1 c = new Class1())
            {
                c.display();
            }

                Console.ReadLine();
        }
    }

    public class Class1 : IDisposable
    {
        public void display()
        {
            checkDispose();
            Console.WriteLine("display function");
        }
        bool isDispose = false;
        public void checkDispose()
        { 
            if(isDispose)
            {
                throw new ObjectDisposedException("Class1");
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose function called");
            isDispose = true;
        }
    }
}
