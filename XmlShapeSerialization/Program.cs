using ShapeClass;
using System.Xml.Serialization;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace XmlShapeSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listofShapes = new()
            {
                new Circle{ Colour = "Red", Radius = 2.5},
                new Rectangle{Colour = "Blue", Height = 20.0, Width = 10.0},
                new Circle{ Colour = "Purple", Radius = 12.3},
                new Rectangle{Colour ="Blue", Height = 45.0, Width = 18.0}
            };

            XmlSerializer xs = new(listofShapes.GetType());

            // create a file to write to
            string path = Combine(CurrentDirectory, "Shape.xml");

            using (FileStream stream = File.Create(path))
            {
                // serialize the object graph to the stream 
                xs.Serialize(stream, listofShapes);
            }

            // Deserializing with XML

            using (FileStream fileXml = File.Open(path, FileMode.Open))
            {
                // deserialize and cast the object graph into a List of Person 
                List<Shape>? loadedShapesXml =
                  xs.Deserialize(fileXml) as List<Shape>;

                
                    foreach (Shape item in loadedShapesXml)
                    {
                        WriteLine("{0} is {1} and has an area of {2:N2}",
                          item.GetType().Name, item.Colour, item.Area);
                    }
                
            }





        }
    }
}