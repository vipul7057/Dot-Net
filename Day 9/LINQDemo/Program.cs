using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static List<employee> empli = new List<employee>();
        static void Main(string[] args)
        {
            add();

            var emplist = from emp in empli select new { emp.Pempid,emp.Pname };

            foreach (var item in emplist)
            {
                Console.WriteLine("{0} and {1}", item.Pempid,item.Pname);
            }

            Console.ReadLine();
        }

        public static void add()
        {

            empli.Add(new employee { Pempid = 1, Pname = " ABC" });
            empli.Add(new employee { Pempid = 2, Pname = "NAME" });
            empli.Add(new employee { Pempid = 3, Pname = "XYZ" });
        }
    }

    public class employee
    {
        private int empid;
        public int Pempid
        {
            get
            {
                return empid;
            }
            set
            {
                empid = value;
            }
        }

        private string empname;
        public string Pname
        {
            get
            {
                return empname;
            }
            set
            {
                empname = value;
            }
        }
    }
}
namespace LinqDemo2
{
    class Program
    {
        static List<employee> empli = new List<employee>();
        static void Main(string[] args)
        {
            add();

           var emplist = from emp in empli select emp;

            foreach (var item in emplist)
            {
                Console.WriteLine("{0} and {1}", item.Pempid, item.Pname);
            }

            Console.ReadLine();
        }

        public static void add()
        {

            empli.Add(new employee { Pempid = 1, Pname = " ABC" });
            empli.Add(new employee { Pempid = 2, Pname = "NAME" });
            empli.Add(new employee { Pempid = 3, Pname = "XYZ" });
        }
    }

    public class employee
    {
        private int empid;
        public int Pempid
        {
            get
            {
                return empid;
            }
            set
            {
                empid = value;
            }
        }

        private string empname;
        public string Pname
        {
            get
            {
                return empname;
            }
            set
            {
                empname = value;
            }
        }
    }
}
