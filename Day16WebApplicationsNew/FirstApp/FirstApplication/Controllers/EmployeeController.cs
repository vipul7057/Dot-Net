using FirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> lstEmp = new List<Employee>();
            lstEmp.Add(new Employee { empno = 1, empname = "Name1", empbasic = 1000 });
            lstEmp.Add(new Employee { empno = 2, empname = "Name2", empbasic = 2000 });
            lstEmp.Add(new Employee { empno = 3, empname = "Name3", empbasic = 3000 });
            return View(lstEmp);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id=0)
        {
            Employee emp = new Employee();
            emp.empno = 1;
            emp.empname = "ABC";
            emp.empbasic = 1100;
            return View(emp);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id=0)
        {
            Employee emp = new Employee();
            emp.empno = 1;
            emp.empname = "ABC";
            emp.empbasic = 1100;
            return View(emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee objemp)
        {
            try
            {
                // TODO: Add update logic here
                string Name = objemp.empname;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id=0)
        {
            Employee emp = new Employee();
            emp.empno = 1;
            emp.empname = "ABC";
            emp.empbasic = 1100;
            return View(emp);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
