using Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Cover { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DayCount { get; set; }
        public int NightCount { get; set; }

        [ForeignKey("Origin")]
        public int OriginId { get; set; }
        public virtual Location Origin { get; set; }



        [ForeignKey("Attraction")]
        public int Attraction_Id { get; set; }
        public virtual Attraction Attraction { get; set; }

        [ForeignKey("Leader")]
        public string LeaderId { get; set; }
        public virtual User Leader { get; set; }
    }
}