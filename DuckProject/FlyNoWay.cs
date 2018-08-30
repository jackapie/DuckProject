using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
