using FornecedoresDDD.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Infra.Dados.Config
{
    public class FornecedoresDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public FornecedoresDbContext()
        {

        }

        public FornecedoresDbContext(DbContextOptions<FornecedoresDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().Property(p => p.Preco).HasColumnType("decimal(6,2)").IsRequired(true);
        }

        private string GetConnectionString()
        {
            //Alterar para configurações desejadas:
            return "Server=(localdb)\\MSSQLLocalDB;Database=FornecedoresDDD;Trusted_Connection=True;MultipleActiveResultSets=True;";
        }
    }
}
