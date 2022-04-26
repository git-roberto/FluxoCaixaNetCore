using FluxoCaixa.Domain.Core.Interfaces.Repositorys;
using FluxoCaixa.Infrastruture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluxoCaixa.Infrastruture.Repository.Repositorys
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        private readonly SqlContext _context;

        public RepositoryBase(SqlContext Context)
        {
            _context = Context;
        }

        public IEnumerable<T> Listar()
        {
            return _context.Set<T>().ToList();
        }

        public T Buscar(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Inserir(T registro)
        {
            _context.Set<T>().Add(registro);
            _context.SaveChanges();
        }

        public void Atualizar(T registro)
        {
            _context.Entry(registro).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Excluir(T registro)
        {
            _context.Set<T>().Remove(registro);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
