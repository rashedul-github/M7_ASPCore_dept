using Microsoft.EntityFrameworkCore;
using Project_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Work.DAL
{
    public interface IContactualRepo
    {
        List<ContactualStaff> GetAll();
        ContactualStaff GetById(int id);
        bool Insert(ContactualStaff c);
        bool Update(ContactualStaff c);
        bool Delete(int id);
        List<Department> GetDept();
    }
    public class ContactualRepo : IContactualRepo
    {
        public DepartmentDbContext db = null;
        public ContactualRepo(DepartmentDbContext db) { this.db = db; }
        public bool Delete(int id)
        {
            ContactualStaff c = new ContactualStaff { ContactualStaffId = id };
            db.Entry(c).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }

        public List<ContactualStaff> GetAll()
        {
            return db.ContactualStaffs.ToList();
        }

        public ContactualStaff GetById(int id)
        {
            return db.ContactualStaffs.Include(x => x.department).FirstOrDefault(x => x.ContactualStaffId == id);
        }

        public List<Department> GetDept()
        {
            return db.Departments.ToList();
        }

        public bool Insert(ContactualStaff c)
        {
            db.ContactualStaffs.Add(c);
            return db.SaveChanges() > 0;
        }

        public bool Update(ContactualStaff c)
        {
            db.Entry(c).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
