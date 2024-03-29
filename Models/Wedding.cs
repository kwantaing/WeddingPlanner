using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int wedding_id {get;set;}
        [Required(ErrorMessage="Please enter the Bride's name.")]
        public string bride_name{get;set;}
        [Required(ErrorMessage="Please enter the Groom's name.")]
        public string groom_name{get;set;}

        [Required(ErrorMessage="Please select the wedding date.")]
        [DateCheck]
        public DateTime wedding_date{get;set;}
        [Required(ErrorMessage="Please enter the wedding venue")]
        public string wedding_address{get;set;}
        
        //Navigation properties
        public List<RSVP> RSVPs{get;set;}
        public Guest Creator{get;set;}

        public class DateCheckAttribute : ValidationAttribute{
        
        protected override ValidationResult IsValid(object date, ValidationContext validationContext){
            DateTime day = Convert.ToDateTime(date);
            DateTime now  =  DateTime.Now;
            if(day<now){
                return new ValidationResult("Weddings must be in the future!");
            }else{
                return ValidationResult.Success;
            }
        }
    }
    }

}