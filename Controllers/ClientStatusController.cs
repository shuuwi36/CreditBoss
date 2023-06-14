using CreditBoss.Enums;
using Microsoft.AspNetCore.Mvc;

namespace CreditBoss.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientStatusController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var clientStatuses = Enum.GetNames(typeof(ClientStatus));
        return Ok(clientStatuses);
    }

}