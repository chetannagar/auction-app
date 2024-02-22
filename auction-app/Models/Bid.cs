﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace auction_app.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public double Price { get; set; }
        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public int? ListingId { get; set; }
        [ForeignKey("ListingId")]
        public Listing? Listing { get; set; }
    }
}
