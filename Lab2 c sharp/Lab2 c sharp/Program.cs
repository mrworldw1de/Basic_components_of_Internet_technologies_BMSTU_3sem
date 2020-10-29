
using System;




namespace Classes
{
    /// <summary>
    /// Класс фигура
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        /// Приведение к строке, переопределение метода Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
    }

    ////////////////////////////////////////////////////////////////
    interface IPrint
    {
        void Print();
    }

    ////////////////////////////////////////////////////////////////
    class Rectangle : Figure, IPrint
    {
        /// <summary>
        /// Высота
        /// </summary>
        double height;

        /// <summary>
        /// Ширина
        /// </summary>
        double width;

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Rectangle(double ph, double pw)
        {
            this.height = ph;
            this.width = pw;
            this.Type = "Прямоугольник";
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = Math.Round(this.width * this.height, 3);
            return Result;
        }

        public void Print()
        {
            string str = this.ToString() + " ширина=" + this.width.ToString() + " высота=" + this.height.ToString();
            Console.WriteLine(str);
        }
    }




    class Square : Rectangle
    {
        double side;
        public Square(double a) : base(a, a)
        {
            side = a;
            this.Type = "Квадрат";
        }
        public new void Print()
        {
            string str = this.ToString() + " сторона=" + this.side.ToString();
            Console.WriteLine(str);
        }
    }



    class Circle : Figure, IPrint
    {
        /// <summary>
        /// Радиус
        /// </summary>
        double Radius;



        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="r">радиус</param>

        public Circle(double r)
        {
            this.Radius = r;

            this.Type = "Окружность";
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = Math.Round(this.Radius  * Math.PI * this.Radius, 3);
            return Result;
        }

        public void Print()
        {
            string str = this.ToString() + " Радиус=" + this.Radius.ToString();
            Console.WriteLine(str);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 4);
            rect.Print();

            Circle circ = new Circle(2);
            circ.Print();


            Square squr = new Square(4);
            squr.Print();



        }
    }
}