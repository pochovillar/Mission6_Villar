using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Villar.Models
{
    public class Movie
    {
        [Key]
        [Required] // Set MovieId as a primary key
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")] // Connect to Category model (table)
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter a title")]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2024, ErrorMessage = "You must enter a year between 1888 and 2024. ")] // To not let users enter a movie before 1888
        public int Year { get; set; }

        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public int Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}
