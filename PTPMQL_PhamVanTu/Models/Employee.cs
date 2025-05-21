using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTPMQL_PhamVanTu.Models
{
    public class Employee : Person
    {
        public String EmployeeId { get; set; }
        public int Age { get; set; }
    }
}