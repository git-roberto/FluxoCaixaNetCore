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
    public class LancamentoController : ControllerBase
    {
        private readonly IApplicationServiceLancamento _applicationServiceLancamento;
        public LancamentoController(IApplicationServiceLancamento ApplicationServiceLancamento)
        {
            _applicationServiceLancamento = ApplicationServiceLancamento;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceLancamento.Listar());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceLancamento.Buscar(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] LancamentoDTO registro)
        {
            try
            {
                if (registro == null)
                    return NotFound();

                _applicationServiceLancamento.Inserir(registro);
                return Ok("Registro incluído com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] LancamentoDTO registro)
        {
            try
            {
                if (registro == null)
                    return NotFound();

                _applicationServiceLancamento.Atualizar(registro);
                return Ok("Registro atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] LancamentoDTO registro)
        {
            try
            {
                if (registro == null)
                    return NotFound();

                _applicationServiceLancamento.Excluir(registro);
                return Ok("Registro excluido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
