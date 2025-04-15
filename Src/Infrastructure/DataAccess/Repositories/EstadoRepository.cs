using Application.Common;
using Application.Common.DataAccess;
using Dapper;
using Domain.Entidades;
using System.Data;

namespace DataAccess.Repositories
{
    /// <summary>
    /// Clase repositorio para la gestión de estados de solicitudes en base de datos.
    /// </summary>
    public class EstadoRepository : IEstadoRepository
    {
        private readonly IDbConnection db;

        public EstadoRepository(IDbConnection db)
        {
            this.db = db;
        }

        /// <summary>
        /// Obtiene una lista con los estados.
        /// </summary>
        /// <returns>Lista con los estados registrados en base de datos.</returns>
        public async Task<List<Estado>> GetEstados()
        {
            return (await db.QueryAsync<Estado>(SQLQueries.GetEstados)).ToList();
        }
    }
}