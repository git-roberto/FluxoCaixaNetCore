using FluxoCaixa.Domain.Core.Interfaces.Repositorys;
using FluxoCaixa.Domain.Core.Interfaces.Services;
using FluxoCaixa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Domain.Services.Services
{
    public class ServiceTipoLancamento : ServiceBase<TipoLancamento>, IServiceTipoLancamento
    {
        public readonly IRepositoryTipoLancamento _repositoryTipoLancamento;

        public ServiceTipoLancamento(IRepositoryTipoLancamento RepositoryTipoLancamento) 
            : base(RepositoryTipoLancamento)
        {
            _repositoryTipoLancamento = RepositoryTipoLancamento;
        }
    }
}
