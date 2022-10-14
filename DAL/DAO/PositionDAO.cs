using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PositionDAO : EmployeeContext
    {
        public static void AddPosition(Position position)
        {
            try
            {
                db.Positions.InsertOnSubmit(position);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PositionDTO> GetPosition()
        {
            try
            {
                var list = (from p in db.Positions
                            join d in db.Departments on p.DepartmentID equals d.ID
                            select new
                            {
                                positionID = p.ID,
                                positionName = p.PositionName,
                                derpartmentName = d.DepartmentName,
                                deparmentID = p.DepartmentID
                            }).OrderBy(x => x.positionID).ToList();

                List<PositionDTO> positionList = new List<PositionDTO>();
                foreach (var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.ID = item.positionID;
                    dto.PositionName = item.positionName;
                    dto.DepartmentName = item.derpartmentName;
                    dto.DepartmentID = item.deparmentID;
                    positionList.Add(dto);
                }
                return positionList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void DeletePosition(int iD)
        {
            try
            {
                Position postion = db.Positions.First(x => x.ID == iD);
                db.Positions.DeleteOnSubmit(postion);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdatePostion(Position position)
        {
            try
            {
                DAL.Position pst = db.Positions.First(x => x.ID == position.ID);
                pst.PositionName = position.PositionName;
                pst.DepartmentID = position.DepartmentID;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
