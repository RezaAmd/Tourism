using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Hotel
    {
        public int id { get; set; }
        public string cover { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        [ForeignKey("Location")]
        public int locationId { get; set; }
        public Location Location { get; set; }
    }
}
