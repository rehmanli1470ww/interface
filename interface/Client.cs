using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    public class Client
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string LiveAdres { get; set; }
        public string WorkAdres { get; set; }
        public int Salary { get; set; }
        public Client(Guid ıd, string name, string surname, int age, string liveAdres, string workAdres, int salary)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Age = age;
            LiveAdres = liveAdres;
            WorkAdres = workAdres;
            Salary = salary;
        }
    }


    
}
