using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEfDemo
{
    public class EfDemoDbContext : DbContext
    {
        private readonly string connstring;

        public DbSet<Product> Products { get; set; }
        public EfDemoDbContext(string connstring)
        {
            this.connstring = connstring;
        }

    }
}
