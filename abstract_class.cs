using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            double salary = Convert.ToDouble(Console.ReadLine());


            Accounts ac = new Accounts(name, salary);
            HR hr = new HR(name, salary);

            Console.WriteLine("\nSalary of "+ac.name +" from account class with 60% bonus: " +ac.SalaryAmount());
            Console.WriteLine("\nSalary of " + hr.name + " from HR class, only Basic: " + hr.SalaryAmount());
          

            Console.ReadKey();

        }
    }

    public abstract class Calculation
    {
        public string name { get; set; }
        public double salary { get; set; }

        public Calculation(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        abstract public double SalaryAmount();
        
    }

    public class Accounts : Calculation
    {

        public Accounts(string name, double salary)
            : base(name, salary)
        {
        }

        public override double SalaryAmount()
        {
            return salary +(salary*0.60); // 60% bonous added
        }
    }

    public class HR : Accounts
    {
        public HR(string name, double salary)
            : base(name, salary)
        {
        }

        public override double SalaryAmount()
        {
            return salary; // basic scale
        }
    }

}
