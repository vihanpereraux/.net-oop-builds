using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Circle:Shape, IShape
    {
        public double radius { get; set; }

        public override void getArea()
        {
            double area = Math.PI * this.radius * this.radius;
            Console.WriteLine($"Area is : {area} cm");
        }

        public void getPerimeter() {
            double perimeter = 2 * Math.PI * this.radius;
            Console.WriteLine($"Perimeter is : {perimeter} cm");
        }

        public void getAreaV2() 
        {
            double area = Math.PI * this.radius * this.radius;
            Console.WriteLine($"Area is : {area} cm");
        }
    }
}
