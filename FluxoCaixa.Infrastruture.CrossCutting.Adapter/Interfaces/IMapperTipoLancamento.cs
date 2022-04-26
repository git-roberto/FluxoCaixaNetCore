using FluxoCaixa.Application.DTO;
using FluxoCaixa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperTipoLancamento
    {
        TipoLancamento MapperToEntity(TipoLancamentoDTO dto);

        IEnumerable<TipoLancamentoDTO> MapperListTipoLancamento(IEnumerable<TipoLancamento> lst);

        TipoLancamentoDTO MapperToDTO(TipoLancamento model);
    }
}
