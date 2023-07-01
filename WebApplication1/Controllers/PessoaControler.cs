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

        [HttpPost]
        public IActionResult Salvar([FromBody] PessoaDto pessoa)
        {
            try
            {
                //_pessoasServices.Salvar();
                
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
