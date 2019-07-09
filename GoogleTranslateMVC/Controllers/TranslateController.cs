using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleTranslateMVC.Models;
namespace GoogleTranslateMVC.Controllers
{
    public class TranslateController : Controller
    {
        // GET: Translate
        public ActionResult Index()
        {
            using (var ctx = new DataContext())
            {
                var Lang = ctx.Translate.ToList();
                return View(Lang);
            }
        }
        [HttpPost]
        public ActionResult Index(Translate tran)
        {
            using (var ctx = new DataContext())
            {
                ctx.Translate.Add(tran);
                ctx.SaveChanges();

                var languageList = ctx.Translate.ToList();
                return View(languageList);
            }
        }

    }
}