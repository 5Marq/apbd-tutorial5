using System.ComponentModel.DataAnnotations;

namespace tutorial5.Models;

public class Animal
{
    public int IdAnimal { get; set; }
    [Required]
    [MaxLength(3)]
    public string Name { get; set; }
    [Required]
    [MaxLength(100)]
    public string Description { get; set; }
    [Required]
    [MaxLength(500)]
    public string Category { get; set; }
    [Required]
    [MaxLength(50)]
    public string Area { get; set; }
}