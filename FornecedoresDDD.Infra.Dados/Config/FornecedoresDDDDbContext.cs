using FornecedoresDDD.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Infra.Dados.Config
{
    public class FornecedoresDDDDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public FornecedoresDDDDbContext(DbContextOptions<FornecedoresDDDDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString()
        {
            //Alterar para configurações desejadas:
            return "Server=(localdb)\\MSSQLLocalDB;Database=FornecedoresDDD;Trusted_Connection=True;";
        }
    }
}
