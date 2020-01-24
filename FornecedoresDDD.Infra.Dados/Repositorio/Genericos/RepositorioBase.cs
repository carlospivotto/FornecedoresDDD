using FornecedoresDDD.Dominio.Interfaces.Genericas;
using FornecedoresDDD.Infra.Dados.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FornecedoresDDD.Infra.Dados.Repositorio.Genericos
{
    public class RepositorioBase<T> : InterfaceBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<FornecedoresDDDDbContext> _optionsBuilder;

        public RepositorioBase()
        {
            _optionsBuilder = new DbContextOptions<FornecedoresDDDDbContext>();
        }

        public void Adicionar(T obj)
        {
            using (var db = new FornecedoresDDDDbContext(_optionsBuilder))
            {
                db.Set<T>().Add(obj);
                db.SaveChangesAsync();
            }
        }

        public T RecuperarPorId(Guid id)
        {
            using (var db = new FornecedoresDDDDbContext(_optionsBuilder))
            {
                return db.Set<T>().Find(id);
            }
        }

        public void Atualizar(T obj)
        {
            using (var db = new FornecedoresDDDDbContext(_optionsBuilder))
            {
                db.Set<T>().Update(obj);
                db.SaveChangesAsync();
            }
        }

        public void Excluir(T obj)
        {
            using (var db = new FornecedoresDDDDbContext(_optionsBuilder))
            {
                db.Set<T>().Remove(obj);
                db.SaveChangesAsync();
            }
        }

        public IList<T> Listar()
        {
            using (var db = new FornecedoresDDDDbContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
