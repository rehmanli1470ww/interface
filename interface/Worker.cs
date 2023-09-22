using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    class Worker: Iinterface
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Worker(Guid ıd, string name, string surname, int age, string position, int salary, DateTime startTime, DateTime endTime)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            Salary = salary;
            StartTime = startTime;
            EndTime = endTime;
        }
        public void Operations(List<Operations> operations) 
        {
            foreach (var operation in operations)
            {
                Console.WriteLine(operation);
            }
        }
    }
}
