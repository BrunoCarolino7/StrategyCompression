using FinalStrategy.API.Dto;
using FinalStrategy.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace FinalStrategy.API.Controllers;

[Route("Compactar")]
[ApiController]
public class CompactarController : ControllerBase
{
    [HttpPost("")]
    public async Task<IActionResult> CompactarArquivo([FromBody] CompactarInputDto dto)
    {
        try
        {
            var service = CompactarService.CompactarArquivo(dto);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}