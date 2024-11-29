using InformacionLogsBots.Application.Dtos.Request;
using InformacionLogsBots.Application.Interfaces;
using InformacionLogsBots.DataAccess.DataBase;
using InformacionLogsBots.DataAccess.Models;

namespace InformacionLogsBots.Application.Services
{
    public class LogService(LogContext context) : ILogService
    {
        public async Task<Guid> GuardarAsync(CrearLogDto log)
        {
            var logEntity = CrearLog(log);
            context.Logs.Add(logEntity);
            await context.SaveChangesAsync();
            return logEntity.Id;
        }

        private static Log CrearLog(CrearLogDto log)
        {
            return new Log()
            {
                Id = Guid.NewGuid(),
                Ambiente = log.Ambiente,
                DuracionTransaccion = log.DuracionTransaccion,
                FechaHora = log.FechaHora,
                FinTransaccion = log.FinTransaccion,
                IdTransaccion = log.IdTransaccion,
                Ip = log.Ip,
                Usuario = log.Usuario,
                Level = log.Level,
                Mensaje = log.Mensaje,
                Proceso = log.Proceso,
                ProcesoInterno = log.ProcesoInterno,
                Proyecto = log.Proyecto,
                Tecnologia = log.Tecnologia,
                TipoProceso = log.TipoProceso
            };
        }
    }
}
