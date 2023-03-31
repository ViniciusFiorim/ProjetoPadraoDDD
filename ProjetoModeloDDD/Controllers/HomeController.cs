using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Informações do projeto.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatos para demais informações";
            return View();
        }
    }
}