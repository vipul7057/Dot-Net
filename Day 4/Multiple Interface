using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            database d = new operations();
            d.delete();
            d.insert();
            Console.WriteLine();
            fileOp op = new operations();
            op.delete();
            op.open();
            Console.ReadLine();
        }
    }

    public interface database
    {
        void insert();
        void delete();
    }

    public interface fileOp
    {
        void open();
        void delete();

    }

    public class operations : database, fileOp
    {
        void database.delete()
        {
            Console.WriteLine("delete of database");
        }

        public void insert()
        {
            Console.WriteLine("insert function");
        }

        public void open()
        {
            Console.WriteLine("open function");
        }
        void fileOp.delete()
        {
            Console.WriteLine("file delete function");
        }
    }
}
