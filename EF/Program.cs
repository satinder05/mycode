using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFirstEF;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.SetUp();
            var t =m.Read();
            foreach (string s in t)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
