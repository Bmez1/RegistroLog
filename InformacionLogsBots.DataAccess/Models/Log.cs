namespace InformacionLogsBots.DataAccess.Models
{
    public class Log
    {
        public Guid Id { get; init; }
        public DateTime FechaHora { get; init; }
        public DateTime FinTransaccion { get; init; }
        public string IdTransaccion { get; init; } = string.Empty;
        public int DuracionTransaccion { get; init; } // en minutos
        public string Ambiente { get; init; } = string.Empty;
        public string Ip { get; init; } = string.Empty;
        public string Usuario { get; init; } = string.Empty;
        public string Tecnologia { get; init; } = string.Empty;
        public string Proceso { get; init; } = string.Empty;
        public string Proyecto { get; init; } = string.Empty;
        public string Level { get; init; } = string.Empty;
        public string ProcesoInterno { get; init; } = string.Empty;
        public string Mensaje { get; init; } = string.Empty;
        public string TipoProceso { get; init; } = string.Empty;
    }
}
