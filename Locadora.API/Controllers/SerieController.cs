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
    
    public class SerieController : ControllerBase
    {
        private GestaoServices _gestaoServices =
            new GestaoServices();

        [HttpPost]
        public ActionResult CadastrarSerie(
            [FromBody] SerieViewModel serieRecebido)
        {
            if (serieRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum titulo de serie.");
            }

            Serie objetoCriado = _gestaoServices
                .CadastrarSerie(serieRecebido);

            return Created("Serie", objetoCriado);
        }
        [HttpGet]
        public List<Item> ListarSerie()
        {
            List<Item> listaSerie =
                _gestaoServices.ListarSerie();

            return listaSerie;
        }
    }
}
