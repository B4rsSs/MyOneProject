using Microsoft.AspNetCore.Mvc;
using MyOneProject.Domain;
using MyOneProject.Models;
using System.Diagnostics;

namespace MyOneProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(_dataManager.TextField.GetTextFieldbyName("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(_dataManager.TextField.GetTextFieldbyName("PageContacts"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}