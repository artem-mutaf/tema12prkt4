using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_4
{
    class Collaborator
    {
        //string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }

        //}
        public string name;
        public string surname;
        public int payment;
        public double kof;
        public Collaborator() { }
        public Collaborator(string name,string surname,int payment)
        {
            this.name = name;
            this.surname = surname;
            this.payment = payment;
        }
        public Collaborator(string name, string surname, int payment, double kof): this(name,surname,payment)
        {
            this.kof = kof;
        }
        public void Show()
        {
            Console.WriteLine($"Имя - {name}\nФамилия - {surname}\nМин. заработная плата = {payment}");
        }
        public double Income()
        {
            return kof*payment;
        }
    }
}
