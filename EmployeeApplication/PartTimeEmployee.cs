using EmployeeApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;

namespace EmployeeNamespace
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;
        public PartTimeEmployee(string FName, string LName, string dept, string job) 
        {
            this.FirstName = FName;
            this.LastName = LName;
            this.Department = dept;
            this.JobTitle = job;
        }
        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            BasicSalary  = hoursWorked * ratePerHour;

        }
        public double BasicSalary 
        {
            get 
            {
                return basic_salary;
            }
            set 
            {
                this.basic_salary = value;
            }
        }
        public string FirstName
        {
            get
            {
                return first_name;
            }
            set
            {
                this.first_name = value;
            }
        }
        public string LastName
        {
            get 
            { 
                return last_name;
            }
            set
            {
                this.last_name = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set 
            { 
                this.department = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return job_title;
            }
            set
            {
                this.job_title = value;
            }
        }
        public double getSalary()
        {
            return BasicSalary;
        }
        
           
    }
}
