using System.ComponentModel.DataAnnotations;

namespace WorkConnect.Models
{
    public class Worker
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string ServiceType { get; set; } // Cleaner, Gardener, etc.

        public string Location { get; set; }

        public string Languages { get; set; }

        public string Experience { get; set; }

        public string Phone { get; set; }

        public string PhotoUrl { get; set; }
    }
}
