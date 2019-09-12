using Microsoft.AspNetCore.Mvc;

namespace ApiOne.Controllers
{
    /// <summary>
    /// Controller responsável pelo método que retorna a taxa de juros
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        /// <summary>
        /// Método responsável pelo retorno da taxa de juros (Retorna fixo 0,01)
        /// </summary>
        /// <returns>Retorna um valor string (0,01)</returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return new string("0,01");
        }
    }
}
