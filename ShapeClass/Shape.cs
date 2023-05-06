using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShapeClass
{

    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    public class Shape
    {
        public string Name { get; set; }

        public string  Colour { get; set; }
        

        public virtual double Area { get; set; }

        public Shape() {}


    }
}
