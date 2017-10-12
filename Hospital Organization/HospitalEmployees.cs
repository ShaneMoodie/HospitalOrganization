using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Organization
{
    abstract class HospitalEmployees
    {
        //Fields
        protected string employeeName;
        protected string specialty;
        protected string department;
        protected int employeeNum;

        //Properties
        public string EmployeeName
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }
        }
        public string Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public int EmployeeNum
        {
            get { return this.employeeNum; }
            set { this.employeeNum = value; }
        }

    }
}
