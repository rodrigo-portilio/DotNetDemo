using DotNetDemo.WebAPI.Services;
using DotNetDemo.WebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDemo.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private readonly ProductService _productService;

    public CustomerController()
    {
    }

    [HttpGet]
    public IActionResult GetCustomer()
    {
        if(!ModelState.IsValid)
            return BadRequest();


        return Ok();
    }

}
