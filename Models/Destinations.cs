
using System;
using System.ComponentModel.DataAnnotations;

namespace DennisMvc.Models
{
    public class Destinations
    {
        // Properties
        public int Id { get; set; }

        [Required]
        [Display(Name = "Destination name:")]
        [MaxLength(25)]
        [MinLength(1)]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Only a-z are allowed in 'Destination name' input.")]
        public String? DestinationName { get; set; }

        [Required]
        [MinLength(1)]
        [Url]
        [Display(Name = "Destination Url:")]
        public String? DestinationUrl { get; set; }
    }
}