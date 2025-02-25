
using BTTH1902.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTTH1902.Controllers
{
    public class BMIController:Controller{
        [HttpGet]

        public IActionResult IndexBMI()
        {
            return View();
        }
          [HttpPost]
        public IActionResult IndexBMI(BMIModel ps)
        {
            double ScoreBMI = ps.Weight / (ps.Height * ps.Height);
            ViewBag.Message = $"{ps.Name}, BMI: {ScoreBMI:0.##}";
            
            return View();
        }

    }
}