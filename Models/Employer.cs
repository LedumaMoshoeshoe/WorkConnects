using System.ComponentModel.DataAnnotations;

namespace WorkConnect.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Location { get; set; }
    }
}
