using System;
using ejemvcxamarin.Models;
using Microsoft.EntityFrameworkCore;

namespace ejemvcxamarin.Data
{
    public class DoctorContext :DbContext
    {
        
        public DoctorContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Doctor> Doctores { get; set; }
    
    }
}
