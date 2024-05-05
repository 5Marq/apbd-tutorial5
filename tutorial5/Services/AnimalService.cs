using tutorial5.Models;
using tutorial5.Repos;

namespace tutorial5.Services;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }
    public IEnumerable<Animal> GetAnimals()
    {
        return _animalRepository.GetAnimals();
    }

    public int CreateAnimal(Animal animal)
    {
        return _animalRepository.CreateAnimal(animal);
    }

    public Animal? GetAnimal(int idAnimal)
    {
        return _animalRepository.GetAnimal(idAnimal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _animalRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalRepository.DeleteAnimal(idAnimal);
    }
}