using carSupermarket.Models;
using carSupermarket.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class CarrinhoController : ControllerBase
{
    
    [HttpGet]
    public ActionResult<List<Carrinho>> GetAll() =>
        CarrinhoService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Carrinho> Get(int id)
    {
        var Carrinho = CarrinhoService.Get(id);

        if (Carrinho == null)
            return NotFound();

        return Carrinho;
    }

    [HttpPost]
    public IActionResult Create(Carrinho Carrinho)
    {
        CarrinhoService.Add(Carrinho);
        return CreatedAtAction(nameof(Get), new { id = Carrinho.Id }, Carrinho);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Carrinho Carrinho)
    {
        if (id != Carrinho.Id)
            return BadRequest();

        var existingCarrinho = CarrinhoService.Get(id);
        if (existingCarrinho is null)
            return NotFound();

        CarrinhoService.Update(Carrinho);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var Carrinho = CarrinhoService.Get(id);

        if (Carrinho is null)
            return NotFound();

        CarrinhoService.Delete(id);

        return NoContent();
    }
}