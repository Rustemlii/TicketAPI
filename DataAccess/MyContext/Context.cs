using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MyContext
{
    public class Context:DbContext
    {

        public DbSet<Ticket>Tickets { get; set; }
        public Context(DbContextOptions<Context>options):base(options)
        {
            
        }
    }
}
