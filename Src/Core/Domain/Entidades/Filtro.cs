namespace Domain.Entidades
{
    public class Filtro
    {
        /// <summary>
        /// Columna a filtrar
        /// </summary>
        public required string Columna { get; set; } = string.Empty;

        /// <summary>
        /// Valor a buscar.
        /// </summary>
        public string Valor { get; set; } = string.Empty;

        /// <summary>
        /// Numero de página para la paginación.
        /// </summary>
        public required int NumeroPagina { get; set; }

        /// <summary>
        /// Numero de items a mostrar
        /// </summary>
        public required int NumeroItems { get; set; }
    }
}