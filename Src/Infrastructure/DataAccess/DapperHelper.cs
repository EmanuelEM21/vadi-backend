using Domain.Entidades;

namespace DataAccess
{
    /// <summary>
    /// Clase Dapper Helper para la construcción de clausulas WHERE y OFFSET.
    /// </summary>
    public class DapperHelper
    {
        /// <summary>
        /// Construye la clausula WHERE para consultas SQL.
        /// </summary>
        /// <param name="filtro">Filtro con los valores necesarios (Columna y Valor).</param>
        /// <returns>Clausula construida.</returns>
        public string BuildClausulaWhere(Filtro filtro)
        {
            if (string.IsNullOrEmpty(filtro.Columna) || string.IsNullOrEmpty(filtro.Valor))
            {
                return string.Empty;
            }

            return $"WHERE {filtro.Columna} LIKE %{filtro.Valor}%";
        }

        /// <summary>
        /// Construye la clausula OFFSET y FETCH NEXT para consultas SQL.
        /// </summary>
        /// <param name="filtro">Filtro con los valores necesarios (NumeroPagina y NumeroItems).</param>
        /// <returns>Clausula construida.</returns>
        public string BuildClausulaPaginacion(Filtro filtro)
        {
            return $"OFFSET {filtro.NumeroPagina * filtro.NumeroItems}\r\nFETCH NEXT {filtro.NumeroItems} ROWS ONLY";
        }
    }
}