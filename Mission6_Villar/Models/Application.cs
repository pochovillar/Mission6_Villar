using System.ComponentModel.DataAnnotations;

namespace Mission6_Villar.Models
{
    public class Application // creating Application table
    {
        [Key]
        [Required]
        public int MovieID { get; set; } 
        public string title {  get; set; }
        public string genre { get; set; }
        public int year { get; set; }
        public string director { get; set; }
        public string rating{ get; set; }
        public bool? edited { get; set;}
        public string? lentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? notes { get; set;}


    }
}
