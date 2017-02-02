using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystemApp.BLL;

namespace UniversityManagementSystemApp.Controllers
{
    public class OtherController : Controller
    {
        OtherManager aOtherManager = new OtherManager();
        //
        // GET: /Other/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult UnassignCourse()
        {
            if (Session["userType"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Session["userType"].ToString() != "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult UnassignCourse(int? a)
        {
            if (Session["userType"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Session["userType"].ToString() != "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            string message = aOtherManager.UnassignCourse();
            ViewBag.message = message;
            
            return View();
        }

        public ActionResult UnAllocateClassRoom()
        {
            if (Session["userType"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Session["userType"].ToString() != "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult UnAllocateClassRoom(int? a)
        {
            if (Session["userType"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Session["userType"].ToString() != "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            string message = aOtherManager.UnAllocateClassRoom();
            ViewBag.message = message;
            return View();
        }


        public ActionResult LogOut()
        {
            if (Session["userType"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Session["userType"].ToString() != null)
            {
                Session.Clear();
                return RedirectToAction("Login", "Account");
            }
            return RedirectToAction("Login", "Account");
            
        }
       
	}
}