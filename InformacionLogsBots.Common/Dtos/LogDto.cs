namespace InformacionLogsBots.Common.Dtos
{
    public class LogDto
    {
        /// <summary>
        /// Fecha del registro
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Hora de inicio de la transaccion
        /// </summary>
        public DateTime InicioTransaccion { get; set; }

        /// <summary>
        /// Hora de fin de la transaccion
        /// </summary>
        public DateTime? FinTransaccion { get; set; }

        /// <summary>
        /// Id de la transaccion
        /// </summary>
        public string IdTransaccion { get; set; } = null!;

        /// <summary>
        /// Duracion de la transaccion
        /// </summary>
        public double Duracion { get; set; }

        /// <summary>
        /// Ambiente de la transaccion.  Se toma de la variable de entorno
        /// </summary>
        public string Ambiente { get; set; } = null!;

        /// <summary>
        /// Ip generadora de la peticion
        /// </summary>
        public string Ip { get; set; } = null!;

        /// <summary>
        /// Usuario
        /// </summary>
        public string Usuario { get; set; } = null!;

        /// <summary>
        /// Tecnologica del servicio
        /// </summary>
        public string Tecnologia { get; set; } = null!;

        /// <summary>
        /// Proceso de la transaccion
        /// </summary>
        public string Proceso { get; set; } = null!;

        /// <summary>
        /// Proyecto de la transaccion
        /// </summary>
        public string Proyecto { get; set; } = null!;

        /// <summary>
        /// Nivel de informe de la transaccion
        /// </summary>
        public string Level { get; set; } = null!;

        /// <summary>
        /// Proceso interno en el cual se genera la transaccion
        /// </summary>
        public string ProcesoInterno { get; set; } = null!;

        /// <summary>
        /// Mensaje
        /// </summary>
        public string Mensaje { get; set; } = null!;

        /// <summary>
        /// Tipo de proceso
        /// </summary>
        public string TipoProceso { get; set; } = null!;

    }
}
