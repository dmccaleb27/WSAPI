using System;
using System.ComponentModel.DataAnnotations;

namespace sample_mvc.Models
{
    public class Teams
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string bestPlayer { get; set; }
    }
}