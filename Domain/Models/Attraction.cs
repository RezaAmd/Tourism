using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Attraction
    {
        public int id { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public string image { get; set; }
        public string conver { get; set; }

        [ForeignKey("Author")]
        public string authorId { get; set; }
        public ApplicationUser Author { get; set; }

        [ForeignKey("Location")]
        public int locationId { get; set; }
        public Location Location { get; set; }
    }
}
