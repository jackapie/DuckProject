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

            Duck model = new ModelDuck();
            model.PerformFly();
            //Use the setFlyBehaviour function in Duck to set behaviour dynamically
            model.setFlyBehaviour(new FlyRocketPowered());
            model.PerformFly();

            Console.ReadLine();
        }

       
    }
}
