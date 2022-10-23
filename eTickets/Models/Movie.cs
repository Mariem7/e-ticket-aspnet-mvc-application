using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        //annotation to annotate the class with an id
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

    }
}
