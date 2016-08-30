using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        //who is preforming when and where and what?

        //associated with another class that represents a user in Gighub
        //found in models=>IdentityModels.cs that holds the class ApplicationUser
        public int ID { get; set; }

        public ApplicationUser Artist { get; set; }

        //Foreign Key
        [Required]
        public string ArtistId { get; set; }// ApplicationUser ID is identified as a string

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength((255))]
        public string Venue { get; set; }

        public Genre Genre { get; set; }

        //Foreign Key
        [Required]
        public byte GenreId { get; set; }

    }

    //adding DbSet<Gig> Gigs {get;set;}
    //into IdentityModels.cs ApplicationDbContex : IdentityDbContext<ApplicationUser>
}