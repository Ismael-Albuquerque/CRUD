using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSMA.Models
{
    public class Context : DbContext
    {
        public DbSet<Reserva> Reservas { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
