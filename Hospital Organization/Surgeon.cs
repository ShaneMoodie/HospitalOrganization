using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Organization
{
    class Surgeon: HospitalEmployees
    {
        //Fields
        private bool inOperation;

        //Properties
        public bool InOperation
        {

        }

        //Contructors
        public Surgeon()
        {

        }
        public Surgeon(string employeeName, int employeeNum, string specialty, bool inOperation)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.specialty = specialty;
            this.inOperation = inOperation;
        }
    }
}
