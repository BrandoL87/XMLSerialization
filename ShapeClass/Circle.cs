using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    public class Circle : Shape
    {
        public double Radius{ get; set; }

        public override double Area {

            get {
                return Math.Pow(this.Radius, 2) * Math.PI;
                 }
            set {
                
            }
        }

        public Circle() { }
        

        
    }
}
