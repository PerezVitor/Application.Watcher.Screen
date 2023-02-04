using Microsoft.AspNetCore.Mvc;
using Painel.Application.Extensions;

namespace Painel.Controllers;
public class BaseController : ControllerBase
{
    protected string draw => Request.GetDraw();
    protected string sortColumn => Request.GetSortColumn();
    protected string sortColumnDirection => Request.GetSortColumnDirection();
    protected int pageSize => Request.GetPageSize();
    protected int skip => Request.GetSkip();
}