using ExFinalCalidadN00020449.Models;
using ExFinalCalidadN00020449.Models.Map;
using ExFinalDiarsN00020449.Models.Map;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExFinalDiarsN00020449.Models
{
    public interface IN00020449Context
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Nota> Notas { get; set; }
        DbSet<Etiqueta> Etiquetas { get; set; }
        DbSet<DetalleEtiquetaNota> DetalleEtiquetaNotas { get; set; }
        DbSet<Compartir> Compartirs { get; set; }
        int SaveChanges();
    }
    public class N00020449Context : DbContext, IN00020449Context
    {
        public N00020449Context(DbContextOptions<N00020449Context> options)
           : base(options) { }
        public N00020449Context() { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<DetalleEtiquetaNota> DetalleEtiquetaNotas { get; set; }
        public DbSet<Compartir> Compartirs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new NotaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaNotaMap());
            modelBuilder.ApplyConfiguration(new CompartirMap());

        }
    }
}
