using FluxoCaixa.Application.DTO;
using FluxoCaixa.Domain.Models;
using FluxoCaixa.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperLancamento : IMapperLancamento
    {
        List<LancamentoDTO> lstLancamentoDTO = new List<LancamentoDTO>();

        public IEnumerable<LancamentoDTO> MapperListLancamento(IEnumerable<Lancamento> tipoLancamento)
        {
            foreach (var item in tipoLancamento)
            {
                LancamentoDTO clienteDTO = new LancamentoDTO
                {

                    Id = item.Id,
                    Valor = item.Valor,
                    DataLancamento = item.DataLancamento,
                    IdTipoLancamento = item.IdTipoLancamento
                };

                lstLancamentoDTO.Add(clienteDTO);

            }

            return lstLancamentoDTO;
        }

        public LancamentoDTO MapperToDTO(Lancamento model)
        {
            LancamentoDTO tipoLancamento = new LancamentoDTO
            {
                Id = model.Id,
                Valor = model.Valor,
                DataLancamento = model.DataLancamento,
                IdTipoLancamento = model.IdTipoLancamento
            };

            return tipoLancamento;
        }

        public Lancamento MapperToEntity(LancamentoDTO dto)
        {
            Lancamento tipoLancamento = new Lancamento
            {
                Id = dto.Id,
                Valor = dto.Valor,
                DataLancamento = dto.DataLancamento,
                IdTipoLancamento = dto.IdTipoLancamento
            };

            return tipoLancamento;
        }
    }
}
