namespace Application.Common
{
    /// <summary>
    /// Clase con queries a ejecutar en base de datos con Dapper.
    /// </summary>
    public class SQLQueries
    {
        /// <summary>
        /// Query para obtener solicitudes filtradas y paginadas.
        /// </summary>
        public const string GetSolicitudesFiltradas = @"
            DECLARE @Solicitudes TABLE (Id INT, FechaSolicitud DATE, Solicitante VARCHAR(100), IdEstado INT, Estado VARCHAR(50));
            INSERT INTO @Solicitudes
            EXEC [dbo].[GetSolicitudes]

            SELECT
                Id,
                FechaSolicitud,
                Solicitante,
                IdEstado,
                Estado AS EstadoValue
            FROM @Solicitudes
            {0}
            {1}
        ";

        /// <summary>
        /// Query para obtener los estados registrados en base de datos.
        /// </summary>
        public const string GetEstados = @"
            SELECT
                IdEstado,
                Estado
            FROM [dbo].[Estados]
        ";
    }
}