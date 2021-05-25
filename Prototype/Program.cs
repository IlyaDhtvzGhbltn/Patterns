using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
/* 
 * problem - you need copy some object.
 * first thing you may think about is create new object and set all fields as in old one.
 * but you can't do it with private properties.
 * 
 * also, if old object has some ref type field, it may bring more problem. 
 * if you change value of some ref type field in old obj it would change and new one to!
 * Use Prototype pattern to avoid these problems.
 * 
 * Prototype could be realized by two ways Shallow copy and Deep copy.
 * Shallow will be enough if object hasn't ref type fields.
 * Deep copy if it has.
 * For Shallow copying will be anough MemberwiseClone() method.
*/
//........................

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle oldRec = new Rectangle(10, 20);
            Rectangle newRec =  (Rectangle)oldRec.ShallowCopy();

            oldRec.GetInfo();
            newRec.GetInfo();

            Console.Read();
        }
    }
    //.........................

    [Serializable]
    class Position
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
    }


    [Serializable]
    class Circle : IFigure
    {
        int radius;
        public Position Position { get; set; }
        public Circle(int radius, int xPos, int yPos)
        {
            this.radius = radius;
            this.Position = new Position { XPos = xPos, YPos = yPos };
        }



        public IFigure ShallowCopy()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = 
                    new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binFormatter.Deserialize(tempStream);
            }
            return figure;
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", radius, Position.XPos, Position.YPos);
        }
    }

    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int width, int height)
        {
            this.height = height;
            this.width = width;
        }
        public void GetInfo()
        {
            Console.WriteLine("Rectangles width - {0}, Rectangles height - {1} ", width, height);
        }

        public IFigure ShallowCopy()
        {
            return this.MemberwiseClone() as IFigure;
        }
    }

    interface IFigure
    {
        IFigure ShallowCopy();
        void GetInfo();
    }
}