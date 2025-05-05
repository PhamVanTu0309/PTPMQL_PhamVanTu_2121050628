using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TinhBMI.Models;

namespace TinhBMI.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult IndexBMI(){
            return view();
        }
    }
}