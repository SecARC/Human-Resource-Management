using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace homework1
{
    partial class Form1
    {
        private Label EmployeeNameLabel;
        private Label FavoriteProgrammingLanguageLabel;
        private Button btnDeleteCertificate;
        private TreeView treeView1;
        private GroupBox DepartmentPanel;
        private Button btnSaveDepartment;
        private TextBox DepartmentName;
        private Label label2;
        private Button btnDeleteDepartment;
        private Button btnEditDepartment;
        private Button btnNewDepartment;
        private TextBox textBox1;
        private Label label1;
        private GroupBox EmployePanel;
        private GroupBox groupBox3;
        private Button btnAddCertificate;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private Button btnDeleteEmployee;
        private Button btnEditEmployee;
        private Button btnNewEmployee;
        private TextBox EmployeeName;
        private Label label3;
        private Button btnSaveEmployee;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent(List<Department> company)
        {
            this.treeView1 = new TreeView();

            this.components = new System.ComponentModel.Container();

            

            this.treeView1.ImageIndex = 0;
            this.treeView1.Location = new Point(12, 12);
            this.treeView1.Name = "Company";
            this.treeView1.Tag = "Company";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new Size(179, 550);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);


            this.EmployePanel = new GroupBox();
            this.groupBox3 = new GroupBox();

            this.EmployeeNameLabel = new Label();
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new Size(230, 20);
            this.EmployeeNameLabel.TabIndex = 14;
            this.EmployeeNameLabel.Location = new Point(182, 90);
            this.EmployePanel.Controls.Add(this.EmployeeNameLabel);

            this.FavoriteProgrammingLanguageLabel = new Label();
            this.FavoriteProgrammingLanguageLabel.Name = "FavoriteProgrammingLanguageLabel";
            this.FavoriteProgrammingLanguageLabel.Size = new Size(230, 20);
            this.FavoriteProgrammingLanguageLabel.TabIndex = 14;
            this.FavoriteProgrammingLanguageLabel.Location = new Point(182, 116);
            this.EmployePanel.Controls.Add(this.FavoriteProgrammingLanguageLabel);

            this.btnAddCertificate = new Button();
            this.btnAddCertificate.Location = new Point(262, 43);
            this.btnAddCertificate.Name = "btnAddCertificate";
            this.btnAddCertificate.Size = new Size(130, 25);
            this.btnAddCertificate.TabIndex = 14;
            this.btnAddCertificate.Text = "Add";
            this.btnAddCertificate.UseVisualStyleBackColor = true;
            this.btnAddCertificate.Click += new System.EventHandler(this.btnAddCertificate_Click);
            this.groupBox3.Controls.Add(this.btnAddCertificate);

            this.btnDeleteCertificate = new Button();
            this.btnDeleteCertificate.Text = "Delete";
            this.btnDeleteCertificate.Size = new Size(this.btnDeleteCertificate.Size.Width, 25);
            this.btnDeleteCertificate.Location = new Point(262 - this.btnDeleteCertificate.Size.Width, 43);
            this.btnDeleteCertificate.Click += new System.EventHandler(this.btnDeleteCertificates_Click);
            this.groupBox3.Controls.Add(this.btnDeleteCertificate);


            this.DepartmentPanel = new GroupBox();
            this.btnSaveDepartment = new Button();
            this.DepartmentName = new TextBox();
            this.label2 = new Label();
            this.btnDeleteDepartment = new Button();
            this.btnEditDepartment = new Button();
            this.btnNewDepartment = new Button();
            this.textBox1 = new TextBox();
            this.label1 = new Label();
            this.listView1 = new ListView();
            this.columnHeader1 = ((ColumnHeader)(new ColumnHeader()));
            this.columnHeader2 = ((ColumnHeader)(new ColumnHeader()));
            this.btnSaveEmployee = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.label7 = new Label();
            this.textBox5 = new TextBox();
            this.label6 = new Label();
            this.comboBox1 = new ComboBox();
            this.label5 = new Label();
            this.textBox4 = new TextBox();
            this.label4 = new Label();
            this.btnDeleteEmployee = new Button();
            this.btnEditEmployee = new Button();
            this.btnNewEmployee = new Button();
            this.EmployeeName = new TextBox();
            this.label3 = new Label();
            this.DepartmentPanel.SuspendLayout();
            this.EmployePanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentPanel
            // 
            this.DepartmentPanel.Controls.Add(this.btnSaveDepartment);
            this.DepartmentPanel.Controls.Add(this.DepartmentName);
            this.DepartmentPanel.Controls.Add(this.label2);
            this.DepartmentPanel.Controls.Add(this.btnDeleteDepartment);
            this.DepartmentPanel.Controls.Add(this.btnEditDepartment);
            this.DepartmentPanel.Controls.Add(this.btnNewDepartment);
            this.DepartmentPanel.Controls.Add(this.textBox1);
            this.DepartmentPanel.Controls.Add(this.label1);
            this.DepartmentPanel.Location = new Point(198, 13);
            this.DepartmentPanel.Name = "DepartmentPanel";
            this.DepartmentPanel.Size = new Size(417, 142);
            this.DepartmentPanel.TabIndex = 2;
            this.DepartmentPanel.TabStop = false;
            this.DepartmentPanel.Text = "Department";
            // 
            // btnSaveDepartment
            // 
            this.btnSaveDepartment.Location = new Point(282, 111);
            this.btnSaveDepartment.Name = "btnSaveDepartment";
            this.btnSaveDepartment.Size = new Size(130, 25);
            this.btnSaveDepartment.TabIndex = 7;
            this.btnSaveDepartment.Text = "Save";
            this.btnSaveDepartment.UseVisualStyleBackColor = true;
            this.btnSaveDepartment.Click += new System.EventHandler(this.btnSaveDepartment_Click);
            // 
            // DepartmentName
            // 
            this.DepartmentName.Location = new Point(13, 114);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            this.DepartmentName.Size = new Size(267, 20);
            this.DepartmentName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department Name";
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new Point(282, 65);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new Size(130, 25);
            this.btnDeleteDepartment.TabIndex = 4;
            this.btnDeleteDepartment.Text = "Delete";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new Point(146, 65);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new Size(130, 25);
            this.btnEditDepartment.TabIndex = 3;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnNewDepartment
            // 
            this.btnNewDepartment.Location = new Point(10, 65);
            this.btnNewDepartment.Name = "btnNewDepartment";
            this.btnNewDepartment.Size = new Size(130, 25);
            this.btnNewDepartment.TabIndex = 2;
            this.btnNewDepartment.Text = "New";
            this.btnNewDepartment.UseVisualStyleBackColor = true;
            this.btnNewDepartment.Click += new System.EventHandler(this.btnNewDepartment_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(10, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(270, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "TG A.Ş\\Administration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Item ";
            // 
            // EmployePanel
            // 
            this.EmployePanel.Controls.Add(this.groupBox3);
            this.EmployePanel.Controls.Add(this.comboBox1);
            this.EmployePanel.Controls.Add(this.label5);
            this.EmployePanel.Controls.Add(this.textBox4);
            this.EmployePanel.Controls.Add(this.label4);
            this.EmployePanel.Controls.Add(this.btnDeleteEmployee);
            this.EmployePanel.Controls.Add(this.btnEditEmployee);
            this.EmployePanel.Controls.Add(this.btnNewEmployee);
            this.EmployePanel.Controls.Add(this.EmployeeName);
            this.EmployePanel.Controls.Add(this.label3);
            this.EmployePanel.Location = new Point(198, 13);
            this.EmployePanel.Name = "EmployePanel";
            this.EmployePanel.Size = new Size(417, 400);
            this.EmployePanel.TabIndex = 3;
            this.EmployePanel.TabStop = false;
            this.EmployePanel.Text = "Staff";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.btnSaveEmployee);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new Point(13, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(398, 232);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Certificates";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new Point(9, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(383, 120);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Year";
            this.columnHeader2.Width = 50;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new Point(262, 201);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new Size(130, 25);
            this.btnSaveEmployee.TabIndex = 17;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(78, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(85, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 4, 17, 1, 47, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new Size(29, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Year";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Point(78, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new Size(314, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Title";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            List<string> programmingLanguages = new List<string> {
                "C++",
                "Visual C#",
                "Java",
                "Python",
                "LISP",
                "Objective-C",
                "Ruby",
                "JavaScript"
            };
            this.comboBox1.DataSource = programmingLanguages;
            this.comboBox1.Location = new Point(182, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(229, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(10, 116);
            this.label5.Name = "label5";
            this.label5.Size = new Size(166, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Favourite Programming Language";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Point(182, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(230, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(10, 90);
            this.label4.Name = "label4";
            this.label4.Size = new Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fullname";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new Point(282, 58);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new Size(130, 25);
            this.btnDeleteEmployee.TabIndex = 8;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new Point(146, 58);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new Size(130, 25);
            this.btnEditEmployee.TabIndex = 8;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new Point(10, 58);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new Size(130, 25);
            this.btnNewEmployee.TabIndex = 8;
            this.btnNewEmployee.Text = "New";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new Point(10, 32);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Size = new Size(270, 20);
            this.EmployeeName.TabIndex = 8;
            this.EmployeeName.Text = "TG A.Ş\\Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selected Item ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(624, 566);
            this.Controls.Add(this.EmployePanel);
            this.Controls.Add(this.DepartmentPanel);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Human Resource Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DepartmentPanel.ResumeLayout(false);
            this.DepartmentPanel.PerformLayout();
            this.EmployePanel.ResumeLayout(false);
            this.EmployePanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

    }
}

