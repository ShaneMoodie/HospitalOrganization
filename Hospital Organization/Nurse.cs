using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Organization
{
    class Nurse: HospitalEmployees
    {
        //Fields
        private int patients;

        //Properties
        public int Patients
        {
            get { return this.patients; }
            set { this.patients = value; }
        }

        //Constructors
        public Nurse()
        {

        }
        public Nurse(string employeeName, int employeeNum, string department, int patients)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.department = department;
            this.patients = patients;
        }
    }
}
