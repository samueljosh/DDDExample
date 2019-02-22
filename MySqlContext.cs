using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayerExample.Infra.Context
{

    //ficará a classe de contexto, 
    //responsável por conectar no banco de dados e,
    //   também, por fazer o mapeamento das
   // tabelas do banco de dados nas entidades.

    public class MySqlContext : DbContext
    {
        public DbSet<User> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UserMap().Configure);
        }


    }
}
