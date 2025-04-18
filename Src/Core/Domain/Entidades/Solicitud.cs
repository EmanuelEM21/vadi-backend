namespace Domain.Entidades;

public class Solicitud
{
    /// <summary>
    /// ID de la solicitud.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Fecha en que se realiz� la solicitud.
    /// </summary>
    public string? FechaSolicitud { get; set; }

    /// <summary>
    /// Nombre del usuario solicitante.
    /// </summary>
    public string? Solicitante { get; set; }

    /// <summary>
    /// ID del estado de la solicitud
    /// </summary>
    public int? IdEstado { get; set; }

    /// <summary>
    /// Nombre del estado.
    /// </summary>
    public string? Estado { get; set; }
}