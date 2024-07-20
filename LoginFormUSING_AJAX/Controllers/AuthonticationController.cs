using LoginFormUSING_AJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginFormUSING_AJAX.Controllers
{
    public class AuthonticationController : Controller
    {
        // GET: Authontication
        MaveRickEntities db=new MaveRickEntities(); 
        public ActionResult IndexLogin()
        {
            return View();
        }
        public JsonResult SaveData(LoginTb tb)
        {
            db.LoginTbs.Add(tb);
            db.SaveChanges();
            return Json("Registration Successfull",JsonRequestBehavior.AllowGet);
        }
            
    }
}