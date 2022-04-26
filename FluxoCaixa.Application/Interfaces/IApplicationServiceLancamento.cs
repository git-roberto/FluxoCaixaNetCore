using FluxoCaixa.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Application.Interfaces
{
    public interface IApplicationServiceLancamento
    {
        LancamentoDTO Buscar(int id);

        IEnumerable<LancamentoDTO> Listar();

        void Inserir(LancamentoDTO registro);

        void Atualizar(LancamentoDTO registro);

        void Excluir(LancamentoDTO registro);

        void Dispose();
    }
}
