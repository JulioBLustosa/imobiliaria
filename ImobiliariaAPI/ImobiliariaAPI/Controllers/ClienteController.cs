using AutoMapper;
using ImobiliariaWebView.Data;
using ImobiliariaWebView.Data.Dtos;
using ImobiliariaWebView.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ImobiliariaWebView.Controllers;

[ApiController]
[Route("[Controller]")]
public class ClienteController : ControllerBase
{
    private ImobiliariaContext _context;
    private IMapper _mapper;

    public ClienteController(ImobiliariaContext context, IMapper mapper)
    {
        _context=context;
        _mapper=mapper;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AdicionaCliente([FromBody] ClienteDto clienteDto)
    {
        Cliente cliente = _mapper.Map<Cliente>(clienteDto);
        _context.Cliente.Add(cliente);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaClientePorId), new { id = cliente.IdCliente }, cliente);
    }

    [HttpGet]
    public IEnumerable<ReadClienteDto> RecuperaClientes([FromQuery] int skip = 0, [FromQuery] int take = 20)
    {
        return _mapper.Map<List<ReadClienteDto>>(_context.Cliente.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaClientePorId(int id)
    {
        var cliente = _context.Cliente.FirstOrDefault(cliente => cliente.IdCliente == id);
        if (cliente == null) return NotFound();
        var clienteDto = _mapper.Map<ReadClienteDto>(cliente);
        return Ok(clienteDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaCliente(int id, [FromBody] ClienteDto clienteDto)
    {
        var cliente = _context.Cliente.FirstOrDefault(cliente => cliente.IdCliente == id); 
        if (cliente == null) return NotFound();
        _mapper.Map(clienteDto, cliente);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult AtualizaClienteParcial(int id, JsonPatchDocument<ClienteDto> patch)
    {
        var cliente = _context.Cliente.FirstOrDefault(cliente => cliente.IdCliente == id);
        if (cliente == null) return NotFound();

        var clienteParaAtualizar = _mapper.Map<ClienteDto>(cliente);
        patch.ApplyTo(clienteParaAtualizar, ModelState);

        if (!TryValidateModel(clienteParaAtualizar))
        {
            return NotFound();
        }

        _mapper.Map(clienteParaAtualizar, cliente);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        var cliente = _context.Cliente.FirstOrDefault(cliente => cliente.IdCliente == id);
        if (cliente == null) return NotFound();
        _context.Remove(cliente);
        _context.SaveChanges();
        return NoContent();
    }
}
