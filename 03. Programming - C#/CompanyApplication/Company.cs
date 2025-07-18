using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApplication
{
    class Company
    {
        public string name { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

       public string companyName { get; set; }

            
    }
}
