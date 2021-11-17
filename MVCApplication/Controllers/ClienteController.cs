using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;

namespace MVCApplication.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //DataAnnotation | Attribute
        [HttpPost]
        public IActionResult Create(ClienteInsertViewModel viewModel)
        {
            return View();
        }
    }
}
