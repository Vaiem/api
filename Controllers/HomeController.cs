using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservateAPI.Models;


namespace ReservateAPI.Controllers
{
   
    public class HomeController : Controller
    {
        IRepository repos;

        public HomeController(IRepository repository)
        {
            repos = repository;
        }

        public IActionResult Index() => View(repos.GetResrvations);

        public IActionResult Error() => View();
    }
}