using Microsoft.EntityFrameworkCore;
using Project_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project_Work.DAL
{
    public interface IPermanentStaffRepo
    {
        List<PermanentStaff> GetAll();
        PermanentStaff GetById(int id);
        bool Insert(PermanentStaff p);
        bool Update(PermanentStaff p);
        bool Delete(int id);
        List<Department> GetDept();
    }
    public class PermanentStaffRepo : IPermanentStaffRepo
    {
        public DepartmentDbContext db = null;
        public PermanentStaffRepo(DepartmentDbContext db) { this.db = db; }
        public bool Delete(int id)
        {
            PermanentStaff p = new PermanentStaff { PermanentStaffId = id };
            db.Entry(p).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }

        public List<PermanentStaff> GetAll()
        {
            return db.PermanentStaffs.ToList();
        }

        public PermanentStaff GetById(int id)
        {
            return db.PermanentStaffs.Include(x=>x.department).FirstOrDefault(x => x.PermanentStaffId == id);
        }

        public List<Department> GetDept()
        {
            return db.Departments.ToList();
        }

        public bool Insert(PermanentStaff p)
        {
            db.PermanentStaffs.Add(p);
            return db.SaveChanges() > 0;
        }

        public bool Update(PermanentStaff p)
        {
            db.Entry(p).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
