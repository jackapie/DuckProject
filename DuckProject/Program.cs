using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.ReadLine();
        }

       
    }
}
