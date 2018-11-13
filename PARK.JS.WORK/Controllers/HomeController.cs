using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PARK.JS.WORK.Data;
using PARK.JS.WORK.Models;
using PARK.JS.WORK.Models.ApplicationModel;

namespace PARK.JS.WORK.Controllers
{
    public class HomeController : Controller
    {
        #region+ User List
        //private ApplicationDbContext _applicationDbContext;

        //public HomeController(ApplicationDbContext applicationDbContext)
        //{
        //    _applicationDbContext = applicationDbContext;
        //}

        //public IActionResult UserList()
        //{
        //    return View(_applicationDbContext.Users.ToList());
        //    //return View();
        //}
        #endregion

        private readonly RoleManager<ApplicationRole> roleManager;

        public HomeController(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> RoleIndex()
        {
            return View(await roleManager.Roles.ToListAsync());
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
