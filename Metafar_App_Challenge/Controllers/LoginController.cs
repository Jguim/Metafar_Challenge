using Metafar_App_Challenge.Models;
using Metafar_App_Challenge.Models.Enum;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipelines;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Metafar_App_Challenge.Controllers
{
    public class LoginController : Controller
    {
        

        private readonly ILogger<LoginController> _logger;        

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Login";            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SignIn(string name, string password)
        {
            string userId = "";
            //Check if it exists in db and return userId
            //HttpResponseMessage response; = await client
            

            if (userId != "") { return RedirectToAction("Index", "Actions", userId); }
            return Json(userId);
        }
        [HttpGet]
        public async Task<IActionResult> Register(string name, string password)
        {
            bool repeated = false;
            string userName = "";

            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync("api/User/");
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {

            }

            return Json(repeated, userName);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}