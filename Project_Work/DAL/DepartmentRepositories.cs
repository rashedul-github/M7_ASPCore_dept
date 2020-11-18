using Project_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project_Work.DAL
{
    public interface IDepartmentRepositories
    {
        List<Department> GetAll();
        bool Insert(Department d);
        bool Update(Department dept, bool childIncluded = false);
        bool Delete(int id);
        int pageCount(int size);
        Department GetAll(int id);
        Department GetById(int id);
    }
    public class DepartmentRepositories : IDepartmentRepositories
    {
        public DepartmentDbContext db = null;
        public DepartmentRepositories(DepartmentDbContext db) { this.db = db; }

        public bool Delete(int id)
        {
            var dept = db.Departments.FirstOrDefault(s => s.DepartmentId == id);
            var per = db.PermanentStaffs.Where(x => x.DepartmentId == dept.DepartmentId);
            var con = db.ContactualStaffs.Where(x => x.DepartmentId == dept.DepartmentId);
            if (per?.Count() > 0 && con?.Count() > 0)
            {
                db.PermanentStaffs.RemoveRange(per);
                db.ContactualStaffs.RemoveRange(con);
            }
            db.Departments.Remove(dept);
            return db.SaveChanges()>0;
        }

        public List<Department> GetAll()
        {
            return db.Departments.Include(x => x.permanentStaff).Include(x => x.contactualStaff).ToList();
        }

        public Department GetAll(int id)
        {
            return db.Departments.Include(x => x.permanentStaff).Include(x => x.contactualStaff).FirstOrDefault(x => x.DepartmentId == id);
        }

        public Department GetById(int id)
        {
            return db.Departments.FirstOrDefault(s => s.DepartmentId == id);
        }

        public bool Insert(Department d)
        {
            db.Departments.Add(d);
            return db.SaveChanges() > 0;
        }

        public int pageCount(int size)
        {
            return (int)Math.Ceiling((double)db.Departments.Count() / size);
        }

        public bool Update(Department dept, bool childIncluded = false)
        {

            var ext = db.Departments.Include(x => x.permanentStaff).Include(y=>y.contactualStaff).First(x => x.DepartmentId == dept.DepartmentId);
            ext.DepartmentName = dept.DepartmentName;
            //permanent
            if (dept.permanentStaff != null && dept.permanentStaff.Count > 0)
            {
                var perStaff = dept.permanentStaff.ToArray();
                for (var i = 0; i < perStaff.Length; i++)
                {
                    var temp = ext.permanentStaff.FirstOrDefault(c => c.PermanentStaffId == perStaff[i].PermanentStaffId);
                    if (temp != null)
                    {
                        temp.PermanentStaffName = perStaff[i].PermanentStaffName;
                        temp.JoinDate = perStaff[i].JoinDate;
                        temp.MonthlySalary = perStaff[i].MonthlySalary;
                    }
                    else
                    {
                        ext.permanentStaff.Add(perStaff[i]);
                    }
                }
                foreach (var p in ext.permanentStaff)
                {
                    var temp = dept.permanentStaff.FirstOrDefault(d => d.PermanentStaffId == p.PermanentStaffId);
                    if (temp == null)
                        db.Entry(p).State = EntityState.Deleted;
                }
            }
            //contacttual
            if (dept.contactualStaff != null && dept.contactualStaff.Count > 0)
            {
                var conStaff = dept.contactualStaff.ToArray();
                for (var i = 0; i < conStaff.Length; i++)
                {
                    var temp = ext.contactualStaff.FirstOrDefault(c => c.ContactualStaffId == conStaff[i].ContactualStaffId);
                    if (temp != null)
                    {
                        temp.ContactualStaffName = conStaff[i].ContactualStaffName;
                        temp.StartDate = conStaff[i].StartDate;
                        temp.WeeklySalary = conStaff[i].WeeklySalary;
                    }
                    else
                    {
                        ext.contactualStaff.Add(conStaff[i]);
                    }
                }
                foreach (var c in ext.contactualStaff)
                {
                    var temp = dept.contactualStaff.FirstOrDefault(d => d.ContactualStaffId == c.ContactualStaffId);
                    if (temp == null)
                        db.Entry(c).State = EntityState.Deleted;
                }
            }
            //end
            return db.SaveChanges() > 0;
        }
    }
}
