using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    abstract class Shape
    {
        public String name { get; set; }
        public String color { get; set; }

        public abstract void getArea();
    }
}
