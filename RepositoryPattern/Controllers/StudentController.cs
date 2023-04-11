using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryPattern.Models;

namespace RepositoryPattern.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository sr = new StudentRepository();
        // GET: Student
        public ActionResult Index()
        {
            return View(sr.getdata());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View(sr.search(id));
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            Student s = new Student();
            return View(s);
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student svm)
        {
            try
            {
                // TODO: Add insert logic here
                sr.Addnewrecord(svm);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student svm)
        {
            try
            {
                sr.EditRecord(svm);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Student svm)
        {
            try
            {
                // TODO: Add delete logic here
                sr.DeleteRecord(svm);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
