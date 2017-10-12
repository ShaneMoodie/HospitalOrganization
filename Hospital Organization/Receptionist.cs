using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Organization
{
    class Receptionist: HospitalEmployees
    {
        //Fields
        private bool phone;

        //Constructors
        public Receptionist()
        {

        }
        public Receptionist(string employeeName, int employeeNum, string department, bool phone)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.department = department;
            this.phone = phone;
        }
    }
}
