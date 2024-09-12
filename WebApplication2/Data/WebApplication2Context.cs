﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class WebApplication2Context : DbContext
    {
        public WebApplication2Context (DbContextOptions<WebApplication2Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2.Models.Department> Department { get; set; }
        public DbSet<WebApplication2.Models.Saller> Saller { get; set; }
        public DbSet<WebApplication2.Models.SalesRecord> SalesRecord { get; set; }
    }
}
