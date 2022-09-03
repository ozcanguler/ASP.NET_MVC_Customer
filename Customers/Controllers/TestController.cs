using Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customers.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //make a list of users

            //usually this would come from a database source
            //in this demo we will hard code the values into this class
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("Roger Federer", "Federer@gmail.com", "123", "https://i.pravatar.cc/300?img=2", "https://en.wikipedia.org/wiki/Roger_Federer", "Roger Federer (born 8 August 1981) is a Swiss professional tennis player. "));
            users.Add(new UserModel("Victoria Azarenka", "Azarenka@gmail.com", "123", "https://i.pravatar.cc/300?img=1", "https://en.wikipedia.org/wiki/Victoria_Azarenka", "Victória Fyódarauna Azárenka (born 31 July 1989) is a Belarusian professional tennis player. "));
            users.Add(new UserModel("Rafael Nadal", "Nadal@gmail.com", "123", "https://i.pravatar.cc/300?img=13", "https://en.wikipedia.org/wiki/Rafael_Nadal", "Rafael Nadal Parera (born 3 June 1986) is a Spanish professional tennis player."));
            users.Add(new UserModel("Serena Williams", "Williams@gmail.com", "123", "https://i.pravatar.cc/300?img=16", "https://en.wikipedia.org/wiki/Serena_Williams", "Serena Jameka Williams (born September 26, 1981) is an American retired professional tennis player."));
            users.Add(new UserModel("Dustin Brown", "Brown@gmail.com", "123", "https://i.pravatar.cc/300?img=51", "https://en.wikipedia.org/wiki/Dustin_Brown_(tennis)", "Dustin Brown (born 8 December 1984) is a German-Jamaican professional tennis player."));
            return View("Test",users);
        }
    }
}