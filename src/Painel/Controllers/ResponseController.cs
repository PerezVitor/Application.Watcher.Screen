using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Bussiness.Application.DTOs;
using Bussiness.Application.Interfaces;

namespace Painel.Controllers;
[Route("api/response")]
public class ResponseController : BaseController
{
    private readonly IResponseService _responseService;
    public ResponseController(IResponseService responseService) => _responseService = responseService;

    [HttpPost("get-all")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var output = await _responseService.GetAll(skip, pageSize);
            output.FormatOutput(draw);

            return Ok(output);
        }
        catch (DbException)
        {
            return StatusCode(500, new ResponseOutput());
        }
        catch (Exception)
        {
            return StatusCode(500, new ResponseOutput());
        }
    }
}