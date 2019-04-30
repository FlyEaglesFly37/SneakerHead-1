using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Models;

namespace backend
{
    public class Sneakers
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Brand {get; set;}
        public string Gender {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}
        public double Rate {get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("user")]
        public int UserId { get; set; }
        public Users user { get; set; }

        public List<Rates> Rates { get; set; }

        public Sneakers()
        {
            Rates = new List<Rates>();
        }
    }
}