using GakkoHorizontalSlice.Model;
using GakkoHorizontalSlice.Repositories;
using tutorial5.Services;

namespace GakkoHorizontalSlice.Services;

public class Animal : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;
    
    public StudentsService(IStudentsRepository studentsRepository)
    {
        _studentsRepository = studentsRepository;
    }
    
    public IEnumerable<Student> GetStudents()
    {
        //Business logic
        return _studentsRepository.GetStudents();
    }
    
    public int CreateStudent(Student student)
    {
        //Business logic
        return _studentsRepository.CreateStudent(student);
    }

    public Student? GetStudent(int idStudent)
    {
        //Business logic
        return _studentsRepository.GetStudent(idStudent);
    }

    public int UpdateStudent(Student student)
    {
        //Business logic
        return _studentsRepository.UpdateStudent(student);
    }

    public int DeleteStudent(int idStudent)
    {
        //Business logic
        return _studentsRepository.DeleteStudent(idStudent);
    }
}