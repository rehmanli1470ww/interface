using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    interface Iinterface
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        string Position { get; set; }
        int Salary { get; set; }

    }
}
