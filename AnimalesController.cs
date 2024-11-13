using System.Collections.Generic;
using Entity.Animal;
using Microsoft.AspNetCore.Mvc;

[Route("Animales")]
[ApiController]
public class AnimalesController : Controller
{
    private readonly AnimalRepository _repository;

    public AnimalesController(AnimalRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("Crear")]
    public IActionResult Index()
    {
        return View(); // Devuelve la vista Crear.cshtml
    }

    [HttpPost("Crear")]
    public IActionResult CrearPost([FromForm] Animal animal)
    {
        _repository.Animales.Add(animal); // Agrega el animal al repositorio
        return Ok($"Animal agregado: Nombre = {animal.Nombre}, Tipo = {animal.Tipo}");
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repository.Animales); // Devuelve la lista completa en formato JSON
    }

    [HttpPost]
    public IActionResult Agregar([FromBody] Animal ani)
    {
        _repository.Animales.Add(ani); // Agrega el animal al repositorio
        return Ok(ani); // Retorna el objeto `Animal` como JSON
    }

    [HttpPost("Insertar")]
    public IActionResult Insertar([FromBody] Animal animal)
    {
        _repository.Animales.Add(animal); // Agrega el animal al repositorio
        return Ok($"Animal agregado: Nombre = {animal.Nombre}, Tipo = {animal.Tipo}");
    }
}
