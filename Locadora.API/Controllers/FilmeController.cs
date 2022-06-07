using Locadora.Models;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class FilmeController : ControllerBase
    {
        private GestaoServices _gestaoServices =
           new GestaoServices();

        [HttpPost]
        public ActionResult CadastrarFilme(
            [FromBody] FilmeViewModel filmeRecebido)
        {
            if (filmeRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum titulo de filme.");
            }

            Filme objetoCriado = _gestaoServices
                .CadastrarFilme(filmeRecebido);

            return Created("Filme", objetoCriado);
        }
    }
}
