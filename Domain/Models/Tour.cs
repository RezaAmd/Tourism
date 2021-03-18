using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Tour
    {
        public int id { get; set; }
        public string image { get; set; }
        public string cover { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int dayCount { get; set; }
        public int nightCount { get; set; }

        [ForeignKey("Origin")]
        public int originId { get; set; }
        public Location Origin { get; set; }

        [ForeignKey("Attraction")]
        public int attraction_Id { get; set; }
        public Attraction Attraction { get; set; }

        [ForeignKey("Leader")]
        public string leaderId { get; set; }
        public ApplicationUser Leader { get; set; }
    }
}
