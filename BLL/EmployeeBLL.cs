using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class EmployeeBLL
    {
        public static EmployeeDTO GetALL()
        {
            EmployeeDTO dto = new EmployeeDTO();
            dto.Departments = DepartmentDAO.GetDepartment();
            dto.Positions = PositionDAO.GetPosition();
            dto.Employees = EmployeeDAO.GetEmployees();
            return dto;

        }

        public static void AddEmployee(Employee employee)
        {
            EmployeeDAO.AddEmployee(employee);
        }

        public static bool isUnique(int v)
        {
            List<Employee> list = EmployeeDAO.GetUser(v);
            if (list.Count > 0)
                return false;
            else
                return true;

        }
    }
}
