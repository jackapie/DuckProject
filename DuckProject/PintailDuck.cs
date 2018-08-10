using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public class PintailDuck : Duck
    {
        public PintailDuck()
        {
            quackBehaviour = new QuackOutLoud();
            flyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Pintail duck");
        }

        public void WhatTail()
        {
            Console.WriteLine("I have a pointy tail!");
        }
    }
}
