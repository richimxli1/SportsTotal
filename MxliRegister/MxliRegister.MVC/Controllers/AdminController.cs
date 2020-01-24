using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MxliRegister.MVC.Controllers
{
    public class AdminController : Controller
    {
        /*   private readonly IHttpContextAccessor _httpContextAccessor;
           private ISession _session => _httpContextAccessor.HttpContext.Session;


           public AdminController(IHttpContextAccessor httpContextAccessor)
           {
               _httpContextAccessor = httpContextAccessor;
           }
            */
        public IActionResult Login()
        {

         /*   //model.UserName = "gustavo.balboa";
            //model.RememberMe = true;
            //Collaborator = collaboratorService.GetCollaborator(model.UserName);
            //Collaborator.Photo = activeDirectoryService.GetCollaboratorPhoto(model.UserName);
            System.Web.HttpContext.Current.Session[Constants.UserSession] = this.Collaborator;
            System.Web.HttpContext.Current.Session[Constants.UserSessionRoles] = projectRoleService.GetUserRoles(this.Collaborator.Id);
            FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
            */
            
            return View();
        }

        public IActionResult InsertTeam()
        {
            return View();
        }
        public IActionResult InsertPlayer()
        {
            return View();
        }
        public IActionResult SeePlayersRegister()
        {
            return View();
        }
    }
}