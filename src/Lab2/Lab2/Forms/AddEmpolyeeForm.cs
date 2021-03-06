﻿using System;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2.Forms
{
    public partial class AddEmpolyeeForm : Form
    {
        private Studio _scopedStudio;

        public AddEmpolyeeForm()
        {
            InitializeComponent();
        }

        public AddEmpolyeeForm(Studio studio) : this()
        {
            _scopedStudio = studio;
        }

        private void bAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = tbEmployeeFirstName.Text;
            string lastName = tbEmployeeLastName.Text;
            double salary = (double) nudEmployeeSalary.Value;

            _scopedStudio.Employees.Add(
                new Employee(firstName, lastName, salary));

            this.Close();
        }
    }
}
