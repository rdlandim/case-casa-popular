using Casa.Popular.Interfaces.Processador;
using Microsoft.AspNetCore.Mvc;

namespace Casa.Popular.API.Controllers;

[ApiController]
[Route("api/casa-popular")]
public class CasaPopularController : ControllerBase
{
    private readonly IProcessadorCategorizacao _processador;

    public CasaPopularController(IProcessadorCategorizacao processador)
    {
        _processador = processador;
    }

    [HttpGet("contemplados")]
    public IActionResult ObterContemplados()
    {
        try
        {
            return Ok(_processador.Processar());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
