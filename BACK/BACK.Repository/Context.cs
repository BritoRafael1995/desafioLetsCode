using BACK.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BACK.Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
          : base(options)
        { }
        public DbSet<Card> Cards { get; set; }
    }
}
