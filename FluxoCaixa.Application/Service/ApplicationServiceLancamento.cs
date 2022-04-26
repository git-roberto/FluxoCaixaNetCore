using FluxoCaixa.Application.DTO;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Domain.Core.Interfaces.Services;
using FluxoCaixa.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Application.Service
{
    public class ApplicationServiceLancamento : IApplicationServiceLancamento
    {
        private readonly IServiceLancamento _serviceLancamento;
        private readonly IMapperLancamento _mapperLancamento;

        public ApplicationServiceLancamento(IServiceLancamento serviceLancamento, IMapperLancamento mapperLancamento)
        {
            _serviceLancamento = serviceLancamento;
            _mapperLancamento = mapperLancamento;
        }

        public IEnumerable<LancamentoDTO> Listar()
        {
            var registroProdutos = _serviceLancamento.Listar();
            return _mapperLancamento.MapperListLancamento(registroProdutos);
        }

        public LancamentoDTO Buscar(int id)
        {
            var registrocliente = _serviceLancamento.Buscar(id);
            return _mapperLancamento.MapperToDTO(registrocliente);
        }

        public void Inserir(LancamentoDTO registro)
        {
            var registroLancamento = _mapperLancamento.MapperToEntity(registro);
            _serviceLancamento.Inserir(registroLancamento);
        }

        public void Atualizar(LancamentoDTO registro)
        {
            var registroLancamento = _mapperLancamento.MapperToEntity(registro);
            _serviceLancamento.Atualizar(registroLancamento);
        }

        public void Excluir(LancamentoDTO registro)
        {
            var registroLancamento = _mapperLancamento.MapperToEntity(registro);
            _serviceLancamento.Excluir(registroLancamento);
        }

        public void Dispose()
        {
            _serviceLancamento.Dispose();
        }
    }
}
