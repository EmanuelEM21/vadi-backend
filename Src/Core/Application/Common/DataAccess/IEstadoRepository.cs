﻿using Domain.Entidades;

namespace Application.Common.DataAccess
{
    /// <summary>
    /// Interfaz para el repositorio de estados de solicitudes.
    /// </summary>
    public interface IEstadoRepository
    {
        /// <summary>
        /// Obtiene una lista con los estados.
        /// </summary>
        /// <returns>Lista con los estados registrados.</returns>
        Task<List<Estado>> GetEstados();
    }
}