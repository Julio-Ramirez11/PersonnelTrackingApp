using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelTrackingApp
{
    public class Employee
    {
        public int UserNo { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; internal set; }
        public string Name { get; internal set; }
        public string Surname { get; internal set; }
        public int Salary { get; internal set; }
        public int DepartmentID { get; internal set; }
        public int PositionID { get; internal set; }
        public string Adress { get; internal set; }
        public DateTime Birthday { get; internal set; }
        public string ImagePath { get; internal set; }
    }
}
