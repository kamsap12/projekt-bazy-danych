using System.ComponentModel.DataAnnotations;
namespace LibrarySystem.Models;

public class Author
{
    public int Id { get; set; }
    [Required] public string FullName { get; set; } = string.Empty;
    public virtual ICollection<Book>? Books { get; set; }
}