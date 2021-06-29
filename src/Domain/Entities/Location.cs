using Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string Flag { get; set; }
        public LocationType LocationType { get; set; }

        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        public virtual Location Parent { get; set; }

        public virtual ICollection<Attraction> Attractions { get; set; }
    }
}