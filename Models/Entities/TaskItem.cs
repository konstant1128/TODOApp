using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TodoApp.Models.Enums;

namespace TodoApp.Models.Entities
{
    public class TaskItem
    {
        [Key]
        public Guid Id {get; set;} = Guid.NewGuid();

        [Required]
        [MaxLength(200)]
        public string Title {get; set;} = string.Empty;

        [MaxLength(2000)]
        public string? Description {get; set;}

        [Required ]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? DueDate { get; set; }

        [Required]
        public Priority Priority { get; set; } = Priority.Medium;

        [Required]
        public Urgency Urgency { get; set; } = Urgency.Medium;

        [Required]
        public bool IsCompleted { get; set; } = false;

        public DateTime? CompletedAt { get; set; }

        [Required]
        public bool ReminderSent { get; set; } = false;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; } = null!;
    }
}