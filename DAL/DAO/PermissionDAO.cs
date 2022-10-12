using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PermissionDAO : EmployeeContext
    {
        public static void AddPermission(Permission permission)
        {
            try
            {
                db.Permissions.InsertOnSubmit(permission);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PermissionState> GetStates()
        {
            return db.PermissionStates.ToList();
        }

        public static List<PermissionDetailDTO> GetPermission()
        {
            List<PermissionDetailDTO> permissions = new List<PermissionDetailDTO>();

            var list = (from p in db.Permissions
                        join s in db.Permissions on p.PermissionState equals s.ID
                        join e in db.Employees on p.EmployeeID equals e.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            name = e.Name,
                            Surname = e.Surname,
                            //StateName = s.StateName,
                            stateID = p.PermissionState,
                            startdate = p.PermissionStartDate,
                            endDate = p.PermissionStartDate,
                            employeeID = p.EmployeeID,
                            PermissionID = p.ID,
                            explanation = p.PermissionExplanation,
                            Dayamount = p.PermissionDay,
                            departmentID = e.DepartmentID,
                            positionID = e.PositionID

                        }).OrderBy(x => x.startdate).ToList();
            return permissions;
        }
    }
}
