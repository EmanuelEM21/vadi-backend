using Application.Common.DataAccess;

namespace DataAccess
{
    /// <summary>
    /// Clase de contexto para la base de datos.
    /// </summary>
    public class DbContext : IDbContext
    {
        public ISolicitudRepository SolicitudRepository { get; }
        public IEstadoRepository EstadoRepository { get; }

        /// <summary>
        /// Constructor de la clase DbContext.
        /// </summary>
        /// <param name="solicitudRepository">Repositorio de solicitudes.</param>
        /// <param name="estadoRepository">Repositorio de estados de solicitudes.</param>
        public DbContext(ISolicitudRepository solicitudRepository, IEstadoRepository estadoRepository)
        {
            SolicitudRepository = solicitudRepository;
            EstadoRepository = estadoRepository;
        }
    }
}