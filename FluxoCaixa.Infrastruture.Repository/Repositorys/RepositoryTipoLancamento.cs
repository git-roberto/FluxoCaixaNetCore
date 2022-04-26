using FluxoCaixa.Domain.Core.Interfaces.Repositorys;
using FluxoCaixa.Domain.Models;
using FluxoCaixa.Infrastruture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Infrastruture.Repository.Repositorys
{
    public class RepositoryTipoLancamento : RepositoryBase<TipoLancamento>, IRepositoryTipoLancamento
    {
        private readonly SqlContext _context;
        public RepositoryTipoLancamento(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
