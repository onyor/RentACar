using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public abstract class BaseEntity : IEntity
    {
        [Column(Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(Order = 94)]
        public DateTime CreatedAt { get; set; }

        [Column(Order = 95)]
        public Guid? CreatedBy { get; set; }

        [Column(Order = 96)]
        public DateTime? UpdatedAt { get; set; }

        [Column(Order = 97)]
        public Guid? UpdatedBy { get; set; }

        [Column(Order = 98)]
        public bool IsActive { get; set; }

        [Column(Order = 99)]
        public bool IsDeleted { get; set; }
    }
}