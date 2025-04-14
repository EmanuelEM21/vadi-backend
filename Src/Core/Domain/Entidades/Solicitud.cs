namespace Domain.Entidades;

public class Solicitud
{
    /// <summary>
    /// ID de la solicitud.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Fecha en que se realizó la solicitud.
    /// </summary>
    public string FechaSolicitud { get; set; } = string.Empty;

    /// <summary>
    /// Nombre del usuario solicitante.
    /// </summary>
    public string Solicitante { get; set; } = string.Empty;

    /// <summary>
    /// ID del estado de la solicitud
    /// </summary>
    public int? IdEstado { get; set; }
}