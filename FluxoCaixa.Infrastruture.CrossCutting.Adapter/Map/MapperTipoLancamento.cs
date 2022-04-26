using FluxoCaixa.Application.DTO;
using FluxoCaixa.Domain.Models;
using FluxoCaixa.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperTipoLancamento : IMapperTipoLancamento
    {
        List<TipoLancamentoDTO> lstTipoLancamentoDTO = new List<TipoLancamentoDTO>();

        public IEnumerable<TipoLancamentoDTO> MapperListTipoLancamento(IEnumerable<TipoLancamento> tipoLancamento)
        {
            foreach (var item in tipoLancamento)
            {
                TipoLancamentoDTO clienteDTO = new TipoLancamentoDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Ativo = item.Ativo
                };

                lstTipoLancamentoDTO.Add(clienteDTO);

            }

            return lstTipoLancamentoDTO;
        }

        public TipoLancamentoDTO MapperToDTO(TipoLancamento model)
        {
            TipoLancamentoDTO tipoLancamento = new TipoLancamentoDTO
            {
                Id = model.Id,
                Nome = model.Nome,
                Ativo = model.Ativo
            };

            return tipoLancamento;
        }

        public TipoLancamento MapperToEntity(TipoLancamentoDTO dto)
        {
            TipoLancamento tipoLancamento = new TipoLancamento
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Ativo = dto.Ativo
            };

            return tipoLancamento;
        }
    }
}
