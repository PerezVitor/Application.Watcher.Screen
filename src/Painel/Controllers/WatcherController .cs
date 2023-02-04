using Microsoft.AspNetCore.Mvc;
using Painel.Models;
using System.Diagnostics;

namespace Painel.Controllers;
[Route("Watcher")]
public class WatcherController : Controller
{
    [HttpGet("Requests")]
    public IActionResult GetAllRequests() => View("RequestDataTable");

    [HttpGet("Responses")]
    public IActionResult GetAllResponses() => View("ResponseDataTable");

    [HttpGet("Logs")]
    public IActionResult GetAllLogs() => View("LogDataTable");

    [HttpGet("Exceptions")]
    public IActionResult GetAllExceptions() => View("ExceptionDataTable");

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}