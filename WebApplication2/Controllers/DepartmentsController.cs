﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers {
    public class DepartmentsController : Controller {
        public IActionResult Index() {
            List<Department> list = new List<Department>();
            list.Add(new Department { id = 1, Name = "Eletronics" });
            list.Add(new Department { id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
