using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ class Shape {
        public virtual void Draw()
        {
            Console.WriteLine("base class draw method");
        
        }


    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a Circle");
            base.Draw();
        }


    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a Triangle");
            base.Draw();
        }



    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a rectangle");
            base.Draw();
        }


    }


    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a square");
            base.Draw();
        }




    }




    class Program
    {
        public static void Main(string[] args)
        {
            Shape s = null;
            int ui;
            do
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1:Circle");
                Console.WriteLine("2:Triangle");
                Console.WriteLine("3:Rectangle");
                Console.WriteLine("4:Square");
                Console.WriteLine("Enter your input");

                ui = Convert.ToInt32(Console.ReadLine());
                switch (ui)
                {
                    case 1:
                        s = new Circle();
                        break;
                    case 2:
                        s = new Triangle();
                        break;
                    case 3:
                        s = new Rectangle();
                        break;
                    case 4:
                        s = new Square();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        Environment.Exit(0);
                        break;
                }
                s.Draw();
            }
            while (ui >= 1 && ui <= 5);
            /* var drawObjects = new List<Shape>
             {
                 new Circle(),
                 new Triangle(),
                 new Rectangle(),
                 new Square()
             };

             foreach (Shape s in drawObjects)
             {
                 s.Draw();

             }*/
            Console.ReadLine();
        }
    }
}
