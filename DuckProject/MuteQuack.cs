﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
