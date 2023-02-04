using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Painel.Application.DTOs;
using Painel.Application.Interfaces;

namespace Painel.Controllers;
[Route("api/log")]
public class LogController : BaseController
{
    private readonly ILoggerService _service;
    public LogController(ILoggerService service) => _service = service;

    [HttpPost("get-all")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var output = await _service.GetAll(skip, pageSize);
            output.FormatOutput(draw);

            return Ok(output);
        }
        catch (DbException)
        {
            return StatusCode(500, new LogOutput());
        }
        catch (Exception)
        {
            return StatusCode(500, new LogOutput());
        }
    }
}