using FluxoCaixa.Domain.Core.Interfaces.Repositorys;
using FluxoCaixa.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Domain.Services.Services
{
    public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> Repository)
        {
            _repository = Repository;
        }

        public virtual IEnumerable<T> Listar()
        {
            return _repository.Listar();
        }

        public virtual T Buscar(int id)
        {
            return _repository.Buscar(id);
        }

        public virtual void Inserir(T registro)
        {
            _repository.Inserir(registro);
        }

        public virtual void Atualizar(T registro)
        {
            _repository.Atualizar(registro);
        }

        public virtual void Excluir(T registro)
        {
            _repository.Excluir(registro);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
