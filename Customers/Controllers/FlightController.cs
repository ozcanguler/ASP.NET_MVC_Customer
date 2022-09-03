using Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customers.Controllers
{
    public class FlightController : Controller
    {
        // GET: Flight
        public ActionResult Flight()
        {
            List<AirlineModel> tickets = new List<AirlineModel>();  
            tickets.Add(new AirlineModel("Pegasus", "KAFA1500", "Esenboga","Sabiha",DateTime.Now,DateTime.Now,123));
           
            return View("Flight", tickets);
        }
    }
}