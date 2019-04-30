using System;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Models;

namespace backend
{
    public class Rates
    {
        public int RateId {get; set;}

        public double Rate {get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created_At { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated_At { get; set; }

        [ForeignKey("user")]
        public int UserId { get; set; }
        public Users user { get; set; }

        [ForeignKey("sneaker")]
        public int SneakerId { get; set; }
        public Sneakers sneaker { get; set; }
    }
}