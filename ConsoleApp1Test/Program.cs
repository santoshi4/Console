using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
           
            Console.WriteLine(String.Concat(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"),"000000"));
        }
    }
}
