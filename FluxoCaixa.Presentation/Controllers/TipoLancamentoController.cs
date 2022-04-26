using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluxoCaixa.Application.DTO;
using FluxoCaixa.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FluxoCaixa.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TipoLancamentoController : ControllerBase
    {
        private readonly IApplicationServiceTipoLancamento _applicationServiceTipoLancamento;
        public TipoLancamentoController(IApplicationServiceTipoLancamento ApplicationServiceTipoLancamento)
        {
            _applicationServiceTipoLancamento = ApplicationServiceTipoLancamento;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceTipoLancamento.Listar());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceTipoLancamento.Buscar(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] TipoLancamentoDTO registro)
        {
            try
            {
                if (registro == null)
                    return NotFound();

                _applicationServiceTipoLancamento.Inserir(registro);
                return Ok("Registro incluído com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] TipoLancamentoDTO registro)
        {
            try
            {
                if (registro == null)
                    return NotFound();

                _applicationServiceTipoLancamento.Atualizar(registro);
                return Ok("Registro atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] TipoLancamentoDTO registro)
        {
            try
            {
                if (registro == null)
                    return NotFound();

                _applicationServiceTipoLancamento.Excluir(registro);
                return Ok("Registro excluido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
