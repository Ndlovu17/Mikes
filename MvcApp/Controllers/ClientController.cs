using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp.Models;
using MvcApp.Repository;


namespace MvcApp.Controllers
{
    public class ClientController : Controller
    {
        private AssessmentContext db = new AssessmentContext();

        public ActionResult Index()
        {
            var client = db.Clients.ToList();
            return View(client);
        }

        
        public ActionResult GetClient(int Id)
        {
            var client = db.Clients.Where(c => c.Id == Id).Single();

            if (client == null)
                return HttpNotFound();


            return View(client);

        }

        public ActionResult Edit(int id)
        {
            var user = db.Clients.Where(c => c.Id == id).Single();
            if (user == null)
                return HttpNotFound("Not Found!");

            return View(new Client
            {
                Surname = user.Surname,
                FirstName = user.FirstName,
                IDType = user.IDType,
                IdNumber  = user.IdNumber,
                DateOfBirth = user.DateOfBirth
            });
        }

        [HttpPost]
        public ActionResult Edit(int id, Client form)
        {
            SelectListItem item;
            var user = db.Clients.Where(c => c.Id == id).Single();

            List<SelectListItem> myList = new List<SelectListItem>();
            item = new SelectListItem();
            item.Text = "ID Number";
            myList.Add(item);

            item = new SelectListItem();
            item.Text = "Passport";
            myList.Add(item);

            ViewBag.MyList = myList;


            if (user == null)
                return HttpNotFound("Not Found!");

            if (!ModelState.IsValid)
                return View(form);

            user.Surname = form.Surname;
            user.FirstName = form.FirstName;
            user.IDType = form.IDType;
            user.IdNumber = form.IdNumber;
            user.DateOfBirth = form.DateOfBirth;
            db.SaveChanges();

            return RedirectToAction("index");

        }



    }
}
