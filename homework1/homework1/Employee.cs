using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class Employee
    {
        public string id;
        public string fullName;
        public string programmingLanguage;
        public List<Certificate> certificates;
        public DateTime year;
        public Employee(string name, string pl, List<Certificate> certs, DateTime year)
        {
            Guid guid = Guid.NewGuid();
            this.id = guid.ToString();
            this.fullName = name;
            this.programmingLanguage = pl;
            this.certificates = certs;
            this.year = year;
        }
    }
}
