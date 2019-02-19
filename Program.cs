using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Ruslan";
            employee.Vacancy = Vacancies.Boss;
            employee.Salary = int.MaxValue;
            employee.EmploymentDate[0] = 19;
            employee.EmploymentDate[1] = 02;
            employee.EmploymentDate[2] = 2019;
        }
    }
}
