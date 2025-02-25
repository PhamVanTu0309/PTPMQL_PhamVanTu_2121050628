using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTTH1902.Models;

namespace BTTH1902.Controllers;

public class ScoreSubjectController : Controller
{
    private readonly ILogger<ScoreSubjectController> _logger;

    public ScoreSubjectController(ILogger<ScoreSubjectController> logger)
    {
        _logger = logger;
    }

     public IActionResult IndexScoreSubject()
        {
            return View();
        }
          [HttpPost]
        public IActionResult IndexScoreSubject(ScoreSubject ps)
        {
            double GPA = (ps.SJA*5 + ps.SJB*4 + ps.SJC*1)/10;
            ViewBag.Message = $" Môn: {ps.Subject} có điểm trung bình là {GPA.ToString("F2")}";
            return View();
        }
}
