﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TMDb.DataAccess.Entities;
using CsvHelper;
using System.Globalization;

namespace TMDb.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

    }

}
