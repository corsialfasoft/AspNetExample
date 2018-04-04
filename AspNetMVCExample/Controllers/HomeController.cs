using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCExample.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Oggetto = new Contatto("Luca","Salzone");
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";
            ViewBag.Oggetto = new Contatto("Luca","Salzone");
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";
            ViewBag.Oggetto = new Contatto("Luca","Salzone");
            return View();
        }
    }

    public class Contatto{
        public string Nome{get;}
        public string Cognome{get;}
        public Contatto(string nome, string cognome){
            this.Nome=nome;
            this.Cognome=cognome;
        }
    }
}