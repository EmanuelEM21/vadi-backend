using Application.Common.DataAccess;
using Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadoController : ControllerBase
    {
        private readonly IDbContext dbContext;

        public EstadoController(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("obtener-estados")]
        public async Task<IActionResult> GetEstados()
        {
            try
            {
                var listaEstados = await dbContext.EstadoRepository.GetEstados() ?? new List<Estado>();
                return Ok(listaEstados);
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = $"Hubo un error durante la obtención de los datos: {ex.Message}" });
            }
        }
    }
}