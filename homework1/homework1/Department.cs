using System;
using System.Collections.Generic;

namespace homework1
{
    public class Department
    {
        public string id;
        public string department_name;
        public List<Employee> employees;

        public Department(string name)
        {
            Guid guid = Guid.NewGuid();
            this.id = guid.ToString();
            this.department_name = name;
            this.employees = new List<Employee>();
        }
    }
}
