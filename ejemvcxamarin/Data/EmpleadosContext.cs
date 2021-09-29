using System;
using ejemvcxamarin.Models;
using Microsoft.EntityFrameworkCore;

namespace ejemvcxamarin.Data
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
