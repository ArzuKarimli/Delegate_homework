using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Domain
{
    internal class Person : BaseEntity
    {
        public string Name { get; set; }    
        public string Surname { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
    }
}
