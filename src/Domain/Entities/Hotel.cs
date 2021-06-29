using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Hotel
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}