using InformacionLogsBots.Application.Dtos.Request;

namespace InformacionLogsBots.Application.Interfaces
{
    public interface ILogService
    {
        Task<Guid> GuardarAsync(CrearLogDto log);
    }
}
