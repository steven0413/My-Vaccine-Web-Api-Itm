using Microsoft.EntityFrameworkCore;
using MyVac.WebApi.Models;
using System.Collections.Generic;

namespace MyVac.WebApi.Data
{
    public class MyVaccineAppDbContext : DbContext
    {
        public MyVaccineAppDbContext(DbContextOptions<MyVaccineAppDbContext> options) : base(options) { }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }
        public DbSet<RegistroVacuna> RegistrosVacunas { get; set; }
    }
}