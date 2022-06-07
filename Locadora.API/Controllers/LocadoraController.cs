using Microsoft.AspNetCore.Mvc;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("locadora")]
    public class LocadoraController : Controller
    {
        [HttpGet]
        public string Inicio()
        {
            return "Teste";
        }
    }
}
