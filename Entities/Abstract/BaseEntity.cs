using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
