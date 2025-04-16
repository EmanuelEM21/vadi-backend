using Application.Common.DataAccess;
using Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SolicitudController : ControllerBase
    {
        private readonly IDbContext dbContext;

        public SolicitudController(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("crear-solicitud")]
        public async Task<IActionResult> CreateSolicitud(Solicitud solicitud)
        {
            try
            {
                var resultado = await dbContext.SolicitudRepository.InsertarSolicitud(solicitud);
                return resultado
                    ? Created("", new { mensaje = "Solicitud creada correctamente" })
                    : BadRequest(new { mensaje = "No se pudo registrar la solicitud" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = $"Hubo un error durante el proceso de registro: {ex.Message}" });
            }
        }

        [HttpPost("obtener-solicitudes")]
        public async Task<IActionResult> GetSolicitudes(Filtro filtro)
        {
            try
            {
                var listaSolicitudes = await dbContext.SolicitudRepository.GetSolicitudes(filtro) ?? new List<Solicitud>();
                return Ok(listaSolicitudes);
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = $"Hubo un error durante la obtención de los datos: {ex.Message}" });
            }
        }

        [HttpPut("actualizar-solicitud")]
        public async Task<IActionResult> UpdateSolicitud(Solicitud solicitud)
        {
            try
            {
                var resultado = await dbContext.SolicitudRepository.UpdateSolicitud(solicitud);
                return resultado
                    ? Ok(new { mensaje = "Solicitud actualizada correctamente" })
                    : BadRequest(new { mensaje = "No se pudo actualizar la solicitud" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = $"Hubo un error durante el proceso de actualización: {ex.Message}" });
            }
        }

        [HttpDelete("eliminar-solicitud")]
        public async Task<IActionResult> DeleteSolicitud(int solicitudId)
        {
            try
            {
                var resultado = await dbContext.SolicitudRepository.DeleteSolicitud(solicitudId);
                return resultado
                    ? Ok(new { mensaje = "Solicitud eliminada correctamente" })
                    : BadRequest(new { mensaje = "No se pudo eliminar la solicitud" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = $"Hubo un error durante el proceso de actualización: {ex.Message}" });
            }
        }
    }
}