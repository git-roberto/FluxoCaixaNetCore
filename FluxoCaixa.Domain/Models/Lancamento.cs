using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Domain.Models
{
    public class Lancamento : Base
    {
        public decimal Valor { get; set; }

        public DateTime DataLancamento { get; set; }

        public int IdTipoLancamento { get; set; }
        public virtual TipoLancamento TipoLancamento { get; set; }
    }
}
