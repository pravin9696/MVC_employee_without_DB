using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_employee_without_DB.Models;

namespace MVC_employee_without_DB.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(login lg)
        {
            if (lg.userid == "admin" && lg.password == "admin@123")
            {
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        public ActionResult Registration()
        {
            List<cities> citylist = new List<cities>() {
             new cities(){cityid=1,cityName="mumbai"},
             new cities(){cityid=2,cityName="pune"},
             new cities(){cityid=3,cityName="nashik"},
             new cities(){cityid=4,cityName="nagar"}
            };
            ViewBag.cities = citylist;

            List<depts> deptlist = new List<depts>() {
            new depts(){ deptid=111,deptName="HR" },
            new depts(){ deptid=222,deptName="Sales" },
            new depts(){ deptid=333,deptName="Account" },
            new depts(){ deptid=444,deptName="Production" },
            };
            ViewBag.depts = deptlist;
            
            return View();
        }
        [HttpPost]
        public ActionResult Registration(employee emp)
        {

            return View();
        }
        public ActionResult editInfo()
        {
            List<cities> citylist = new List<cities>() {
             new cities(){cityid=1,cityName="mumbai"},
             new cities(){cityid=2,cityName="pune"},
             new cities(){cityid=3,cityName="nashik"},
             new cities(){cityid=4,cityName="nagar"}
            };
            ViewBag.cities1 = citylist;

            List<depts> deptlist = new List<depts>() {
            new depts(){ deptid=111,deptName="HR" },
            new depts(){ deptid=222,deptName="Sales" },
            new depts(){ deptid=333,deptName="Account" },
            new depts(){ deptid=444,deptName="Production" },
            };
            ViewBag.depts = deptlist;
            employee emp = new employee() {
                empid = 999, name = "pavan mane", deptName = "Sales", gender = "Female", address = "karve nagar",
                city = "pune",
            };
            return View(emp);
        }
    }
}