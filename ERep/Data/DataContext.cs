using ERep.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ERep.Data
{
    public class DataContext : DbContext
    {
        //constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSR>()
                .HasMany(p => p.PartosInfos)
                .WithOne()
                .HasForeignKey(b => b.CSRId)
                .OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<CSR>()
            //    .HasMany(c => c.CesareaMotivos)
            //    .WithOne()
            //    .HasForeignKey(b => b.CSRId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<Patient>().HasData(
            //    new Patient
            //    {
            //        Id = 1,
            //        Iniciales = "JD2",
            //        Folio = "102589",
            //        ECU = "102589",
            //        Date = DateTime.Now,
            //        Age = 0,
            //        StateId = 1,
            //        BornDate = DateTime.Now,
            //        PostalCode = "01070",
            //        Phone = "510000000",
            //        Email = "a@a.com",
            //        estadocivil = 1,
            //        CurrentPartner = SiNo.Sí,
            //        Residencia = Residencia.Rural,
            //        Residencialugar = "mmmer",
            //        escolaridad=3,
            //        escolaridadanos=1,
            //        escolaridadtipo = "mecanica"
            //    }
            // );
            modelBuilder.Entity<State>().HasData(
                new State { Id = 1, Name = "Aguascalientes" },
                new State { Id = 2, Name = "Baja California" },
                new State { Id = 3, Name = "Baja California Sur" },
                new State { Id = 4, Name = "Campeche" },
                new State { Id = 5, Name = "Chiapas" },
                new State { Id = 6, Name = "Chihuahua" },
                new State { Id = 7, Name = "Coahuila" },
                new State { Id = 8, Name = "Colima" },
                new State { Id = 9, Name = "Ciudad de México" },
                new State { Id = 10, Name = "Durango" },
                new State { Id = 11, Name = "Guanajuato" },
                new State { Id = 12, Name = "Guerrero" },
                new State { Id = 13, Name = "Hidalgo" },
                new State { Id = 14, Name = "Jalisco" },
                new State { Id = 15, Name = "México" },
                new State { Id = 16, Name = "Michoacán" },
                new State { Id = 17, Name = "Morelos" },
                new State { Id = 18, Name = "Nayarit" },
                new State { Id = 19, Name = "Nuevo León" },
                new State { Id = 20, Name = "Oaxaca" },
                new State { Id = 21, Name = "Puebla" },
                new State { Id = 22, Name = "Querétaro" },
                new State { Id = 23, Name = "Quintana Roo" },
                new State { Id = 24, Name = "San Luis Potosí" },
                new State { Id = 25, Name = "Sinaloa" },
                new State { Id = 26, Name = "Sonora" },
                new State { Id = 27, Name = "Tabasco" },
                new State { Id = 28, Name = "Tamaulipas" },
                new State { Id = 29, Name = "Tlaxcala" },
                new State { Id = 30, Name = "Veracruz" },
                new State { Id = 31, Name = "Yucatán" },
                new State { Id = 32, Name = "Zacatecas" }
            );
            base.OnModelCreating(modelBuilder);
        }
       
        public DbSet<Patient> Patients { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<CSR> CSRs { get; set; }
        public DbSet<PartosInfo> PartosInfos { get; set; }
        //public DbSet<CesareaMotivo> CesareaMotivos { get; set; }
    }
}

