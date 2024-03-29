﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
    }
}
