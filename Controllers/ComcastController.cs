using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
//using Models;
using Microsoft.AspNetCore.Components;
//using MPower.Website.Screens;
//using MPower.Website.Pages;

namespace BlazorApp1.Controllers
{
    public class ComcastController : Controller
    { 
       
        public IActionResult about()
        {
            //UserClaimsBase sso = new UserClaimsBase();
            
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ViewData["ASPNETCORE_ENVIRONMENT"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            ViewBag.version = "Comcast endpoint for Mpower 2.0 " + version;
            ViewBag.versionnumber = version;

            return View();
        }

        public ActionResult login( )
        {
            //if (value == null) return BadRequest("Request body is invalid");
            //Screen screen = new Screen();
            //EntryModel? dealerNumber = new EntryModel();
            //EntryModel? username = new EntryModel();
            //PasswordEntryModel? dealerPasscode = new PasswordEntryModel();
            //ButtonModel? submit = new ButtonModel();

            try
            {
                return Redirect("https://localhost:7176/SSOLoginScreen");
            }
            catch
            {
                //return View();
                return StatusCode(500, "Comcast Login failed!");
            }
        }

        public ActionResult SSOLogin()
        {

            try
            { 

                string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                ViewData["ASPNETCORE_ENVIRONMENT"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                ViewBag.version = "Comcast endpoint for Mpower 2.0 " + version;
                ViewBag.versionnumber = version;

                return View();
               //return Redirect("https://localhost:7176/counter");
            }
            catch
            {
                //return View();
                return StatusCode(500, "Comcast Login failed!");
            }
        }

    }
}
