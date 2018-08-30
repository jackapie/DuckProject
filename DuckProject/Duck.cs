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
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        //Constructor
        public Duck() { } 

        //Methods
        public abstract void Display();


        /// <summary>
        /// The following 2 methods delegate to the behaviour class.
        /// </summary>
        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        //Setting behaviour dynamically
       // public void setFlyBehaviour(FlyBehaviour fb)
       // {
       //     flyBehaviour = fb;
       // }
       // public void setQuackBehaviour(QuackBehaviour qb)
        //{
        //    quackBehaviour = qb;
        //}
    }
}
