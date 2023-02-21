using System;
using System.ComponentModel.DataAnnotations;
namespace TrackerWeb.Models
{
    public class Issue
    {
        public uint Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = String.Empty;
        [Required]
        [StringLength(300)]
        public string Description { get; set; } = String.Empty;
        public IssueType IssueType { get; set; }
        public Priority Priority { get; set; }
        public String? Created { get; set; }
        public String? Completed { get; set; }
    }

    public enum IssueType
    {
        Feature,
        Bug,
        Documentation
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}

