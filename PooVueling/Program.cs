﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora iCalc = new Calculadora();
            iCalc.Division(9, 0);
        }
    }
}
