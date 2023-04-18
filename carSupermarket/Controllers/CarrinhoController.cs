using Microsoft.AspNetCore.Mvc;
using carSupermarket.Models;
using carSupermarket.Services;


namespace carSupermarket.Controllers;

[ApiController]
[Route("[controller]")]

public class CarrinhoController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Carrinho>> GetAll() => CarrinhoService.GetAll();
}


