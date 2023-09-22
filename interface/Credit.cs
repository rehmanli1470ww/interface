using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    public class Credit
    {

        public Guid Id { get; set; }
        public Client client { get; set; }
        public int Amont { get; set; }
        public double Percent { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }
        public Credit(Guid ıd, Client client, int amont, double percent, int months, int days)
        {
            Id = ıd;
            this.client = client;
            Amont = amont;
            Percent = percent;
            Months = months;
            Days = days;
        }
    }
    
}
