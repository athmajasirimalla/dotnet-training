using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2


{
    public class Pets
    {
        //class Variables

        public static int count = 0;
        public string Name;
        public int Age;
        public float Happiness;
        //class Constructors

        public Pets()
        {
            Name = "Reo";
            Age = 2;
            Happiness = 0.4f;
            count++;
        }
        public Pets(string _Name,int _Age,float _Happiness)
        {
            Name = _Name;
            Age = _Age;
            Happiness = _Happiness;
            count++;
        }
        //class Method

        public void print()
        {
 
       
            Console.WriteLine("Name-"+Name);
            Console.WriteLine("Age-" + Age);
            Console.WriteLine("Happiness-" + Happiness);
            Console.WriteLine();
        }
        //Main Method

        public static void Main()
        {
            Pets Dog = new Pets();
            Console.WriteLine("Dog");
            Console.WriteLine("---");
            Console.Write();
            Dog.print();
            Pets cat = new Pets("Spotty",3,0.7f);
             Console.WriteLine("Cat");
            Console.WriteLine("----");
            Console.WriteLine();
            cat.print();

            Console.WriteLine();
            Console.WriteLine("Number of Animals-" + count);
        }
    }
}
   /* public class Employee

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

