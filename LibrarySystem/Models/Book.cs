using System.ComponentModel.DataAnnotations;
namespace LibrarySystem.Models;

public class Book
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Tytuł jest wymagany")]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;
    public int AuthorId { get; set; } 
    public Author? Author { get; set; } 
    public int CategoryId { get; set; }
    public Category? Category { get; set; } 
    public virtual ICollection<Review>? Reviews { get; set; }
}