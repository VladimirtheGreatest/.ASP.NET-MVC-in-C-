using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        // GET: People/PeopleList
        public ActionResult ListPeople()
        {
            //model
            List<PersonModel> people = new List<PersonModel>();

            //data, can get it from the database, classlibrary, sql or the rest api
            people.Add(new PersonModel { FirstName = "Vladimir", LastName = "Doktorov", Age = 29 });
            people.Add(new PersonModel { FirstName = "Jeremy", LastName = "Corbyn", Age = 69 });
            people.Add(new PersonModel { FirstName = "Jessica", LastName = "James", Age = 39 });

            return View(people);
        }
    }
}