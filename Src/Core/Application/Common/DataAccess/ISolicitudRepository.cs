using Domain.Entidades;

namespace Application.Common.DataAccess;

/// <summary>
/// Interfaz con los métodos para la gestión de solicitudes.
/// </summary>
public interface ISolicitudRepository
{
    /// <summary>
    /// Registra una nueva solicitud en base de datos.
    /// </summary>
    /// <param name="solicitud">Solicitud a insertar.</param>
    /// <returns>True o false dependiendo de la finalización adecuada del proceso.</returns>
    Task<bool> InsertarSolicitud(Solicitud solicitud);

    /// <summary>
    /// Obtiene una lista filtrada y paginada con las solicitudes.
    /// </summary>
    /// <returns>Lista con las solicitudes en base de datos.</returns>
    Task<List<Solicitud>> GetSolicitudes();

    /// <summary>
    /// Actualiza una solicitud en base de datos.
    /// </summary>
    /// <param name="solicitud">Solicitud a actualizar con los nuevos datos.</param>
    /// <returns>True o false dependiendo de la finalización adecuada del proceso.</returns>
    Task<bool> UpdateSolicitud(Solicitud solicitud);

    /// <summary>
    /// Elimina un registro Solicitud de base de datos.
    /// </summary>
    /// <param name="solicitudID">ID de la solicitud a eliminar.</param>
    /// <returns>True o false dependiendo de la finalización adecuada del proceso.</returns>
    Task<bool> DeleteSolicitud(int solicitudID);
}