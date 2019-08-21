using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class RSVP
    {
        [Key]
        public int rsvp_id{get;set;}
        public int wedding_id{get;set;}
        public int guest_id{get;set;}
        public bool RSVPed{get;set;}

        public RSVP(int wedding_id, int guest_id)
        {
            this.wedding_id = wedding_id;
            this.guest_id = guest_id;
            this.RSVPed = true;
        }
        

        //Navigation Properties

        public Wedding Wedding{get;set;}
        public Guest Guest{get;set;}
    }
}