using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult IndexPerson()
        {
            return View();
        }
       [HttpPost]
       public IActionResult IndexPerson(Person ps)
       {
        string str0utput = "Xin chao " +ps.PersonId + "-" + ps.Fullname +"-" + ps.Address;
        ViewBag.infoPerson = str0utput;
        return View();
       }
    }
}