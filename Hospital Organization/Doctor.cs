using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Organization
{
    class Doctor: HospitalEmployees
    {
        //Constructors
        public Doctor()
        {

        }

        public Doctor(string employeeName, int epmloyeeNum, string specialty)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.specialty = specialty;
        }
            
    }
}
