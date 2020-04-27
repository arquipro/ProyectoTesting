using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFacturaMvc.Models;
using Model.Entity;

namespace WebFacturaMvc.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public JsonResult Login(string usuario, string password)
        //{
        //    if (usuario == "admin" && password == "admin")
        //    {
        //        FormsAuthentication.SetAuthCookie(usuario, false);
        //        return Json(1);
        //    }
        //    else
        //    {
        //        return Json(-1);
        //    }
        //}
        //public ActionResult Verify(Account acc)
        //{
        //    objConexionDB.getCon().Open();
        //    com.Connection = objConexionD;
        //    com.CommandText = "select * from login where Usuario ='" + acc.Nombre + "' and Password ='" + acc.Password + "'";
        //    dr = com.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        con.close();
        //    }

        //}
    }
}