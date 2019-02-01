using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Inheritence Example//
class Employee
{
    string FirstName;
    string LastName;
    string MailId;

    public void PrintFullDetails()
    {
        Console.WriteLine();
        Console.WriteLine(FirstName + " " + LastName);
        Console.WriteLine();
        Console.WriteLine(MailId);
        Console.WriteLine();


    }
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;

    }
    public class PartTimeEmployee : Employee
    {
        public new void PrintFullDetails()
        {

            Console.WriteLine(FirstName + " " + LastName + "- Contractor");
            Console.WriteLine();
            Console.WriteLine(MailId);
        }
        public float HourlyRate;
    
}
    class Program
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = ("LOGIQINT");
            FTE.LastName = ("TECHNOLOGY");
            FTE.MailId = ("logiqintservices@gmail.com");
            FTE.YearlySalary = 180000;
            Console.WriteLine();
            PartTimeEmployee PTE = new PartTimeEmployee();


            PTE.FirstName = ("SERVICES");
            PTE.LastName = ("LIMITED");
            PTE.MailId = ("serviceslimited@gmail.com");
            PTE.HourlyRate = 200000;
            FTE.PrintFullDetails();
            PTE.PrintFullDetails();

        }

    }
} 
/*public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("parentclass constructor called");
    }
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
    public class ChildClass : ParentClass
    {
        public ChildClass() //: base("derived class controlling parentclass")
        {
            Console.WriteLine("childclass constructor called");
        }
        public static void Main()
        {
            ChildClass CC = new ChildClass();
            
        }
    }
}*/

//Inheritence Example//

/*class rectangle
{
    int length;
    int breadth;
    public rectangle(int Length, int Breadth)
    {
        this.length = Length;
        this.breadth = Breadth;

    }
    public int AreaOfRectangle()
    {
        return this.length * this.breadth;

    }
}
class Program
{
    public static void Main()
    {

        

        rectangle R1 = new rectangle(67, 86);
       int Area1= R1.AreaOfRectangle();
        Console.WriteLine("Area of the Reactangle ={0}", Area1);
        rectangle R2 = new rectangle(24, 32);
        int Area2 = R2.AreaOfRectangle();
        Console.WriteLine("Area of the Reactangle ={0}", Area2);

    }
}
class customer
{
    string firstName;
    string lastname;
    string mail;
    public customer() : this("not provided","not provided","not provided")
    {

    }
    public customer(string Firstname, string LastName, string Mail)
    {
        this.firstName = Firstname;
        this.lastname = LastName;
        this.mail = Mail;
    }
    public void PrintMailId()
    {
        Console.WriteLine("MAILID is={0}", this.firstName + this.lastname + this.mail);
    }
    ~customer()
    {

    }
}
    class Program
    { 
    public static void Main()
    {
        customer C1 = new customer("athmaja", "sirimalla", "@gmail.com");
        C1.PrintMailId();
        customer C2 = new customer();
        C2.PrintMailId();
    }
    }


        
   
    /*int[] a = new int[4];
    a[0] = 10;
    a[1] = 11;
    a[2] = 35;
    a[3] = 54;
    ParamsMethod(a);


}
public static void ParamsMethod(params int[] a)
{
    Console.WriteLine("The number of elements are {0}", a.Length);
    foreach(int i in a)
    {
        Console.WriteLine(i);
    }
}
   /* int Sum = 0;
    int Product = 0;
    Calculate(36, 67, out Sum, out Product);

    Console.WriteLine("The sum is {0} & product is {1}",Sum,Product);
}
public static void Calculate(int a, int b,out int Sum, out int Product)
{
    Sum = a + b;
    Product = a * b;
}*/
/* Program.OddNumbers(30);

     Program p = new Program();
int sub = p.Sub(900, 100);
}
public int Sub(int Fn,int Sn)
{
 return Fn-Sn ; 
}
/* public static void OddNumbers(int Target)
{
 int start = 1;
 while (start <= Target)
 {
     Console.WriteLine(start);
     start = start +2 ;
 }

}*/


/* for(int i=0;i<=50;i++)
 {

     if (i % 2 == 1)
         continue;
     if (i == 30)
         break;
     Console.WriteLine(i);

 }
 /*int[] Numbers = new int[5];
 Numbers[0] = 100;
 Numbers[1] = 101;
 Numbers[2] = 102;
 Numbers[3] = 103;
 Numbers[4] = 104;
/* foreach(int k in Numbers)
 {
     Console.WriteLine(k);
 }*/

/* for (int j = 0; j <Numbers.Length;j++)
 {
     Console.WriteLine(Numbers[j]);
 }*/

/*int[] Numbers = new int[5];
Numbers[0] = 100;
Numbers[1] = 101;
Numbers[2] = 102;
Numbers[3] = 103;
Numbers[4] = 104;
int i = 0;
while (i < Numbers.Length)
{
    Console.WriteLine(Numbers[i]);
    i++;

}*/
















