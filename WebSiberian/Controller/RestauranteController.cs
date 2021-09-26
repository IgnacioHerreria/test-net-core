using AccesoDatos.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebSiberian.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSiberian.Controller
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private readonly IRestauranteService _restauranteService;
        public RestauranteController(IRestauranteService restauranteService)
        {
            _restauranteService = restauranteService;
        }

        [HttpPost]
        [Route("Lst")]
        public IActionResult Lst([FromBody] DtoRestaurante value)
        {
            try
            {

                return Ok(_restauranteService.Consulta(value));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        [Route("LstId")]
        public IActionResult LstId([FromBody] DtoRestaurante value)
        {
            try
            {
                return Ok(_restauranteService.ConsultaId(value));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("Crt")]
        public IActionResult Crt([FromBody] DtoRestaurante value)
        {
            try
            {

                return Ok(_restauranteService.Crear(value));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("Upd")]
        public IActionResult Upd([FromBody] DtoRestaurante value)
        {
            try
            {

                return Ok(_restauranteService.Actualizar(value));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("Del")]
        public IActionResult Del([FromBody] DtoRestaurante value)
        {
            try
            {

                return Ok(_restauranteService.Eliminar(value));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }


    }
}
