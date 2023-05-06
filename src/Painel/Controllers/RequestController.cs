using Painel.Domain.Entities;
using Painel.Domain.Interfaces;

namespace Painel.Controllers;
public class RequestController : BaseController<RequestModel>
{
    public RequestController(IRequestRepository repository) : base(repository) { }
}
