using iphound.API.Models.Entities;
using iphound.API.Providers.Service.IpService;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace iphound.API.Controllers;

[ApiController]
[Route("[controller]")]
public class IpInfoController : ControllerBase
{
    [HttpGet]
    public IActionResult Test([FromServices] IIpService service, string ip)
    {
        var result = service.RequestIp(ip);
        return Ok(result);
    }
    
}