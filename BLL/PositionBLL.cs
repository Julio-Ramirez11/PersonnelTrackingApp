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
    public class PositionBLL
    {
        public static void AddPosition(Position position)
        {
            PositionDAO.AddPosition(position);
        }

        public static List<PositionDTO> GetPosition()
        {
            return PositionDAO.GetPosition();
        }

        public static void UpdatePosition(Position position, bool control)
        {
            PositionDAO.UpdatePostion(position);
            if (control)
                EmployeeDAO.UpdateEmployee(position);
        }

        public static void DeletePosition(int iD)
        {
            PositionDAO.DeletePosition(iD);
        }
    }
}
