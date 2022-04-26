using FluxoCaixa.Application.DTO;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Domain.Core.Interfaces.Services;
using FluxoCaixa.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Application.Service
{
    public class ApplicationServiceTipoLancamento : IApplicationServiceTipoLancamento
    {
        private readonly IServiceTipoLancamento _serviceTipoLancamento;
        private readonly IMapperTipoLancamento _mapperTipoLancamento;

        public ApplicationServiceTipoLancamento(IServiceTipoLancamento serviceTipoLancamento, IMapperTipoLancamento mapperTipoLancamento)
        {
            _serviceTipoLancamento = serviceTipoLancamento;
            _mapperTipoLancamento = mapperTipoLancamento;
        }

        public IEnumerable<TipoLancamentoDTO> Listar()
        {
            var registroProdutos = _serviceTipoLancamento.Listar();
            return _mapperTipoLancamento.MapperListTipoLancamento(registroProdutos);
        }

        public TipoLancamentoDTO Buscar(int id)
        {
            var registrocliente = _serviceTipoLancamento.Buscar(id);
            return _mapperTipoLancamento.MapperToDTO(registrocliente);
        }

        public void Inserir(TipoLancamentoDTO registro)
        {
            var registroTipoLancamento = _mapperTipoLancamento.MapperToEntity(registro);
            _serviceTipoLancamento.Inserir(registroTipoLancamento);
        }

        public void Atualizar(TipoLancamentoDTO registro)
        {
            var registroTipoLancamento = _mapperTipoLancamento.MapperToEntity(registro);
            _serviceTipoLancamento.Atualizar(registroTipoLancamento);
        }

        public void Excluir(TipoLancamentoDTO registro)
        {
            var registroTipoLancamento = _mapperTipoLancamento.MapperToEntity(registro);
            _serviceTipoLancamento.Excluir(registroTipoLancamento);
        }

        public void Dispose()
        {
            _serviceTipoLancamento.Dispose();
        }
    }
}
