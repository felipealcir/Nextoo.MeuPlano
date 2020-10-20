using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Nextoo.MeuPlano.DAL.Extensions;
using Nextoo.MeuPlano.DAL.Mapping.Planos;
using Nextoo.MeuPlano.Dominio.Planos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nextoo.MeuPlano.DAL.Connection
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Plano> Planos { get; set; }     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new PlanoMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("MeuPlanoBD"));
        }

    }
}
