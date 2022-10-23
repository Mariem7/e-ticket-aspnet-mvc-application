using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        //annotation to annotate the class with an id
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureUrl { get; set; } 
        public string FullName { get; set; }
        public string Bio { get; set; }

    }
}
