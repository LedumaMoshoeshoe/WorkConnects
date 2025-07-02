using System;
using System.ComponentModel.DataAnnotations;

namespace WorkConnect.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime DatePosted { get; set; }

        public int EmployerId { get; set; }

        public Employer Employer { get; set; }
    }
}
