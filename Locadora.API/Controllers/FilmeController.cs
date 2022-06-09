using Locadora.Models;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class FilmeController : ControllerBase
    {
        private GestaoServices _filme =
           new GestaoServices();

        [HttpPost]
        public ActionResult CadastrarFilme(
            [FromBody] FilmeViewModel filmeRecebido)
        {
            if (filmeRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum titulo de filme.");
            }

            Filme objetoCriado = _filme
                .CadastrarFilme(filmeRecebido);

            return Created("Filme", objetoCriado);
        }
        [HttpGet]
        public List<Filme> ListarFilme()
        {
            List<Filme> listaFilme =
                _filme.ListarFilme();

            return listaFilme;
        }
    }
}
