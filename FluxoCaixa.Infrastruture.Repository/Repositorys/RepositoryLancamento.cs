using FluxoCaixa.Domain.Core.Interfaces.Repositorys;
using FluxoCaixa.Domain.Models;
using FluxoCaixa.Infrastruture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Infrastruture.Repository.Repositorys
{
    public class RepositoryLancamento : RepositoryBase<Lancamento>, IRepositoryLancamento
    {
        private readonly SqlContext _context;
        public RepositoryLancamento(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
