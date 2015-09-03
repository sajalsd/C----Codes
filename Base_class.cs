using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class
{


    class program
    {
        static void Main(string[] args)
        {
            ChildClass twoint = new ChildClass(10, 20);
            Console.WriteLine("Value of X from parent = "+twoint.x);
            Console.WriteLine("Value of y from parent = "+twoint.y);
            Console.ReadKey();
        }
    }
    
    class TwoInteger
    {
        public int x;
        public int y;

        public TwoInteger(int a, int b)
        {
            Console.WriteLine("Calling Parent constructor");
            x = a;
            y = b;
        }
    }

    class ChildClass : TwoInteger
    {

        public ChildClass(int a, int b)
            : base(a, b)
        {
           
        }
    }

    
}
