using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTTH1902.Models;

namespace BTTH1902.Controllers;

public class CaculatorController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public CaculatorController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult IndexCaculator()
    {
        return View();
    }
    [HttpPost]
    public IActionResult IndexCaculator(CaculatorModel ps)
    {
        Double TotalBill = ps.NumberItem * ps.Price;
        ViewBag.Message= $"Tổng tiền hoá đơn cho mặt hàng {ps.Item} là {TotalBill.ToString("F2")}";
        return View();
    }

   
}
