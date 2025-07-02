using System.ComponentModel.DataAnnotations;

namespace WorkConnect.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int WorkerId { get; set; }

        public Worker Worker { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }

        public string ReviewerName { get; set; }

        public DateTime DatePosted { get; set; } = DateTime.Now;
    }
}
