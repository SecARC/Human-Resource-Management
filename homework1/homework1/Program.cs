using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Department> company = new List<Department>();

            for (int i = 0; i < 3; i++)
            {
                Department dp = new Department("Dep" + i);

                for (int k = 0; k < 4; k++)
                {
                    List<Certificate> certs = new List<Certificate>();
                    for (int j = 0; j < 3; j++)
                    {
                        Certificate nc = new Certificate("Employee " + k + " Cert" + j, DateTime.Now);
                        certs.Add(nc);
                    }

                    dp.employees.Add(new Employee("Employee " + k, "Visual C#", certs, new DateTime()));
                }

                company.Add(dp);
            }


            Application.Run(new Form1(company));
        }
    }
}
