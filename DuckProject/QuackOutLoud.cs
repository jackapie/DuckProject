using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public class QuackOutLoud : IQuackBehaviour 
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
