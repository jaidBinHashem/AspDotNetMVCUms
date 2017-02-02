using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystemApp.BLL;
using UniversityManagementSystemApp.DAL.Model;

namespace UniversityManagementSystemApp.Controllers
{
    public class TeacherController : Controller
    {
        //
        // GET: /Teacher/
        DepartmentManager aDepartmentManager = new DepartmentManager();
        DesignationManager aDesignationManager = new DesignationManager();
        TeacherManager aTeacherManager = new TeacherManager();
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult AddTeacher()
        {
            if (Session["userType"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Session["userType"].ToString() != "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            List<Department> aDepartments = aDepartmentManager.GetAllDepartment();
            ViewBag.DepatmentList = aDepartments;
            List<Designation> aDesignations = aDesignationManager.GetAllDesignation();
            ViewBag.DesignationList = aDesignations;
            return View();
        }
        [HttpPost]
        public ActionResult AddTeacher(Teacher aTeacher)
        {
            if (Session["userType"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Session["userType"].ToString() != "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            List<Department> aDepartments = aDepartmentManager.GetAllDepartment();
            ViewBag.DepatmentList = aDepartments;
            List<Designation> aDesignations = aDesignationManager.GetAllDesignation();
            ViewBag.DesignationList = aDesignations;
            aTeacher.Creditremain = aTeacher.CreditToTake;
            string message = aTeacherManager.SaveTeacher(aTeacher);
            ViewBag.message = message;
            return View();

        }
	}
}