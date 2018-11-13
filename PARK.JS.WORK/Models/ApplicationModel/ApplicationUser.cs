using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARK.JS.WORK.Models.ApplicationModel
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    // cshtml and cshtml.cs 에서 IdentityUser -> ApplicationUser 로 모두 바꾸어줘야 한다.
    // InvalidOperationException: Unable to resolve service for type 'Microsoft.AspNetCore.Identity.SignInManager`1[Microsoft.AspNetCore.Identity.IdentityUser]' while attempting to activate
    public class ApplicationUser : IdentityUser
    {
        #region+ 참고
        //[Display(Name = "USER NAME")]
        //override public string UserName { get; set; }

        //// override 작성한 뒤 ctrl + . 누르면 오버라이드 대상목록이 나옴. 선택하면 자동으로 작성됨
        //[Display(Name = "E-MAIL")]
        //public override string Email { get => base.Email; set => base.Email = value; }
        #endregion
    }
}