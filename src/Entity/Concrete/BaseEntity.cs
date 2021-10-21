using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public abstract class BaseEntity : IEntity
    {
        // This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 94)]
        public DateTime CreatedAt { get; set; }

        [Column(Order = 95)]
        public Guid CreatedBy { get; set; }

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