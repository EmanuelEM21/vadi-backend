namespace Application.Common.DataAccess;

/// <summary>
/// Clase de contexto de la base de datos.
/// </summary>
public interface IDbContext
{
    /// <summary>
    /// Repositorio para las solicitudes.
    /// </summary>
    ISolicitudRepository SolicitudRepository { get; }

    /// <summary>
    /// Repositorio de estados de solicitudes.
    /// </summary>
    IEstadoRepository EstadoRepository { get; }
}