using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_Work.DAL;
using Project_Work.Models;

namespace Project_Work.Controllers
{
    public class ContactualsController : Controller
    {
        public IContactualRepo _repo = null;
        public ContactualsController(IContactualRepo repo) { this._repo = repo; }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.DeptList = this._repo.GetDept();
            return View();
        }
        [HttpPost]
        public IActionResult Create(ContactualStaff c)
        {
            if (ModelState.IsValid)
            {
                if (this._repo.Insert(c))
                {
                    return RedirectToAction("Index", "Departments");
                }
                else
                {
                    NotFound();
                }
            }
            ViewBag.DeptList = this._repo.GetDept();
            return View();
        }
        public IActionResult Edit(int id)
        {
            var data = this._repo.GetById(id);
            ViewBag.DeptList = this._repo.GetDept();
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(ContactualStaff c)
        {
            if (ModelState.IsValid)
            {
                if (this._repo.Update(c))
                {
                    return RedirectToAction("Index", "Departments");
                }
                else
                {
                    NotFound();
                }
            }
            ViewBag.DeptList = this._repo.GetDept();
            return View();
        }
        public IActionResult Delete(int id)
        {
            var data = this._repo.GetById(id);
            return View(data);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            if (ModelState.IsValid)
            {
                if (this._repo.Delete(id))
                {
                    return RedirectToAction("Index", "Departments");
                }
                else
                {
                    NotFound();
                }
            }
            return View();
        }
    }
}