using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models{
    
    public class loginGuest{
        public string logEmail{get;set;}
        public string logPassword{get;set;}
    }
}