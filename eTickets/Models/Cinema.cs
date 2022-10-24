using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        //annotation to annotate the class with an id
        [Key]
        public int CinemaId { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships : Cinema has a list of movies
        public List<Movie> Movies { get; set; }
    }
}
