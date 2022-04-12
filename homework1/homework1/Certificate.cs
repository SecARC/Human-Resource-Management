using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class Certificate
    {
        public string id;
        public string name;
        public DateTime year;

        public Certificate (string name, DateTime year)
        {
            Guid guid = Guid.NewGuid();
            this.id = guid.ToString();
            this.name = name;
            this.year = year;
        }
    }
}
