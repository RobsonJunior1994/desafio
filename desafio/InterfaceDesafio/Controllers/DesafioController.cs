﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceDesafio.Controllers
{
    public class DesafioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdicionarItem()
        {
            return View();
        }

        public IActionResult IndexContact()
        {
            return View();
        }
    }
}