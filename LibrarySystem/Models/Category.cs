using System.ComponentModel.DataAnnotations;
namespace LibrarySystem.Models;

public class Category
{
    public int Id { get; set; }
    [Required] public string Name { get; set; } = string.Empty;
    public virtual ICollection<Book>? Books { get; set; }
}