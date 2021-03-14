using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Name")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(10, 1000)]
        [Display(Name = "Entry fee")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Gender")]
        public string Genre { get; set; }

        [Display(Name = "Comments")]
        [StringLength(255)]
        public string Rating { get; set; }
    }
}