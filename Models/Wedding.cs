using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int wedding_id {get;set;}
        [Required]
        public string bride_name{get;set;}
        [Required]
        public string groom_name{get;set;}

        [Required]
        public DateTime wedding_date{get;set;}
        [Required]
        public string wedding_address{get;set;}
        
        //Navigation properties
        public List<RSVP> RSVPs{get;set;}
        public Guest Creator{get;set;}

    }

}