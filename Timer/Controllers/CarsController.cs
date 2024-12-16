using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController: ControllerBase
{
    private readonly ICarsService _carsService;
    public CarsController(ICarsService carsService)
    {
        _carsService = carsService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_carsService.GetCarNames());
    }
    
}