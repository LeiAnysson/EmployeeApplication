using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            string fname, lname, dept, job;
            fname = firstname.Text;
            lname = lastname.Text;
            dept = department.Text;
            job = jobTitle.Text;
            double ratePerHour = Convert.ToDouble(RpH.Text);
            int totalHoursWorked = Convert.ToInt32(ThW.Text);

            PartTimeEmployee pte = new PartTimeEmployee(fname, lname, dept, job);
            pte.computeSalary(totalHoursWorked,ratePerHour);

            firstNameLabel.Text = pte.FirstName;
            lastNameLabel.Text = pte.LastName;
            basicSalaryLabel.Text = pte.getSalary().ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
