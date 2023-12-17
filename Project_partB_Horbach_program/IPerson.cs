using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partB_Horbach_program
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string ContactNumber { get; set; }
    }
}
