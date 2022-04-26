using FluxoCaixa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Infrastruture.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<TipoLancamento> TipoLancamento { get; set; }

        public DbSet<Lancamento> Lancamento { get; set; }
    }
}
