using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_4
{
    class Figures
    {
        /// <summary>
        /// Первое поле 
        /// </summary>
        public string name;
        /// <summary>
        /// Второе поле первая сторона
        /// </summary>
        public int side1;
        /// <summary>
        /// Третье поле вторая сторона
        /// </summary>
        public int side2;
        /// <summary>
        /// Четвертое поле третья сторона
        /// </summary>
        public int side3;
        /// <summary>
        /// Конструктор без параметров <по умолчанию>
        /// </summary>

        public Figures() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Figures(string name, int side1, int side2)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;

        }
        public Figures(string name, int side1, int side2, int side3) : this(name, side1, side2)
        {
            this.side3 = side3;
        }
        /// <summary>
        /// Вывод <Метод>
        /// </summary>
        public void Showinfo()
        {
            Console.WriteLine($"Название фигуры- {name}\tПервая сторона равна= {side2}\tВторая сторона равна= {side2}\tТретья сторона= {side3}");
        }
        /// <summary>
        /// Вычисление периметра <Метод>
        /// </summary>
        /// <returns></returns>
        public double Perimetr()
        {
            return (side1 + side2 + side3);
        }
        /// <summary>
        /// Вычисление площади <Метод>
        /// </summary>
        /// <returns></returns>

        public double Площадь()
        {
            return side1 * side2 * side3;
        }
    }
}
