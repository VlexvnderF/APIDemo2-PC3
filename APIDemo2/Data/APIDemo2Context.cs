using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIDemo2.Models;

namespace APIDemo2.Data
{
    public class APIDemo2Context : DbContext
    {
        public APIDemo2Context (DbContextOptions<APIDemo2Context> options)
            : base(options)
        {
        }

        public DbSet<APIDemo2.Models.Invoice> Invoice { get; set; } = default!;
    }
}
