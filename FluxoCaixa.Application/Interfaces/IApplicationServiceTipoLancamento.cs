using FluxoCaixa.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Application.Interfaces
{
    public interface IApplicationServiceTipoLancamento
    {
        TipoLancamentoDTO Buscar(int id);

        IEnumerable<TipoLancamentoDTO> Listar();

        void Inserir(TipoLancamentoDTO registro);

        void Atualizar(TipoLancamentoDTO registro);

        void Excluir(TipoLancamentoDTO registro);

        void Dispose();
    }
}
