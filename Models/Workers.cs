using System.ComponentModel.DataAnnotations;

namespace WorkConnect.Models
{
    public class Workers
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string ServiceType { get; set; } // Gardener, Cleaner, etc.

        public string Location { get; set; }

        public string Languages { get; set; }

        public string Experience { get; set; }

        public string Phone { get; set; }

        public string PhotoUrl { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
