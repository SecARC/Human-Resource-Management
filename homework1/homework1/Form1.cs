using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        List<Certificate> tempCerts = new List<Certificate>();
        
        List<Department> company = new List<Department>();
        public Form1(List<Department> company)
        {
            this.company = company;
            InitializeComponent(company);

            DepartmentPanel.Visible = false;
            EmployePanel.Visible = false;

            textBox4.ReadOnly = true;
            textBox4.Visible = false;

            comboBox1.Visible = false;

            textBox5.Visible = false;
            textBox5.ReadOnly = false;

            label6.Visible = false;
            label7.Visible = false;

            dateTimePicker1.Visible = false;
            btnAddCertificate.Visible = false;
            btnDeleteCertificate.Visible = false;
            btnSaveEmployee.Visible = false;
            //groupBox3.Visible = false;
            //textBox4.ReadOnly = true;
            //textBox5.ReadOnly = true;

            DepartmentName.KeyPress += new KeyPressEventHandler(CheckEnterOnDepartmentEdit);
            textBox5.KeyPress += new KeyPressEventHandler(CheckEnterOnCertificateAdd);
        }

        private void CheckEnterOnDepartmentEdit(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SaveDepartmentName();
            }
        }
        private void CheckEnterOnCertificateAdd(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AddCertificate();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectNode();
        }

        private void SelectNode ()
        {
            TreeNode root = treeView1.SelectedNode;
            treeView1.Focus();
            ResetAll();
            switch (root.Tag)
            {
                case "Department":
                    DepartmentPanel.Visible = true;
                    textBox1.Text = treeView1.SelectedNode.Text;
                    DepartmentName.Text = treeView1.SelectedNode.Text;
                    break;

                case "Employee":
                    SelectEmployee();
                    break;
            }
        }

        private void SelectEmployee()
        {
            Department dp = this.company.Find(x => x.id == this.treeView1.SelectedNode.Parent.Name);
            Employee emp = dp.employees.Find(x => x.id == this.treeView1.SelectedNode.Name);
            if (emp != null)
            {
                this.tempCerts.Clear();
                this.EmployePanel.Visible = true;
                this.EmployeeName.Text = emp.fullName;
                this.textBox4.Text = emp.fullName;
                this.EmployeeNameLabel.Text = emp.fullName;
                this.EmployeeNameLabel.Visible = true;
                this.FavoriteProgrammingLanguageLabel.Text = emp.programmingLanguage;
                this.comboBox1.SelectedItem = emp.programmingLanguage;

                this.listView1.Items.Clear();
                foreach (Certificate crt in emp.certificates)
                {
                    Certificate nc = new Certificate(crt.name, crt.year);
                    tempCerts.Add(nc);
                }
                RenderCertificateList();
            }
        }

        private void RenderCertificateList()
        {
            this.listView1.Items.Clear();
            foreach (Certificate crt in tempCerts)
            {
                ListViewItem lvi = new ListViewItem()
                {
                    Name = crt.id,
                    Text = crt.name,
                    Tag = "Certificate"
                };
                lvi.SubItems.Add(crt.year.Year.ToString());
                this.listView1.Items.Add(lvi);
            }
        }

        private void ResetAll()
        {
            textBox1.Text = "";
            DepartmentName.Text = "";
            DepartmentName.Visible= false;
            DepartmentName.ReadOnly = true;
            textBox4.Text = "";
            DepartmentPanel.Visible = false;
            EmployePanel.Visible = false;
            btnSaveDepartment.Visible = false;
            label2.Visible = false;
            btnEditDepartment.Text = "Edit";
        }

        private void btnNewDepartment_Click(object sender, EventArgs e)
        {
            Department dp = new Department("New Department");
            company.Add(dp);
            UpdateTreeview("Department", dp.id);
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentName.Visible == false)
            {
                btnEditDepartment.Text = "Cancel";
            }
            else
            {
                btnEditDepartment.Text = "Edit";
            }
            DepartmentName.ReadOnly = !DepartmentName.ReadOnly;
            DepartmentName.Visible = !DepartmentName.Visible;
            label2.Visible = !label2.Visible;
            btnSaveDepartment.Visible = !btnSaveDepartment.Visible;
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            Department dp = company.Find(x => x.id == treeView1.SelectedNode.Name);
            if (dp != null)
            {
                company.Remove(dp);
                UpdateTreeview();
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            TreeNode depNode = treeView1.SelectedNode.Parent;

            Department dp = company.Find(x => x.id == depNode.Name);
            Employee emp = new Employee("New Employee", "", new List<Certificate>(), DateTime.Now);
            dp.employees.Add(emp);
            UpdateTreeview("Employee", emp.id);
            EditEmployee();
        }

        private void btnSaveDepartment_Click(object sender, EventArgs e)
        {
            SaveDepartmentName();
        }

        private void SaveDepartmentName()
        {
            string id = treeView1.SelectedNode.Name;
            string tag = treeView1.SelectedNode.Tag.ToString();
            Department activeDep = company.Find(x => x.id == id);
            activeDep.department_name = DepartmentName.Text;
            UpdateTreeview(tag, id);
            SelectNode();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            string empId = treeView1.SelectedNode.Name;
            string name = textBox4.Text;
            string favoriteProgrammingLanguage = comboBox1.SelectedValue.ToString();

            TreeNode empNode = treeView1.SelectedNode;
            TreeNode depNode = treeView1.SelectedNode.Parent;

            string depId = depNode.Name;

            Department dp = company.Find(x => x.id == depId);
            Employee emp = dp.employees.Find(x => x.id == empId);

            emp.fullName = name;
            emp.programmingLanguage = favoriteProgrammingLanguage;
            emp.certificates.Clear();
            foreach (Certificate crt in tempCerts)
            {
                Certificate nc = new Certificate(crt.name, crt.year);
                emp.certificates.Add(nc);
            }

            textBox4.Text = name;
            EditEmployee();
            UpdateTreeview("Employee", empId);
            SelectNode();
            RenderCertificateList();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void EditEmployee ()
        {
            Boolean visible = this.textBox4.Visible;
            if (textBox4.Visible == false)
            {
                btnEditEmployee.Text = "Cancel";
                this.listView1.Location = new Point(9, 75);
            }
            else
            {
                btnEditEmployee.Text = "Edit";
                this.listView1.Location = new Point(9, 15);
            }

            textBox4.Visible = !textBox4.Visible;
            textBox4.ReadOnly = !textBox4.ReadOnly;
            EmployeeNameLabel.Visible = !EmployeeNameLabel.Visible;

            this.FavoriteProgrammingLanguageLabel.Visible = !this.FavoriteProgrammingLanguageLabel.Visible;
            comboBox1.Visible = !comboBox1.Visible;

            textBox5.Visible = !textBox5.Visible;

            label6.Visible = !label6.Visible;
            label7.Visible = !label7.Visible;

            dateTimePicker1.Visible = !dateTimePicker1.Visible;
            btnAddCertificate.Visible = !btnAddCertificate.Visible;

            btnSaveEmployee.Visible = !btnSaveEmployee.Visible;

            if (!visible)
            {
                textBox4.Focus();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            TreeNode empNode = treeView1.SelectedNode;
            TreeNode depNode = empNode.Parent;

            string depId = depNode.Name;
            string empId = empNode.Name;

            Department dep = company.Find(x => x.id == depId);
            Employee emp = dep.employees.Find(x => x.id == empId);

            dep.employees.Remove(emp);
            UpdateTreeview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy";
            UpdateTreeview();
            treeView1.ExpandAll();
        }

        private void UpdateTreeview (string tag = "", string id = "")
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            TreeNode mainNode = new TreeNode("TG A.Ş.");
            TreeNode selectedNode = mainNode;

            foreach (var dp in company)
            {
                TreeNode dpNode = new TreeNode(dp.department_name)
                {
                    Tag = "Department",
                    Name = dp.id
                };
                if (tag == "Department" && id == dp.id) {
                    selectedNode = dpNode;
                }
                foreach (Employee emp in dp.employees)
                {
                    TreeNode empNode = new TreeNode(emp.fullName)
                    {
                        Tag = "Employee",
                        Name = emp.id
                    };

                    if (tag == "Employee" && id == emp.id)
                    {
                        selectedNode = empNode;
                    }
                    dpNode.Nodes.Add(empNode);
                }
                mainNode.Nodes.Add(dpNode);
            }
            treeView1.Nodes.Add(mainNode);
            treeView1.Focus();
            treeView1.SelectedNode = selectedNode;
            treeView1.Select();
            treeView1.EndUpdate();
            treeView1.ExpandAll();
        }

        private void btnAddCertificate_Click(object sender, EventArgs e)
        {
            AddCertificate();
        }

        private void AddCertificate ()
        {
            string name = textBox5.Text;
            DateTime year = dateTimePicker1.Value;
            Certificate nc = new Certificate(name, year);
            tempCerts.Add(nc);
            RenderCertificateList();
            textBox5.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox5.Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0 && this.textBox5.Visible)
            {
                this.btnDeleteCertificate.Visible = true;
            }
            else
            {
                this.btnDeleteCertificate.Visible = false;
            }
        }

        private void btnDeleteCertificates_Click (object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                string id = item.Name;

                Certificate crt = tempCerts.Find(x => x.id == id);
                tempCerts.Remove(crt);
            }
            RenderCertificateList();
        }
    }
}
