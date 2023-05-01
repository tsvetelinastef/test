﻿using PearReview.Areas.Identity.Data;
using PearReview.Data;
using System.ComponentModel.DataAnnotations;

namespace PearReview.Areas.Courses.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public string TeacherId { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime CreatedOn { get; set; }

        public ICollection<Resource> Resources { get; set; }

        // Navigation properties

        public AppUser Teacher { get; set; }
    }
}
