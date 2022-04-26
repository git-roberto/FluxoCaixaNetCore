using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Application.DTO
{
    public class TipoLancamentoDTO
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
