using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_employee_without_DB.Models
{
    public class employee
    {
        public int empid { get; set; }
        public string name { get; set; }
        public string deptName { get; set; }
        public string gender { set; get; }
        public string address { get; set; }
        public string city  { get; set; }
    }
}