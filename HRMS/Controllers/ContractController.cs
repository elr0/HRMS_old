using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class ContractController : Controller
    {


        private s15153Context _context;

        public ContractController(s15153Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contracts()
        {
            return View(_context.Contract.ToList());
        }

    }
}