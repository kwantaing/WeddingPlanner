using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models{
    
    public class Guest{
        [Key]
        public int guest_id{get;set;}
        [Required]
        [MinLength(2)]
        public string first_name{get;set;}
        [Required]
        [MinLength(2)]
        public string last_name{get;set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be 8 characters or more!")]
        public string password{get;set;}

        [Required]
        [Compare("password")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string pwConfirm{get;set;}
        [DataType(DataType.DateTime)]
        public DateTime created_at{get;set;}

        [DataType(DataType.DateTime)]
        public DateTime updated_at{get;set;}

        //Navigation Properties
        public List<RSVP> RSVPs{get;set;}



    }
}