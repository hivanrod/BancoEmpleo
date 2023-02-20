using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ClassLibraryBancoEmpleo;

namespace ApiBancoEmpleo
{
    public class BancoEmpleoDbContext : DbContext
    {
        public DbSet<Empleador> Empleadores { get; set; }
        public DbSet<Empleo> Empleos { get; set; }
        public BancoEmpleoDbContext(DbContextOptions<BancoEmpleoDbContext> options)
             : base(options)
        {

        }
    }
}
