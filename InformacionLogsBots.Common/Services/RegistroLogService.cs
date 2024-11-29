using InformacionLogsBots.Common.Dtos;
using InformacionLogsBots.Common.Interfaces;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace InformacionLogsBots.Common.Services
{
    public class RegistroLogService(ILogger<RegistroLogService> log) : IRegistroLogService
    {
        public void Guardar(DateTime inicioTransaccion, DateTime finTransaccion, LogLevel level, string mensaje, string procesoInterno = "", string ip = "")
        {
            // Se crea el cuerpo
            var logDto = new LogDto
            {
                Fecha = DateTime.UtcNow,
                InicioTransaccion = inicioTransaccion,
                FinTransaccion = finTransaccion,
                IdTransaccion = DateTime.UtcNow.ToString("yyyyMMddHHmmss"),
                Duracion = finTransaccion.Subtract(inicioTransaccion).TotalMilliseconds,
                Ambiente = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")!,
                Ip = ip,
                Usuario = Environment.MachineName,
                Tecnologia = "NETCORE",
                Proceso = Environment.GetEnvironmentVariable("PROYECT_DESCRIPTION")!,
                Proyecto = Environment.GetEnvironmentVariable("PROYECT_NAME")!,
                Level = level.ToString(),
                ProcesoInterno = procesoInterno,
                Mensaje = mensaje,
                TipoProceso = "_doc"
            };

            log.Log(level, "{Mensaje}", JsonSerializer.Serialize(logDto));
        }
    }
}
