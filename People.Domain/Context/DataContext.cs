using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using People.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace People.Domain.Context
{
    public class DataContext : DbContext
    {
        public DataContext(
            DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
