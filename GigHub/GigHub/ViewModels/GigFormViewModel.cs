using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        //used for drop down list in Create.cshtml, need numeric options for a DDL 
        [Required]
        public byte Genre { get; set; }

        // gets list of Genres from DB. Could use list<>, 
        //but will not be adding to the list or using its options,
        //so IEnumerable is the simplest soultion. 
        [Required]
        public IEnumerable<Genre> Genres { get; set; }//for dropdownListFor

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}