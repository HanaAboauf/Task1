using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Employee
    {


        public int Id { get; set; }

        public string? Name { get; set; }

        public double Salary { get; set; }
        

       public Gender Gender { get; set; }

        public SecurityLevel SecurityLevel { get; set; }

        public HireDate HireDate { get; set; }


        public override string ToString()
        {
            return $"Id: {Id},\n Name: {Name},\n SaLary: {Salary},\n Gender:{Gender},\n SecurityLevel:{SecurityLevel},\n HireDate:{HireDate}";
        }




    }
}
