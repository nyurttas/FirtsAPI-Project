﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YMYP67_FirstAPI.Entities.Concrete;


namespace YMYP67_FirstAPI.DataAccess.Concrete.EntityFramework;
public class FirstApiContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=MUSTAFA;Initial Catalog=Ymyp67FirstApi;Integrated Security=True;Trust Server Certificate=True;");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Person> Persons { get; set; }
}