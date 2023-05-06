using Painel.Domain.Entities;
using Painel.Domain.Interfaces;

namespace Painel.Controllers;
public class ExceptionController : BaseController<ExceptionModel>
{
    public ExceptionController(IExceptionRepository repository) : base(repository) { }
}
