using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PARK.JS.WORK.Areas.UserManage.Models;
using PARK.JS.WORK.Models.ApplicationModel;

namespace PARK.JS.WORK.Areas.UserManage.Controllers
{
    // 컨트롤러의 경우 Area 생성후 Controller 폴더에서 우클릭하여 컨트롤러 추가(빈 컨트롤러)
    [Area("UserManage")]
    [Authorize(Roles = "Administrator")]
    public class ManageUsersController : ManageUsersControllerBaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        
        // Ctrl + . 눌러서 생성자 생성을 클릭하면 자동으로 작성됨
        public ManageUsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var admins = (await _userManager.GetUsersInRoleAsync("Administrator")).ToArray();

            var everyone = await _userManager.Users.ToArrayAsync();

            var model = new ManageUsersViewModel
            {
                Administrators = admins,
                Everyone = everyone
            };

            return View(model);
        }
    }
}