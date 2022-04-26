using FluxoCaixa.Domain.Core.Interfaces.Repositorys;
using FluxoCaixa.Domain.Core.Interfaces.Services;
using FluxoCaixa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Domain.Services.Services
{
    public class ServiceLancamento : ServiceBase<Lancamento>, IServiceLancamento
    {
        public readonly IRepositoryLancamento _repositoryLancamento;

        public ServiceLancamento(IRepositoryLancamento RepositoryLancamento) 
            : base(RepositoryLancamento)
        {
            _repositoryLancamento = RepositoryLancamento;
        }
    }
}
