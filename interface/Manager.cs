using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  interfacee
{
    public class Manager: Iinterface
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public Manager(Guid ıd, string name, string surname, int age, string position, int salary)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            Salary = salary;
        }
        public void organize()
        {
            Console.WriteLine($"{Name} {Surname} Organize ucun hazirdir");
        }
        public void calculeitSalaries()
        {
            Console.WriteLine($"{Name} {Surname} Maasi :" + Salary * 12);
        }

    }
}
