using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class SalaryDAO : EmployeeContext
    {
        public static List<Month> GetMonths()
        {
            return db.Months.ToList();
        }

        public static void AddSalary(Salary salary)
        {
            try
            {
                db.Salaries.InsertOnSubmit(salary);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<SalaryDetailDTO> AddSalaries()
        {
            List<SalaryDetailDTO> salaryList = new List<SalaryDetailDTO>();

            var list = (from s in db.Salaries
                        join e in db.Employees on s.EmployeeID equals e.ID
                        join m in db.Months on s.MonthId equals m.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            name = e.Name,
                            surname = e.Surname,
                            EmployeeID = s.EmployeeID,
                            amount = s.Amount,
                            year = s.Year,
                            monthName = m.MonthName,
                            monthID = s.MonthId,
                            salaryID = s.ID,
                            departmentID = e.DepartmentID,
                            positionID = e.PositionID
                        }).OrderBy(x => x.year).ToList();

            foreach (var item in list)
            {
                SalaryDetailDTO dto = new SalaryDetailDTO();
                dto.UserNo = item.UserNo;
                dto.Name = item.name;
                dto.Surname = item.surname;
                dto.EmployeeID = (int)item.EmployeeID;
                dto.SalaryAmount = (int)item.amount;
                dto.SalaryYear = (int)item.year;
                dto.MonthName = item.monthName;
                dto.MonthID = (int)item.monthID;
                dto.SalaryID = item.salaryID;
                dto.DepartmentID = item.departmentID;
                dto.PositionID = item.positionID;
                dto.OldSalary = (int)item.amount;
                salaryList.Add(dto);
            }

            return salaryList;
        }

        public static void UpdateSalary(Salary salary)
        {
            try
            {
                Salary s1 = db.Salaries.First(x => x.ID == salary.ID);
                s1.Amount = salary.Amount;
                s1.Year = salary.Year;
                s1.MonthId = salary.MonthId;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
