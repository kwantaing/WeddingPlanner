using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models{
    
    public class loginGuest{
        public string email{get;set;}
        public string password{get;set;}
    }
}