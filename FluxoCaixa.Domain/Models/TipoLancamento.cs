using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Domain.Models
{
    public class TipoLancamento : Base
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
