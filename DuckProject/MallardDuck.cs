using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehaviour = new QuackOutLoud();
            FlyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }

       
    }
}
