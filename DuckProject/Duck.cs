using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public abstract class Duck
    {
        /// <summary>
        /// The two reference variables for the behaviour interface types.
        /// All duck subclasses (in the same package) inherit (implement?) these.
        /// </summary>
        protected FlyBehaviour flyBehaviour;
        protected QuackBehaviour quackBehaviour;

        //Constructor
        public Duck() { } 

        //Methods
        public abstract void Display();


        /// <summary>
        /// The following 2 methods delegate to the behaviour class.
        /// </summary>
        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
