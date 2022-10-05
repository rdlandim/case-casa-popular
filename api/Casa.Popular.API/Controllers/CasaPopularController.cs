using Microsoft.AspNetCore.Mvc;

namespace Casa.Popular.API.Controllers;

[ApiController]
[Route("api/casa-popular")]
public class CasaPopularController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CasaPopularController> _logger;

    public CasaPopularController(ILogger<CasaPopularController> logger)
    {
        _logger = logger;
    }

    [HttpGet("contemplados")]
    public IActionResult ObterContemplados()
    {
        try
        {
            return Ok(new { Api = this.GetType().Assembly.ImageRuntimeVersion, Data = DateTime.Now.ToString("g") });
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
