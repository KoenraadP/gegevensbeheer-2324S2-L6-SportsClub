using SportsClub.Bll;
using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsClub.WebApp.Controllers
{
    // deze NIET static!
    public class MembersController : Controller
    {
        // CREATE
        // eerste create methode maakt de create pagina aan
        public ActionResult Create()
        {
            return View();
        }

        // tweede create methode verwerkt de data van de create pagina
        // parameters = zelfde naam als de 'name' van de input tags
        [HttpPost]
        public ActionResult Create(string firstName, string lastName)
        {
            // create methode uit BLL uitvoeren en waarde opslaan
            bool createSuccessful = Members.Create(firstName, lastName);

            // feedback maken
            if (createSuccessful)
            {
                // ViewBag is iets dat meegenomen wordt naar de view
                // je kunt de inhoud van de viewbag dus tonen op de view
                ViewBag.Feedback = firstName + " " + lastName + " werd toegevoegd.";  
            }
            else
            {
                ViewBag.Feedback = "Het is niet gelukt om een member aan te maken.";
            }

            return View();
        }

        // READ ALL
        public ActionResult Index()
        {
            // read methode uit Bll gebruiken
            List<Member> lstMembers = Members.Read();
            // lijst van members doorsturen naar Index View pagina
            return View(lstMembers);
        }

        // READ SINGLE
        public ActionResult Details(int id)
        {
            // Read methode uit BLL gebruiken om member op te zoeken
            Member m = Members.Read(id);
            // Member m doorgeven aan view
            return View(m);
        }

        // UPDATE

        // DELETE
        // eerste methode --> delete pagina (view) linken en maken
        public ActionResult Delete(int id)
        {
            // read methode uit bll uitvoeren om member op te zoeken
            Member m = Members.Read(id);
            // member doorgeven aan delete view
            return View(m);
        }
    }
}