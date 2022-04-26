using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Application.DTO
{
    public class LancamentoDTO
    {
        public int? Id { get; set; }
        public decimal Valor { get; set; }

        public DateTime DataLancamento { get; set; }

        public int IdTipoLancamento { get; set; }
        public virtual TipoLancamentoDTO TipoLancamento { get; set; }
    }
}
