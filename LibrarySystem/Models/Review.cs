using System.ComponentModel.DataAnnotations;
namespace LibrarySystem.Models;

public class Review
{
    public int Id { get; set; }
    [Range(1, 5)] public int Rating { get; set; }
    public string? Comment { get; set; }
    public int BookId { get; set; }
    public Book? Book { get; set; }
}