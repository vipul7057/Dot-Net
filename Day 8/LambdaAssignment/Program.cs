using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> q1 = (p, n, r) =>
               {
                   return (p * n * r) / 100;
               };

            Console.WriteLine("SI is " + q1(10, 10, 2));

            Func<int, int, bool> q2 = (a, b) =>
              {
                  return a > b;
              };

            Console.WriteLine(q2(10, 20));

            Predicate<int> q4 = x => x % 2 == 0;
            Employee emp1 = new Employee();
            emp1.Basic = 112;
            Predicate < Employee > q5 = emp => emp1.Basic > 100;

            Console.WriteLine(q5(emp1));

            Console.ReadLine();
        }
    }   

    public class Employee
    {
        private int basic;
        public int Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if(value > 100)
                {
                    basic = value;
                }          
            }
        }
    }
}
