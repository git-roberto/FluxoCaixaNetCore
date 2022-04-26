using FluxoCaixa.Application.DTO;
using FluxoCaixa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperLancamento
    {
        Lancamento MapperToEntity(LancamentoDTO lancamentoDTO);

        IEnumerable<LancamentoDTO> MapperListLancamento(IEnumerable<Lancamento> lancamento);

        LancamentoDTO MapperToDTO(Lancamento lancamento);
    }
}
