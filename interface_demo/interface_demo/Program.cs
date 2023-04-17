using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_demo
{
    interface Ifigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();
    }
    class Circle : Ifigure
    {
        public int Dimension
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public int _radius;


        public double Area()
        {
            return Math.PI * _radius * _radius;

        }
        public double Perimeter()
        {
            return 2 * Math.PI * _radius;

        }
    }
        class Square : Ifigure
        {
            public int side;
            public int Dimension
            {
                get { return side; }
                set { side = value; }
            }
            public double Area()
            {
                return side * side;
            }
            public double Perimeter()
            {
                return 4 * side;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Ifigure figure = null;
                Console.WriteLine("Enter 'c' for circle and 's' for square");
                string ch = Console.ReadLine();
                if (ch == "c")
                {
                    figure = new Circle();
                }
                else if (ch == "s")
                {
                    figure = new Square();
                }
                figure.Dimension = 10;
                Console.WriteLine(figure.Area());
                Console.WriteLine(figure.Perimeter());


            }
        }
    }

