﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public override double Area
        {

            get
            {
                return Height * Width;
            }
            set
            {
                
            }
        }

        public Rectangle() {}
        
        
    }
}
