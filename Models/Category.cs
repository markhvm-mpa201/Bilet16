using System.ComponentModel.DataAnnotations;

namespace Bilet16.Models;

public class Category
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; }

    public bool IsDeleted { get; set; }
}
