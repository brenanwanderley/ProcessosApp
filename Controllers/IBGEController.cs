using Microsoft.AspNetCore.Mvc;
using ProcessosApp.Services;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class IBGEController : Controller
{

    private readonly IBGEService _ibgeService;

    public IBGEController(IBGEService ibgeService)
    {
        _ibgeService = ibgeService;

    }

    // Endpoint para listar estados
    [HttpGet("estados")]
    public async Task<IActionResult> GetEstados()
    {
        var estados = await _ibgeService.GetEstadosAsync();
        return Ok(estados); // Retorna os dados dos estados
    }

    // Endpoint para listar municípios de um estado específico
    [HttpGet("municipios/{uf}")]
    public async Task<IActionResult> GetMunicipios(string uf)
    {
        var municipios = await _ibgeService.GetMunicipiosAsync(uf);
        return Ok(municipios); // Retorna os dados dos municípios
    }

    // Endpoint para pegar informações de um município específico
    [HttpGet("municipio/{codigo}")]
    public async Task<IActionResult> GetMunicipio(int codigo)
    {
        var municipio = await _ibgeService.GetMunicipioAsync(codigo);
        return Ok(municipio); // Retorna os dados de um município
    }

}