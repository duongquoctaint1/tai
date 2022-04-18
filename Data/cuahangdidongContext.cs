using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cuahangdidong.Models;

namespace cuahangdidong.Data
{
    public class cuahangdidongContext : DbContext
    {
        public cuahangdidongContext (DbContextOptions<cuahangdidongContext> options)
            : base(options)
        {
        }

        public DbSet<cuahangdidong.Models.didong> didong { get; set; }
    }
}
