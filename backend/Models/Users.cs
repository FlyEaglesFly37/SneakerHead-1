using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Users
    {
        
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created_At { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated_At { get; set; }

        public List<Sneakers> Sneakers {get; set;}

        public List<Rates> Rates {get; set;}

        public Users()
        {
            Sneakers = new List<Sneakers>();
            Rates = new List<Rates>();
        }
    }    
}