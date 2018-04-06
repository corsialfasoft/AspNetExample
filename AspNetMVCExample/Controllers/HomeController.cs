using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMVCExample.Models;

namespace AspNetMVCExample.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Oggetto = new Contatto("Luca", "Salzone");
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";
            ViewBag.Oggetto = new Contatto("Luca", "Salzone");
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";
            ViewBag.Oggetto = new Contatto("Luca", "Salzone");
            return View();
        }

        public ActionResult MyPage() {
            return View();
        }

        ITournement TournementDomain = new DomainModel();
        [HttpPost]
        public ActionResult MyPage(TorneoModel torneo) {
            try {
                TournementDomain.Save(torneo);
                ViewBag.Message = "inserito " + torneo.Nome;
            } catch (Exception) {
                ViewBag.Message = "Errore in fase di inserimento";
            }
            return View();
        }
        public class Contatto {
            public string Nome { get; }
            public string Cognome { get; }
            public Contatto(string nome, string cognome) {
                this.Nome = nome;
                this.Cognome = cognome;
            }
        }
    }
}