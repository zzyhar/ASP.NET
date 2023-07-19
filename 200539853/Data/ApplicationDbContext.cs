using System;
using _200539853.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _200539853.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}


