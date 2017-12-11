using disec.Areas.Admin.Models;
using disec.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace disec.Areas.Admin.Controllers
{
    public class UsuariosController : Controller
    {
        private ApplicationUser db = new ApplicationUser();
        public ActionResult ResetPassword()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult ResetPassword(ResetPasswordViewModels dato)
        //{
        //    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext(new OracleConnection(ConfigurationManager.ConnectionStrings["ContextIdentity"].ConnectionString))));          

        //    if (ModelState.IsValid)
        //    {
        //        var result = userManager.RemovePassword(dato.idUsuario);

        //        if (result.Succeeded)
        //        {
        //            var resul = userManager.AddPassword(dato.idUsuario, dato.nuevoPassword);

        //            if (resul.Succeeded)
        //            {
        //                //return RedirectToAction("Index", "Usuarios", new { area = "Administracion" });
        //            }
        //            else
        //            {
        //                ModelState.AddModelError(dato.nuevoPassword, "Lo sentimos, no se restablecio la contraseña");
        //            }
        //        }
        //    }
        //    return View(dato);
        //}
    }
}