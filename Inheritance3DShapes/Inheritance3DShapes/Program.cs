﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3DShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cone c = new Cone(1f, 1f, new Point(1f, 1f, 1f));
            Console.WriteLine(c.Volume());
            Console.WriteLine(c.Area());
            Console.ReadKey();
        }
    }
}