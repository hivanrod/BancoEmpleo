using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ClassLibraryBancoEmpleo;
using ClassLibraryBancoEmpleo.Models;

namespace ApiBancoEmpleo
{
    public class ApiBancoEmpleoDbContext : DbContext
    {
        public DbSet<Empleador> Empleadores { get; set; }
        public DbSet<Empleo> Empleos { get; set; }
        public DbSet<CargoTipo> EmpleoTipo { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
         public DbSet<Zona> Zona { get; set; }
       public ApiBancoEmpleoDbContext(DbContextOptions<ApiBancoEmpleoDbContext> options)
             : base(options)
        {

        }
    }
}
