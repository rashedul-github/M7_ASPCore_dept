using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_Work.DAL;
using Project_Work.Models;
using X.PagedList;

namespace Project_Work.Controllers
{
    [Authorize]
    public class DepartmentsController : Controller
    {
        IDepartmentRepositories _repo = null;
        public DepartmentsController(IDepartmentRepositories repo) { this._repo = repo; }

        [AllowAnonymous]
        public IActionResult Index(int page=1)
        {
            
            int size = 4;
            var data = this._repo.GetAll().ToPagedList(page, size);
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = this._repo.pageCount(size);
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CreatePost(Department d)
        {
            if (ModelState.IsValid)
            {
                this._repo.Insert(d);
                return Json(new { success = true, message = "Data save succeeded" });
            }
            return Json(new { success = false, message = "Data save failed" });
        }
        public IActionResult Edit(int id)
        {
            var data = this._repo.GetAll(id);
            if (data == null)
                return NotFound();
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit([FromBody]Department d)
        {
            if (ModelState.IsValid)
            {
                if (this._repo.Update(d))
                    return Json(new { success = true });

            }
            return Json(new { success = false });
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
                    return RedirectToAction("Index");
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