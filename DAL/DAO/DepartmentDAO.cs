﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmentDAO : EmployeeContext
    {
        public static void AddDepartment(Department department)
        {
            try
            {
                db.Departments.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<Department> GetDepartment()
        {
            return db.Departments.ToList();
        }

        public static void UpdateDepartment(Department department)
        {
            try
            {
                Department dpt = db.Departments.First(x => x.ID == department.ID);
                dpt.DepartmentName = department.DepartmentName;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public static void DeleteDepartment(int iD)
        {
            try
            {
                Department department = db.Departments.First(x => x.ID == iD);
                db.Departments.DeleteOnSubmit(department);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
