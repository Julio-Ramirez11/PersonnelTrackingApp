using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL.DAO;

namespace BLL
{
    public class TaskBLL
    {
        public static TaskDTO GetAll()
        {
            TaskDTO taskdto = new TaskDTO();
            taskdto.Employees = EmployeeDAO.GetEmployees();
            taskdto.Departments = DepartmentDAO.GetDepartment();
            taskdto.Positions = PositionDAO.GetPosition();
            taskdto.TaskStates = TaskDAO.GettaskState();
            taskdto.Tasks = TaskDAO.GetTasks();
            return taskdto;

        }

        public static void AddTask(DAL.Task task)
        {
            TaskDAO.AddTask(task);
        }
    }
}
