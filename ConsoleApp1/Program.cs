﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2


{
    //Getter and Setter Method
    public class Student
    {
        private int _id;
        private string _name;
        private int _passmarks=35;
        public int GetPassMarks()
        {
            return this._passmarks;
        }

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student Id cannot be nagative");

            }
            this._id = Id;

        }
        public int GetId()
        {
            return this._id;

        }
        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be Null or Empty");

            }
            this._name = Name;
        }

        public string GetName()
        {
            if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }
        }
        public class program
        {
            public static void Main()
            {
                Student C1 = new Student();
                C1.SetId(100);
                C1.SetName("Scott");
                C1.GetPassMarks();
                Console.WriteLine("Student Id = {0}", C1.GetId());
                Console.WriteLine("Student Name = {0}", C1.GetName());
                Console.WriteLine("PassMarks = {0}", C1.GetPassMarks());

            }
        }
    }
}
/* public class BaseClass
    {
        public virtual void print()
        {
            Console.WriteLine("This is a Baseclass method");
        }

    }
    public class DerivedClass : BaseClass
    {
        public override void print()
        {
            Console.WriteLine("This is a DerivedClass method");
        }
    }
    class program
    {
        public static void Main()
        {
            BaseClass B = new DerivedClass();
            B.print();

        }
    }
}
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
}*/

         //string   

       /* public static void Main()
        {
            Console.WriteLine("Hello");
        }
    }*/

