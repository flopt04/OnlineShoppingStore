using OnlineShoppingStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Controllers
{
    public class RegisterController : Controller
    {
        dbMyOnlineShoppingEntities db = new dbMyOnlineShoppingEntities();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveData(Tbl_Members model)
        {
            db.Tbl_Members.Add(model);
            db.SaveChanges();
            return Json("Registro efetuado com sucesso", JsonRequestBehavior.AllowGet);
        }

    }
}