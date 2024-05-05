using Microsoft.AspNetCore.Mvc;
using tutorial5.Models;
using tutorial5.Services;

namespace tutorial5.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{
    private IAnimalService _animalsService;

    public AnimalController(IAnimalService animalsService)
    {
        _animalsService = animalsService;
    }

    [HttpGet]
    public IActionResult GetAnimals(string orderBy = "name")
    {
        var animals = _animalsService.GetAnimals();
        switch (orderBy.ToLower())
        {
            case "area":
                animals = animals.OrderBy(a => a.Area);
                break;
            case "description":
                animals = animals.OrderBy(a => a.Description);
                break;
            case "category":
                animals = animals.OrderBy(a => a.Category);
                break;
            default:
                animals = animals.OrderBy(a => a.Name);
                break;
        }
        return Ok(animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalsService.GetAnimal(id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        var affectedCount = _animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPut]
    public IActionResult UpdateAnimal(Animal animal)
    {
        var affectedCount = _animalsService.UpdateAnimal(animal);
        return NoContent();
    }
    
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var affectedCount = _animalsService.DeleteAnimal(id);
        return NoContent();
    }
}