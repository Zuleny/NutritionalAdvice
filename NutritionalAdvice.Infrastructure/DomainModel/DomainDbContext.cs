﻿using NutritionalAdvice.Infrastructure.StoredModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutritionalAdvice.Domain.Ingredients;

namespace NutritionalAdvice.Infrastructure.DomainModel
{
    internal class DomainDbContext : DbContext
    {
        public DbSet<Ingredient> Ingredient { get; set; }

        public DomainDbContext(DbContextOptions<DomainDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DomainDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
