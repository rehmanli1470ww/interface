using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    public class Operations
    {
        public Guid Id { get; set; }
        public string Proces_name { get; set; }
        public DateTime dateTime { get; set; }
        Operations(Guid ıd, string proces_name, DateTime dateTime)
        {
            Id = ıd;
            Proces_name = proces_name;
            this.dateTime = dateTime;
        }
        public override string ToString()
        {
            return $"Guid Id :{Id}\nProces name :{Proces_name}\nDateTime : {dateTime}";
        }
    }
}
