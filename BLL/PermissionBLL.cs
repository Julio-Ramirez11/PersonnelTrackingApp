using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class PermissionBLL
    {
        public static void AddPermission(Permission permission)
        {
            PermissionDAO.AddPermission(permission);
        }

        public static PermissionDTO GetALL()
        {
            PermissionDTO dto = new PermissionDTO();
            dto.Departments = DepartmentDAO.GetDepartment();
            dto.Positions = PositionDAO.GetPosition();
            dto.States = PermissionDAO.GetStates();
            dto.Permission = PermissionDAO.GetPermission();
            return dto;
        }

        public static void UpdatePermission(Permission permission)
        {
            PermissionDAO.UpdatePermission(permission);
        }

        public static void UpdatePermission(int permissionID, int approved)
        {
            PermissionDAO.UpdatePermission(permissionID, approved);
        }

        public static void DeletePermission(int permissionID)
        {
            PermissionDAO.DeletePermission(permissionID);
        }
    }
}
