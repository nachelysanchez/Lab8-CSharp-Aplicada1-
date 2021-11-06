using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosControl.Entidades;

namespace UsuariosControl.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging().UseSqlite(@"Data Source = DATA\UsersControl.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombres = "Nachely V.",
                Apellidos = "Sanchez B.",
                NombreUsuario = "admin",
                Contrasena = "fe2592b42a727e977f055947385b709cc82b16b9a87f88c6abf3900d65d0cdc3" 
                //Contrasena: 4321
            });
        }
    }
}
