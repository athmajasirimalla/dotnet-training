using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2


{
    public class Employee

    {
        public string FirstName = "ABCD";
        public string LastName = "EFGH";
        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName+"-FullTime");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "-PartTime");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "-Temporary");
        }

    }
    class program
    {
        public static void Main()
        {
            Employee[] Employees = new Employee[4];
            Employees[0] = new Employee();
            Employees[1] = new FullTimeEmployee();
            Employees[2] = new PartTimeEmployee();
            Employees[3] = new TemporaryEmployee();


            foreach (Employee e in Employees)
            {
                e.PrintFullName();
            }

        }
    }
}

            

       /* public static void Main()
        {
            Console.WriteLine("Hello");
        }
    }*/

