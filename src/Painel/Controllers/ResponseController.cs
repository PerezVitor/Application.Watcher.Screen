using Painel.Domain.Entities;
using Painel.Domain.Interfaces;

namespace Painel.Controllers;
public class ResponseController : BaseController<ResponseModel>
{
    public ResponseController(IResponseRepository repository) : base(repository) { }
}
