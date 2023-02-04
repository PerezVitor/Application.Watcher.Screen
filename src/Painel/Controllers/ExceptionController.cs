using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Painel.Application.DTOs;
using Painel.Application.Interfaces;

namespace Painel.Controllers;
[Route("api/exception")]
public class ExceptionController : BaseController
{
    private readonly IExceptionService _service;
    public ExceptionController(IExceptionService service) => _service = service;

    [HttpPost("get-all")]
    public async Task<IActionResult> GetAll()
    {
        try 
        {
            var output = await _service.GetAll(skip, pageSize);
            output.FormatOutput(draw);

            return Ok(output);
        }
        catch(DbException)
        {
            return StatusCode(500, new ExceptionOutput());
        }
        catch(Exception)
        {
            return StatusCode(500, new ExceptionOutput());
        }
    }
}
