using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersRegistration.Models;

namespace UsersRegistration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //static List<GeneralUsersRole> mylist = new List<GeneralUsersRole>();

        static GeneralUsersRole generalUsersRole = new GeneralUsersRole();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ListOfUsers()
        {
            return View(generalUsersRole.mylist);
        }

        [HttpPost]
        public ActionResult Index(GeneralUsersRole models)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer

                models.roleOfUser.Id = models.myusers.Id;

                generalUsersRole.AddUsers(models);

                // ViewBag.MyList = generalUsersRole.mylist;

                //ViewBag.MyUser = generalUsersRole.myusers;

                return RedirectToAction("ListOfUsers", generalUsersRole.mylist);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        
    }
}