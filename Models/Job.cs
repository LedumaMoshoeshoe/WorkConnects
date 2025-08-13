using System;
using System.ComponentModel.DataAnnotations;

namespace WorkConnect.Models
{
    public class Job
    {
        public int Id { get; set; } // Primary Key

        [Required, StringLength(80)]
        public string JobTitle { get; set; }

        [StringLength(80)]
        public string ServiceType { get; set; } // e.g., Gardening, Cleaning, Painting

        [StringLength(120)]
        public string Location { get; set; }

        [DataType(DataType.Currency)]
        public decimal? PayRate { get; set; } // hourly/day rate

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Posted At")]
        public DateTime PostedAt { get; set; } = DateTime.UtcNow;
    }
}
