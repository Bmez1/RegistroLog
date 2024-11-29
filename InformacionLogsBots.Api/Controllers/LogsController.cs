using InformacionLogsBots.Application.Dtos.Request;
using InformacionLogsBots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InformacionLogsBots.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class LogsController(ILogService logService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegistrarLog(CrearLogDto request)
        {
            throw new NotImplementedException("No se ha implementado el servicio de logs");
            var logId = await logService.GuardarAsync(request);
            return Ok(new
            {
                Mensaje = "Log registrado con éxito",
                LogId = logId
            });
        }
    }
}
