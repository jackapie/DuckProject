using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new QuackOutLoud();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }

    }
}
