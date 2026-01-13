using System.ComponentModel.DataAnnotations;

namespace Bilet16.Models;

public class Trainer
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; }

    [Required, MaxLength(100)]
    public string Description { get; set; }

    [Required]
    public string Image { get; set; }
    
    public int CategoryId { get; set; }

    public Category Category { get; set; }

    public bool IsDeleted { get; set; }
}
