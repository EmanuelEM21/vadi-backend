using Application.Common;
using Application.Common.DataAccess;
using Dapper;
using Domain.Entidades;
using System.Data;

namespace DataAccess.Repositories;

/// <summary>
/// Clase repositorio para la gestión de solicitudes en base de datos
/// </summary>
public class SolicitudRepository : ISolicitudRepository
{
    private readonly IDbConnection db;
    private readonly DapperHelper dapperHelper;

    public SolicitudRepository(IDbConnection db, DapperHelper dapperHelper)
    {
        this.db = db;
        this.dapperHelper = dapperHelper;
    }

    /// <summary>
    /// Registra una nueva solicitud en base de datos.
    /// </summary>
    /// <param name="solicitud">Solicitud a insertar.</param>
    /// <returns>True o false dependiendo de la finalización adecuada del proceso.</returns>
    public async Task<bool> InsertarSolicitud(Solicitud solicitud)
    {
        var parametros = new
        {
            solicitud.Id,
            solicitud.FechaSolicitud,
            solicitud.Solicitante,
            solicitud.IdEstado
        };

        return await db.QueryFirstOrDefaultAsync<bool>("[dbo].[InsertSolicitud]", parametros, commandType: CommandType.StoredProcedure);
    }

    /// <summary>
    /// Obtiene una lista filtrada y paginada con las solicitudes.
    /// </summary>
    /// <returns>Lista con las solicitudes en base de datos.</returns>
    public async Task<List<Solicitud>> GetSolicitudes(Filtro filtro)
    {
        var query = SQLQueries.GetSolicitudesFiltradas;
        var whereClause = dapperHelper.BuildClausulaWhere(filtro);
        var paginacion = dapperHelper.BuildClausulaPaginacion(filtro);
        query = string.Format(query, whereClause, paginacion);

        return (await db.QueryAsync<Solicitud>(query)).ToList();
    }

    /// <summary>
    /// Actualiza una solicitud en base de datos.
    /// </summary>
    /// <param name="solicitud">Solicitud a actualizar con los nuevos datos.</param>
    /// <returns>True o false dependiendo de la finalización adecuada del proceso.</returns>
    public async Task<bool> UpdateSolicitud(Solicitud solicitud)
    {
        var parametros = new
        {
            solicitud.Id,
            solicitud.FechaSolicitud,
            solicitud.Solicitante,
            solicitud.IdEstado
        };

        return await db.QueryFirstOrDefaultAsync<bool>("[dbo].[UpdateSolicitud]", parametros);
    }

    /// <summary>
    /// Elimina un registro Solicitud de base de datos.
    /// </summary>
    /// <param name="solicitudID">ID de la solicitud a eliminar.</param>
    /// <returns>True o false dependiendo de la finalización adecuada del proceso.</returns>
    public async Task<bool> DeleteSolicitud(int solicitudID)
    {
        return await db.QueryFirstOrDefaultAsync<bool>("[dbo].[DeleteSolicitud]", new { Id = solicitudID });
    }
}