using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvite.Models;

namespace PartyInvite.Controllers
{
    public class HomeController : Controller
    {


        
        

        
        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good evening";
            return View("MyView");
            
        }
        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponce guestResponce) {
            if (ModelState.IsValid)
            {
                Repository.AddResponce(guestResponce);
                
             //   Repository.AddResponce(guestResponce);
           //     db.Responces.Add(guestResponce)
                return View("ThankForm", guestResponce);
            }
            else return View();
        }
        
        public ViewResult ListResponses() {
            return View(Repository.Responces.Where(r=>r.WillAttend==true));
        }
       
    }
}
