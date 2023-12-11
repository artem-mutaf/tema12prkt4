using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figures figures = new Figures();
            //figures.name = "Квадрат";
            //figures.side1 = 6;
            //figures.side2 = 8;
            //Figures figures1 = new Figures("прямоугольник", 7, 9);
            //{

            //}
            //Figures figures2 = new Figures("Треугольник",8,3,int.Parse(Console.ReadLine()));
            //{

            //}


            //figures2.Showinfo();
            //Console.WriteLine($"Периметр прямоугольника равен\t{figures2.Perimetr()}");
            //Console.WriteLine($"Площадь  прямоугольника равна\t{figures2.Площадь()}");
            Collaborator col = new Collaborator("Артём", "Мутаф", 5098,3.56);
            col.Show();
            Console.WriteLine($"Зарплата с повышающим коэффициентом = {col.Income()}");

            Console.ReadKey();
        }
    }
}
