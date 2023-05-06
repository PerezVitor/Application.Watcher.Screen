using Painel.Domain.Entities;
using Painel.Domain.Interfaces;

namespace Painel.Controllers;
public class LoggerController : BaseController<LoggerModel>
{
    public LoggerController(ILoggerRepository repository) : base(repository) { }
}
