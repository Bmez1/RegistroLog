using Microsoft.Extensions.Logging;

namespace InformacionLogsBots.Common.Interfaces
{
    public interface IRegistroLogService
    {
        void Guardar(DateTime inicioTransaccion, DateTime finTransaccion, LogLevel level, string mensaje, string procesoInterno = "", string ip = "");
    }
}
