using Microsoft.AspNetCore.Mvc;
using SenaiApi.Domen.NovaPasta;
using SenaiApi.Service.Interface;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {        
        private readonly IPessoasServices _pessoasServices;
        public PessoaController(IPessoasServices pessoasServices) 
        {
            _pessoasServices = pessoasServices;
        
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var pessoa = _pessoasServices.BuscarTodos();
            return new JsonResult(pessoa);
        }

        [HttpPost]
        public IActionResult Salvar([FromBody] PessoaDto pessoa)
        {
            try
            {
                _pessoasServices.Salvar(pessoa);
                
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete( int id)
        {
            try
            {
                _pessoasServices.Remover(id);
                return Ok();

            }catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
