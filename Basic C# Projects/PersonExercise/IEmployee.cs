using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExercise
{
    interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Id { get; set; }
    }
}
