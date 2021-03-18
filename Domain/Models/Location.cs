using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }

        [ForeignKey("Parent")]
        public int parentId { get; set; }
        public Location Parent { get; set; }

        public ICollection<Attraction> Attractions { get; set; }
    }
}
