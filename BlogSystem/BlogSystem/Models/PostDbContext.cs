using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSystem.Models
{
    public class PostDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}