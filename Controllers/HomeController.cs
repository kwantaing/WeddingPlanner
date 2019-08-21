using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        public MyContext dbContext;

        public HomeController(MyContext context){
            dbContext = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Register");
        }

        [HttpGet("register")]
        public IActionResult RegisterPage()
        {
            return View("Register");
        }
        [HttpPost("register")]
        public IActionResult Register(Guest guest)
        {
            if(ModelState.IsValid){

                if(dbContext.Guests.Where(u => u.email==guest.email).ToList().Count>0){
                    //Guest with that email already exists
                    ModelState.AddModelError("email","Email is already in use!");
                    return View("Register");
                }
                PasswordHasher<Guest> Hasher = new PasswordHasher<Guest>();
                guest.password = Hasher.HashPassword(guest, guest.password);
                dbContext.Guests.Add(guest);
                dbContext.SaveChanges();

                var newguest = dbContext.Guests.Last();
                newguest.created_at = DateTime.Now;
                newguest.updated_at = DateTime.Now;
                
                int id = newguest.guest_id;
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("guest_id",id);

                return RedirectToAction("Welcome");

            }else{
                return View("Register");
            }
        }
        [HttpGet("welcome")]

        public IActionResult Welcome()
        {
            int ? current_guest_id = HttpContext.Session.GetInt32("guest_id");
            if(current_guest_id==null){
                ModelState.AddModelError("email","Not logged in, please register or log in.");
                return View("Register");
            }else{
                var CurrentGuest = dbContext.Guests.FirstOrDefault(u => u.guest_id == current_guest_id);
                if(CurrentGuest == null){
                    ModelState.AddModelError("email","Not logged in, please register or log in.");
                    return View("Register");
                }else{
                    var allWeddings = dbContext.Weddings
                        .Include(w => w.Creator)
                        .Include(w => w.RSVPs)
                            .ThenInclude(r => r.Guest)
                        .ToList();
                    ViewBag.guest_id = current_guest_id;
                    return View(allWeddings);
                }
            }
        }
        [HttpGet("wedding/new")]
        public IActionResult weddingPage()
        {
            return View("Add");
        }
        [HttpPost("wedding/new")]
        public IActionResult addWedding(Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                newWedding.Creator = dbContext.Guests.First(g => g.guest_id == HttpContext.Session.GetInt32("guest_id"));
                dbContext.Weddings.Add(newWedding);
                dbContext.SaveChanges();
                ViewBag.guest_id = HttpContext.Session.GetInt32("guest_id");
                return RedirectToAction("Welcome");
            }else
            {
                return View("Add");
            }
        }
        [HttpGet("rsvp/new/{wedding_id}")]
        public IActionResult addRSVP(int wedding_id)
        {
            RSVP newRSVP =  new RSVP(wedding_id,(int)HttpContext.Session.GetInt32("guest_id"));
            // var Wedding = dbContext.Weddings.FirstOrDefault(w => w.wedding_id == RSVP.wedding_id);
            var Guest = dbContext.Guests.FirstOrDefault(g => g.guest_id == newRSVP.guest_id);
            dbContext.RSVPs.Add(newRSVP);
            dbContext.SaveChanges();
            Guest.RSVPs.Add(dbContext.RSVPs.Last());
            dbContext.SaveChanges();
            return RedirectToAction("Welcome");
        }
        [HttpGet("rsvp/remove/{wedding_id}")]
        public IActionResult unRSVP(int wedding_id)
        {
            var weddingRSVPs =  dbContext.RSVPs.Where(r => r.wedding_id == wedding_id).ToList();
            var toberemoved = weddingRSVPs.FirstOrDefault(r => r.guest_id == HttpContext.Session.GetInt32("guest_id"));
            dbContext.RSVPs.Remove(toberemoved);
            dbContext.SaveChanges();
            return RedirectToAction("Welcome");
        }
        [HttpGet("wedding/remove/{wedding_id}")]
        public IActionResult removeWedding(int wedding_id)
        {
            var wedding = dbContext.Weddings.Include(w => w.RSVPs).First(w => w.wedding_id == wedding_id);
            var weddingRSVPs = wedding.RSVPs.ToList();
            foreach(var rsvp in weddingRSVPs)
            {
                dbContext.RSVPs.Remove(rsvp);   
            }
            dbContext.Weddings.Remove(wedding);
            dbContext.SaveChanges();
            return RedirectToAction("Welcome");
        }
        [HttpGet("wedding/{wedding_id}")]
        public IActionResult Detail(int wedding_id)
        {
            var wedding = dbContext.Weddings
                            .Include(w => w.RSVPs)
                                .ThenInclude(r => r.Guest)
                            .Include(w => w.Creator)
                            .FirstOrDefault(w => w.wedding_id == wedding_id);
            return View(wedding);
        }
        [HttpGet("login")]
        public IActionResult LoginPage(){
            return View("Login");
        }
        [HttpPost("login")]
        public IActionResult Login(loginGuest guest){
            if(ModelState.IsValid){
                if(dbContext.Guests.FirstOrDefault(u => u.email == guest.email) ==null){
                    ModelState.AddModelError("email", "Invalid Email/Password");
                    return View("Login");
                }
                var correctGuest = dbContext.Guests.First(u =>u.email == guest.email);
                var hasher = new PasswordHasher<loginGuest>();

                if(hasher.VerifyHashedPassword(guest,correctGuest.password,guest.password)!=0){
                    HttpContext.Session.SetInt32("guest_id",correctGuest.guest_id);
                    return RedirectToAction("Welcome");
                }else{
                    ModelState.AddModelError("email","Invalid Email/Password");
                    return View("Login");
                }
            }
            return View("Login");   
        }

        [HttpGet("logout")]
        public IActionResult Logout(){
            HttpContext.Session.Remove("guest_id");
            return View("Register");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
