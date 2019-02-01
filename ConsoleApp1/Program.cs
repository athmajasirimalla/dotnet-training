using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = projectA.TeamA;
using PATB = projectA.TeamB;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            PATA.classA.Print();
        }
    }
}
namespace projectA
{
    namespace TeamA
    {
        class classA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print method");
            }
        }
    }
}
namespace projectA
{
    namespace TeamB
    {
        class classA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print method");
            }
        }
    }
}
